using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using System.Xml.XPath;
using MfgControl.AdvancedHMI.Controls;
using lib60870;
using lib60870.CS101;
using lib60870.CS104;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MikroSRZ104
{
    delegate void ListBoxUpdaterDelegate(ListBox listBox, string listBoxStr);
    public delegate void LabelUpdaterDelegate(Label label, string labelStr, Color color);
    delegate void LabelLocationChangerDelegate(Label label, Point point, bool value);
    delegate void LEDUpdaterDelegate(SimpleLED led, bool value);
    delegate void PictureBoxUpdaterDelegate(PictureBox picturebox, bool value);
    delegate void DigitalPanelMeterUpdaterDelegate(DigitalPanelMeterBlue digitalmeter, double value);
    delegate void ButtonUpdaterDelegate(Button button, bool isEnabled, bool isVisible);
    delegate void ReConnectDelegate();
    delegate void ComboBoxUpdaterDelegate(ComboBox combobox, string name);
    public delegate void MikroSRZDataChangedDelegate(string fieldname, object value);
    public delegate void SensorDataChangedDelegate(int number, string fieldname, object value);
    public delegate void StatusChangedDelegate(string status);
    public delegate void DeviceErrorDelegate(bool IsError);


    public partial class MainForm : Form
    {
        //         
        MiniPageMikroSRZ[] miniPagesArray;
        //
        MikroSRZ[] mikroSRZArray;
        //
        SensorsTableForm[] sensorTableFormsArray;
        //
        Thread workerThread = null;
        //
        bool stopThread = false;

        public MainForm()
        {

            InitializeComponent();

            // Парсим            

            if (File.Exists("MikroSRZ104Config.ea"))
            {
                string name, ipAddress, factoryNum, sensorName;
                int sensorsCount;
                double thresholdMinResistance, thresholdMaxResistance;

                XmlDocument config = new XmlDocument();
                config.Load("MikroSRZ104Config.ea");

                XmlNode rootNode = config.DocumentElement;

                XmlNodeList devices = rootNode.ChildNodes;

                int devicesCount = rootNode.ChildNodes.Count;

                mikroSRZArray = new MikroSRZ[devicesCount];
                miniPagesArray = new MiniPageMikroSRZ[devicesCount];
                sensorTableFormsArray = new SensorsTableForm[devicesCount];

                int i = 0;

                foreach (XmlNode device in rootNode.ChildNodes)
                {
                    name = "Имя";
                    ipAddress = "IP";
                    factoryNum = "00-000000";
                    sensorName = "Имя";
                    thresholdMinResistance = 20;
                    thresholdMaxResistance = 200;

                    sensorsCount = 0;

                    foreach (XmlNode fieldOfDevice in device.ChildNodes)
                    {
                        switch (fieldOfDevice.Name)
                        {
                            case "NAME":
                                name = fieldOfDevice.InnerText;
                                break;
                            case "IP":
                                ipAddress = fieldOfDevice.InnerText;
                                break;
                            case "ISA":
                                sensorsCount++;
                                break;
                        }

                    }

                    mikroSRZArray[i] = new MikroSRZ(name, ipAddress, sensorsCount);

                    int j = 0;

                    foreach (XmlNode fieldOfDevice in device.ChildNodes)
                    {
                        switch (fieldOfDevice.Name)
                        {
                            case "MIN_THRESHOLD_RES":
                                thresholdMinResistance = Convert.ToDouble(fieldOfDevice.InnerText);
                                break;

                            case "MAX_THRESHOLD_RES":
                                thresholdMaxResistance = Convert.ToDouble(fieldOfDevice.InnerText);
                                break;

                            case "ISA":
                                foreach (XmlNode item in fieldOfDevice.ChildNodes)
                                {
                                    switch (item.Name)
                                    {
                                        case "FACTORY_NUM":
                                            factoryNum = item.InnerText;
                                            break;

                                        case "NAME":
                                            sensorName = item.InnerText;
                                            break;

                                    }
                                }
                                mikroSRZArray[i].CreateSensor(j, factoryNum, sensorName, thresholdMinResistance, thresholdMaxResistance);
                                j++;
                                break;
                        }

                    }

                    i++;

                }


                int locationX = 0;

                for (int k = 0; k < mikroSRZArray.Length; k++)
                {
                    sensorTableFormsArray[k] = new SensorsTableForm(mikroSRZArray[k].Sensors);
                    mikroSRZArray[k].Subscribe(sensorTableFormsArray[k]);
                    miniPagesArray[k] = new MiniPageMikroSRZ(mikroSRZArray[k].Name,sensorTableFormsArray[k], new Point(locationX, 0));
                    this.Controls.Add(miniPagesArray[k]);
                    locationX += miniPagesArray[k].Size.Width;

                    mikroSRZArray[k].StatusChanged += miniPagesArray[k].StatusChanger;
                    mikroSRZArray[k].Changed += miniPagesArray[k].Method;
                    mikroSRZArray[k].DevErrHappened += miniPagesArray[k].ErrorHandler;

                }


                workerThread = new Thread(ConnectCycle);
                workerThread.Start();
            }

        }

        public void ConnectCycle()
        {
            while (!stopThread)
            {
                foreach (var item in mikroSRZArray)
                {
                    if (!item.ConnectionStatus)/////!!!!!!не меняется!!!!!!!!////////
                    {
                        item.Connect();
                    }
                }

                Thread.Sleep(5000);
            }

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopThread = true;

            foreach (var item in mikroSRZArray)
            {
                item.Disconnect();
            }

            Application.Exit();
        }
    }
}
