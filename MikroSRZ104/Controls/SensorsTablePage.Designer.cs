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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoToMainForm = new System.Windows.Forms.Button();
            this.sensorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorFacNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorSwitchDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorCircuitLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorResistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorComErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorCalcErr = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 80;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sensorNumber,
            this.sensorFacNumber,
            this.sensorSwitchDevice,
            this.sensorCircuitLoad,
            this.sensorResistance,
            this.sensorComErr,
            this.sensorCalcErr});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(105, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 80;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1646, 657);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnGoToMainForm
            // 
            this.btnGoToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoToMainForm.Location = new System.Drawing.Point(810, 741);
            this.btnGoToMainForm.Name = "btnGoToMainForm";
            this.btnGoToMainForm.Size = new System.Drawing.Size(209, 67);
            this.btnGoToMainForm.TabIndex = 3;
            this.btnGoToMainForm.Text = "На главный экран";
            this.btnGoToMainForm.UseVisualStyleBackColor = true;
            this.btnGoToMainForm.Click += new System.EventHandler(this.btnGoToMainForm_Click);
            // 
            // sensorNumber
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.sensorNumber.HeaderText = "Номер";
            this.sensorNumber.Name = "sensorNumber";
            this.sensorNumber.ReadOnly = true;
            this.sensorNumber.Width = 150;
            // 
            // sensorFacNumber
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorFacNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.sensorFacNumber.HeaderText = "Заводской номер";
            this.sensorFacNumber.Name = "sensorFacNumber";
            this.sensorFacNumber.ReadOnly = true;
            this.sensorFacNumber.Width = 250;
            // 
            // sensorSwitchDevice
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorSwitchDevice.DefaultCellStyle = dataGridViewCellStyle5;
            this.sensorSwitchDevice.HeaderText = "Коммутационный аппарат";
            this.sensorSwitchDevice.Name = "sensorSwitchDevice";
            this.sensorSwitchDevice.ReadOnly = true;
            this.sensorSwitchDevice.Width = 300;
            // 
            // sensorCircuitLoad
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorCircuitLoad.DefaultCellStyle = dataGridViewCellStyle6;
            this.sensorCircuitLoad.HeaderText = "Потребитель";
            this.sensorCircuitLoad.Name = "sensorCircuitLoad";
            this.sensorCircuitLoad.ReadOnly = true;
            this.sensorCircuitLoad.Width = 250;
            // 
            // sensorResistance
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorResistance.DefaultCellStyle = dataGridViewCellStyle7;
            this.sensorResistance.HeaderText = "Сопротивление, кОм";
            this.sensorResistance.Name = "sensorResistance";
            this.sensorResistance.ReadOnly = true;
            this.sensorResistance.Width = 270;
            // 
            // sensorComErr
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorComErr.DefaultCellStyle = dataGridViewCellStyle8;
            this.sensorComErr.HeaderText = "Статус связи";
            this.sensorComErr.Name = "sensorComErr";
            this.sensorComErr.ReadOnly = true;
            this.sensorComErr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sensorComErr.Width = 200;
            // 
            // sensorCalcErr
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorCalcErr.DefaultCellStyle = dataGridViewCellStyle9;
            this.sensorCalcErr.HeaderText = "Статус измерения";
            this.sensorCalcErr.Name = "sensorCalcErr";
            this.sensorCalcErr.ReadOnly = true;
            this.sensorCalcErr.Width = 205;
            // 
            // SensorsTablePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGoToMainForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SensorsTablePage";
            this.Size = new System.Drawing.Size(1876, 854);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoToMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorFacNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorSwitchDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorCircuitLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorResistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorComErr;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorCalcErr;
    }
}
