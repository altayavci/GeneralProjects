namespace EntesProject.Forms
{
    partial class DataDelete
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.cbxDeleteData = new System.Windows.Forms.ComboBox();
            this.dgwDelete = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.labelSelected);
            this.groupBox1.Controls.Add(this.cbxDeleteData);
            this.groupBox1.Location = new System.Drawing.Point(493, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select from:";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(94, 90);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(33, 13);
            this.labelValue.TabIndex = 20;
            this.labelValue.Text = "None";
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Location = new System.Drawing.Point(27, 90);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(55, 13);
            this.labelSelected.TabIndex = 19;
            this.labelSelected.Text = "Selected :";
            // 
            // cbxDeleteData
            // 
            this.cbxDeleteData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeleteData.FormattingEnabled = true;
            this.cbxDeleteData.Items.AddRange(new object[] {
            "Device",
            "Modem",
            "Datas"});
            this.cbxDeleteData.Location = new System.Drawing.Point(30, 19);
            this.cbxDeleteData.Name = "cbxDeleteData";
            this.cbxDeleteData.Size = new System.Drawing.Size(121, 21);
            this.cbxDeleteData.TabIndex = 17;
            this.cbxDeleteData.SelectedIndexChanged += new System.EventHandler(this.cbxDeleteData_SelectedIndexChanged);
            // 
            // dgwDelete
            // 
            this.dgwDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDelete.Location = new System.Drawing.Point(32, 22);
            this.dgwDelete.Name = "dgwDelete";
            this.dgwDelete.Size = new System.Drawing.Size(416, 216);
            this.dgwDelete.TabIndex = 10;
            // 
            // DataDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Name = "DataDelete";
            this.Text = "DataDelete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.ComboBox cbxDeleteData;
        private System.Windows.Forms.DataGridView dgwDelete;
    }
}