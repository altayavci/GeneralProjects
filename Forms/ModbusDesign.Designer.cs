namespace NModbusWorkshop
{
    partial class ModbusDesign
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.btnOpenAll = new System.Windows.Forms.Button();
            this.tbxOpenGreen = new System.Windows.Forms.TextBox();
            this.btnOpenGreen = new System.Windows.Forms.Button();
            this.tbxOpenRed = new System.Windows.Forms.TextBox();
            this.btnOpenRed = new System.Windows.Forms.Button();
            this.btnStatusCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxWriter = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(272, 203);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(149, 23);
            this.btnCloseAll.TabIndex = 21;
            this.btnCloseAll.Text = "Close All";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click_1);
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.Location = new System.Drawing.Point(84, 203);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(149, 23);
            this.btnOpenAll.TabIndex = 20;
            this.btnOpenAll.Text = "Open All ";
            this.btnOpenAll.UseVisualStyleBackColor = true;
            this.btnOpenAll.Click += new System.EventHandler(this.btnOpenAll_Click_1);
            // 
            // tbxOpenGreen
            // 
            this.tbxOpenGreen.Location = new System.Drawing.Point(84, 106);
            this.tbxOpenGreen.Name = "tbxOpenGreen";
            this.tbxOpenGreen.Size = new System.Drawing.Size(149, 20);
            this.tbxOpenGreen.TabIndex = 19;
            // 
            // btnOpenGreen
            // 
            this.btnOpenGreen.Location = new System.Drawing.Point(84, 155);
            this.btnOpenGreen.Name = "btnOpenGreen";
            this.btnOpenGreen.Size = new System.Drawing.Size(149, 23);
            this.btnOpenGreen.TabIndex = 18;
            this.btnOpenGreen.Text = "Open the Device (Green)";
            this.btnOpenGreen.UseVisualStyleBackColor = true;
            this.btnOpenGreen.Click += new System.EventHandler(this.btnOpenGreen_Click_1);
            // 
            // tbxOpenRed
            // 
            this.tbxOpenRed.Location = new System.Drawing.Point(272, 106);
            this.tbxOpenRed.Name = "tbxOpenRed";
            this.tbxOpenRed.Size = new System.Drawing.Size(149, 20);
            this.tbxOpenRed.TabIndex = 17;
            // 
            // btnOpenRed
            // 
            this.btnOpenRed.Location = new System.Drawing.Point(272, 155);
            this.btnOpenRed.Name = "btnOpenRed";
            this.btnOpenRed.Size = new System.Drawing.Size(149, 23);
            this.btnOpenRed.TabIndex = 16;
            this.btnOpenRed.Text = "Open the Device (Red)\r\n\r\n";
            this.btnOpenRed.UseVisualStyleBackColor = true;
            this.btnOpenRed.Click += new System.EventHandler(this.btnOpenRed_Click_1);
            // 
            // btnStatusCheck
            // 
            this.btnStatusCheck.Location = new System.Drawing.Point(62, 63);
            this.btnStatusCheck.Name = "btnStatusCheck";
            this.btnStatusCheck.Size = new System.Drawing.Size(101, 23);
            this.btnStatusCheck.TabIndex = 11;
            this.btnStatusCheck.Text = "Status Checker";
            this.btnStatusCheck.UseVisualStyleBackColor = true;
            this.btnStatusCheck.Click += new System.EventHandler(this.btnStatusCheck_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status of Device:";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(144, 31);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(33, 13);
            this.lblExp.TabIndex = 10;
            this.lblExp.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReconnect);
            this.groupBox1.Controls.Add(this.btnStatusCheck);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblExp);
            this.groupBox1.Location = new System.Drawing.Point(524, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 121);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device Status";
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(39, 92);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(149, 23);
            this.btnReconnect.TabIndex = 16;
            this.btnReconnect.Text = "Reconnect to the Device ";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter the Command Number:";
            // 
            // tbxWriter
            // 
            this.tbxWriter.Location = new System.Drawing.Point(230, 53);
            this.tbxWriter.Name = "tbxWriter";
            this.tbxWriter.Size = new System.Drawing.Size(53, 20);
            this.tbxWriter.TabIndex = 22;
            // 
            // ModbusDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnOpenAll);
            this.Controls.Add(this.tbxOpenGreen);
            this.Controls.Add(this.btnOpenGreen);
            this.Controls.Add(this.tbxOpenRed);
            this.Controls.Add(this.btnOpenRed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxWriter);
            this.Name = "ModbusDesign";
            this.Text = "ModbusDesign";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.Button btnOpenAll;
        private System.Windows.Forms.TextBox tbxOpenGreen;
        private System.Windows.Forms.Button btnOpenGreen;
        private System.Windows.Forms.TextBox tbxOpenRed;
        private System.Windows.Forms.Button btnOpenRed;
        private System.Windows.Forms.Button btnStatusCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxWriter;
    }
}