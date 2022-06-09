namespace SerialCommunication
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ParityCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StopBitsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataBitsCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaudRateCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortCB = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.OpenBtn = new System.Windows.Forms.Button();
            this.TxBtn = new System.Windows.Forms.Button();
            this.TxTB = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ParityCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StopBitsCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DataBitsCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BaudRateCB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PortCB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Configuration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity";
            // 
            // ParityCB
            // 
            this.ParityCB.FormattingEnabled = true;
            this.ParityCB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.ParityCB.Location = new System.Drawing.Point(77, 124);
            this.ParityCB.Name = "ParityCB";
            this.ParityCB.Size = new System.Drawing.Size(121, 20);
            this.ParityCB.TabIndex = 8;
            this.ParityCB.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop Bits";
            // 
            // StopBitsCB
            // 
            this.StopBitsCB.FormattingEnabled = true;
            this.StopBitsCB.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.StopBitsCB.Location = new System.Drawing.Point(77, 98);
            this.StopBitsCB.Name = "StopBitsCB";
            this.StopBitsCB.Size = new System.Drawing.Size(121, 20);
            this.StopBitsCB.TabIndex = 6;
            this.StopBitsCB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Bits";
            // 
            // DataBitsCB
            // 
            this.DataBitsCB.FormattingEnabled = true;
            this.DataBitsCB.Items.AddRange(new object[] {
            "7",
            "8"});
            this.DataBitsCB.Location = new System.Drawing.Point(77, 72);
            this.DataBitsCB.Name = "DataBitsCB";
            this.DataBitsCB.Size = new System.Drawing.Size(121, 20);
            this.DataBitsCB.TabIndex = 4;
            this.DataBitsCB.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boud Rate";
            // 
            // BaudRateCB
            // 
            this.BaudRateCB.FormattingEnabled = true;
            this.BaudRateCB.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateCB.Location = new System.Drawing.Point(77, 46);
            this.BaudRateCB.Name = "BaudRateCB";
            this.BaudRateCB.Size = new System.Drawing.Size(121, 20);
            this.BaudRateCB.TabIndex = 2;
            this.BaudRateCB.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name";
            // 
            // PortCB
            // 
            this.PortCB.FormattingEnabled = true;
            this.PortCB.Location = new System.Drawing.Point(77, 20);
            this.PortCB.Name = "PortCB";
            this.PortCB.Size = new System.Drawing.Size(121, 20);
            this.PortCB.TabIndex = 0;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(232, 24);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 71);
            this.OpenBtn.TabIndex = 1;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // TxBtn
            // 
            this.TxBtn.Location = new System.Drawing.Point(232, 173);
            this.TxBtn.Name = "TxBtn";
            this.TxBtn.Size = new System.Drawing.Size(75, 21);
            this.TxBtn.TabIndex = 4;
            this.TxBtn.Text = "Tx Data";
            this.TxBtn.UseVisualStyleBackColor = true;
            this.TxBtn.Click += new System.EventHandler(this.TxBtn_Click);
            // 
            // TxTB
            // 
            this.TxTB.Location = new System.Drawing.Point(12, 173);
            this.TxTB.Name = "TxTB";
            this.TxTB.Size = new System.Drawing.Size(209, 21);
            this.TxTB.TabIndex = 5;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(232, 101);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 66);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rx Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.TxTB);
            this.Controls.Add(this.TxBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ParityCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StopBitsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DataBitsCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BaudRateCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortCB;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button TxBtn;
        private System.Windows.Forms.TextBox TxTB;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

