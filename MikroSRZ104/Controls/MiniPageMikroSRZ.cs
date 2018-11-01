using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using lib60870;
using lib60870.CS101;
using lib60870.CS104;
using MfgControl.AdvancedHMI.Controls;
using MikroSRZ104.Controls;

namespace MikroSRZ104
{
    public partial class MiniPageMikroSRZ : UserControl
    {
        SensorsTablePage sensorTablePage;

        public MiniPageMikroSRZ(string name, SensorsTablePage sTP, Point location)
        {
            InitializeComponent();

            sensorTablePage = sTP;

            lblName.Text = name;

            this.Location = location;

        }

        public void Method(string fieldname, object value)
        {
            switch (fieldname)
            {
                case "VoltageOnMainBuses":

                    LabelUpdater(lblValueVoltage, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    break;

                case "ResistanceOfPositivePole":

                    if ((double)value >= 16000)
                    {
                        LabelUpdater(lblValuePositiveResistance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblValuePositiveResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;

                case "ResistanceOfNegativePole":

                    if ((double)value >= 16000)
                    {
                        LabelUpdater(lblTextNegativeResistance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblTextNegativeResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;

                case "ResistanceOfMainBusesAndBattery":

                    if ((double)value >= 16000)
                    {
                        LabelUpdater(lblValueNetworkResistance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblValueNetworkResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;

                case "CapacityOfNetwork":

                    if ((double)value > 220)
                    {
                        LabelUpdater(lblValueCapacitance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblValueCapacitance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;

                case "IsSensorsCommunicationError":

                    LEDUpdater(LEDIsCommunicationError, (bool)value);
                    break;

                case "IsAlarm":

                    LEDUpdater(LEDGroundAlarm, (bool)value);
                    break;

                case "ConnectionStatus":

                    switch ((bool)value)
                    {
                        case true:
                            LabelUpdater(lblStatusValue, "Подключено", Color.Green);
                            ListBoxUpdater(listBox1, "Подключено");
                            break;
                        case false:
                            LabelUpdater(lblStatusValue, "Не подключено", Color.Red);
                            ListBoxUpdater(listBox1, "Не подключено");
                            break;
                    }
                    break;

                case "DeviceError":

                    LEDUpdater(LEDDevErr, (bool)value);
                    break;
            }
        }



        private void LabelUpdater(Label label, string labelstr, Color color)
        {           
            if (label.InvokeRequired)
            {
                LabelUpdaterDelegate d = new LabelUpdaterDelegate(LabelUpdater);


                
                this.BeginInvoke(d, new object[] { label, labelstr, color });
            }
            else
            {
                label.Text = labelstr;
                label.ForeColor = color;
            }
        }

        private void LEDUpdater(SimpleLED led, bool value)
        {
            if (led.InvokeRequired)
            {
                LEDUpdaterDelegate d = new LEDUpdaterDelegate(LEDUpdater);
                this.BeginInvoke(d, new object[] { led, value });
            }
            else
            {
                if (value)
                {
                    led.LED_Color = SimpleLED.LED_Col.Red;
                }
                else
                {
                    led.LED_Color = SimpleLED.LED_Col.White;
                }
                led.Value = true;
            }
        }

        private void ListBoxUpdater(ListBox listBox, string value)
        {
            if (listBox.InvokeRequired)
            {
                ListBoxUpdaterDelegate d = new ListBoxUpdaterDelegate(ListBoxUpdater);
                this.BeginInvoke(d, new object[] { listBox, value });
            }
            else
            {
                listBox.Items.Add(Convert.ToString(DateTime.Now));
                listBox.Items.Add(value);
            }
        }



        private void btnToSensorsInfoList_Click(object sender, EventArgs e)
        {
            sensorTablePage.Show();
            sensorTablePage.BringToFront();
            sensorTablePage.Enabled = true;
        }
    }
}
