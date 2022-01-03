namespace EntesProject
{
    partial class DataView
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
            this.dgwModemDatas = new System.Windows.Forms.DataGridView();
            this.dgwDatas = new System.Windows.Forms.DataGridView();
            this.dgwDeviceDatas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelSelected = new System.Windows.Forms.Label();
            this.cbxAddDatas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModbusGet = new System.Windows.Forms.Button();
            this.btnAccessGet = new System.Windows.Forms.Button();
            this.btnAccessAdd = new System.Windows.Forms.Button();
            this.btnAccessUpdate = new System.Windows.Forms.Button();
            this.btnAccessDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeviceController = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwModemDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeviceDatas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwModemDatas
            // 
            this.dgwModemDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwModemDatas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwModemDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwModemDatas.Location = new System.Drawing.Point(15, 172);
            this.dgwModemDatas.Name = "dgwModemDatas";
            this.dgwModemDatas.Size = new System.Drawing.Size(380, 119);
            this.dgwModemDatas.TabIndex = 0;
            // 
            // dgwDatas
            // 
            this.dgwDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDatas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDatas.Location = new System.Drawing.Point(15, 319);
            this.dgwDatas.Name = "dgwDatas";
            this.dgwDatas.Size = new System.Drawing.Size(380, 119);
            this.dgwDatas.TabIndex = 1;
            // 
            // dgwDeviceDatas
            // 
            this.dgwDeviceDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDeviceDatas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwDeviceDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeviceDatas.Location = new System.Drawing.Point(12, 24);
            this.dgwDeviceDatas.Name = "dgwDeviceDatas";
            this.dgwDeviceDatas.Size = new System.Drawing.Size(380, 119);
            this.dgwDeviceDatas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modem Datas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Device Datas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValue);
            this.groupBox1.Controls.Add(this.labelSelected);
            this.groupBox1.Controls.Add(this.cbxAddDatas);
            this.groupBox1.Location = new System.Drawing.Point(512, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 178);
            this.groupBox1.TabIndex = 1;
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
            // cbxAddDatas
            // 
            this.cbxAddDatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddDatas.FormattingEnabled = true;
            this.cbxAddDatas.Items.AddRange(new object[] {
            "Device",
            "Modem",
            "Datas"});
            this.cbxAddDatas.Location = new System.Drawing.Point(30, 19);
            this.cbxAddDatas.Name = "cbxAddDatas";
            this.cbxAddDatas.Size = new System.Drawing.Size(121, 21);
            this.cbxAddDatas.TabIndex = 17;
            this.cbxAddDatas.SelectedIndexChanged += new System.EventHandler(this.cbxAddDatas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeviceController);
            this.groupBox2.Controls.Add(this.btnModbusGet);
            this.groupBox2.Controls.Add(this.btnAccessGet);
            this.groupBox2.Controls.Add(this.btnAccessAdd);
            this.groupBox2.Controls.Add(this.btnAccessUpdate);
            this.groupBox2.Controls.Add(this.btnAccessDelete);
            this.groupBox2.Location = new System.Drawing.Point(414, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 178);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access";
            // 
            // btnModbusGet
            // 
            this.btnModbusGet.Location = new System.Drawing.Point(6, 111);
            this.btnModbusGet.Name = "btnModbusGet";
            this.btnModbusGet.Size = new System.Drawing.Size(86, 34);
            this.btnModbusGet.TabIndex = 17;
            this.btnModbusGet.Text = "Modbus Connection";
            this.btnModbusGet.UseVisualStyleBackColor = true;
            this.btnModbusGet.Click += new System.EventHandler(this.btnModbusGet_Click);
            // 
            // btnAccessGet
            // 
            this.btnAccessGet.Location = new System.Drawing.Point(282, 47);
            this.btnAccessGet.Name = "btnAccessGet";
            this.btnAccessGet.Size = new System.Drawing.Size(84, 35);
            this.btnAccessGet.TabIndex = 16;
            this.btnAccessGet.Text = "Get";
            this.btnAccessGet.UseVisualStyleBackColor = true;
            this.btnAccessGet.Click += new System.EventHandler(this.btnAccessGet_Click);
            // 
            // btnAccessAdd
            // 
            this.btnAccessAdd.Location = new System.Drawing.Point(6, 47);
            this.btnAccessAdd.Name = "btnAccessAdd";
            this.btnAccessAdd.Size = new System.Drawing.Size(86, 35);
            this.btnAccessAdd.TabIndex = 6;
            this.btnAccessAdd.Text = "Add";
            this.btnAccessAdd.UseVisualStyleBackColor = true;
            this.btnAccessAdd.Click += new System.EventHandler(this.btnAccessAdd_Click);
            // 
            // btnAccessUpdate
            // 
            this.btnAccessUpdate.Location = new System.Drawing.Point(190, 47);
            this.btnAccessUpdate.Name = "btnAccessUpdate";
            this.btnAccessUpdate.Size = new System.Drawing.Size(86, 35);
            this.btnAccessUpdate.TabIndex = 15;
            this.btnAccessUpdate.Text = "Update";
            this.btnAccessUpdate.UseVisualStyleBackColor = true;
            this.btnAccessUpdate.Click += new System.EventHandler(this.btnAccessUpdate_Click);
            // 
            // btnAccessDelete
            // 
            this.btnAccessDelete.Location = new System.Drawing.Point(98, 47);
            this.btnAccessDelete.Name = "btnAccessDelete";
            this.btnAccessDelete.Size = new System.Drawing.Size(86, 35);
            this.btnAccessDelete.TabIndex = 14;
            this.btnAccessDelete.Text = "Delete";
            this.btnAccessDelete.UseVisualStyleBackColor = true;
            this.btnAccessDelete.Click += new System.EventHandler(this.btnAccessDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(702, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeviceController
            // 
            this.btnDeviceController.Location = new System.Drawing.Point(98, 111);
            this.btnDeviceController.Name = "btnDeviceController";
            this.btnDeviceController.Size = new System.Drawing.Size(86, 34);
            this.btnDeviceController.TabIndex = 18;
            this.btnDeviceController.Text = "Device Controller";
            this.btnDeviceController.UseVisualStyleBackColor = true;
            this.btnDeviceController.Click += new System.EventHandler(this.btnDeviceController_Click);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwDeviceDatas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDatas);
            this.Controls.Add(this.dgwModemDatas);
            this.Name = "DataView";
            this.Text = "General Datas";
            ((System.ComponentModel.ISupportInitialize)(this.dgwModemDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeviceDatas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwModemDatas;
        private System.Windows.Forms.DataGridView dgwDatas;
        private System.Windows.Forms.DataGridView dgwDeviceDatas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxAddDatas;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelSelected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAccessAdd;
        private System.Windows.Forms.Button btnAccessUpdate;
        private System.Windows.Forms.Button btnAccessDelete;
        private System.Windows.Forms.Button btnAccessGet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModbusGet;
        private System.Windows.Forms.Button btnDeviceController;
    }
}