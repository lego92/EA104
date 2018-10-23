namespace MikroSRZ104
{
    partial class MiniPageMikroSRZ
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblValueVoltage = new System.Windows.Forms.Label();
            this.lblValueNetworkResistance = new System.Windows.Forms.Label();
            this.lblValuePositiveResistance = new System.Windows.Forms.Label();
            this.lblTextNegativeResistance = new System.Windows.Forms.Label();
            this.lblTextVoltage = new System.Windows.Forms.Label();
            this.lblValueCapacitance = new System.Windows.Forms.Label();
            this.lblTextPositiveResistance = new System.Windows.Forms.Label();
            this.lblValueNegativeResistance = new System.Windows.Forms.Label();
            this.lblTextNetworkResistance = new System.Windows.Forms.Label();
            this.lblTextCapacitance = new System.Windows.Forms.Label();
            this.LEDIsCommunicationError = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblTextGroundFault = new System.Windows.Forms.Label();
            this.lblTextSensorError = new System.Windows.Forms.Label();
            this.LEDGroundAlarm = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.btnToSensorsInfoList = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LEDDevErr = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.lblTextMalfunction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(158, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(133, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название ЩПТ";
            // 
            // lblValueVoltage
            // 
            this.lblValueVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueVoltage.Location = new System.Drawing.Point(177, 149);
            this.lblValueVoltage.Name = "lblValueVoltage";
            this.lblValueVoltage.Size = new System.Drawing.Size(196, 20);
            this.lblValueVoltage.TabIndex = 1;
            this.lblValueVoltage.Text = "Напряжение на шинах";
            this.lblValueVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueNetworkResistance
            // 
            this.lblValueNetworkResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueNetworkResistance.Location = new System.Drawing.Point(187, 310);
            this.lblValueNetworkResistance.Name = "lblValueNetworkResistance";
            this.lblValueNetworkResistance.Size = new System.Drawing.Size(186, 20);
            this.lblValueNetworkResistance.TabIndex = 2;
            this.lblValueNetworkResistance.Text = "Сопротивление сети";
            this.lblValueNetworkResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValuePositiveResistance
            // 
            this.lblValuePositiveResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValuePositiveResistance.Location = new System.Drawing.Point(221, 202);
            this.lblValuePositiveResistance.Name = "lblValuePositiveResistance";
            this.lblValuePositiveResistance.Size = new System.Drawing.Size(152, 20);
            this.lblValuePositiveResistance.TabIndex = 3;
            this.lblValuePositiveResistance.Text = "Сопротивление+";
            this.lblValuePositiveResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextNegativeResistance
            // 
            this.lblTextNegativeResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextNegativeResistance.Location = new System.Drawing.Point(225, 255);
            this.lblTextNegativeResistance.Name = "lblTextNegativeResistance";
            this.lblTextNegativeResistance.Size = new System.Drawing.Size(148, 20);
            this.lblTextNegativeResistance.TabIndex = 4;
            this.lblTextNegativeResistance.Text = "Сопротивление-";
            this.lblTextNegativeResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextVoltage
            // 
            this.lblTextVoltage.AutoSize = true;
            this.lblTextVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextVoltage.Location = new System.Drawing.Point(66, 149);
            this.lblTextVoltage.Name = "lblTextVoltage";
            this.lblTextVoltage.Size = new System.Drawing.Size(54, 20);
            this.lblTextVoltage.TabIndex = 5;
            this.lblTextVoltage.Text = "U, В :";
            // 
            // lblValueCapacitance
            // 
            this.lblValueCapacitance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueCapacitance.Location = new System.Drawing.Point(243, 363);
            this.lblValueCapacitance.Name = "lblValueCapacitance";
            this.lblValueCapacitance.Size = new System.Drawing.Size(129, 20);
            this.lblValueCapacitance.TabIndex = 6;
            this.lblValueCapacitance.Text = "Емкость";
            this.lblValueCapacitance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextPositiveResistance
            // 
            this.lblTextPositiveResistance.AutoSize = true;
            this.lblTextPositiveResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextPositiveResistance.Location = new System.Drawing.Point(66, 202);
            this.lblTextPositiveResistance.Name = "lblTextPositiveResistance";
            this.lblTextPositiveResistance.Size = new System.Drawing.Size(96, 20);
            this.lblTextPositiveResistance.TabIndex = 7;
            this.lblTextPositiveResistance.Text = "R + , кОм :";
            // 
            // lblValueNegativeResistance
            // 
            this.lblValueNegativeResistance.AutoSize = true;
            this.lblValueNegativeResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueNegativeResistance.Location = new System.Drawing.Point(66, 255);
            this.lblValueNegativeResistance.Name = "lblValueNegativeResistance";
            this.lblValueNegativeResistance.Size = new System.Drawing.Size(92, 20);
            this.lblValueNegativeResistance.TabIndex = 8;
            this.lblValueNegativeResistance.Text = "R - , кОм :";
            // 
            // lblTextNetworkResistance
            // 
            this.lblTextNetworkResistance.AutoSize = true;
            this.lblTextNetworkResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextNetworkResistance.Location = new System.Drawing.Point(66, 310);
            this.lblTextNetworkResistance.Name = "lblTextNetworkResistance";
            this.lblTextNetworkResistance.Size = new System.Drawing.Size(125, 20);
            this.lblTextNetworkResistance.TabIndex = 9;
            this.lblTextNetworkResistance.Text = "R сети , кОм :";
            // 
            // lblTextCapacitance
            // 
            this.lblTextCapacitance.AutoSize = true;
            this.lblTextCapacitance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextCapacitance.Location = new System.Drawing.Point(66, 363);
            this.lblTextCapacitance.Name = "lblTextCapacitance";
            this.lblTextCapacitance.Size = new System.Drawing.Size(132, 20);
            this.lblTextCapacitance.TabIndex = 10;
            this.lblTextCapacitance.Text = "C сети , мкФ  :";
            // 
            // LEDIsCommunicationError
            // 
            this.LEDIsCommunicationError.BackColor = System.Drawing.Color.Transparent;
            this.LEDIsCommunicationError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDIsCommunicationError.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDIsCommunicationError.LED_Color = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Col.White;
            this.LEDIsCommunicationError.Location = new System.Drawing.Point(338, 470);
            this.LEDIsCommunicationError.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDIsCommunicationError.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDIsCommunicationError.Name = "LEDIsCommunicationError";
            this.LEDIsCommunicationError.Size = new System.Drawing.Size(34, 34);
            this.LEDIsCommunicationError.TabIndex = 11;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusText.Location = new System.Drawing.Point(66, 90);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(193, 20);
            this.lblStatusText.TabIndex = 12;
            this.lblStatusText.Text = "Статус подключения:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusValue.ForeColor = System.Drawing.Color.Red;
            this.lblStatusValue.Location = new System.Drawing.Point(272, 90);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(101, 20);
            this.lblStatusValue.TabIndex = 13;
            this.lblStatusValue.Text = "Неактивно";
            this.lblStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTextGroundFault
            // 
            this.lblTextGroundFault.AutoSize = true;
            this.lblTextGroundFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextGroundFault.Location = new System.Drawing.Point(66, 426);
            this.lblTextGroundFault.Name = "lblTextGroundFault";
            this.lblTextGroundFault.Size = new System.Drawing.Size(123, 20);
            this.lblTextGroundFault.TabIndex = 14;
            this.lblTextGroundFault.Text = "Земля в сети";
            // 
            // lblTextSensorError
            // 
            this.lblTextSensorError.AutoSize = true;
            this.lblTextSensorError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextSensorError.Location = new System.Drawing.Point(66, 484);
            this.lblTextSensorError.Name = "lblTextSensorError";
            this.lblTextSensorError.Size = new System.Drawing.Size(230, 20);
            this.lblTextSensorError.TabIndex = 15;
            this.lblTextSensorError.Text = "Ошибка связи с датчиком";
            // 
            // LEDGroundAlarm
            // 
            this.LEDGroundAlarm.BackColor = System.Drawing.Color.Transparent;
            this.LEDGroundAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDGroundAlarm.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDGroundAlarm.LED_Color = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Col.White;
            this.LEDGroundAlarm.Location = new System.Drawing.Point(338, 412);
            this.LEDGroundAlarm.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDGroundAlarm.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDGroundAlarm.Name = "LEDGroundAlarm";
            this.LEDGroundAlarm.Size = new System.Drawing.Size(34, 34);
            this.LEDGroundAlarm.TabIndex = 16;
            // 
            // btnToSensorsInfoList
            // 
            this.btnToSensorsInfoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToSensorsInfoList.Location = new System.Drawing.Point(144, 616);
            this.btnToSensorsInfoList.Name = "btnToSensorsInfoList";
            this.btnToSensorsInfoList.Size = new System.Drawing.Size(171, 42);
            this.btnToSensorsInfoList.TabIndex = 17;
            this.btnToSensorsInfoList.Text = "К списку датчиков";
            this.btnToSensorsInfoList.UseVisualStyleBackColor = true;
            this.btnToSensorsInfoList.Click += new System.EventHandler(this.btnToSensorsInfoList_Click);
            // 
            // LEDDevErr
            // 
            this.LEDDevErr.BackColor = System.Drawing.Color.Transparent;
            this.LEDDevErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDDevErr.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDDevErr.LED_Color = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Col.White;
            this.LEDDevErr.Location = new System.Drawing.Point(339, 529);
            this.LEDDevErr.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDDevErr.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDDevErr.Name = "LEDDevErr";
            this.LEDDevErr.Size = new System.Drawing.Size(33, 33);
            this.LEDDevErr.TabIndex = 18;
            // 
            // lblTextMalfunction
            // 
            this.lblTextMalfunction.AutoSize = true;
            this.lblTextMalfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextMalfunction.Location = new System.Drawing.Point(66, 542);
            this.lblTextMalfunction.Name = "lblTextMalfunction";
            this.lblTextMalfunction.Size = new System.Drawing.Size(140, 20);
            this.lblTextMalfunction.TabIndex = 19;
            this.lblTextMalfunction.Text = "Неисправность";
            // 
            // MiniPageMikroSRZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTextMalfunction);
            this.Controls.Add(this.LEDDevErr);
            this.Controls.Add(this.btnToSensorsInfoList);
            this.Controls.Add(this.LEDGroundAlarm);
            this.Controls.Add(this.lblTextSensorError);
            this.Controls.Add(this.lblTextGroundFault);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.LEDIsCommunicationError);
            this.Controls.Add(this.lblTextCapacitance);
            this.Controls.Add(this.lblTextNetworkResistance);
            this.Controls.Add(this.lblValueNegativeResistance);
            this.Controls.Add(this.lblTextPositiveResistance);
            this.Controls.Add(this.lblValueCapacitance);
            this.Controls.Add(this.lblTextVoltage);
            this.Controls.Add(this.lblTextNegativeResistance);
            this.Controls.Add(this.lblValuePositiveResistance);
            this.Controls.Add(this.lblValueNetworkResistance);
            this.Controls.Add(this.lblValueVoltage);
            this.Controls.Add(this.lblName);
            this.Name = "MiniPageMikroSRZ";
            this.Size = new System.Drawing.Size(465, 684);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblValueVoltage;
        private System.Windows.Forms.Label lblValueNetworkResistance;
        private System.Windows.Forms.Label lblValuePositiveResistance;
        private System.Windows.Forms.Label lblTextNegativeResistance;
        private System.Windows.Forms.Label lblTextVoltage;
        private System.Windows.Forms.Label lblValueCapacitance;
        private System.Windows.Forms.Label lblTextPositiveResistance;
        private System.Windows.Forms.Label lblValueNegativeResistance;
        private System.Windows.Forms.Label lblTextNetworkResistance;
        private System.Windows.Forms.Label lblTextCapacitance;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDIsCommunicationError;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblTextGroundFault;
        private System.Windows.Forms.Label lblTextSensorError;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDGroundAlarm;
        private System.Windows.Forms.Button btnToSensorsInfoList;
        private System.Windows.Forms.Timer timer1;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDDevErr;
        private System.Windows.Forms.Label lblTextMalfunction;
    }
}
