using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace MikroSRZ104
{
    public partial class ConfigFilesForm : Form
    {
        int currentSelectedTab = 0;

        List<String> filePathes = new List<String>();

        List<String> fileNames = new List<String>();

        String[] deviceNames = new String[4];

        double[] currentMinRes = new double[] { 20, 20, 20, 20 };

        double[] currentMaxRes = new double[] { 200, 200, 200, 200 };

        List<double> minThreshold = new List<double>();

        List<double> maxThreshold = new List<double>();

        public ConfigFilesForm()
        {
            InitializeComponent();
        }

        private void btnAddConfigFile_Click(object sender, EventArgs e)
        {
            if (filePathes.Count < 4)
            {
                openFileDialog1.Filter = "Файл конфигурации МикроСРЗ (.ea)| *.ea";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePathes.Add(openFileDialog1.FileName);
                    lstbxFilesNames.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
                }
            }
            else
            {
                MessageBox.Show("Число файлов конфигурации должно равняться 4", "Ошибка");
            }
        }

        private void btnDeleteConfigFile_Click(object sender, EventArgs e)
        {
            if (lstbxFilesNames.SelectedIndex != -1)
            {
                filePathes.RemoveAt(lstbxFilesNames.SelectedIndex);
                lstbxFilesNames.Items.RemoveAt(lstbxFilesNames.SelectedIndex);
            }
        }
        private void AppendXML(string fileName, XmlNodeList list, String mikroSRZFileName, double minThreshold,
                                                                                               double maxThreshold)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(fileName);
            foreach (XmlNode item in list)
            {
                XmlNode temp = xml.ImportNode(item, true);
                XmlNode nameNode = xml.CreateNode(XmlNodeType.Element, "NAME", null);
                nameNode.InnerText = mikroSRZFileName;
                temp.PrependChild(nameNode);
                foreach (XmlNode tempnode in temp)
                {
                    if (tempnode.Name == "ISA")
                    {
                        XmlNode minThresholdNode = xml.CreateNode(XmlNodeType.Element, "MIN_THRESHOLD_RES", null);
                        minThresholdNode.InnerText = Convert.ToString(minThreshold);
                        temp.InsertBefore(minThresholdNode, tempnode);

                        XmlNode maxThresholdNode = xml.CreateNode(XmlNodeType.Element, "MAX_THRESHOLD_RES", null);
                        maxThresholdNode.InnerText = Convert.ToString(maxThreshold);
                        temp.InsertBefore(maxThresholdNode, tempnode);

                        break;
                    }
                }

                xml.DocumentElement.AppendChild(temp);
            }

            xml.Save(fileName);
        }

        private void ConcatFunction(List<String> files, List<String> fileNames,
                                             double[] currentMinRes, double[] currentMaxRes)
        {
            int k = 0;

            foreach (String file in files)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(file);
                AppendXML("MikroSRZ104Config.ea", xml.DocumentElement.SelectNodes("/configuration"), fileNames[k],
                                                                                    currentMinRes[k], currentMaxRes[k]);
                k++;
            }
        }

        private void btnNextToTab2_Click(object sender, EventArgs e)
        {
            if (lstbxFilesNames.Items.Count != 4)
            {
                MessageBox.Show("Число файлов конфигурации должно равняться 4", "Ошибка");
            }
            else
            {
                fileNames.Clear();

                foreach (var item in lstbxFilesNames.Items)
                {
                    fileNames.Add(item.ToString());
                }

                lblFirstDeviceName.Text = fileNames[0];
                lblSecondDeviceName.Text = fileNames[1];
                lblThirdDeviceName.Text = fileNames[2];
                lblFourthDeviceName.Text = fileNames[3];

                currentSelectedTab = 1;
                tabControlConfig.SelectedIndex = 1;
            }
        }


        private void btnNextToTab3_Click(object sender, EventArgs e)
        {
            if (txtbxFirstDeviceName.Text != "")
            {
                deviceNames[0] = txtbxFirstDeviceName.Text;
            }
            else
            {
                deviceNames[0] = fileNames[0];
            }

            if (txtbxSecondDeviceName.Text != "")
            {
                deviceNames[1] = txtbxSecondDeviceName.Text;
            }
            else
            {
                deviceNames[1] = fileNames[1];
            }

            if (txtbxThirdDeviceName.Text != "")
            {
                deviceNames[2] = txtbxThirdDeviceName.Text;
            }
            else
            {
                deviceNames[2] = fileNames[2];
            }

            if (txtbxFourthDeviceName.Text != "")
            {
                deviceNames[3] = txtbxFourthDeviceName.Text;
            }
            else
            {
                deviceNames[3] = fileNames[3];
            }

            lblInfoForFirstDevice.Text = "Уставки для датчиков " + deviceNames[0];
            lblInfoForSecondDevice.Text = "Уставки для датчиков " + deviceNames[1];
            lblInfoForThirdDevice.Text = "Уставки для датчиков " + deviceNames[2];
            lblInfoForFourthDevice.Text = "Уставки для датчиков " + deviceNames[3];

            currentSelectedTab = 2;
            tabControlConfig.SelectedIndex = 2;

        }

        private void btnBackToTab1_Click(object sender, EventArgs e)
        {
            currentSelectedTab = 0;
            tabControlConfig.SelectedIndex = 0;
        }

        private void btnFinishConfig_Click(object sender, EventArgs e)
        {

            XmlTextWriter xmlwr = new XmlTextWriter("MikroSRZ104Config.ea", null);

            xmlwr.Formatting = Formatting.Indented;

            xmlwr.IndentChar = '\t';

            xmlwr.Indentation = 1;

            xmlwr.WriteStartDocument();

            xmlwr.WriteStartElement("root");

            xmlwr.WriteFullEndElement();

            xmlwr.Close();
            //
            ConcatFunction(filePathes, fileNames, currentMinRes, currentMaxRes);
            //

            XmlDocument xml = new XmlDocument();

            xml.Load("MikroSRZ104Config.ea");

            XmlNode root = xml.DocumentElement;

            XmlNodeList configs = root.ChildNodes;

            int y = 0;

            foreach (XmlNode config in configs)
            {

                XmlNodeList parameters = config.ChildNodes;

                foreach (XmlNode parameter in parameters)
                {
                    if (parameter.Name == "NAME")
                    {
                        parameter.InnerText = deviceNames[y];
                    }
                }

                y++;
            }

            xml.Save("MikroSRZ104Config.ea");
        }

        private void btnBackToTab2_Click(object sender, EventArgs e)
        {
            currentSelectedTab = 1;
            tabControlConfig.SelectedIndex = 1;

        }

        private void tabControlConfig_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (currentSelectedTab != tabControlConfig.SelectedIndex)
            {
                tabControlConfig.SelectTab(currentSelectedTab);
            }
        }

        private void AcceptMinResThreshold(TextBox textbox, int index)
        {
            lblInfoForFirstDevice.Focus();
            double result;
            bool isParsed = Double.TryParse(textbox.Text, out result);
            if (!isParsed)
            {
                textbox.Text = currentMinRes[index].ToString();
            }
            else
            {
                if (result >= currentMaxRes[index])
                {
                    MessageBox.Show("Минимальная уставка не может быть больше или равна максимальной!");
                    textbox.Text = currentMinRes[index].ToString();
                }
                else
                {
                    currentMinRes[index] = result;
                }
            }
        }

        private void AcceptMaxResThreshold(TextBox textbox, int index)
        {
            lblInfoForFirstDevice.Focus();
            double result;
            bool isParsed = Double.TryParse(textbox.Text, out result);
            if (!isParsed)
            {
                textbox.Text = currentMaxRes[index].ToString();
            }
            else
            {
                if (result <= currentMinRes[index])
                {
                    MessageBox.Show("Максимальная уставка не может быть меньше или равна минимальной!");
                    textbox.Text = currentMaxRes[index].ToString();
                }
                else
                {
                    currentMaxRes[index] = result;
                }
            }
        }

        private void KeysValidatorMin(TextBox textbox, int index, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                AcceptMinResThreshold(textbox, index);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void KeysValidatorMax(TextBox textbox, int index, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44 || e.KeyChar == 8 || e.KeyChar == 127)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == 13)
            {
                AcceptMaxResThreshold(textbox, index);
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtbxFirstDevSensorMinRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMin(txtbxFirstDevSensorMinRes, 0, e);
        }

        private void txtbxFirstDevSensorMinRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMinResThreshold(txtbxFirstDevSensorMinRes, 0);
        }

        private void txtbxFirstDevSensorMaxRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMax(txtbxFirstDevSensorMaxRes, 0, e);
        }

        private void txtbxFirstDevSensorMaxRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMaxResThreshold(txtbxFirstDevSensorMaxRes, 0);
        }

        private void txtbxSecondDevSensorMinRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMin(txtbxSecondDevSensorMinRes, 1, e);
        }

        private void txtbxSecondDevSensorMinRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMinResThreshold(txtbxSecondDevSensorMinRes, 1);
        }

        private void txtbxSecondDevSensorMaxRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMax(txtbxSecondDevSensorMaxRes, 1, e);
        }

        private void txtbxSecondDevSensorMaxRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMaxResThreshold(txtbxSecondDevSensorMaxRes, 1);
        }

        private void txtbxThirdDevSensorMinRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMin(txtbxThirdDevSensorMinRes, 2, e);
        }

        private void txtbxThirdDevSensorMinRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMinResThreshold(txtbxThirdDevSensorMinRes, 2);
        }
        private void txtbxThirdDevSensorMaxRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMax(txtbxThirdDevSensorMaxRes, 2, e);
        }

        private void txtbxThirdDevSensorMaxRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMaxResThreshold(txtbxThirdDevSensorMaxRes, 2);
        }

        private void txtbxFourthDevSensorMinRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMin(txtbxFourthDevSensorMinRes, 3, e);
        }

        private void txtbxFourthDevSensorMinRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMinResThreshold(txtbxFourthDevSensorMinRes, 3);
        }

        private void txtbxFourthDevSensorMaxRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysValidatorMax(txtbxFourthDevSensorMaxRes, 3, e);
        }

        private void txtbxFourthDevSensorMaxRes_Validating(object sender, CancelEventArgs e)
        {
            AcceptMaxResThreshold(txtbxFourthDevSensorMaxRes, 3);
        }
    }
}
