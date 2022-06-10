namespace TcpIpCommunication
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientIpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientOpenBtn = new System.Windows.Forms.Button();
            this.ClientSendBtn = new System.Windows.Forms.Button();
            this.ClientMsgTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientPortTB = new System.Windows.Forms.TextBox();
            this.ClientCloseBtn = new System.Windows.Forms.Button();
            this.ClientIpPortTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientDisplayTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServerDisplayTB = new System.Windows.Forms.TextBox();
            this.ServerIpPortTB = new System.Windows.Forms.TextBox();
            this.ServerIpTB = new System.Windows.Forms.TextBox();
            this.ServerCloseBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerOpenBtn = new System.Windows.Forms.Button();
            this.ServerPortTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientIpTB
            // 
            this.ClientIpTB.Location = new System.Drawing.Point(74, 17);
            this.ClientIpTB.Name = "ClientIpTB";
            this.ClientIpTB.Size = new System.Drawing.Size(155, 21);
            this.ClientIpTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server IP :";
            // 
            // ClientOpenBtn
            // 
            this.ClientOpenBtn.Location = new System.Drawing.Point(235, 44);
            this.ClientOpenBtn.Name = "ClientOpenBtn";
            this.ClientOpenBtn.Size = new System.Drawing.Size(45, 23);
            this.ClientOpenBtn.TabIndex = 4;
            this.ClientOpenBtn.Text = "Open";
            this.ClientOpenBtn.UseVisualStyleBackColor = true;
            this.ClientOpenBtn.Click += new System.EventHandler(this.ClientOpenBtn_Click);
            // 
            // ClientSendBtn
            // 
            this.ClientSendBtn.Location = new System.Drawing.Point(265, 73);
            this.ClientSendBtn.Name = "ClientSendBtn";
            this.ClientSendBtn.Size = new System.Drawing.Size(75, 21);
            this.ClientSendBtn.TabIndex = 7;
            this.ClientSendBtn.Text = "Send";
            this.ClientSendBtn.UseVisualStyleBackColor = true;
            this.ClientSendBtn.Click += new System.EventHandler(this.ClientSendBtn_Click);
            // 
            // ClientMsgTB
            // 
            this.ClientMsgTB.Location = new System.Drawing.Point(6, 73);
            this.ClientMsgTB.Name = "ClientMsgTB";
            this.ClientMsgTB.Size = new System.Drawing.Size(253, 21);
            this.ClientMsgTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port :";
            // 
            // ClientPortTB
            // 
            this.ClientPortTB.Location = new System.Drawing.Point(276, 17);
            this.ClientPortTB.Name = "ClientPortTB";
            this.ClientPortTB.Size = new System.Drawing.Size(64, 21);
            this.ClientPortTB.TabIndex = 8;
            // 
            // ClientCloseBtn
            // 
            this.ClientCloseBtn.Location = new System.Drawing.Point(286, 44);
            this.ClientCloseBtn.Name = "ClientCloseBtn";
            this.ClientCloseBtn.Size = new System.Drawing.Size(54, 23);
            this.ClientCloseBtn.TabIndex = 10;
            this.ClientCloseBtn.Text = "Close";
            this.ClientCloseBtn.UseVisualStyleBackColor = true;
            this.ClientCloseBtn.Click += new System.EventHandler(this.ClientCloseBtn_Click);
            // 
            // ClientIpPortTB
            // 
            this.ClientIpPortTB.Enabled = false;
            this.ClientIpPortTB.Location = new System.Drawing.Point(6, 46);
            this.ClientIpPortTB.Name = "ClientIpPortTB";
            this.ClientIpPortTB.Size = new System.Drawing.Size(223, 21);
            this.ClientIpPortTB.TabIndex = 11;
            this.ClientIpPortTB.Text = "IP와 Port를 설정하세요";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientDisplayTB);
            this.groupBox1.Controls.Add(this.ClientMsgTB);
            this.groupBox1.Controls.Add(this.ClientIpPortTB);
            this.groupBox1.Controls.Add(this.ClientIpTB);
            this.groupBox1.Controls.Add(this.ClientCloseBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ClientOpenBtn);
            this.groupBox1.Controls.Add(this.ClientPortTB);
            this.groupBox1.Controls.Add(this.ClientSendBtn);
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 210);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // ClientDisplayTB
            // 
            this.ClientDisplayTB.Location = new System.Drawing.Point(6, 100);
            this.ClientDisplayTB.Multiline = true;
            this.ClientDisplayTB.Name = "ClientDisplayTB";
            this.ClientDisplayTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientDisplayTB.Size = new System.Drawing.Size(334, 104);
            this.ClientDisplayTB.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServerDisplayTB);
            this.groupBox2.Controls.Add(this.ServerIpPortTB);
            this.groupBox2.Controls.Add(this.ServerIpTB);
            this.groupBox2.Controls.Add(this.ServerCloseBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ServerOpenBtn);
            this.groupBox2.Controls.Add(this.ServerPortTB);
            this.groupBox2.Location = new System.Drawing.Point(27, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 199);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // ServerDisplayTB
            // 
            this.ServerDisplayTB.Location = new System.Drawing.Point(6, 73);
            this.ServerDisplayTB.Multiline = true;
            this.ServerDisplayTB.Name = "ServerDisplayTB";
            this.ServerDisplayTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServerDisplayTB.Size = new System.Drawing.Size(334, 120);
            this.ServerDisplayTB.TabIndex = 12;
            // 
            // ServerIpPortTB
            // 
            this.ServerIpPortTB.Enabled = false;
            this.ServerIpPortTB.Location = new System.Drawing.Point(6, 46);
            this.ServerIpPortTB.Name = "ServerIpPortTB";
            this.ServerIpPortTB.Size = new System.Drawing.Size(223, 21);
            this.ServerIpPortTB.TabIndex = 11;
            this.ServerIpPortTB.Text = "IP와 Port를 설정하세요";
            // 
            // ServerIpTB
            // 
            this.ServerIpTB.Location = new System.Drawing.Point(74, 17);
            this.ServerIpTB.Name = "ServerIpTB";
            this.ServerIpTB.Size = new System.Drawing.Size(155, 21);
            this.ServerIpTB.TabIndex = 0;
            // 
            // ServerCloseBtn
            // 
            this.ServerCloseBtn.Location = new System.Drawing.Point(286, 44);
            this.ServerCloseBtn.Name = "ServerCloseBtn";
            this.ServerCloseBtn.Size = new System.Drawing.Size(54, 23);
            this.ServerCloseBtn.TabIndex = 10;
            this.ServerCloseBtn.Text = "Close";
            this.ServerCloseBtn.UseVisualStyleBackColor = true;
            this.ServerCloseBtn.Click += new System.EventHandler(this.ServerCloseBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server IP :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Port :";
            // 
            // ServerOpenBtn
            // 
            this.ServerOpenBtn.Location = new System.Drawing.Point(235, 44);
            this.ServerOpenBtn.Name = "ServerOpenBtn";
            this.ServerOpenBtn.Size = new System.Drawing.Size(45, 23);
            this.ServerOpenBtn.TabIndex = 4;
            this.ServerOpenBtn.Text = "Open";
            this.ServerOpenBtn.UseVisualStyleBackColor = true;
            this.ServerOpenBtn.Click += new System.EventHandler(this.ServerOpenBtn_Click);
            // 
            // ServerPortTB
            // 
            this.ServerPortTB.Location = new System.Drawing.Point(276, 17);
            this.ServerPortTB.Name = "ServerPortTB";
            this.ServerPortTB.Size = new System.Drawing.Size(64, 21);
            this.ServerPortTB.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ClientIpTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientOpenBtn;
        private System.Windows.Forms.Button ClientSendBtn;
        private System.Windows.Forms.TextBox ClientMsgTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientPortTB;
        private System.Windows.Forms.Button ClientCloseBtn;
        private System.Windows.Forms.TextBox ClientIpPortTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ClientDisplayTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ServerDisplayTB;
        private System.Windows.Forms.TextBox ServerIpPortTB;
        private System.Windows.Forms.TextBox ServerIpTB;
        private System.Windows.Forms.Button ServerCloseBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ServerOpenBtn;
        private System.Windows.Forms.TextBox ServerPortTB;
    }
}

