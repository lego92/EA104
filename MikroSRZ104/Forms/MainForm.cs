﻿using System;
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
using MikroSRZ104.Controls;
using System.Timers;

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
    public delegate void DeviceErrorDelegate(bool IsError);


    public partial class MainForm : Form
    {
        //         
        MiniPageMikroSRZ[] miniPagesArray;
        //
        MikroSRZ[] mikroSRZArray;
        //        
        SensorsTablePage[] sensorTablePagesArray;
        //
        Thread workerThread = null;
        //
        bool stopThread = false;

        public System.Timers.Timer connectTimer;

        public MainForm()
        {

            InitializeComponent();

            // Парсим            

            if (File.Exists("MikroSRZ104Config.ea"))
            {
                string name, ipAddress, factoryNum, sensorSwitchDev, sensorCircLoad;
                String[] sensorInfo = new String[3];
                int sensorsCount;
                double thresholdMinResistance, thresholdMaxResistance;

                XmlDocument config = new XmlDocument();
                config.Load("MikroSRZ104Config.ea");

                XmlNode rootNode = config.DocumentElement;

                XmlNodeList devices = rootNode.ChildNodes;

                int devicesCount = rootNode.ChildNodes.Count;

                mikroSRZArray = new MikroSRZ[devicesCount];
                miniPagesArray = new MiniPageMikroSRZ[devicesCount];
                sensorTablePagesArray = new SensorsTablePage[devicesCount];

                int i = 0;

                foreach (XmlNode device in rootNode.ChildNodes)
                {
                    name = "";
                    ipAddress = "";
                    factoryNum = "";
                    sensorSwitchDev = "";
                    sensorCircLoad = "";
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

                                            sensorInfo = item.InnerText.Split(new char[] { ' ' }, 3,
                                                                                     StringSplitOptions.RemoveEmptyEntries);

                                            switch (sensorInfo.Length)
                                            {
                                                case 1:
                                                    sensorSwitchDev = "-";
                                                    sensorCircLoad = "-";
                                                    break;
                                                case 2:
                                                    sensorSwitchDev = sensorInfo[1];
                                                    sensorCircLoad = "-";
                                                    break;
                                                case 3:
                                                    sensorSwitchDev = sensorInfo[1];
                                                    sensorCircLoad = sensorInfo[2];
                                                    break;
                                            }

                                            Array.Clear(sensorInfo, 0, sensorInfo.Length);
                                            break;
                                    }

                                }

                                mikroSRZArray[i].CreateSensor(j, factoryNum, sensorSwitchDev, sensorCircLoad,
                                                                        thresholdMinResistance, thresholdMaxResistance);
                                sensorSwitchDev = "";
                                sensorCircLoad = "";
                                j++;
                                break;
                        }
                    }
                    i++;
                }

                int locationX = 0;

                for (int k = 0; k < mikroSRZArray.Length; k++)
                {
                    sensorTablePagesArray[k] = new SensorsTablePage(mikroSRZArray[k].Sensors);
                    mikroSRZArray[k].Subscribe(sensorTablePagesArray[k]);
                    miniPagesArray[k] = new MiniPageMikroSRZ(mikroSRZArray[k].Name, sensorTablePagesArray[k],
                                                                                         new Point(locationX, 0));
                    Controls.Add(miniPagesArray[k]);
                    Controls.Add(sensorTablePagesArray[k]);
                    locationX += miniPagesArray[k].Size.Width;

                    mikroSRZArray[k].DataChanged += miniPagesArray[k].Method;
                }

                workerThread = new Thread(ConnectCycle);
                workerThread.Start();

            }

        }


        public void ConnectCycle()
        {
            while (true)
            {
                foreach (var item in mikroSRZArray)
                {
                    if (stopThread)
                    {
                        break;
                    }
                    else
                    {
                        if (!item.ConnectionStatus)
                        {
                            item.Connect();
                        }
                    }

                }

                if (stopThread)
                {
                    break;
                }

                Thread.Sleep(5000);
            }
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopThread = true;

            foreach (var item in mikroSRZArray)
            {
                item.Disconnect();
            }

            while (workerThread.IsAlive)
            {

            }

            Application.Exit();
        }
    }
}
