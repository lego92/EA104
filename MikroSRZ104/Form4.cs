﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MfgControl.AdvancedHMI.Controls;

namespace MikroSRZ104
{
    
    public partial class Form4 : Form
    {
        public Form4(Sensor[] sensors)
        {
            InitializeComponent();

            var a = dataGridView1.Columns[3].DataGridView;            

            for (int i = 0; i < sensors.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["sensorNumber"].Value = sensors[i].Number;
                dataGridView1.Rows[i].Cells["sensorName"].Value = sensors[i].Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Method(int number, string fieldname, object value)
        {
            switch (fieldname)
            {
                case "Resistance":
                    if ((double)value > 10000)
                    {
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = "Норма";
                    }
                    else
                    {
                        if ((double)value < 20)
                        {
                            dataGridView1.Rows[number - 1].Cells["insulationDrop"].Value = "Снижена";
                            dataGridView1.Rows[number - 1].Cells["insulationDrop"].Style.BackColor = Color.Orange;
                            //dataGridView1.Rows[number - 1].Cells["insulationDrop"].Style.
                        }
                        else
                        {
                            dataGridView1.Rows[number - 1].Cells["insulationDrop"].Value = "Норма";
                            dataGridView1.Rows[number - 1].Cells["insulationDrop"].Style.BackColor = SystemColors.Control;
                        }
                        dataGridView1.Rows[number - 1].Cells["sensorResistance"].Value = Math.Round((double)value, 3);
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
        }
    }
}