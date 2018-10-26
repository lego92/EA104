using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MikroSRZ104.Controls
{
    public partial class SensorsTablePage : UserControl
    {
        double[] thresholdSensorsAlarmResistance;

        double[] thresholdSensorsPrelimResistance;

        public SensorsTablePage(Sensor[] sensors)
        {
            InitializeComponent();

            this.Hide();

            this.Enabled = false;

            thresholdSensorsAlarmResistance = new double[sensors.Length];

            thresholdSensorsPrelimResistance = new double[sensors.Length];

            for (int i = 0; i < sensors.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["sensorNumber"].Value = sensors[i].Number;
                dataGridView1.Rows[i].Cells["sensorFacNumber"].Value = sensors[i].FactoryNumber;
                dataGridView1.Rows[i].Cells["sensorSwitchDevice"].Value = sensors[i].SwitchingDevice;
                dataGridView1.Rows[i].Cells["sensorCircuitLoad"].Value = sensors[i].CircuitLoad;
                thresholdSensorsAlarmResistance[i] = sensors[i].ThresholdAlarmResistance;
                thresholdSensorsPrelimResistance[i] = sensors[i].ThresholdPrelimResistance;
            }
        }


        public void Method(int number, string fieldname, object value)
        {
            switch (fieldname)
            {
                case "Resistance":

                    if ((double)value > 30)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = "> 30 кОм";
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Style.BackColor = Color.White;
                    }
                    else if ((double)value < thresholdSensorsPrelimResistance[number - 1])
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = Math.Round((double)value, 3);
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Style.BackColor = Color.Yellow;
                    }
                    else if ((double)value < thresholdSensorsAlarmResistance[number - 1])
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = Math.Round((double)value, 3);
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Style.BackColor = Color.Orange;
                    }

                    break;

                case "IsCommunicationError":

                    if ((bool)value == true)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Value = "Нарушена";
                    }
                    else
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Style.BackColor = Color.White;
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Value = "Норма";
                    }
                    break;

                case "IsCalculationImpossible":

                    if ((bool)value == true)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Value = "Ошибка";
                    }
                    else
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Style.BackColor = Color.White;
                        dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Value = "Норма";
                    }
                    break;                

            }

            string isComErr = (string)dataGridView1.Rows[number - 1].Cells["sensorComErr"].Value;

            string isCalErr = (string)dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Value;


            if (isComErr == "Нарушена" )
            {
                for (int i = 4; i < dataGridView1.Columns.Count; i++)
                {
                    string val = dataGridView1.Columns[i].Name;

                    if (val != "sensorComErr")
                    {
                        dataGridView1.Rows[number - 1].Cells[i].Style.BackColor = Color.White;
                        dataGridView1.Rows[number - 1].Cells[i].Value = "-";
                    }
                }
            }
        }

        private void btnGoToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
        }
    }
}
