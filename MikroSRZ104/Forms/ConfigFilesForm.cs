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
        List<String> filePathes = new List<String>();        

        public List<String> FilePathes
        {
            get
            {
                return filePathes;
            }
        }

        List<String> fileNames = new List<String>();

        public List<String> FileNames
        {
            get
            {
                return fileNames;
            }
        }

        String[] deviceNames = new String[4];        

        List<double> minThreshold = new List<double>();

        List<double> maxThreshold = new List<double>();


        public ConfigFilesForm()
        {
            InitializeComponent();            
        }

        private void btnAddConfigFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Файл конфигурации МикроСРЗ (.ea)| *.ea";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePathes.Add(openFileDialog1.FileName);
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(openFileDialog1.FileName));
            }
        }

        private void btnDeleteConfigFile_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FilePathes.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btnNextToTab2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 4)
            {
                MessageBox.Show("Число файлов конфигурации должно равняться 4");
            }
            else
            {
                fileNames.Clear();
                         
                foreach (var item in listBox1.Items)
                {
                    fileNames.Add(item.ToString());                  
                }

                


                label16.Text = fileNames[0];
                label17.Text = fileNames[1];
                label18.Text = fileNames[2];
                label19.Text = fileNames[3];

                tabControl1.SelectedIndex = 1;

            }

           
        }

        private void AppendXML(string filename, XmlNodeList list, String mikroSRZfilename, double minthreshold, double maxthreshold)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            foreach (XmlNode item in list)
            {
                XmlNode temp = xml.ImportNode(item, true);
                XmlNode nameNode = xml.CreateNode(XmlNodeType.Element, "NAME", null);
                nameNode.InnerText = mikroSRZfilename;
                temp.PrependChild(nameNode);                
                foreach (XmlNode tempnode in temp)
                {
                    if (tempnode.Name == "ISA")
                    {
                        XmlNode minThresholdNode = xml.CreateNode(XmlNodeType.Element, "MIN_THRESHOLD_RES", null);
                        minThresholdNode.InnerText = Convert.ToString(minthreshold);
                        temp.InsertBefore(minThresholdNode, tempnode);

                        XmlNode maxThresholdNode = xml.CreateNode(XmlNodeType.Element, "MAX_THRESHOLD_RES", null);
                        maxThresholdNode.InnerText = Convert.ToString(maxthreshold);
                        temp.InsertBefore(maxThresholdNode, tempnode);

                        break;
                    }
                }

                xml.DocumentElement.AppendChild(temp);               

            }
            
            xml.Save(filename);                        
        }

        private void ConcatFunction(List<String> files, List<String> filenames, List<double> minthreshold, List<double> maxthreshold)
        {
            int k = 0;

            foreach (String file in files)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(file);
                AppendXML("MikroSRZ104Config.ea", xml.DocumentElement.SelectNodes("/configuration"), filenames[k], minthreshold[k], maxthreshold[k]);
                k++;
            }
        }        

        private void btnNextToTab3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                deviceNames[0] = textBox9.Text;
            }
            else
            {
                deviceNames[0] = fileNames[0];
            }

            if (textBox10.Text != "")
            {
                deviceNames[1] = textBox10.Text;
            }
            else
            {
                deviceNames[1] = fileNames[1];
            }

            if (textBox11.Text != "")
            {
                deviceNames[2] = textBox11.Text;
            }
            else
            {
                deviceNames[2] = fileNames[2];
            }

            if (textBox12.Text != "")
            {
                deviceNames[3] = textBox12.Text;
            }
            else
            {
                deviceNames[3] = fileNames[3];
            }

            label3.Text = "Уставки для датчиков МикроСРЗ с именем  " + deviceNames[0];
            label8.Text = "Уставки для датчиков МикроСРЗ с именем  " + deviceNames[1];
            label11.Text = "Уставки для датчиков МикроСРЗ с именем  " + deviceNames[2];
            label14.Text = "Уставки для датчиков МикроСРЗ с именем  " + deviceNames[3];

            tabControl1.SelectedIndex = 2;
        }

        private void btnBackToTab1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnFinishConfig_Click(object sender, EventArgs e)
        {
            minThreshold.Add(Convert.ToDouble((textBox1.Text)));
            minThreshold.Add(Convert.ToDouble((textBox3.Text)));
            minThreshold.Add(Convert.ToDouble((textBox5.Text)));
            minThreshold.Add(Convert.ToDouble((textBox7.Text)));

            maxThreshold.Add(Convert.ToDouble((textBox2.Text)));
            maxThreshold.Add(Convert.ToDouble((textBox4.Text)));
            maxThreshold.Add(Convert.ToDouble((textBox6.Text)));
            maxThreshold.Add(Convert.ToDouble((textBox8.Text)));

            //
            XmlTextWriter xmlwr = new XmlTextWriter("MikroSRZ104Config.ea", null);

            xmlwr.Formatting = Formatting.Indented;

            xmlwr.IndentChar = '\t';

            xmlwr.Indentation = 1;

            xmlwr.WriteStartDocument();

            xmlwr.WriteStartElement("root");

            xmlwr.WriteFullEndElement();

            xmlwr.Close();
            //
            ConcatFunction(filePathes, fileNames, minThreshold, maxThreshold);
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
            tabControl1.SelectedIndex = 1;
        }

        private void ConfigFilesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            Dispose();
        }
    }
}
