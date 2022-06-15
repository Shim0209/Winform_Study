namespace Protocol_01_Server
{
    partial class Server
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LogTB = new System.Windows.Forms.TextBox();
            this.PxCB = new System.Windows.Forms.ComboBox();
            this.RxCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RotationBtn = new System.Windows.Forms.Button();
            this.DataTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.IpPortInfoTB = new System.Windows.Forms.TextBox();
            this.ClientPortTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientIpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.PxCB);
            this.groupBox1.Controls.Add(this.RxCB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RotationBtn);
            this.groupBox1.Controls.Add(this.DataTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.OpenBtn);
            this.groupBox1.Controls.Add(this.IpPortInfoTB);
            this.groupBox1.Controls.Add(this.ClientPortTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClientIpTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 447);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server [Vision]";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LogTB);
            this.groupBox2.Location = new System.Drawing.Point(6, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 297);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // LogTB
            // 
            this.LogTB.Location = new System.Drawing.Point(6, 16);
            this.LogTB.Multiline = true;
            this.LogTB.Name = "LogTB";
            this.LogTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTB.Size = new System.Drawing.Size(345, 275);
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
            this.PxCB.Location = new System.Drawing.Point(44, 115);
            this.PxCB.Name = "PxCB";
            this.PxCB.Size = new System.Drawing.Size(82, 23);
            this.PxCB.TabIndex = 16;
            // 
            // RxCB
            // 
            this.RxCB.FormattingEnabled = true;
            this.RxCB.Items.AddRange(new object[] {
            "ROTATION1",
            "ROTATION2",
            "ROTATION3"});
            this.RxCB.Location = new System.Drawing.Point(158, 115);
            this.RxCB.Name = "RxCB";
            this.RxCB.Size = new System.Drawing.Size(82, 23);
            this.RxCB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Px : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rx : ";
            // 
            // RotationBtn
            // 
            this.RotationBtn.Location = new System.Drawing.Point(252, 80);
            this.RotationBtn.Name = "RotationBtn";
            this.RotationBtn.Size = new System.Drawing.Size(111, 58);
            this.RotationBtn.TabIndex = 11;
            this.RotationBtn.Text = "ROTATION";
            this.RotationBtn.UseVisualStyleBackColor = true;
            this.RotationBtn.Click += new System.EventHandler(this.RotationBtn_Click);
            // 
            // DataTB
            // 
            this.DataTB.Location = new System.Drawing.Point(43, 80);
            this.DataTB.Name = "DataTB";
            this.DataTB.Size = new System.Drawing.Size(198, 23);
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
            this.OpenBtn.Location = new System.Drawing.Point(247, 50);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(55, 23);
            this.OpenBtn.TabIndex = 5;
            this.OpenBtn.Text = "연결";
            this.OpenBtn.UseVisualStyleBackColor = true;
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
            // ClientPortTB
            // 
            this.ClientPortTB.Location = new System.Drawing.Point(281, 21);
            this.ClientPortTB.Name = "ClientPortTB";
            this.ClientPortTB.Size = new System.Drawing.Size(82, 23);
            this.ClientPortTB.TabIndex = 3;
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
            // ClientIpTB
            // 
            this.ClientIpTB.Location = new System.Drawing.Point(67, 22);
            this.ClientIpTB.Name = "ClientIpTB";
            this.ClientIpTB.Size = new System.Drawing.Size(174, 23);
            this.ClientIpTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client IP : ";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 471);
            this.Controls.Add(this.groupBox1);
            this.Name = "Server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox RxCB;
        private Label label4;
        private Button RotationBtn;
        private TextBox DataTB;
        private Label label3;
        private Button CloseBtn;
        private Button OpenBtn;
        private TextBox ClientPortTB;
        private Label label2;
        private TextBox ClientIpTB;
        private Label label1;
        private ComboBox PxCB;
        private Label label5;
        private GroupBox groupBox2;
        private TextBox LogTB;
        private TextBox IpPortInfoTB;
    }
}