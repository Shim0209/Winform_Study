namespace NetworkTester
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnUdp = new System.Windows.Forms.Button();
            this.btnTcpip = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpViewPoint = new System.Windows.Forms.TableLayoutPanel();
            this.tbViewPoint = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 735);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSetting, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSerial, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUdp, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTcpip, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1069, 73);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(852, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 73);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(639, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(213, 73);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSerial
            // 
            this.btnSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSerial.FlatAppearance.BorderSize = 0;
            this.btnSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerial.Location = new System.Drawing.Point(426, 0);
            this.btnSerial.Margin = new System.Windows.Forms.Padding(0);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(213, 73);
            this.btnSerial.TabIndex = 2;
            this.btnSerial.Text = "SERIAL";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnUdp
            // 
            this.btnUdp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUdp.FlatAppearance.BorderSize = 0;
            this.btnUdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUdp.Location = new System.Drawing.Point(213, 0);
            this.btnUdp.Margin = new System.Windows.Forms.Padding(0);
            this.btnUdp.Name = "btnUdp";
            this.btnUdp.Size = new System.Drawing.Size(213, 73);
            this.btnUdp.TabIndex = 1;
            this.btnUdp.Text = "UDP";
            this.btnUdp.UseVisualStyleBackColor = true;
            this.btnUdp.Click += new System.EventHandler(this.btnUdp_Click);
            // 
            // btnTcpip
            // 
            this.btnTcpip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTcpip.FlatAppearance.BorderSize = 0;
            this.btnTcpip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTcpip.Location = new System.Drawing.Point(0, 0);
            this.btnTcpip.Margin = new System.Windows.Forms.Padding(0);
            this.btnTcpip.Name = "btnTcpip";
            this.btnTcpip.Size = new System.Drawing.Size(213, 73);
            this.btnTcpip.TabIndex = 0;
            this.btnTcpip.Text = "TCP / IP";
            this.btnTcpip.UseVisualStyleBackColor = true;
            this.btnTcpip.Click += new System.EventHandler(this.btnTcpip_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tlpViewPoint, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbViewPoint, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1069, 662);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tlpViewPoint
            // 
            this.tlpViewPoint.ColumnCount = 1;
            this.tlpViewPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewPoint.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpViewPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewPoint.Location = new System.Drawing.Point(855, 0);
            this.tlpViewPoint.Margin = new System.Windows.Forms.Padding(0);
            this.tlpViewPoint.Name = "tlpViewPoint";
            this.tlpViewPoint.RowCount = 1;
            this.tlpViewPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpViewPoint.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 616F));
            this.tlpViewPoint.Size = new System.Drawing.Size(214, 397);
            this.tlpViewPoint.TabIndex = 2;
            // 
            // tbViewPoint
            // 
            this.tbViewPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbViewPoint.Location = new System.Drawing.Point(3, 3);
            this.tbViewPoint.Multiline = true;
            this.tbViewPoint.Name = "tbViewPoint";
            this.tbViewPoint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbViewPoint.Size = new System.Drawing.Size(849, 391);
            this.tbViewPoint.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 735);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.Button btnUdp;
        private System.Windows.Forms.Button btnTcpip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tlpViewPoint;
        public System.Windows.Forms.TextBox tbViewPoint;
    }
}

