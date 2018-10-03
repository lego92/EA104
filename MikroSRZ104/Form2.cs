using System;
using System.Drawing;
using System.Windows.Forms;
using MfgControl.AdvancedHMI.Controls;

namespace MikroSRZ104
{
    public partial class Form2 : Form
    {
        DataExchange dataExchange;
        public Form2(DataExchange data)
        {
            InitializeComponent();
            dataExchange = data;
            // подписка на событие изменения данных датчика в буферном объекте DataExchange
            //dataExchange.DataChanged += UpdateFormData;
            // отображение информации о датчике из DataExchange с помощью контролов формы
            LabelUpdater(lblTextSensorNumber, "Датчик № " + dataExchange.SensorNumber, lblTextSensorNumber.ForeColor);

            if (dataExchange.IsCurrentSensor)
            {
                LabelLocationChanger(lblTextResistance, new System.Drawing.Point(250, 193), false);
                LabelLocationChanger(lblValueResistance, new System.Drawing.Point(400, 193), false);

                LabelLocationChanger(lblTextCurrent, new System.Drawing.Point(153, 193), true);
                LabelLocationChanger(lblValueCurrent, new System.Drawing.Point(305, 193), true);

                LabelUpdater(lblValueCurrent, Convert.ToString(Math.Round(dataExchange.Current, 4)),
                                                                             lblValueCurrent.ForeColor);
            }
            else
            {
                LabelLocationChanger(lblTextCurrent, new System.Drawing.Point(250, 193), false);
                LabelLocationChanger(lblValueCurrent, new System.Drawing.Point(400, 193), false);

                LabelLocationChanger(lblTextResistance, new System.Drawing.Point(153, 193), true);
                LabelLocationChanger(lblValueResistance, new System.Drawing.Point(305, 193), true);

                LabelUpdater(lblValueResistance, Convert.ToString(Math.Round(dataExchange.Resistance, 4)),
                                                                             lblValueResistance.ForeColor);
            }

            LEDUpdater(ledCalcImposible, dataExchange.IsCalculaionImpossible);
            LEDUpdater(ledDischarge, dataExchange.IsBatteryDischarging);
            LEDUpdater(ledNoVoltageSignal, dataExchange.IsNoVoltage);
            LEDUpdater(ledNoise, dataExchange.IsHighNoiseLevel);
            LEDUpdater(ledCommError, dataExchange.IsCommunicationError);
        }

        // обновление данных на форме с информацией о датчике -
        // вызывается, когда в любое поле DataExchange записывается новое значение        
        public void UpdateFormData()
        {            
            LabelUpdater(lblTextSensorNumber, "Датчик № " + dataExchange.SensorNumber, lblTextSensorNumber.ForeColor);

            if (dataExchange.IsCurrentSensor)
            {
                LabelLocationChanger(lblTextResistance, new System.Drawing.Point(250, 193), false);
                LabelLocationChanger(lblValueResistance, new System.Drawing.Point(400, 193), false);

                LabelLocationChanger(lblTextCurrent, new System.Drawing.Point(153, 193), true);
                LabelLocationChanger(lblValueCurrent, new System.Drawing.Point(305, 193), true);

                LabelUpdater(lblValueCurrent, Convert.ToString(Math.Round(dataExchange.Current, 4)),
                                                                             lblValueCurrent.ForeColor);
            }
            else
            {
                LabelLocationChanger(lblTextCurrent, new System.Drawing.Point(250, 193), false);
                LabelLocationChanger(lblValueCurrent, new System.Drawing.Point(400, 193), false);

                LabelLocationChanger(lblTextResistance, new System.Drawing.Point(153, 193), true);
                LabelLocationChanger(lblValueResistance, new System.Drawing.Point(305, 193), true);

                LabelUpdater(lblValueResistance, Convert.ToString(Math.Round(dataExchange.Resistance, 4)),
                                                                             lblValueResistance.ForeColor);
            }

            LEDUpdater(ledCalcImposible, dataExchange.IsCalculaionImpossible);
            LEDUpdater(ledDischarge, dataExchange.IsBatteryDischarging);
            LEDUpdater(ledNoVoltageSignal, dataExchange.IsNoVoltage);
            LEDUpdater(ledNoise, dataExchange.IsHighNoiseLevel);
            LEDUpdater(ledCommError, dataExchange.IsCommunicationError);
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

        private void LabelLocationChanger(Label label, Point point, bool value)
        {
            if (label.InvokeRequired)
            {
                LabelLocationChangerDelegate d = new LabelLocationChangerDelegate(LabelLocationChanger);
                this.Invoke(d, new object[] { label, point, value });
            }
            else
            {
                label.Location = point;
                label.Enabled = value;
                label.Visible = value;
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

        // закрытие формы
        private void btnCloseSensorForm_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // отображение информации о датчике с предыдущим номером относительно текущего
        private void btnGoToPreviousSensor_Click(object sender, EventArgs e)
        {
            if (dataExchange.SensorsCount > 1 && dataExchange.SensorNumber != 1)
            {
                dataExchange.SensorNumber -= 1;
            }
        }

        // отображение информации о датчике с следующим номером относительно текущего
        private void btnGoToNextSensor_Click(object sender, EventArgs e)
        {
            if (dataExchange.SensorsCount > 1 && dataExchange.SensorNumber != dataExchange.SensorsCount - 1)
            {
                dataExchange.SensorNumber += 1;
            }
        }        
    }
}
