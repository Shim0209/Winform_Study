namespace SocketCommunication_Client
{
    partial class Machine
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Rx_RequestMsgTB = new System.Windows.Forms.TextBox();
            this.Rx_CommandCB = new System.Windows.Forms.ComboBox();
            this.Rx_ReceiveTB = new System.Windows.Forms.TextBox();
            this.Rx_RespBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Rx_MessageTB = new System.Windows.Forms.TextBox();
            this.Rx_DataCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rx_PickerCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Rx_VisionCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tx_OpenBtn = new System.Windows.Forms.Button();
            this.Tx_SendBtn = new System.Windows.Forms.Button();
            this.Tx_ResultTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tx_DataTB = new System.Windows.Forms.TextBox();
            this.Tx_CommandCB = new System.Windows.Forms.ComboBox();
            this.Tx_VisionCB = new System.Windows.Forms.ComboBox();
            this.Tx_PickerCB = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Rx_RequestMsgTB);
            this.groupBox2.Controls.Add(this.Rx_CommandCB);
            this.groupBox2.Controls.Add(this.Rx_ReceiveTB);
            this.groupBox2.Controls.Add(this.Rx_RespBtn);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Rx_MessageTB);
            this.groupBox2.Controls.Add(this.Rx_DataCB);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Rx_PickerCB);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Rx_VisionCB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(504, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 650);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "Message";
            // 
            // Rx_RequestMsgTB
            // 
            this.Rx_RequestMsgTB.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rx_RequestMsgTB.Location = new System.Drawing.Point(81, 19);
            this.Rx_RequestMsgTB.Multiline = true;
            this.Rx_RequestMsgTB.Name = "Rx_RequestMsgTB";
            this.Rx_RequestMsgTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Rx_RequestMsgTB.Size = new System.Drawing.Size(378, 38);
            this.Rx_RequestMsgTB.TabIndex = 32;
            // 
            // Rx_CommandCB
            // 
            this.Rx_CommandCB.FormattingEnabled = true;
            this.Rx_CommandCB.Items.AddRange(new object[] {
            "ROTATION1",
            "ROTATION2",
            "ROTATION3"});
            this.Rx_CommandCB.Location = new System.Drawing.Point(81, 142);
            this.Rx_CommandCB.Name = "Rx_CommandCB";
            this.Rx_CommandCB.Size = new System.Drawing.Size(297, 20);
            this.Rx_CommandCB.TabIndex = 22;
            // 
            // Rx_ReceiveTB
            // 
            this.Rx_ReceiveTB.Location = new System.Drawing.Point(9, 195);
            this.Rx_ReceiveTB.Multiline = true;
            this.Rx_ReceiveTB.Name = "Rx_ReceiveTB";
            this.Rx_ReceiveTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Rx_ReceiveTB.Size = new System.Drawing.Size(450, 449);
            this.Rx_ReceiveTB.TabIndex = 12;
            // 
            // Rx_RespBtn
            // 
            this.Rx_RespBtn.Location = new System.Drawing.Point(384, 62);
            this.Rx_RespBtn.Name = "Rx_RespBtn";
            this.Rx_RespBtn.Size = new System.Drawing.Size(75, 128);
            this.Rx_RespBtn.TabIndex = 21;
            this.Rx_RespBtn.Text = "Resp";
            this.Rx_RespBtn.UseVisualStyleBackColor = true;
            this.Rx_RespBtn.Click += new System.EventHandler(this.Rx_RespBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "Vision";
            // 
            // Rx_MessageTB
            // 
            this.Rx_MessageTB.Location = new System.Drawing.Point(81, 168);
            this.Rx_MessageTB.Name = "Rx_MessageTB";
            this.Rx_MessageTB.Size = new System.Drawing.Size(297, 21);
            this.Rx_MessageTB.TabIndex = 20;
            this.Rx_MessageTB.Text = "ERROR";
            // 
            // Rx_DataCB
            // 
            this.Rx_DataCB.FormattingEnabled = true;
            this.Rx_DataCB.Items.AddRange(new object[] {
            "ACK",
            "NCK"});
            this.Rx_DataCB.Location = new System.Drawing.Point(81, 63);
            this.Rx_DataCB.Name = "Rx_DataCB";
            this.Rx_DataCB.Size = new System.Drawing.Size(297, 20);
            this.Rx_DataCB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "Data";
            // 
            // Rx_PickerCB
            // 
            this.Rx_PickerCB.FormattingEnabled = true;
            this.Rx_PickerCB.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4",
            "P5"});
            this.Rx_PickerCB.Location = new System.Drawing.Point(81, 89);
            this.Rx_PickerCB.Name = "Rx_PickerCB";
            this.Rx_PickerCB.Size = new System.Drawing.Size(297, 20);
            this.Rx_PickerCB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "Message";
            // 
            // Rx_VisionCB
            // 
            this.Rx_VisionCB.FormattingEnabled = true;
            this.Rx_VisionCB.Items.AddRange(new object[] {
            "GLASS"});
            this.Rx_VisionCB.Location = new System.Drawing.Point(81, 115);
            this.Rx_VisionCB.Name = "Rx_VisionCB";
            this.Rx_VisionCB.Size = new System.Drawing.Size(297, 20);
            this.Rx_VisionCB.TabIndex = 13;
            this.Rx_VisionCB.Text = "GLASS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Command";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Picker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tx_OpenBtn);
            this.groupBox1.Controls.Add(this.Tx_SendBtn);
            this.groupBox1.Controls.Add(this.Tx_ResultTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tx_DataTB);
            this.groupBox1.Controls.Add(this.Tx_CommandCB);
            this.groupBox1.Controls.Add(this.Tx_VisionCB);
            this.groupBox1.Controls.Add(this.Tx_PickerCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 650);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tx";
            // 
            // Tx_OpenBtn
            // 
            this.Tx_OpenBtn.Location = new System.Drawing.Point(11, 20);
            this.Tx_OpenBtn.Name = "Tx_OpenBtn";
            this.Tx_OpenBtn.Size = new System.Drawing.Size(450, 38);
            this.Tx_OpenBtn.TabIndex = 11;
            this.Tx_OpenBtn.Text = "연결";
            this.Tx_OpenBtn.UseVisualStyleBackColor = true;
            this.Tx_OpenBtn.Click += new System.EventHandler(this.Tx_OpenBtn_Click);
            // 
            // Tx_SendBtn
            // 
            this.Tx_SendBtn.Location = new System.Drawing.Point(386, 62);
            this.Tx_SendBtn.Name = "Tx_SendBtn";
            this.Tx_SendBtn.Size = new System.Drawing.Size(75, 101);
            this.Tx_SendBtn.TabIndex = 10;
            this.Tx_SendBtn.Text = "Send";
            this.Tx_SendBtn.UseVisualStyleBackColor = true;
            this.Tx_SendBtn.Click += new System.EventHandler(this.Tx_SendBtn_Click);
            // 
            // Tx_ResultTB
            // 
            this.Tx_ResultTB.Location = new System.Drawing.Point(11, 169);
            this.Tx_ResultTB.Multiline = true;
            this.Tx_ResultTB.Name = "Tx_ResultTB";
            this.Tx_ResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tx_ResultTB.Size = new System.Drawing.Size(450, 475);
            this.Tx_ResultTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vision";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Picker";
            // 
            // Tx_DataTB
            // 
            this.Tx_DataTB.Location = new System.Drawing.Point(79, 142);
            this.Tx_DataTB.Name = "Tx_DataTB";
            this.Tx_DataTB.Size = new System.Drawing.Size(301, 21);
            this.Tx_DataTB.TabIndex = 3;
            // 
            // Tx_CommandCB
            // 
            this.Tx_CommandCB.FormattingEnabled = true;
            this.Tx_CommandCB.Items.AddRange(new object[] {
            "START",
            "STOP",
            "REQUEST"});
            this.Tx_CommandCB.Location = new System.Drawing.Point(79, 116);
            this.Tx_CommandCB.Name = "Tx_CommandCB";
            this.Tx_CommandCB.Size = new System.Drawing.Size(301, 20);
            this.Tx_CommandCB.TabIndex = 2;
            // 
            // Tx_VisionCB
            // 
            this.Tx_VisionCB.FormattingEnabled = true;
            this.Tx_VisionCB.Items.AddRange(new object[] {
            "ALL",
            "GLASS",
            "PCB"});
            this.Tx_VisionCB.Location = new System.Drawing.Point(79, 90);
            this.Tx_VisionCB.Name = "Tx_VisionCB";
            this.Tx_VisionCB.Size = new System.Drawing.Size(301, 20);
            this.Tx_VisionCB.TabIndex = 1;
            // 
            // Tx_PickerCB
            // 
            this.Tx_PickerCB.FormattingEnabled = true;
            this.Tx_PickerCB.Items.AddRange(new object[] {
            "P0",
            "P1",
            "P2",
            "P3",
            "P4",
            "P5"});
            this.Tx_PickerCB.Location = new System.Drawing.Point(79, 64);
            this.Tx_PickerCB.Name = "Tx_PickerCB";
            this.Tx_PickerCB.Size = new System.Drawing.Size(301, 20);
            this.Tx_PickerCB.TabIndex = 0;
            // 
            // Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Machine";
            this.Text = "Machine";
            this.Load += new System.EventHandler(this.Machine_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Rx_ReceiveTB;
        private System.Windows.Forms.Button Rx_RespBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Rx_MessageTB;
        private System.Windows.Forms.ComboBox Rx_DataCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Rx_PickerCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Rx_VisionCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Tx_SendBtn;
        private System.Windows.Forms.TextBox Tx_ResultTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tx_DataTB;
        private System.Windows.Forms.ComboBox Tx_CommandCB;
        private System.Windows.Forms.ComboBox Tx_VisionCB;
        private System.Windows.Forms.ComboBox Tx_PickerCB;
        private System.Windows.Forms.ComboBox Rx_CommandCB;
        private System.Windows.Forms.Button Tx_OpenBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Rx_RequestMsgTB;
    }
}

