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
        double[] thresholdSensorsMinResistance;

        double[] thresholdSensorsMaxResistance;

        public SensorsTablePage(Sensor[] sensors)
        {
            InitializeComponent();

            this.Hide();

            this.Enabled = false;

            thresholdSensorsMinResistance = new double[sensors.Length];

            thresholdSensorsMaxResistance = new double[sensors.Length];

            for (int i = 0; i < sensors.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["sensorNumber"].Value = sensors[i].Number;
                dataGridView1.Rows[i].Cells["sensorName"].Value = sensors[i].Name;
                thresholdSensorsMinResistance[i] = sensors[i].ThresholdMinResistance;
                thresholdSensorsMaxResistance[i] = sensors[i].ThresholdMaxResistance;
            }
        }


        public void Method(int number, string fieldname, object value)
        {
            switch (fieldname)
            {
                case "Resistance":

                    if ((double)value > thresholdSensorsMinResistance[number - 1])
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = "Норма";
                        dataGridView1.Rows[number - 1].Cells["insulationDrop"].Value = "Норма";
                        dataGridView1.Rows[number - 1].Cells["insulationDrop"].Style.BackColor = Color.White;
                    }
                    else
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = Math.Round((double)value, 3);
                        dataGridView1.Rows[number - 1].Cells["insulationDrop"].Value = "Снижена";
                        dataGridView1.Rows[number - 1].Cells["insulationDrop"].Style.BackColor = Color.Orange;
                    }
                    break;

                case "IsCommunicationError":

                    if ((bool)value == true)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[number - 1].Cells["sensorComErr"].Value = "Ошибка";
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

                case "IsNoVoltage":

                    if ((bool)value == true)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorVoltagePresence"].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[number - 1].Cells["sensorVoltagePresence"].Value = "Отсутствует";
                    }
                    else
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorVoltagePresence"].Style.BackColor = Color.White;
                        dataGridView1.Rows[number - 1].Cells["sensorVoltagePresence"].Value = "Присутствует";
                    }
                    break;

                case "IsHighNoiseLevel":

                    if ((bool)value == true)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorHighNoiseLevel"].Style.BackColor = Color.Orange;
                        dataGridView1.Rows[number - 1].Cells["sensorHighNoiseLevel"].Value = "Высокий";
                    }
                    else
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorHighNoiseLevel"].Style.BackColor = Color.White;
                        dataGridView1.Rows[number - 1].Cells["sensorHighNoiseLevel"].Value = "Норма";
                    }
                    break;

            }

            string isComErr = (string)dataGridView1.Rows[number - 1].Cells["sensorComErr"].Value;

            string isCalErr = (string)dataGridView1.Rows[number - 1].Cells["sensorCalcErr"].Value;


            if (isComErr == "Ошибка" || isCalErr == "Ошибка")
            {
                for (int i = 2; i < dataGridView1.Columns.Count; i++)
                {
                    string val = dataGridView1.Columns[i].Name;

                    if (val != "sensorComErr" && val != "sensorCalcErr")
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
