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
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.lblPositiveResistance = new System.Windows.Forms.Label();
            this.lblNegativeResistance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCapacitance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LEDIsCommunicationError = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LEDGroundAlarm = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.btnToSensorsInfoList = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LEDDevErr = new MfgControl.AdvancedHMI.Controls.SimpleLED();
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
            // lblVoltage
            // 
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVoltage.Location = new System.Drawing.Point(176, 184);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(196, 20);
            this.lblVoltage.TabIndex = 1;
            this.lblVoltage.Text = "Напряжение на шинах";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResistance
            // 
            this.lblResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResistance.Location = new System.Drawing.Point(186, 354);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(186, 20);
            this.lblResistance.TabIndex = 2;
            this.lblResistance.Text = "Сопротивление сети";
            this.lblResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResistance.Click += new System.EventHandler(this.lblResistance_Click);
            // 
            // lblPositiveResistance
            // 
            this.lblPositiveResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPositiveResistance.Location = new System.Drawing.Point(220, 237);
            this.lblPositiveResistance.Name = "lblPositiveResistance";
            this.lblPositiveResistance.Size = new System.Drawing.Size(152, 20);
            this.lblPositiveResistance.TabIndex = 3;
            this.lblPositiveResistance.Text = "Сопротивление+";
            this.lblPositiveResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNegativeResistance
            // 
            this.lblNegativeResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNegativeResistance.Location = new System.Drawing.Point(224, 293);
            this.lblNegativeResistance.Name = "lblNegativeResistance";
            this.lblNegativeResistance.Size = new System.Drawing.Size(148, 20);
            this.lblNegativeResistance.TabIndex = 4;
            this.lblNegativeResistance.Text = "Сопротивление-";
            this.lblNegativeResistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "U, В :";
            // 
            // lblCapacitance
            // 
            this.lblCapacitance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapacitance.Location = new System.Drawing.Point(291, 413);
            this.lblCapacitance.Name = "lblCapacitance";
            this.lblCapacitance.Size = new System.Drawing.Size(81, 20);
            this.lblCapacitance.TabIndex = 6;
            this.lblCapacitance.Text = "Емкость";
            this.lblCapacitance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(66, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "R + , кОм :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(66, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "R - , кОм :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(66, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "R сети , кОм :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(66, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "C сети , мкФ  :";
            // 
            // LEDIsCommunicationError
            // 
            this.LEDIsCommunicationError.BackColor = System.Drawing.Color.Transparent;
            this.LEDIsCommunicationError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDIsCommunicationError.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDIsCommunicationError.Location = new System.Drawing.Point(325, 523);
            this.LEDIsCommunicationError.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDIsCommunicationError.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDIsCommunicationError.Name = "LEDIsCommunicationError";
            this.LEDIsCommunicationError.Size = new System.Drawing.Size(47, 47);
            this.LEDIsCommunicationError.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(66, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус подключения:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(285, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Неактивно";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(66, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Земля в сети";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(66, 539);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Ошибка связи с датчиком";
            // 
            // LEDGroundAlarm
            // 
            this.LEDGroundAlarm.BackColor = System.Drawing.Color.Transparent;
            this.LEDGroundAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDGroundAlarm.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDGroundAlarm.Location = new System.Drawing.Point(325, 460);
            this.LEDGroundAlarm.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDGroundAlarm.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDGroundAlarm.Name = "LEDGroundAlarm";
            this.LEDGroundAlarm.Size = new System.Drawing.Size(47, 47);
            this.LEDGroundAlarm.TabIndex = 16;
            // 
            // btnToSensorsInfoList
            // 
            this.btnToSensorsInfoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToSensorsInfoList.Location = new System.Drawing.Point(104, 610);
            this.btnToSensorsInfoList.Name = "btnToSensorsInfoList";
            this.btnToSensorsInfoList.Size = new System.Drawing.Size(171, 42);
            this.btnToSensorsInfoList.TabIndex = 17;
            this.btnToSensorsInfoList.Text = "К списку датчиков";
            this.btnToSensorsInfoList.UseVisualStyleBackColor = true;
            this.btnToSensorsInfoList.Click += new System.EventHandler(this.button123_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LEDDevErr
            // 
            this.LEDDevErr.BackColor = System.Drawing.Color.Transparent;
            this.LEDDevErr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LEDDevErr.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.LEDDevErr.Location = new System.Drawing.Point(339, 610);
            this.LEDDevErr.MaximumSize = new System.Drawing.Size(360, 360);
            this.LEDDevErr.MinimumSize = new System.Drawing.Size(30, 30);
            this.LEDDevErr.Name = "LEDDevErr";
            this.LEDDevErr.Size = new System.Drawing.Size(47, 47);
            this.LEDDevErr.TabIndex = 18;
            // 
            // MiniPageMikroSRZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.LEDDevErr);
            this.Controls.Add(this.btnToSensorsInfoList);
            this.Controls.Add(this.LEDGroundAlarm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LEDIsCommunicationError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCapacitance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNegativeResistance);
            this.Controls.Add(this.lblPositiveResistance);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.lblVoltage);
            this.Controls.Add(this.lblName);
            this.Name = "MiniPageMikroSRZ";
            this.Size = new System.Drawing.Size(465, 684);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.Label lblPositiveResistance;
        private System.Windows.Forms.Label lblNegativeResistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCapacitance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDIsCommunicationError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDGroundAlarm;
        private System.Windows.Forms.Button btnToSensorsInfoList;
        private System.Windows.Forms.Timer timer1;
        private MfgControl.AdvancedHMI.Controls.SimpleLED LEDDevErr;
    }
}
