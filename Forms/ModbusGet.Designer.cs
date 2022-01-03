namespace EntesProject.Forms
{
    partial class ModbusGet
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
            this.dgwModbusGet = new System.Windows.Forms.DataGridView();
            this.cbxModbusGet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwModbusGet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwModbusGet
            // 
            this.dgwModbusGet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwModbusGet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwModbusGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwModbusGet.Location = new System.Drawing.Point(12, 12);
            this.dgwModbusGet.Name = "dgwModbusGet";
            this.dgwModbusGet.Size = new System.Drawing.Size(776, 243);
            this.dgwModbusGet.TabIndex = 0;
            // 
            // cbxModbusGet
            // 
            this.cbxModbusGet.FormattingEnabled = true;
            this.cbxModbusGet.Items.AddRange(new object[] {
            "Device Datas ",
            "Modem Datas",
            "Datas"});
            this.cbxModbusGet.Location = new System.Drawing.Point(12, 296);
            this.cbxModbusGet.Name = "cbxModbusGet";
            this.cbxModbusGet.Size = new System.Drawing.Size(121, 21);
            this.cbxModbusGet.TabIndex = 1;
            this.cbxModbusGet.SelectedIndexChanged += new System.EventHandler(this.cbxModbusGet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Count :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(85, 334);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(33, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "None";
            // 
            // ModbusGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxModbusGet);
            this.Controls.Add(this.dgwModbusGet);
            this.Name = "ModbusGet";
            this.Text = "ModbusGet";
            ((System.ComponentModel.ISupportInitialize)(this.dgwModbusGet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwModbusGet;
        private System.Windows.Forms.ComboBox cbxModbusGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
    }
}