namespace Protocol_01_Client
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VisionCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogTB = new System.Windows.Forms.TextBox();
            this.PxCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.EndBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.DataTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.IpPortInfoTB = new System.Windows.Forms.TextBox();
            this.ServerPortTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerIpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.VisionCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PxCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RequestBtn);
            this.groupBox1.Controls.Add(this.EndBtn);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Controls.Add(this.DataTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.OpenBtn);
            this.groupBox1.Controls.Add(this.IpPortInfoTB);
            this.groupBox1.Controls.Add(this.ServerPortTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ServerIpTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 447);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client [Machine]";
            // 
            // VisionCB
            // 
            this.VisionCB.FormattingEnabled = true;
            this.VisionCB.Items.AddRange(new object[] {
            "GLASS",
            "PCB"});
            this.VisionCB.Location = new System.Drawing.Point(189, 80);
            this.VisionCB.Name = "VisionCB";
            this.VisionCB.Size = new System.Drawing.Size(69, 23);
            this.VisionCB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "VISION : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogTB);
            this.groupBox2.Location = new System.Drawing.Point(6, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 259);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // LogTB
            // 
            this.LogTB.Location = new System.Drawing.Point(6, 16);
            this.LogTB.Multiline = true;
            this.LogTB.Name = "LogTB";
            this.LogTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTB.Size = new System.Drawing.Size(345, 237);
            this.LogTB.TabIndex = 12;
            // 
            // PxCB
            // 
            this.PxCB.FormattingEnabled = true;
            this.PxCB.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4",
            "P5"});
            this.PxCB.Location = new System.Drawing.Point(292, 80);
            this.PxCB.Name = "PxCB";
            this.PxCB.Size = new System.Drawing.Size(71, 23);
            this.PxCB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Px : ";
            // 
            // RequestBtn
            // 
            this.RequestBtn.Location = new System.Drawing.Point(252, 109);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(111, 67);
            this.RequestBtn.TabIndex = 11;
            this.RequestBtn.Text = "REQUEST";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // EndBtn
            // 
            this.EndBtn.Location = new System.Drawing.Point(130, 109);
            this.EndBtn.Name = "EndBtn";
            this.EndBtn.Size = new System.Drawing.Size(111, 67);
            this.EndBtn.TabIndex = 10;
            this.EndBtn.Text = "END";
            this.EndBtn.UseVisualStyleBackColor = true;
            this.EndBtn.Click += new System.EventHandler(this.EndBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(6, 109);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(111, 67);
            this.StartBtn.TabIndex = 9;
            this.StartBtn.Text = "START\r\n";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // DataTB
            // 
            this.DataTB.Location = new System.Drawing.Point(43, 80);
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(89, 23);
            this.DataTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data : ";
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(308, 51);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(55, 23);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "해제";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.OpenBtn.Location = new System.Drawing.Point(247, 50);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(55, 23);
            this.OpenBtn.TabIndex = 5;
            this.OpenBtn.Text = "연결";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // IpPortInfoTB
            // 
            this.IpPortInfoTB.Enabled = false;
            this.IpPortInfoTB.Location = new System.Drawing.Point(6, 51);
            this.IpPortInfoTB.Name = "IpPortInfoTB";
            this.IpPortInfoTB.Size = new System.Drawing.Size(235, 23);
            this.IpPortInfoTB.TabIndex = 4;
            // 
            // ServerPortTB
            // 
            this.ServerPortTB.Location = new System.Drawing.Point(281, 21);
            this.ServerPortTB.Name = "ServerPortTB";
            this.ServerPortTB.Size = new System.Drawing.Size(82, 23);
            this.ServerPortTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port : ";
            // 
            // ServerIpTB
            // 
            this.ServerIpTB.Location = new System.Drawing.Point(67, 22);
            this.ServerIpTB.Name = "ServerIpTB";
            this.ServerIpTB.Size = new System.Drawing.Size(174, 23);
            this.ServerIpTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP : ";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 471);
            this.Controls.Add(this.groupBox1);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox ServerPortTB;
        private Label label2;
        private TextBox ServerIpTB;
        private Label label1;
        private TextBox DataTB;
        private Label label3;
        private Button CloseBtn;
        private Button OpenBtn;
        private Label label4;
        private TextBox LogTB;
        private Button RequestBtn;
        private Button EndBtn;
        private Button StartBtn;
        private ComboBox PxCB;
        private GroupBox groupBox2;
        private TextBox IpPortInfoTB;
        private ComboBox VisionCB;
        private Label label5;
    }
}