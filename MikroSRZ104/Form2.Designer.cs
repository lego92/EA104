namespace MikroSRZ104
{
    partial class Form2
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
            this.lblValueCurrent = new System.Windows.Forms.Label();
            this.lblTextCurrent = new System.Windows.Forms.Label();
            this.lblTextCalcImposible = new System.Windows.Forms.Label();
            this.lblTextDischarge = new System.Windows.Forms.Label();
            this.lblTextNoVoltageSignal = new System.Windows.Forms.Label();
            this.lblTextNoise = new System.Windows.Forms.Label();
            this.lbltextCommError = new System.Windows.Forms.Label();
            this.btnCloseSensorForm = new System.Windows.Forms.Button();
            this.btnGoToPreviousSensor = new System.Windows.Forms.Button();
            this.lblTextSensorNumber = new System.Windows.Forms.Label();
            this.btnGoToNextSensor = new System.Windows.Forms.Button();
            this.ledCalcImposible = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.ledDischarge = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.ledNoVoltageSignal = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.ledNoise = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.ledCommError = new MfgControl.AdvancedHMI.Controls.SimpleLED();
            this.lblValueResistance = new System.Windows.Forms.Label();
            this.lblTextResistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValueCurrent
            // 
            this.lblValueCurrent.AutoSize = true;
            this.lblValueCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblValueCurrent.Location = new System.Drawing.Point(305, 193);
            this.lblValueCurrent.Name = "lblValueCurrent";
            this.lblValueCurrent.Size = new System.Drawing.Size(228, 29);
            this.lblValueCurrent.TabIndex = 0;
            this.lblValueCurrent.Text = "Нет информации";
            // 
            // lblTextCurrent
            // 
            this.lblTextCurrent.AutoSize = true;
            this.lblTextCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextCurrent.Location = new System.Drawing.Point(153, 193);
            this.lblTextCurrent.Name = "lblTextCurrent";
            this.lblTextCurrent.Size = new System.Drawing.Size(64, 29);
            this.lblTextCurrent.TabIndex = 1;
            this.lblTextCurrent.Text = "I, А :";
            // 
            // lblTextCalcImposible
            // 
            this.lblTextCalcImposible.AutoSize = true;
            this.lblTextCalcImposible.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTextCalcImposible.Location = new System.Drawing.Point(205, 324);
            this.lblTextCalcImposible.Name = "lblTextCalcImposible";
            this.lblTextCalcImposible.Size = new System.Drawing.Size(295, 58);
            this.lblTextCalcImposible.TabIndex = 31;
            this.lblTextCalcImposible.Text = "Измерение изоляции \r\nневозможно";
            // 
            // lblTextDischarge
            // 
            this.lblTextDischarge.AutoSize = true;
            this.lblTextDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTextDischarge.Location = new System.Drawing.Point(205, 432);
            this.lblTextDischarge.Name = "lblTextDischarge";
            this.lblTextDischarge.Size = new System.Drawing.Size(227, 58);
            this.lblTextDischarge.TabIndex = 36;
            this.lblTextDischarge.Text = "Разряд батареи /\r\nобратный ток";
            // 
            // lblTextNoVoltageSignal
            // 
            this.lblTextNoVoltageSignal.AutoSize = true;
            this.lblTextNoVoltageSignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTextNoVoltageSignal.Location = new System.Drawing.Point(205, 546);
            this.lblTextNoVoltageSignal.Name = "lblTextNoVoltageSignal";
            this.lblTextNoVoltageSignal.Size = new System.Drawing.Size(328, 58);
            this.lblTextNoVoltageSignal.TabIndex = 37;
            this.lblTextNoVoltageSignal.Text = "Отсутствует напряжение\r\nна присоединении ";
            // 
            // lblTextNoise
            // 
            this.lblTextNoise.AutoSize = true;
            this.lblTextNoise.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTextNoise.Location = new System.Drawing.Point(718, 324);
            this.lblTextNoise.Name = "lblTextNoise";
            this.lblTextNoise.Size = new System.Drawing.Size(229, 58);
            this.lblTextNoise.TabIndex = 38;
            this.lblTextNoise.Text = "Высокий уровень\r\nпомех";
            // 
            // lbltextCommError
            // 
            this.lbltextCommError.AutoSize = true;
            this.lbltextCommError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbltextCommError.Location = new System.Drawing.Point(718, 432);
            this.lbltextCommError.Name = "lbltextCommError";
            this.lbltextCommError.Size = new System.Drawing.Size(198, 58);
            this.lbltextCommError.TabIndex = 39;
            this.lbltextCommError.Text = "Ошибка связи \r\nс датчиком";
            // 
            // btnCloseSensorForm
            // 
            this.btnCloseSensorForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseSensorForm.Location = new System.Drawing.Point(998, 642);
            this.btnCloseSensorForm.Name = "btnCloseSensorForm";
            this.btnCloseSensorForm.Size = new System.Drawing.Size(106, 62);
            this.btnCloseSensorForm.TabIndex = 40;
            this.btnCloseSensorForm.Text = "Закрыть окно";
            this.btnCloseSensorForm.UseVisualStyleBackColor = true;
            this.btnCloseSensorForm.Click += new System.EventHandler(this.btnCloseSensorForm_Click);
            // 
            // btnGoToPreviousSensor
            // 
            this.btnGoToPreviousSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToPreviousSensor.Location = new System.Drawing.Point(638, 50);
            this.btnGoToPreviousSensor.Name = "btnGoToPreviousSensor";
            this.btnGoToPreviousSensor.Size = new System.Drawing.Size(151, 66);
            this.btnGoToPreviousSensor.TabIndex = 41;
            this.btnGoToPreviousSensor.Text = "Предыдущий";
            this.btnGoToPreviousSensor.UseVisualStyleBackColor = true;
            this.btnGoToPreviousSensor.Click += new System.EventHandler(this.btnGoToPreviousSensor_Click);
            // 
            // lblTextSensorNumber
            // 
            this.lblTextSensorNumber.AutoSize = true;
            this.lblTextSensorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextSensorNumber.Location = new System.Drawing.Point(353, 59);
            this.lblTextSensorNumber.Name = "lblTextSensorNumber";
            this.lblTextSensorNumber.Size = new System.Drawing.Size(246, 39);
            this.lblTextSensorNumber.TabIndex = 43;
            this.lblTextSensorNumber.Text = "Датчик № ###";
            // 
            // btnGoToNextSensor
            // 
            this.btnGoToNextSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToNextSensor.Location = new System.Drawing.Point(808, 50);
            this.btnGoToNextSensor.Name = "btnGoToNextSensor";
            this.btnGoToNextSensor.Size = new System.Drawing.Size(139, 66);
            this.btnGoToNextSensor.TabIndex = 44;
            this.btnGoToNextSensor.Text = "Следующий";
            this.btnGoToNextSensor.UseVisualStyleBackColor = true;
            this.btnGoToNextSensor.Click += new System.EventHandler(this.btnGoToNextSensor_Click);
            // 
            // ledCalcImposible
            // 
            this.ledCalcImposible.BackColor = System.Drawing.Color.Transparent;
            this.ledCalcImposible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledCalcImposible.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.ledCalcImposible.Location = new System.Drawing.Point(101, 313);
            this.ledCalcImposible.MaximumSize = new System.Drawing.Size(360, 360);
            this.ledCalcImposible.MinimumSize = new System.Drawing.Size(30, 30);
            this.ledCalcImposible.Name = "ledCalcImposible";
            this.ledCalcImposible.Size = new System.Drawing.Size(69, 69);
            this.ledCalcImposible.TabIndex = 156;
            // 
            // ledDischarge
            // 
            this.ledDischarge.BackColor = System.Drawing.Color.Transparent;
            this.ledDischarge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledDischarge.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.ledDischarge.Location = new System.Drawing.Point(101, 421);
            this.ledDischarge.MaximumSize = new System.Drawing.Size(360, 360);
            this.ledDischarge.MinimumSize = new System.Drawing.Size(30, 30);
            this.ledDischarge.Name = "ledDischarge";
            this.ledDischarge.Size = new System.Drawing.Size(69, 69);
            this.ledDischarge.TabIndex = 157;
            // 
            // ledNoVoltageSignal
            // 
            this.ledNoVoltageSignal.BackColor = System.Drawing.Color.Transparent;
            this.ledNoVoltageSignal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledNoVoltageSignal.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.ledNoVoltageSignal.Location = new System.Drawing.Point(101, 535);
            this.ledNoVoltageSignal.MaximumSize = new System.Drawing.Size(360, 360);
            this.ledNoVoltageSignal.MinimumSize = new System.Drawing.Size(30, 30);
            this.ledNoVoltageSignal.Name = "ledNoVoltageSignal";
            this.ledNoVoltageSignal.Size = new System.Drawing.Size(69, 69);
            this.ledNoVoltageSignal.TabIndex = 158;
            // 
            // ledNoise
            // 
            this.ledNoise.BackColor = System.Drawing.Color.Transparent;
            this.ledNoise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledNoise.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.ledNoise.Location = new System.Drawing.Point(604, 313);
            this.ledNoise.MaximumSize = new System.Drawing.Size(360, 360);
            this.ledNoise.MinimumSize = new System.Drawing.Size(30, 30);
            this.ledNoise.Name = "ledNoise";
            this.ledNoise.Size = new System.Drawing.Size(69, 69);
            this.ledNoise.TabIndex = 159;
            // 
            // ledCommError
            // 
            this.ledCommError.BackColor = System.Drawing.Color.Transparent;
            this.ledCommError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledCommError.LED_Brightness = MfgControl.AdvancedHMI.Controls.SimpleLED.LED_Bri.Brighter;
            this.ledCommError.Location = new System.Drawing.Point(604, 421);
            this.ledCommError.MaximumSize = new System.Drawing.Size(360, 360);
            this.ledCommError.MinimumSize = new System.Drawing.Size(30, 30);
            this.ledCommError.Name = "ledCommError";
            this.ledCommError.Size = new System.Drawing.Size(69, 69);
            this.ledCommError.TabIndex = 160;
            // 
            // lblValueResistance
            // 
            this.lblValueResistance.AutoSize = true;
            this.lblValueResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblValueResistance.Location = new System.Drawing.Point(770, 193);
            this.lblValueResistance.Name = "lblValueResistance";
            this.lblValueResistance.Size = new System.Drawing.Size(228, 29);
            this.lblValueResistance.TabIndex = 162;
            this.lblValueResistance.Text = "Нет информации";
            // 
            // lblTextResistance
            // 
            this.lblTextResistance.AutoSize = true;
            this.lblTextResistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTextResistance.Location = new System.Drawing.Point(618, 193);
            this.lblTextResistance.Name = "lblTextResistance";
            this.lblTextResistance.Size = new System.Drawing.Size(111, 29);
            this.lblTextResistance.TabIndex = 161;
            this.lblTextResistance.Text = "R, кОм :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 716);
            this.ControlBox = false;
            this.Controls.Add(this.lblValueResistance);
            this.Controls.Add(this.lblTextResistance);
            this.Controls.Add(this.ledCommError);
            this.Controls.Add(this.ledNoise);
            this.Controls.Add(this.ledNoVoltageSignal);
            this.Controls.Add(this.ledDischarge);
            this.Controls.Add(this.ledCalcImposible);
            this.Controls.Add(this.btnGoToNextSensor);
            this.Controls.Add(this.lblTextSensorNumber);
            this.Controls.Add(this.btnGoToPreviousSensor);
            this.Controls.Add(this.btnCloseSensorForm);
            this.Controls.Add(this.lbltextCommError);
            this.Controls.Add(this.lblTextNoise);
            this.Controls.Add(this.lblTextNoVoltageSignal);
            this.Controls.Add(this.lblTextDischarge);
            this.Controls.Add(this.lblTextCalcImposible);
            this.Controls.Add(this.lblTextCurrent);
            this.Controls.Add(this.lblValueCurrent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sensor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueCurrent;
        private System.Windows.Forms.Label lblTextCurrent;
        private System.Windows.Forms.Label lblTextCalcImposible;
        private System.Windows.Forms.Label lblTextDischarge;
        private System.Windows.Forms.Label lblTextNoVoltageSignal;
        private System.Windows.Forms.Label lblTextNoise;
        private System.Windows.Forms.Label lbltextCommError;
        private System.Windows.Forms.Button btnCloseSensorForm;
        private System.Windows.Forms.Button btnGoToPreviousSensor;
        private System.Windows.Forms.Label lblTextSensorNumber;
        private System.Windows.Forms.Button btnGoToNextSensor;
        private MfgControl.AdvancedHMI.Controls.SimpleLED ledCalcImposible;
        private MfgControl.AdvancedHMI.Controls.SimpleLED ledDischarge;
        private MfgControl.AdvancedHMI.Controls.SimpleLED ledNoVoltageSignal;
        private MfgControl.AdvancedHMI.Controls.SimpleLED ledNoise;
        private MfgControl.AdvancedHMI.Controls.SimpleLED ledCommError;
        private System.Windows.Forms.Label lblValueResistance;
        private System.Windows.Forms.Label lblTextResistance;
    }
}