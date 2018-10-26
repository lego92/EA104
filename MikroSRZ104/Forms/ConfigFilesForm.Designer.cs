namespace MikroSRZ104
{
    partial class ConfigFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFilesForm));
            this.lstbxFilesNames = new System.Windows.Forms.ListBox();
            this.btnAddConfigFile = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteConfigFile = new System.Windows.Forms.Button();
            this.btnNextToTabPage2 = new System.Windows.Forms.Button();
            this.lblInfoFilesPage1 = new System.Windows.Forms.Label();
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPageConfigFiles = new System.Windows.Forms.TabPage();
            this.lblInfoFilesPage2 = new System.Windows.Forms.Label();
            this.tabPageNames = new System.Windows.Forms.TabPage();
            this.btnBackToTabPage1 = new System.Windows.Forms.Button();
            this.btnNextToTabPage3 = new System.Windows.Forms.Button();
            this.txtbxFourthDeviceName = new System.Windows.Forms.TextBox();
            this.lblFourthDeviceName = new System.Windows.Forms.Label();
            this.txtbxThirdDeviceName = new System.Windows.Forms.TextBox();
            this.lblThirdDeviceName = new System.Windows.Forms.Label();
            this.txtbxSecondDeviceName = new System.Windows.Forms.TextBox();
            this.lblSecondDeviceName = new System.Windows.Forms.Label();
            this.txtbxFirstDeviceName = new System.Windows.Forms.TextBox();
            this.lblFirstDeviceName = new System.Windows.Forms.Label();
            this.lblInfoNamesPage1 = new System.Windows.Forms.Label();
            this.tabPageSensors = new System.Windows.Forms.TabPage();
            this.btnBackToTab2 = new System.Windows.Forms.Button();
            this.btnFinishConfig = new System.Windows.Forms.Button();
            this.txtbxFourthDevSensorMinRes = new System.Windows.Forms.TextBox();
            this.lblFourthDevSensorMaxRes = new System.Windows.Forms.Label();
            this.lblFourthDevSensorMinRes = new System.Windows.Forms.Label();
            this.lblInfoForFourthDevice = new System.Windows.Forms.Label();
            this.txtbxFourthDevSensorMaxRes = new System.Windows.Forms.TextBox();
            this.txtbxThirdDevSensorMinRes = new System.Windows.Forms.TextBox();
            this.lblThirdDevSensorMaxRes = new System.Windows.Forms.Label();
            this.lblThirdDevSensorMinRes = new System.Windows.Forms.Label();
            this.lblInfoForThirdDevice = new System.Windows.Forms.Label();
            this.txtbxThirdDevSensorMaxRes = new System.Windows.Forms.TextBox();
            this.txtbxSecondDevSensorMinRes = new System.Windows.Forms.TextBox();
            this.lblSecondDevSensorMaxRes = new System.Windows.Forms.Label();
            this.lblSecondDevSensorMinRes = new System.Windows.Forms.Label();
            this.lblInfoForSecondDevice = new System.Windows.Forms.Label();
            this.txtbxSecondDevSensorMaxRes = new System.Windows.Forms.TextBox();
            this.txtbxFirstDevSensorMaxRes = new System.Windows.Forms.TextBox();
            this.lblFirstDevSensorMaxRes = new System.Windows.Forms.Label();
            this.lblFirstDevSensorMinRes = new System.Windows.Forms.Label();
            this.lblInfoForFirstDevice = new System.Windows.Forms.Label();
            this.txtbxFirstDevSensorMinRes = new System.Windows.Forms.TextBox();
            this.tabControlConfig.SuspendLayout();
            this.tabPageConfigFiles.SuspendLayout();
            this.tabPageNames.SuspendLayout();
            this.tabPageSensors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxFilesNames
            // 
            this.lstbxFilesNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstbxFilesNames.FormattingEnabled = true;
            this.lstbxFilesNames.ItemHeight = 25;
            this.lstbxFilesNames.Location = new System.Drawing.Point(23, 251);
            this.lstbxFilesNames.Name = "lstbxFilesNames";
            this.lstbxFilesNames.Size = new System.Drawing.Size(591, 254);
            this.lstbxFilesNames.TabIndex = 0;
            // 
            // btnAddConfigFile
            // 
            this.btnAddConfigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddConfigFile.Location = new System.Drawing.Point(117, 185);
            this.btnAddConfigFile.Name = "btnAddConfigFile";
            this.btnAddConfigFile.Size = new System.Drawing.Size(167, 40);
            this.btnAddConfigFile.TabIndex = 1;
            this.btnAddConfigFile.Text = "Добавить файл";
            this.btnAddConfigFile.UseVisualStyleBackColor = true;
            this.btnAddConfigFile.Click += new System.EventHandler(this.btnAddConfigFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDeleteConfigFile
            // 
            this.btnDeleteConfigFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteConfigFile.Location = new System.Drawing.Point(311, 185);
            this.btnDeleteConfigFile.Name = "btnDeleteConfigFile";
            this.btnDeleteConfigFile.Size = new System.Drawing.Size(167, 40);
            this.btnDeleteConfigFile.TabIndex = 2;
            this.btnDeleteConfigFile.Text = "Удалить файл";
            this.btnDeleteConfigFile.UseVisualStyleBackColor = true;
            this.btnDeleteConfigFile.Click += new System.EventHandler(this.btnDeleteConfigFile_Click);
            // 
            // btnNextToTabPage2
            // 
            this.btnNextToTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextToTabPage2.Location = new System.Drawing.Point(252, 627);
            this.btnNextToTabPage2.Name = "btnNextToTabPage2";
            this.btnNextToTabPage2.Size = new System.Drawing.Size(100, 37);
            this.btnNextToTabPage2.TabIndex = 3;
            this.btnNextToTabPage2.Text = "Далее";
            this.btnNextToTabPage2.UseVisualStyleBackColor = true;
            this.btnNextToTabPage2.Click += new System.EventHandler(this.btnNextToTab2_Click);
            // 
            // lblInfoFilesPage1
            // 
            this.lblInfoFilesPage1.AutoSize = true;
            this.lblInfoFilesPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoFilesPage1.Location = new System.Drawing.Point(11, 38);
            this.lblInfoFilesPage1.Name = "lblInfoFilesPage1";
            this.lblInfoFilesPage1.Size = new System.Drawing.Size(607, 96);
            this.lblInfoFilesPage1.TabIndex = 4;
            this.lblInfoFilesPage1.Text = "Файл конфигурации программы отсутствует.\r\n\r\nДля конфигурирования программы укажит" +
    "е файлы конфигурации \r\nустройств МикроСРЗ.";
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPageConfigFiles);
            this.tabControlConfig.Controls.Add(this.tabPageNames);
            this.tabControlConfig.Controls.Add(this.tabPageSensors);
            this.tabControlConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlConfig.Location = new System.Drawing.Point(-3, 1);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(648, 787);
            this.tabControlConfig.TabIndex = 5;
            this.tabControlConfig.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlConfig_Selecting);
            // 
            // tabPageConfigFiles
            // 
            this.tabPageConfigFiles.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageConfigFiles.Controls.Add(this.lblInfoFilesPage2);
            this.tabPageConfigFiles.Controls.Add(this.btnNextToTabPage2);
            this.tabPageConfigFiles.Controls.Add(this.lblInfoFilesPage1);
            this.tabPageConfigFiles.Controls.Add(this.btnAddConfigFile);
            this.tabPageConfigFiles.Controls.Add(this.lstbxFilesNames);
            this.tabPageConfigFiles.Controls.Add(this.btnDeleteConfigFile);
            this.tabPageConfigFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageConfigFiles.Location = new System.Drawing.Point(4, 25);
            this.tabPageConfigFiles.Name = "tabPageConfigFiles";
            this.tabPageConfigFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfigFiles.Size = new System.Drawing.Size(640, 758);
            this.tabPageConfigFiles.TabIndex = 0;
            this.tabPageConfigFiles.Text = "Файлы конфигурации";
            // 
            // lblInfoFilesPage2
            // 
            this.lblInfoFilesPage2.AutoSize = true;
            this.lblInfoFilesPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoFilesPage2.Location = new System.Drawing.Point(104, 542);
            this.lblInfoFilesPage2.Name = "lblInfoFilesPage2";
            this.lblInfoFilesPage2.Size = new System.Drawing.Size(415, 24);
            this.lblInfoFilesPage2.TabIndex = 5;
            this.lblInfoFilesPage2.Text = "После добавления файлов нажмите \"Далее\".";
            // 
            // tabPageNames
            // 
            this.tabPageNames.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNames.Controls.Add(this.btnBackToTabPage1);
            this.tabPageNames.Controls.Add(this.btnNextToTabPage3);
            this.tabPageNames.Controls.Add(this.txtbxFourthDeviceName);
            this.tabPageNames.Controls.Add(this.lblFourthDeviceName);
            this.tabPageNames.Controls.Add(this.txtbxThirdDeviceName);
            this.tabPageNames.Controls.Add(this.lblThirdDeviceName);
            this.tabPageNames.Controls.Add(this.txtbxSecondDeviceName);
            this.tabPageNames.Controls.Add(this.lblSecondDeviceName);
            this.tabPageNames.Controls.Add(this.txtbxFirstDeviceName);
            this.tabPageNames.Controls.Add(this.lblFirstDeviceName);
            this.tabPageNames.Controls.Add(this.lblInfoNamesPage1);
            this.tabPageNames.Location = new System.Drawing.Point(4, 25);
            this.tabPageNames.Name = "tabPageNames";
            this.tabPageNames.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNames.Size = new System.Drawing.Size(640, 758);
            this.tabPageNames.TabIndex = 2;
            this.tabPageNames.Text = "Наименования устройств";
            // 
            // btnBackToTabPage1
            // 
            this.btnBackToTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToTabPage1.Location = new System.Drawing.Point(170, 663);
            this.btnBackToTabPage1.Name = "btnBackToTabPage1";
            this.btnBackToTabPage1.Size = new System.Drawing.Size(111, 41);
            this.btnBackToTabPage1.TabIndex = 10;
            this.btnBackToTabPage1.Text = "Назад";
            this.btnBackToTabPage1.UseVisualStyleBackColor = true;
            this.btnBackToTabPage1.Click += new System.EventHandler(this.btnBackToTab1_Click);
            // 
            // btnNextToTabPage3
            // 
            this.btnNextToTabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNextToTabPage3.Location = new System.Drawing.Point(310, 663);
            this.btnNextToTabPage3.Name = "btnNextToTabPage3";
            this.btnNextToTabPage3.Size = new System.Drawing.Size(116, 41);
            this.btnNextToTabPage3.TabIndex = 9;
            this.btnNextToTabPage3.Text = "Далее";
            this.btnNextToTabPage3.UseVisualStyleBackColor = true;
            this.btnNextToTabPage3.Click += new System.EventHandler(this.btnNextToTab3_Click);
            // 
            // txtbxFourthDeviceName
            // 
            this.txtbxFourthDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFourthDeviceName.Location = new System.Drawing.Point(240, 534);
            this.txtbxFourthDeviceName.Name = "txtbxFourthDeviceName";
            this.txtbxFourthDeviceName.Size = new System.Drawing.Size(234, 29);
            this.txtbxFourthDeviceName.TabIndex = 8;
            // 
            // lblFourthDeviceName
            // 
            this.lblFourthDeviceName.AutoSize = true;
            this.lblFourthDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFourthDeviceName.Location = new System.Drawing.Point(54, 539);
            this.lblFourthDeviceName.Name = "lblFourthDeviceName";
            this.lblFourthDeviceName.Size = new System.Drawing.Size(116, 24);
            this.lblFourthDeviceName.TabIndex = 7;
            this.lblFourthDeviceName.Text = "МикроСРЗ4";
            // 
            // txtbxThirdDeviceName
            // 
            this.txtbxThirdDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxThirdDeviceName.Location = new System.Drawing.Point(240, 413);
            this.txtbxThirdDeviceName.Name = "txtbxThirdDeviceName";
            this.txtbxThirdDeviceName.Size = new System.Drawing.Size(234, 29);
            this.txtbxThirdDeviceName.TabIndex = 6;
            // 
            // lblThirdDeviceName
            // 
            this.lblThirdDeviceName.AutoSize = true;
            this.lblThirdDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThirdDeviceName.Location = new System.Drawing.Point(54, 418);
            this.lblThirdDeviceName.Name = "lblThirdDeviceName";
            this.lblThirdDeviceName.Size = new System.Drawing.Size(116, 24);
            this.lblThirdDeviceName.TabIndex = 5;
            this.lblThirdDeviceName.Text = "МикроСРЗ3";
            // 
            // txtbxSecondDeviceName
            // 
            this.txtbxSecondDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxSecondDeviceName.Location = new System.Drawing.Point(240, 306);
            this.txtbxSecondDeviceName.Name = "txtbxSecondDeviceName";
            this.txtbxSecondDeviceName.Size = new System.Drawing.Size(234, 29);
            this.txtbxSecondDeviceName.TabIndex = 4;
            // 
            // lblSecondDeviceName
            // 
            this.lblSecondDeviceName.AutoSize = true;
            this.lblSecondDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondDeviceName.Location = new System.Drawing.Point(54, 313);
            this.lblSecondDeviceName.Name = "lblSecondDeviceName";
            this.lblSecondDeviceName.Size = new System.Drawing.Size(116, 24);
            this.lblSecondDeviceName.TabIndex = 3;
            this.lblSecondDeviceName.Text = "МикроСРЗ2";
            // 
            // txtbxFirstDeviceName
            // 
            this.txtbxFirstDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFirstDeviceName.Location = new System.Drawing.Point(240, 196);
            this.txtbxFirstDeviceName.MaxLength = 20;
            this.txtbxFirstDeviceName.Name = "txtbxFirstDeviceName";
            this.txtbxFirstDeviceName.Size = new System.Drawing.Size(234, 29);
            this.txtbxFirstDeviceName.TabIndex = 2;
            // 
            // lblFirstDeviceName
            // 
            this.lblFirstDeviceName.AutoSize = true;
            this.lblFirstDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstDeviceName.Location = new System.Drawing.Point(54, 201);
            this.lblFirstDeviceName.Name = "lblFirstDeviceName";
            this.lblFirstDeviceName.Size = new System.Drawing.Size(116, 24);
            this.lblFirstDeviceName.TabIndex = 1;
            this.lblFirstDeviceName.Text = "МикроСРЗ1";
            // 
            // lblInfoNamesPage1
            // 
            this.lblInfoNamesPage1.AutoSize = true;
            this.lblInfoNamesPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoNamesPage1.Location = new System.Drawing.Point(8, 12);
            this.lblInfoNamesPage1.Name = "lblInfoNamesPage1";
            this.lblInfoNamesPage1.Size = new System.Drawing.Size(598, 144);
            this.lblInfoNamesPage1.TabIndex = 0;
            this.lblInfoNamesPage1.Text = resources.GetString("lblInfoNamesPage1.Text");
            // 
            // tabPageSensors
            // 
            this.tabPageSensors.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSensors.Controls.Add(this.btnBackToTab2);
            this.tabPageSensors.Controls.Add(this.btnFinishConfig);
            this.tabPageSensors.Controls.Add(this.txtbxFourthDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblFourthDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.lblFourthDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblInfoForFourthDevice);
            this.tabPageSensors.Controls.Add(this.txtbxFourthDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.txtbxThirdDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblThirdDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.lblThirdDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblInfoForThirdDevice);
            this.tabPageSensors.Controls.Add(this.txtbxThirdDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.txtbxSecondDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblSecondDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.lblSecondDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblInfoForSecondDevice);
            this.tabPageSensors.Controls.Add(this.txtbxSecondDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.txtbxFirstDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.lblFirstDevSensorMaxRes);
            this.tabPageSensors.Controls.Add(this.lblFirstDevSensorMinRes);
            this.tabPageSensors.Controls.Add(this.lblInfoForFirstDevice);
            this.tabPageSensors.Controls.Add(this.txtbxFirstDevSensorMinRes);
            this.tabPageSensors.Location = new System.Drawing.Point(4, 25);
            this.tabPageSensors.Name = "tabPageSensors";
            this.tabPageSensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSensors.Size = new System.Drawing.Size(640, 758);
            this.tabPageSensors.TabIndex = 1;
            this.tabPageSensors.Text = "Уставки датчиков";
            // 
            // btnBackToTab2
            // 
            this.btnBackToTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackToTab2.Location = new System.Drawing.Point(76, 689);
            this.btnBackToTab2.Name = "btnBackToTab2";
            this.btnBackToTab2.Size = new System.Drawing.Size(126, 45);
            this.btnBackToTab2.TabIndex = 27;
            this.btnBackToTab2.Text = "Назад";
            this.btnBackToTab2.UseVisualStyleBackColor = true;
            this.btnBackToTab2.Click += new System.EventHandler(this.btnBackToTab2_Click);
            // 
            // btnFinishConfig
            // 
            this.btnFinishConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFinishConfig.Location = new System.Drawing.Point(243, 689);
            this.btnFinishConfig.Name = "btnFinishConfig";
            this.btnFinishConfig.Size = new System.Drawing.Size(310, 43);
            this.btnFinishConfig.TabIndex = 26;
            this.btnFinishConfig.Text = "Завершить конфигурирование";
            this.btnFinishConfig.UseVisualStyleBackColor = true;
            this.btnFinishConfig.Click += new System.EventHandler(this.btnFinishConfig_Click);
            // 
            // txtbxFourthDevSensorMinRes
            // 
            this.txtbxFourthDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFourthDevSensorMinRes.Location = new System.Drawing.Point(60, 608);
            this.txtbxFourthDevSensorMinRes.Name = "txtbxFourthDevSensorMinRes";
            this.txtbxFourthDevSensorMinRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxFourthDevSensorMinRes.TabIndex = 25;
            this.txtbxFourthDevSensorMinRes.Text = "20";
            this.txtbxFourthDevSensorMinRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFourthDevSensorMinRes_KeyPress);
            this.txtbxFourthDevSensorMinRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFourthDevSensorMinRes_Validating);
            // 
            // lblFourthDevSensorMaxRes
            // 
            this.lblFourthDevSensorMaxRes.AutoSize = true;
            this.lblFourthDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFourthDevSensorMaxRes.Location = new System.Drawing.Point(320, 549);
            this.lblFourthDevSensorMaxRes.Name = "lblFourthDevSensorMaxRes";
            this.lblFourthDevSensorMaxRes.Size = new System.Drawing.Size(191, 48);
            this.lblFourthDevSensorMaxRes.TabIndex = 24;
            this.lblFourthDevSensorMaxRes.Text = "Предварительная \r\nсигнализация, кОм :";
            // 
            // lblFourthDevSensorMinRes
            // 
            this.lblFourthDevSensorMinRes.AutoSize = true;
            this.lblFourthDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFourthDevSensorMinRes.Location = new System.Drawing.Point(56, 548);
            this.lblFourthDevSensorMinRes.Name = "lblFourthDevSensorMinRes";
            this.lblFourthDevSensorMinRes.Size = new System.Drawing.Size(191, 48);
            this.lblFourthDevSensorMinRes.TabIndex = 23;
            this.lblFourthDevSensorMinRes.Text = "Аварийная \r\nсигнализация, кОм :";
            // 
            // lblInfoForFourthDevice
            // 
            this.lblInfoForFourthDevice.AutoSize = true;
            this.lblInfoForFourthDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoForFourthDevice.Location = new System.Drawing.Point(56, 511);
            this.lblInfoForFourthDevice.Name = "lblInfoForFourthDevice";
            this.lblInfoForFourthDevice.Size = new System.Drawing.Size(209, 24);
            this.lblInfoForFourthDevice.TabIndex = 22;
            this.lblInfoForFourthDevice.Text = "Уставки для датчиков";
            // 
            // txtbxFourthDevSensorMaxRes
            // 
            this.txtbxFourthDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFourthDevSensorMaxRes.Location = new System.Drawing.Point(324, 608);
            this.txtbxFourthDevSensorMaxRes.Name = "txtbxFourthDevSensorMaxRes";
            this.txtbxFourthDevSensorMaxRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxFourthDevSensorMaxRes.TabIndex = 21;
            this.txtbxFourthDevSensorMaxRes.Text = "200";
            this.txtbxFourthDevSensorMaxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFourthDevSensorMaxRes_KeyPress);
            this.txtbxFourthDevSensorMaxRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFourthDevSensorMaxRes_Validating);
            // 
            // txtbxThirdDevSensorMinRes
            // 
            this.txtbxThirdDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxThirdDevSensorMinRes.Location = new System.Drawing.Point(61, 449);
            this.txtbxThirdDevSensorMinRes.Name = "txtbxThirdDevSensorMinRes";
            this.txtbxThirdDevSensorMinRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxThirdDevSensorMinRes.TabIndex = 20;
            this.txtbxThirdDevSensorMinRes.Text = "20";
            this.txtbxThirdDevSensorMinRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxThirdDevSensorMinRes_KeyPress);
            this.txtbxThirdDevSensorMinRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxThirdDevSensorMinRes_Validating);
            // 
            // lblThirdDevSensorMaxRes
            // 
            this.lblThirdDevSensorMaxRes.AutoSize = true;
            this.lblThirdDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThirdDevSensorMaxRes.Location = new System.Drawing.Point(320, 388);
            this.lblThirdDevSensorMaxRes.Name = "lblThirdDevSensorMaxRes";
            this.lblThirdDevSensorMaxRes.Size = new System.Drawing.Size(191, 48);
            this.lblThirdDevSensorMaxRes.TabIndex = 19;
            this.lblThirdDevSensorMaxRes.Text = "Предварительная \r\nсигнализация, кОм :\r\n";
            // 
            // lblThirdDevSensorMinRes
            // 
            this.lblThirdDevSensorMinRes.AutoSize = true;
            this.lblThirdDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThirdDevSensorMinRes.Location = new System.Drawing.Point(57, 388);
            this.lblThirdDevSensorMinRes.Name = "lblThirdDevSensorMinRes";
            this.lblThirdDevSensorMinRes.Size = new System.Drawing.Size(191, 48);
            this.lblThirdDevSensorMinRes.TabIndex = 18;
            this.lblThirdDevSensorMinRes.Text = "Аварийная \r\nсигнализация, кОм :\r\n";
            // 
            // lblInfoForThirdDevice
            // 
            this.lblInfoForThirdDevice.AutoSize = true;
            this.lblInfoForThirdDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoForThirdDevice.Location = new System.Drawing.Point(57, 350);
            this.lblInfoForThirdDevice.Name = "lblInfoForThirdDevice";
            this.lblInfoForThirdDevice.Size = new System.Drawing.Size(214, 24);
            this.lblInfoForThirdDevice.TabIndex = 17;
            this.lblInfoForThirdDevice.Text = "Уставки для датчиков ";
            // 
            // txtbxThirdDevSensorMaxRes
            // 
            this.txtbxThirdDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxThirdDevSensorMaxRes.Location = new System.Drawing.Point(324, 449);
            this.txtbxThirdDevSensorMaxRes.Name = "txtbxThirdDevSensorMaxRes";
            this.txtbxThirdDevSensorMaxRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxThirdDevSensorMaxRes.TabIndex = 16;
            this.txtbxThirdDevSensorMaxRes.Text = "200";
            this.txtbxThirdDevSensorMaxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxThirdDevSensorMaxRes_KeyPress);
            this.txtbxThirdDevSensorMaxRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxThirdDevSensorMaxRes_Validating);
            // 
            // txtbxSecondDevSensorMinRes
            // 
            this.txtbxSecondDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxSecondDevSensorMinRes.Location = new System.Drawing.Point(60, 286);
            this.txtbxSecondDevSensorMinRes.Name = "txtbxSecondDevSensorMinRes";
            this.txtbxSecondDevSensorMinRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxSecondDevSensorMinRes.TabIndex = 15;
            this.txtbxSecondDevSensorMinRes.Text = "20";
            this.txtbxSecondDevSensorMinRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSecondDevSensorMinRes_KeyPress);
            this.txtbxSecondDevSensorMinRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxSecondDevSensorMinRes_Validating);
            // 
            // lblSecondDevSensorMaxRes
            // 
            this.lblSecondDevSensorMaxRes.AutoSize = true;
            this.lblSecondDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondDevSensorMaxRes.Location = new System.Drawing.Point(320, 222);
            this.lblSecondDevSensorMaxRes.Name = "lblSecondDevSensorMaxRes";
            this.lblSecondDevSensorMaxRes.Size = new System.Drawing.Size(191, 48);
            this.lblSecondDevSensorMaxRes.TabIndex = 14;
            this.lblSecondDevSensorMaxRes.Text = "Предварительная \r\nсигнализация, кОм :";
            // 
            // lblSecondDevSensorMinRes
            // 
            this.lblSecondDevSensorMinRes.AutoSize = true;
            this.lblSecondDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondDevSensorMinRes.Location = new System.Drawing.Point(56, 222);
            this.lblSecondDevSensorMinRes.Name = "lblSecondDevSensorMinRes";
            this.lblSecondDevSensorMinRes.Size = new System.Drawing.Size(191, 48);
            this.lblSecondDevSensorMinRes.TabIndex = 13;
            this.lblSecondDevSensorMinRes.Text = "Аварийная \r\nсигнализация, кОм :";
            // 
            // lblInfoForSecondDevice
            // 
            this.lblInfoForSecondDevice.AutoSize = true;
            this.lblInfoForSecondDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoForSecondDevice.Location = new System.Drawing.Point(56, 186);
            this.lblInfoForSecondDevice.Name = "lblInfoForSecondDevice";
            this.lblInfoForSecondDevice.Size = new System.Drawing.Size(209, 24);
            this.lblInfoForSecondDevice.TabIndex = 12;
            this.lblInfoForSecondDevice.Text = "Уставки для датчиков";
            // 
            // txtbxSecondDevSensorMaxRes
            // 
            this.txtbxSecondDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxSecondDevSensorMaxRes.Location = new System.Drawing.Point(324, 286);
            this.txtbxSecondDevSensorMaxRes.Name = "txtbxSecondDevSensorMaxRes";
            this.txtbxSecondDevSensorMaxRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxSecondDevSensorMaxRes.TabIndex = 11;
            this.txtbxSecondDevSensorMaxRes.Text = "200";
            this.txtbxSecondDevSensorMaxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSecondDevSensorMaxRes_KeyPress);
            this.txtbxSecondDevSensorMaxRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxSecondDevSensorMaxRes_Validating);
            // 
            // txtbxFirstDevSensorMaxRes
            // 
            this.txtbxFirstDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFirstDevSensorMaxRes.Location = new System.Drawing.Point(324, 128);
            this.txtbxFirstDevSensorMaxRes.Name = "txtbxFirstDevSensorMaxRes";
            this.txtbxFirstDevSensorMaxRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxFirstDevSensorMaxRes.TabIndex = 10;
            this.txtbxFirstDevSensorMaxRes.Text = "200";
            this.txtbxFirstDevSensorMaxRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstDevSensorMaxRes_KeyPress);
            this.txtbxFirstDevSensorMaxRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFirstDevSensorMaxRes_Validating);
            // 
            // lblFirstDevSensorMaxRes
            // 
            this.lblFirstDevSensorMaxRes.AutoSize = true;
            this.lblFirstDevSensorMaxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstDevSensorMaxRes.Location = new System.Drawing.Point(320, 68);
            this.lblFirstDevSensorMaxRes.Name = "lblFirstDevSensorMaxRes";
            this.lblFirstDevSensorMaxRes.Size = new System.Drawing.Size(191, 48);
            this.lblFirstDevSensorMaxRes.TabIndex = 3;
            this.lblFirstDevSensorMaxRes.Text = "Предварительная \r\nсигнализация, кОм :";
            // 
            // lblFirstDevSensorMinRes
            // 
            this.lblFirstDevSensorMinRes.AutoSize = true;
            this.lblFirstDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstDevSensorMinRes.Location = new System.Drawing.Point(56, 68);
            this.lblFirstDevSensorMinRes.Name = "lblFirstDevSensorMinRes";
            this.lblFirstDevSensorMinRes.Size = new System.Drawing.Size(191, 48);
            this.lblFirstDevSensorMinRes.TabIndex = 2;
            this.lblFirstDevSensorMinRes.Text = "Аварийная \r\nсигнализация, кОм :";
            // 
            // lblInfoForFirstDevice
            // 
            this.lblInfoForFirstDevice.AutoSize = true;
            this.lblInfoForFirstDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfoForFirstDevice.Location = new System.Drawing.Point(56, 33);
            this.lblInfoForFirstDevice.Name = "lblInfoForFirstDevice";
            this.lblInfoForFirstDevice.Size = new System.Drawing.Size(209, 24);
            this.lblInfoForFirstDevice.TabIndex = 1;
            this.lblInfoForFirstDevice.Text = "Уставки для датчиков";
            // 
            // txtbxFirstDevSensorMinRes
            // 
            this.txtbxFirstDevSensorMinRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbxFirstDevSensorMinRes.Location = new System.Drawing.Point(60, 128);
            this.txtbxFirstDevSensorMinRes.Name = "txtbxFirstDevSensorMinRes";
            this.txtbxFirstDevSensorMinRes.Size = new System.Drawing.Size(144, 29);
            this.txtbxFirstDevSensorMinRes.TabIndex = 0;
            this.txtbxFirstDevSensorMinRes.Text = "20";
            this.txtbxFirstDevSensorMinRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxFirstDevSensorMinRes_KeyPress);
            this.txtbxFirstDevSensorMinRes.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxFirstDevSensorMinRes_Validating);
            // 
            // ConfigFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 785);
            this.Controls.Add(this.tabControlConfig);
            this.Name = "ConfigFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конфигурирование программы";
            this.tabControlConfig.ResumeLayout(false);
            this.tabPageConfigFiles.ResumeLayout(false);
            this.tabPageConfigFiles.PerformLayout();
            this.tabPageNames.ResumeLayout(false);
            this.tabPageNames.PerformLayout();
            this.tabPageSensors.ResumeLayout(false);
            this.tabPageSensors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxFilesNames;
        private System.Windows.Forms.Button btnAddConfigFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDeleteConfigFile;
        private System.Windows.Forms.Button btnNextToTabPage2;
        private System.Windows.Forms.Label lblInfoFilesPage1;
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPageConfigFiles;
        private System.Windows.Forms.Label lblInfoFilesPage2;
        private System.Windows.Forms.TabPage tabPageSensors;
        private System.Windows.Forms.TextBox txtbxFourthDevSensorMinRes;
        private System.Windows.Forms.Label lblFourthDevSensorMaxRes;
        private System.Windows.Forms.Label lblFourthDevSensorMinRes;
        private System.Windows.Forms.Label lblInfoForFourthDevice;
        private System.Windows.Forms.TextBox txtbxFourthDevSensorMaxRes;
        private System.Windows.Forms.TextBox txtbxThirdDevSensorMinRes;
        private System.Windows.Forms.Label lblThirdDevSensorMaxRes;
        private System.Windows.Forms.Label lblThirdDevSensorMinRes;
        private System.Windows.Forms.Label lblInfoForThirdDevice;
        private System.Windows.Forms.TextBox txtbxThirdDevSensorMaxRes;
        private System.Windows.Forms.TextBox txtbxSecondDevSensorMinRes;
        private System.Windows.Forms.Label lblSecondDevSensorMaxRes;
        private System.Windows.Forms.Label lblSecondDevSensorMinRes;
        private System.Windows.Forms.Label lblInfoForSecondDevice;
        private System.Windows.Forms.TextBox txtbxSecondDevSensorMaxRes;
        private System.Windows.Forms.TextBox txtbxFirstDevSensorMaxRes;
        private System.Windows.Forms.Label lblFirstDevSensorMaxRes;
        private System.Windows.Forms.Label lblFirstDevSensorMinRes;
        private System.Windows.Forms.Label lblInfoForFirstDevice;
        private System.Windows.Forms.TextBox txtbxFirstDevSensorMinRes;
        private System.Windows.Forms.Button btnFinishConfig;
        private System.Windows.Forms.TabPage tabPageNames;
        private System.Windows.Forms.TextBox txtbxFourthDeviceName;
        private System.Windows.Forms.Label lblFourthDeviceName;
        private System.Windows.Forms.TextBox txtbxThirdDeviceName;
        private System.Windows.Forms.Label lblThirdDeviceName;
        private System.Windows.Forms.TextBox txtbxSecondDeviceName;
        private System.Windows.Forms.Label lblSecondDeviceName;
        private System.Windows.Forms.TextBox txtbxFirstDeviceName;
        private System.Windows.Forms.Label lblFirstDeviceName;
        private System.Windows.Forms.Label lblInfoNamesPage1;
        private System.Windows.Forms.Button btnNextToTabPage3;
        private System.Windows.Forms.Button btnBackToTabPage1;
        private System.Windows.Forms.Button btnBackToTab2;
    }
}