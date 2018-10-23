namespace MikroSRZ104.Controls
{
    partial class SensorsTablePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoToMainForm = new System.Windows.Forms.Button();
            this.sensorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorResistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insulationDrop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorVoltagePresence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorComErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorCalcErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorHighNoiseLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNumber,
            this.sensorName,
            this.sensorResistance,
            this.insulationDrop,
            this.sensorVoltagePresence,
            this.sensorComErr,
            this.sensorCalcErr,
            this.sensorHighNoiseLevel});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(105, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1595, 550);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGoToMainForm
            // 
            this.btnGoToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToMainForm.Location = new System.Drawing.Point(821, 609);
            this.btnGoToMainForm.Name = "btnGoToMainForm";
            this.btnGoToMainForm.Size = new System.Drawing.Size(176, 55);
            this.btnGoToMainForm.TabIndex = 3;
            this.btnGoToMainForm.Text = "На главный экран";
            this.btnGoToMainForm.UseVisualStyleBackColor = true;
            this.btnGoToMainForm.Click += new System.EventHandler(this.btnGoToMainForm_Click);
            // 
            // sensorNumber
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.sensorNumber.HeaderText = "Номер";
            this.sensorNumber.Name = "sensorNumber";
            this.sensorNumber.ReadOnly = true;
            this.sensorNumber.Width = 130;
            // 
            // sensorName
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorName.DefaultCellStyle = dataGridViewCellStyle4;
            this.sensorName.HeaderText = "Имя";
            this.sensorName.Name = "sensorName";
            this.sensorName.ReadOnly = true;
            this.sensorName.Width = 205;
            // 
            // sensorResistance
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorResistance.DefaultCellStyle = dataGridViewCellStyle5;
            this.sensorResistance.HeaderText = "Сопротивление, кОм";
            this.sensorResistance.Name = "sensorResistance";
            this.sensorResistance.ReadOnly = true;
            this.sensorResistance.Width = 250;
            // 
            // insulationDrop
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insulationDrop.DefaultCellStyle = dataGridViewCellStyle6;
            this.insulationDrop.HeaderText = "Состояние изоляции";
            this.insulationDrop.Name = "insulationDrop";
            this.insulationDrop.ReadOnly = true;
            this.insulationDrop.Width = 220;
            // 
            // sensorVoltagePresence
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorVoltagePresence.DefaultCellStyle = dataGridViewCellStyle7;
            this.sensorVoltagePresence.HeaderText = "Наличие напряжения";
            this.sensorVoltagePresence.Name = "sensorVoltagePresence";
            this.sensorVoltagePresence.ReadOnly = true;
            this.sensorVoltagePresence.Width = 230;
            // 
            // sensorComErr
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorComErr.DefaultCellStyle = dataGridViewCellStyle8;
            this.sensorComErr.HeaderText = "Статус связи";
            this.sensorComErr.Name = "sensorComErr";
            this.sensorComErr.ReadOnly = true;
            this.sensorComErr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sensorComErr.Width = 170;
            // 
            // sensorCalcErr
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorCalcErr.DefaultCellStyle = dataGridViewCellStyle9;
            this.sensorCalcErr.HeaderText = "Статус измерения";
            this.sensorCalcErr.Name = "sensorCalcErr";
            this.sensorCalcErr.ReadOnly = true;
            this.sensorCalcErr.Width = 205;
            // 
            // sensorHighNoiseLevel
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorHighNoiseLevel.DefaultCellStyle = dataGridViewCellStyle10;
            this.sensorHighNoiseLevel.HeaderText = "Уровень помех";
            this.sensorHighNoiseLevel.Name = "sensorHighNoiseLevel";
            this.sensorHighNoiseLevel.ReadOnly = true;
            this.sensorHighNoiseLevel.Width = 180;
            // 
            // SensorsTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoToMainForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SensorsTablePage";
            this.Size = new System.Drawing.Size(1860, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoToMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorResistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn insulationDrop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorVoltagePresence;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorComErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorCalcErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorHighNoiseLevel;
    }
}
