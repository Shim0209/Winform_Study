namespace NetworkTester
{
    partial class ucTcpip
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcpipPing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTcpipTargetPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTcpipTargetIp = new System.Windows.Forms.TextBox();
            this.btnTcpipConnect = new System.Windows.Forms.Button();
            this.btnTcpipDisconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTcpipOpenIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTcpipOpenPort = new System.Windows.Forms.TextBox();
            this.tbTcpipStatus = new System.Windows.Forms.TextBox();
            this.btnTcpipClose = new System.Windows.Forms.Button();
            this.btnTcpipOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcpipClose);
            this.groupBox1.Controls.Add(this.btnTcpipOpen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTcpipOpenPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTcpipOpenIp);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTcpipDisconnect);
            this.groupBox1.Controls.Add(this.btnTcpipConnect);
            this.groupBox1.Controls.Add(this.btnTcpipPing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTcpipTargetPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTcpipTargetIp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP";
            // 
            // btnTcpipPing
            // 
            this.btnTcpipPing.Location = new System.Drawing.Point(18, 237);
            this.btnTcpipPing.Name = "btnTcpipPing";
            this.btnTcpipPing.Size = new System.Drawing.Size(176, 23);
            this.btnTcpipPing.TabIndex = 4;
            this.btnTcpipPing.Text = "Ping Test";
            this.btnTcpipPing.UseVisualStyleBackColor = true;
            this.btnTcpipPing.Click += new System.EventHandler(this.btnTcpipPing_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Port";
            // 
            // tbTcpipTargetPort
            // 
            this.tbTcpipTargetPort.Location = new System.Drawing.Point(18, 150);
            this.tbTcpipTargetPort.Name = "tbTcpipTargetPort";
            this.tbTcpipTargetPort.Size = new System.Drawing.Size(176, 21);
            this.tbTcpipTargetPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target IP";
            // 
            // tbTcpipTargetIp
            // 
            this.tbTcpipTargetIp.Location = new System.Drawing.Point(18, 112);
            this.tbTcpipTargetIp.Name = "tbTcpipTargetIp";
            this.tbTcpipTargetIp.Size = new System.Drawing.Size(176, 21);
            this.tbTcpipTargetIp.TabIndex = 0;
            // 
            // btnTcpipConnect
            // 
            this.btnTcpipConnect.Location = new System.Drawing.Point(18, 208);
            this.btnTcpipConnect.Name = "btnTcpipConnect";
            this.btnTcpipConnect.Size = new System.Drawing.Size(86, 23);
            this.btnTcpipConnect.TabIndex = 5;
            this.btnTcpipConnect.Text = "Connect";
            this.btnTcpipConnect.UseVisualStyleBackColor = true;
            this.btnTcpipConnect.Click += new System.EventHandler(this.btnTcpipConnect_Click);
            // 
            // btnTcpipDisconnect
            // 
            this.btnTcpipDisconnect.Location = new System.Drawing.Point(105, 208);
            this.btnTcpipDisconnect.Name = "btnTcpipDisconnect";
            this.btnTcpipDisconnect.Size = new System.Drawing.Size(89, 23);
            this.btnTcpipDisconnect.TabIndex = 6;
            this.btnTcpipDisconnect.Text = "DisConnect";
            this.btnTcpipDisconnect.UseVisualStyleBackColor = true;
            this.btnTcpipDisconnect.Click += new System.EventHandler(this.btnTcpipDisconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTcpipStatus);
            this.groupBox2.Location = new System.Drawing.Point(18, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Open IP";
            // 
            // tbTcpipOpenIp
            // 
            this.tbTcpipOpenIp.Location = new System.Drawing.Point(18, 32);
            this.tbTcpipOpenIp.Name = "tbTcpipOpenIp";
            this.tbTcpipOpenIp.Size = new System.Drawing.Size(176, 21);
            this.tbTcpipOpenIp.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Open Port";
            // 
            // tbTcpipOpenPort
            // 
            this.tbTcpipOpenPort.Location = new System.Drawing.Point(18, 72);
            this.tbTcpipOpenPort.Name = "tbTcpipOpenPort";
            this.tbTcpipOpenPort.Size = new System.Drawing.Size(176, 21);
            this.tbTcpipOpenPort.TabIndex = 10;
            // 
            // tbTcpipStatus
            // 
            this.tbTcpipStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTcpipStatus.Location = new System.Drawing.Point(3, 17);
            this.tbTcpipStatus.Multiline = true;
            this.tbTcpipStatus.Name = "tbTcpipStatus";
            this.tbTcpipStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTcpipStatus.Size = new System.Drawing.Size(170, 93);
            this.tbTcpipStatus.TabIndex = 0;
            // 
            // btnTcpipClose
            // 
            this.btnTcpipClose.Location = new System.Drawing.Point(105, 179);
            this.btnTcpipClose.Name = "btnTcpipClose";
            this.btnTcpipClose.Size = new System.Drawing.Size(89, 23);
            this.btnTcpipClose.TabIndex = 13;
            this.btnTcpipClose.Text = "Close";
            this.btnTcpipClose.UseVisualStyleBackColor = true;
            this.btnTcpipClose.Click += new System.EventHandler(this.btnTcpipClose_Click);
            // 
            // btnTcpipOpen
            // 
            this.btnTcpipOpen.Location = new System.Drawing.Point(18, 179);
            this.btnTcpipOpen.Name = "btnTcpipOpen";
            this.btnTcpipOpen.Size = new System.Drawing.Size(86, 23);
            this.btnTcpipOpen.TabIndex = 12;
            this.btnTcpipOpen.Text = "Open";
            this.btnTcpipOpen.UseVisualStyleBackColor = true;
            this.btnTcpipOpen.Click += new System.EventHandler(this.btnTcpipOpen_Click);
            // 
            // ucTcpip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucTcpip";
            this.Size = new System.Drawing.Size(214, 397);
            this.Load += new System.EventHandler(this.ucTcpip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTcpipTargetPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTcpipTargetIp;
        private System.Windows.Forms.Button btnTcpipPing;
        private System.Windows.Forms.Button btnTcpipDisconnect;
        private System.Windows.Forms.Button btnTcpipConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTcpipOpenIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTcpipOpenPort;
        private System.Windows.Forms.TextBox tbTcpipStatus;
        private System.Windows.Forms.Button btnTcpipClose;
        private System.Windows.Forms.Button btnTcpipOpen;
    }
}
