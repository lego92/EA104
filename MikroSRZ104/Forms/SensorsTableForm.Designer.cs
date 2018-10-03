namespace MikroSRZ104
{
    partial class SensorsTableForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(865, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "На главный экран";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(79, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1648, 550);
            this.dataGridView1.TabIndex = 1;
            // 
            // sensorNumber
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.sensorNumber.HeaderText = "Номер";
            this.sensorNumber.Name = "sensorNumber";
            this.sensorNumber.ReadOnly = true;
            // 
            // sensorName
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorName.DefaultCellStyle = dataGridViewCellStyle4;
            this.sensorName.HeaderText = "Имя";
            this.sensorName.Name = "sensorName";
            this.sensorName.ReadOnly = true;
            this.sensorName.Width = 220;
            // 
            // sensorResistance
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorResistance.DefaultCellStyle = dataGridViewCellStyle5;
            this.sensorResistance.HeaderText = "Сопротивление, кОм";
            this.sensorResistance.Name = "sensorResistance";
            this.sensorResistance.ReadOnly = true;
            this.sensorResistance.Width = 220;
            // 
            // insulationDrop
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insulationDrop.DefaultCellStyle = dataGridViewCellStyle6;
            this.insulationDrop.HeaderText = "Состояние изоляции";
            this.insulationDrop.Name = "insulationDrop";
            this.insulationDrop.ReadOnly = true;
            this.insulationDrop.Width = 225;
            // 
            // sensorVoltagePresence
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorVoltagePresence.DefaultCellStyle = dataGridViewCellStyle7;
            this.sensorVoltagePresence.HeaderText = "Наличие напряжения";
            this.sensorVoltagePresence.Name = "sensorVoltagePresence";
            this.sensorVoltagePresence.ReadOnly = true;
            this.sensorVoltagePresence.Width = 250;
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
            this.sensorCalcErr.Width = 200;
            // 
            // sensorHighNoiseLevel
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sensorHighNoiseLevel.DefaultCellStyle = dataGridViewCellStyle10;
            this.sensorHighNoiseLevel.HeaderText = "Уровень помех";
            this.sensorHighNoiseLevel.Name = "sensorHighNoiseLevel";
            this.sensorHighNoiseLevel.ReadOnly = true;
            this.sensorHighNoiseLevel.Width = 200;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 684);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(30, 190);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
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