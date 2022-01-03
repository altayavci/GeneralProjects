namespace EntesProject.Forms
{
    partial class DataGet
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
            this.dgwGet = new System.Windows.Forms.DataGridView();
            this.tbxGet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetMac = new System.Windows.Forms.Button();
            this.gbxModem = new System.Windows.Forms.GroupBox();
            this.cbxGet = new System.Windows.Forms.ComboBox();
            this.dgwShowDatas = new System.Windows.Forms.DataGridView();
            this.gbxDevice = new System.Windows.Forms.GroupBox();
            this.tbxDataSearching = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDataSearching = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblSearching = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGet)).BeginInit();
            this.gbxModem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowDatas)).BeginInit();
            this.gbxDevice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwGet
            // 
            this.dgwGet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGet.Location = new System.Drawing.Point(12, 19);
            this.dgwGet.Name = "dgwGet";
            this.dgwGet.Size = new System.Drawing.Size(334, 173);
            this.dgwGet.TabIndex = 0;
            // 
            // tbxGet
            // 
            this.tbxGet.Location = new System.Drawing.Point(99, 40);
            this.tbxGet.Name = "tbxGet";
            this.tbxGet.Size = new System.Drawing.Size(123, 20);
            this.tbxGet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mac of Modem ";
            // 
            // btnGetMac
            // 
            this.btnGetMac.Location = new System.Drawing.Point(82, 75);
            this.btnGetMac.Name = "btnGetMac";
            this.btnGetMac.Size = new System.Drawing.Size(140, 33);
            this.btnGetMac.TabIndex = 3;
            this.btnGetMac.Text = "Search";
            this.btnGetMac.UseVisualStyleBackColor = true;
            this.btnGetMac.Click += new System.EventHandler(this.btnGetMac_Click);
            // 
            // gbxModem
            // 
            this.gbxModem.Controls.Add(this.tbxGet);
            this.gbxModem.Controls.Add(this.label1);
            this.gbxModem.Controls.Add(this.btnGetMac);
            this.gbxModem.Location = new System.Drawing.Point(12, 198);
            this.gbxModem.Name = "gbxModem";
            this.gbxModem.Size = new System.Drawing.Size(271, 131);
            this.gbxModem.TabIndex = 5;
            this.gbxModem.TabStop = false;
            this.gbxModem.Text = "Device Searching with Modem Query";
            // 
            // cbxGet
            // 
            this.cbxGet.FormattingEnabled = true;
            this.cbxGet.Items.AddRange(new object[] {
            "Modem Datas",
            "Device Datas",
            "Datas"});
            this.cbxGet.Location = new System.Drawing.Point(114, 21);
            this.cbxGet.Name = "cbxGet";
            this.cbxGet.Size = new System.Drawing.Size(136, 21);
            this.cbxGet.TabIndex = 4;
            this.cbxGet.SelectedIndexChanged += new System.EventHandler(this.cbxGet_SelectedIndexChanged);
            // 
            // dgwShowDatas
            // 
            this.dgwShowDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwShowDatas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwShowDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowDatas.Location = new System.Drawing.Point(454, 19);
            this.dgwShowDatas.Name = "dgwShowDatas";
            this.dgwShowDatas.Size = new System.Drawing.Size(334, 173);
            this.dgwShowDatas.TabIndex = 6;
            this.dgwShowDatas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShowDatas_CellClick);
            // 
            // gbxDevice
            // 
            this.gbxDevice.Controls.Add(this.tbxDataSearching);
            this.gbxDevice.Controls.Add(this.label2);
            this.gbxDevice.Controls.Add(this.btnDataSearching);
            this.gbxDevice.Location = new System.Drawing.Point(12, 328);
            this.gbxDevice.Name = "gbxDevice";
            this.gbxDevice.Size = new System.Drawing.Size(271, 122);
            this.gbxDevice.TabIndex = 7;
            this.gbxDevice.TabStop = false;
            this.gbxDevice.Text = "Data Searching with Device Query";
            // 
            // tbxDataSearching
            // 
            this.tbxDataSearching.Location = new System.Drawing.Point(99, 33);
            this.tbxDataSearching.Name = "tbxDataSearching";
            this.tbxDataSearching.Size = new System.Drawing.Size(121, 20);
            this.tbxDataSearching.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id of Device";
            // 
            // btnDataSearching
            // 
            this.btnDataSearching.Location = new System.Drawing.Point(82, 75);
            this.btnDataSearching.Name = "btnDataSearching";
            this.btnDataSearching.Size = new System.Drawing.Size(140, 33);
            this.btnDataSearching.TabIndex = 3;
            this.btnDataSearching.Text = "Search";
            this.btnDataSearching.UseVisualStyleBackColor = true;
            this.btnDataSearching.Click += new System.EventHandler(this.btnDataSearching_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(114, 72);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(136, 20);
            this.tbxSearch.TabIndex = 8;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Choose Type of Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Get Data By Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Get Data by Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxGet);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(532, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 143);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Detection with Different Querys";
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(54, 3);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(33, 13);
            this.lblQuery.TabIndex = 14;
            this.lblQuery.Text = "None";
            // 
            // lblSearching
            // 
            this.lblSearching.AutoSize = true;
            this.lblSearching.Location = new System.Drawing.Point(711, 3);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(33, 13);
            this.lblSearching.TabIndex = 15;
            this.lblSearching.Text = "None";
            // 
            // DataGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearching);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDevice);
            this.Controls.Add(this.dgwShowDatas);
            this.Controls.Add(this.gbxModem);
            this.Controls.Add(this.dgwGet);
            this.Name = "DataGet";
            this.Text = "DataGet";
            this.Load += new System.EventHandler(this.DataGet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGet)).EndInit();
            this.gbxModem.ResumeLayout(false);
            this.gbxModem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowDatas)).EndInit();
            this.gbxDevice.ResumeLayout(false);
            this.gbxDevice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwGet;
        private System.Windows.Forms.TextBox tbxGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetMac;
        private System.Windows.Forms.GroupBox gbxModem;
        private System.Windows.Forms.ComboBox cbxGet;
        private System.Windows.Forms.DataGridView dgwShowDatas;
        private System.Windows.Forms.GroupBox gbxDevice;
        private System.Windows.Forms.TextBox tbxDataSearching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDataSearching;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblSearching;
    }
}