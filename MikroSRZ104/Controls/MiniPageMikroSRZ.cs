﻿using System;
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

namespace MikroSRZ104
{
    public partial class MiniPageMikroSRZ : UserControl
    {
        SensorsTableForm ff;

        System.Windows.Forms.Timer deviceErrorTimer;

        Thread timerThread = null; 

        public MiniPageMikroSRZ(string name, SensorsTableForm f, Point location)
        {
            InitializeComponent();

            ff = f;

            lblName.Text = name;

            this.Location = location;

            deviceErrorTimer = new System.Windows.Forms.Timer();

            deviceErrorTimer.Enabled = true;            

            //deviceErrorTimer = new System.Threading.Timer();        

            timerThread = new Thread(Timer);   

        }

        public void Timer()
        {

        }

        public void Method(string fieldname, object value)
        {
            switch (fieldname)
            {
                case "VoltageOnMainBuses":
                    LabelUpdater(lblVoltage, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    break;
                case "ResistanceOfPositivePole":
                    LabelUpdater(lblPositiveResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    break;
                case "ResistanceOfNegativePole":
                    LabelUpdater(lblNegativeResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    break;
                case "ResistanceOfMainBusesAndBattery":
                    if ((double)value >= 16000)
                    {
                        LabelUpdater(lblResistance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblResistance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;
                case "CapacityOfNetwork":
                    if ((double)value > 220)
                    {
                        LabelUpdater(lblCapacitance, "Нет данных", Color.Black);
                    }
                    else
                    {
                        LabelUpdater(lblCapacitance, Convert.ToString(Math.Round((double)value, 3)), Color.Black);
                    }
                    break;
                case "IsSensorsCommunicationError":
                    LEDUpdater(LEDIsCommunicationError, (bool)value);
                    break;
                case "IsAlarm":
                    LEDUpdater(LEDGroundAlarm, (bool)value);
                    break;

            }
        }

        public void StatusChanger(string status)
        {
            switch (status)
            {
                case "Активно":
                    LabelUpdater(label8, status, Color.Green);
                    break;
                case "Неактивно":
                    LabelUpdater(label8, status, Color.Red);
                    break;
            }
        }

        private void LabelUpdater(Label label, string labelstr, Color color)
        {
            if (label.InvokeRequired)
            {
                LabelUpdaterDelegate d = new LabelUpdaterDelegate(LabelUpdater);
                this.Invoke(d, new object[] { label, labelstr, color });
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
                this.Invoke(d, new object[] { led, value });
            }
            else
            {
                led.Value = value;
            }
        }

        private void button123_Click(object sender, EventArgs e)
        {
            //ff.Location = new Point(0, 0);
            ff.ShowDialog();
        }

        private void lblResistance_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
