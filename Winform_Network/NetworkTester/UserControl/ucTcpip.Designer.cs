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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcpipOpen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTcpipOpenPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTcpipOpenIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTcpipStatus = new System.Windows.Forms.TextBox();
            this.btnTcpipConnect = new System.Windows.Forms.Button();
            this.btnTcpipPing = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTcpipTargetPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTcpipTargetIp = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbSendSpeed5 = new System.Windows.Forms.TextBox();
            this.tbSendSpeed4 = new System.Windows.Forms.TextBox();
            this.tbSendSpeed3 = new System.Windows.Forms.TextBox();
            this.tbSendSpeed2 = new System.Windows.Forms.TextBox();
            this.tbSendSpeed1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.btnSendBox4 = new System.Windows.Forms.Button();
            this.cbSendBox4 = new System.Windows.Forms.CheckBox();
            this.tbSendBox4 = new System.Windows.Forms.TextBox();
            this.btnSendBox3 = new System.Windows.Forms.Button();
            this.cbSendBox3 = new System.Windows.Forms.CheckBox();
            this.tbSendBox3 = new System.Windows.Forms.TextBox();
            this.btnSendBox2 = new System.Windows.Forms.Button();
            this.cbSendBox2 = new System.Windows.Forms.CheckBox();
            this.tbSendBox2 = new System.Windows.Forms.TextBox();
            this.btnSendBox1 = new System.Windows.Forms.Button();
            this.cbSendBox1 = new System.Windows.Forms.CheckBox();
            this.tbSendBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbViewPoint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnImageSend = new System.Windows.Forms.Button();
            this.pbViewImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 662);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcpipOpen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbTcpipOpenPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTcpipOpenIp);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTcpipConnect);
            this.groupBox1.Controls.Add(this.btnTcpipPing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTcpipTargetPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTcpipTargetIp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(855, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 652);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP";
            // 
            // btnTcpipOpen
            // 
            this.btnTcpipOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTcpipOpen.Location = new System.Drawing.Point(6, 99);
            this.btnTcpipOpen.Name = "btnTcpipOpen";
            this.btnTcpipOpen.Size = new System.Drawing.Size(202, 23);
            this.btnTcpipOpen.TabIndex = 12;
            this.btnTcpipOpen.Text = "Open";
            this.btnTcpipOpen.UseVisualStyleBackColor = true;
            this.btnTcpipOpen.Click += new System.EventHandler(this.btnTcpipOpen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Open Port";
            // 
            // tbTcpipOpenPort
            // 
            this.tbTcpipOpenPort.Location = new System.Drawing.Point(6, 72);
            this.tbTcpipOpenPort.Name = "tbTcpipOpenPort";
            this.tbTcpipOpenPort.Size = new System.Drawing.Size(202, 21);
            this.tbTcpipOpenPort.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Open IP";
            // 
            // tbTcpipOpenIp
            // 
            this.tbTcpipOpenIp.Location = new System.Drawing.Point(6, 32);
            this.tbTcpipOpenIp.Name = "tbTcpipOpenIp";
            this.tbTcpipOpenIp.Size = new System.Drawing.Size(202, 21);
            this.tbTcpipOpenIp.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTcpipStatus);
            this.groupBox2.Location = new System.Drawing.Point(6, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 381);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // tbTcpipStatus
            // 
            this.tbTcpipStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTcpipStatus.Location = new System.Drawing.Point(3, 17);
            this.tbTcpipStatus.Margin = new System.Windows.Forms.Padding(0);
            this.tbTcpipStatus.Multiline = true;
            this.tbTcpipStatus.Name = "tbTcpipStatus";
            this.tbTcpipStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTcpipStatus.Size = new System.Drawing.Size(196, 361);
            this.tbTcpipStatus.TabIndex = 4;
            // 
            // btnTcpipConnect
            // 
            this.btnTcpipConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTcpipConnect.Location = new System.Drawing.Point(6, 238);
            this.btnTcpipConnect.Name = "btnTcpipConnect";
            this.btnTcpipConnect.Size = new System.Drawing.Size(202, 23);
            this.btnTcpipConnect.TabIndex = 5;
            this.btnTcpipConnect.Text = "Connect";
            this.btnTcpipConnect.UseVisualStyleBackColor = true;
            this.btnTcpipConnect.Click += new System.EventHandler(this.btnTcpipConnect_Click);
            // 
            // btnTcpipPing
            // 
            this.btnTcpipPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTcpipPing.Location = new System.Drawing.Point(6, 209);
            this.btnTcpipPing.Name = "btnTcpipPing";
            this.btnTcpipPing.Size = new System.Drawing.Size(202, 23);
            this.btnTcpipPing.TabIndex = 4;
            this.btnTcpipPing.Text = "Ping Test";
            this.btnTcpipPing.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Port";
            // 
            // tbTcpipTargetPort
            // 
            this.tbTcpipTargetPort.Location = new System.Drawing.Point(6, 182);
            this.tbTcpipTargetPort.Name = "tbTcpipTargetPort";
            this.tbTcpipTargetPort.Size = new System.Drawing.Size(202, 21);
            this.tbTcpipTargetPort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Target IP";
            // 
            // tbTcpipTargetIp
            // 
            this.tbTcpipTargetIp.Location = new System.Drawing.Point(6, 144);
            this.tbTcpipTargetIp.Name = "tbTcpipTargetIp";
            this.tbTcpipTargetIp.Size = new System.Drawing.Size(202, 21);
            this.tbTcpipTargetIp.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(849, 656);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnImageSend);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnAllClear);
            this.groupBox3.Controls.Add(this.btnSendBox4);
            this.groupBox3.Controls.Add(this.cbSendBox4);
            this.groupBox3.Controls.Add(this.tbSendBox4);
            this.groupBox3.Controls.Add(this.btnSendBox3);
            this.groupBox3.Controls.Add(this.cbSendBox3);
            this.groupBox3.Controls.Add(this.tbSendBox3);
            this.groupBox3.Controls.Add(this.btnSendBox2);
            this.groupBox3.Controls.Add(this.cbSendBox2);
            this.groupBox3.Controls.Add(this.tbSendBox2);
            this.groupBox3.Controls.Add(this.btnSendBox1);
            this.groupBox3.Controls.Add(this.cbSendBox1);
            this.groupBox3.Controls.Add(this.tbSendBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 393);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.tbSendSpeed5);
            this.groupBox5.Controls.Add(this.tbSendSpeed4);
            this.groupBox5.Controls.Add(this.tbSendSpeed3);
            this.groupBox5.Controls.Add(this.tbSendSpeed2);
            this.groupBox5.Controls.Add(this.tbSendSpeed1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(12, 214);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox5.Size = new System.Drawing.Size(666, 43);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Count of Auto Send";
            // 
            // tbSendSpeed5
            // 
            this.tbSendSpeed5.Location = new System.Drawing.Point(430, 16);
            this.tbSendSpeed5.Name = "tbSendSpeed5";
            this.tbSendSpeed5.Size = new System.Drawing.Size(38, 21);
            this.tbSendSpeed5.TabIndex = 43;
            this.tbSendSpeed5.Text = "1000";
            // 
            // tbSendSpeed4
            // 
            this.tbSendSpeed4.Location = new System.Drawing.Point(335, 16);
            this.tbSendSpeed4.Name = "tbSendSpeed4";
            this.tbSendSpeed4.Size = new System.Drawing.Size(38, 21);
            this.tbSendSpeed4.TabIndex = 41;
            this.tbSendSpeed4.Text = "1000";
            // 
            // tbSendSpeed3
            // 
            this.tbSendSpeed3.Location = new System.Drawing.Point(242, 16);
            this.tbSendSpeed3.Name = "tbSendSpeed3";
            this.tbSendSpeed3.Size = new System.Drawing.Size(38, 21);
            this.tbSendSpeed3.TabIndex = 39;
            this.tbSendSpeed3.Text = "1000";
            // 
            // tbSendSpeed2
            // 
            this.tbSendSpeed2.Location = new System.Drawing.Point(148, 16);
            this.tbSendSpeed2.Name = "tbSendSpeed2";
            this.tbSendSpeed2.Size = new System.Drawing.Size(38, 21);
            this.tbSendSpeed2.TabIndex = 37;
            this.tbSendSpeed2.Text = "1000";
            // 
            // tbSendSpeed1
            // 
            this.tbSendSpeed1.Location = new System.Drawing.Point(56, 16);
            this.tbSendSpeed1.Name = "tbSendSpeed1";
            this.tbSendSpeed1.Size = new System.Drawing.Size(38, 21);
            this.tbSendSpeed1.TabIndex = 35;
            this.tbSendSpeed1.Text = "1000";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(574, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAllClear
            // 
            this.btnAllClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClear.Location = new System.Drawing.Point(684, 228);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(146, 23);
            this.btnAllClear.TabIndex = 15;
            this.btnAllClear.Text = "ALL Clear";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // btnSendBox4
            // 
            this.btnSendBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox4.Location = new System.Drawing.Point(739, 147);
            this.btnSendBox4.Name = "btnSendBox4";
            this.btnSendBox4.Size = new System.Drawing.Size(91, 23);
            this.btnSendBox4.TabIndex = 11;
            this.btnSendBox4.Text = "Send";
            this.btnSendBox4.UseVisualStyleBackColor = true;
            this.btnSendBox4.Click += new System.EventHandler(this.btnSendBox4_Click);
            // 
            // cbSendBox4
            // 
            this.cbSendBox4.AutoSize = true;
            this.cbSendBox4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSendBox4.Location = new System.Drawing.Point(684, 150);
            this.cbSendBox4.Name = "cbSendBox4";
            this.cbSendBox4.Size = new System.Drawing.Size(57, 20);
            this.cbSendBox4.TabIndex = 10;
            this.cbSendBox4.Text = "HEX";
            this.cbSendBox4.UseVisualStyleBackColor = true;
            // 
            // tbSendBox4
            // 
            this.tbSendBox4.Location = new System.Drawing.Point(12, 149);
            this.tbSendBox4.Name = "tbSendBox4";
            this.tbSendBox4.Size = new System.Drawing.Size(666, 21);
            this.tbSendBox4.TabIndex = 9;
            // 
            // btnSendBox3
            // 
            this.btnSendBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox3.Location = new System.Drawing.Point(739, 104);
            this.btnSendBox3.Name = "btnSendBox3";
            this.btnSendBox3.Size = new System.Drawing.Size(91, 23);
            this.btnSendBox3.TabIndex = 8;
            this.btnSendBox3.Text = "Send";
            this.btnSendBox3.UseVisualStyleBackColor = true;
            this.btnSendBox3.Click += new System.EventHandler(this.btnSendBox3_Click);
            // 
            // cbSendBox3
            // 
            this.cbSendBox3.AutoSize = true;
            this.cbSendBox3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSendBox3.Location = new System.Drawing.Point(684, 107);
            this.cbSendBox3.Name = "cbSendBox3";
            this.cbSendBox3.Size = new System.Drawing.Size(57, 20);
            this.cbSendBox3.TabIndex = 7;
            this.cbSendBox3.Text = "HEX";
            this.cbSendBox3.UseVisualStyleBackColor = true;
            // 
            // tbSendBox3
            // 
            this.tbSendBox3.Location = new System.Drawing.Point(12, 106);
            this.tbSendBox3.Name = "tbSendBox3";
            this.tbSendBox3.Size = new System.Drawing.Size(666, 21);
            this.tbSendBox3.TabIndex = 6;
            // 
            // btnSendBox2
            // 
            this.btnSendBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox2.Location = new System.Drawing.Point(739, 61);
            this.btnSendBox2.Name = "btnSendBox2";
            this.btnSendBox2.Size = new System.Drawing.Size(91, 23);
            this.btnSendBox2.TabIndex = 5;
            this.btnSendBox2.Text = "Send";
            this.btnSendBox2.UseVisualStyleBackColor = true;
            this.btnSendBox2.Click += new System.EventHandler(this.btnSendBox2_Click);
            // 
            // cbSendBox2
            // 
            this.cbSendBox2.AutoSize = true;
            this.cbSendBox2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSendBox2.Location = new System.Drawing.Point(684, 64);
            this.cbSendBox2.Name = "cbSendBox2";
            this.cbSendBox2.Size = new System.Drawing.Size(57, 20);
            this.cbSendBox2.TabIndex = 4;
            this.cbSendBox2.Text = "HEX";
            this.cbSendBox2.UseVisualStyleBackColor = true;
            // 
            // tbSendBox2
            // 
            this.tbSendBox2.Location = new System.Drawing.Point(12, 63);
            this.tbSendBox2.Name = "tbSendBox2";
            this.tbSendBox2.Size = new System.Drawing.Size(666, 21);
            this.tbSendBox2.TabIndex = 3;
            // 
            // btnSendBox1
            // 
            this.btnSendBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBox1.Location = new System.Drawing.Point(739, 23);
            this.btnSendBox1.Name = "btnSendBox1";
            this.btnSendBox1.Size = new System.Drawing.Size(91, 23);
            this.btnSendBox1.TabIndex = 2;
            this.btnSendBox1.Text = "Send";
            this.btnSendBox1.UseVisualStyleBackColor = true;
            this.btnSendBox1.Click += new System.EventHandler(this.btnSendBox1_Click);
            // 
            // cbSendBox1
            // 
            this.cbSendBox1.AutoSize = true;
            this.cbSendBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbSendBox1.Location = new System.Drawing.Point(684, 26);
            this.cbSendBox1.Name = "cbSendBox1";
            this.cbSendBox1.Size = new System.Drawing.Size(57, 20);
            this.cbSendBox1.TabIndex = 1;
            this.cbSendBox1.Text = "HEX";
            this.cbSendBox1.UseVisualStyleBackColor = true;
            // 
            // tbSendBox1
            // 
            this.tbSendBox1.Location = new System.Drawing.Point(12, 25);
            this.tbSendBox1.Name = "tbSendBox1";
            this.tbSendBox1.Size = new System.Drawing.Size(666, 21);
            this.tbSendBox1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbViewImage);
            this.groupBox4.Controls.Add(this.tbViewPoint);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 393);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Received Data";
            // 
            // tbViewPoint
            // 
            this.tbViewPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbViewPoint.Location = new System.Drawing.Point(3, 17);
            this.tbViewPoint.Margin = new System.Windows.Forms.Padding(0);
            this.tbViewPoint.Multiline = true;
            this.tbViewPoint.Name = "tbViewPoint";
            this.tbViewPoint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbViewPoint.Size = new System.Drawing.Size(843, 373);
            this.tbViewPoint.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 44;
            this.label5.Text = "Box 1.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 45;
            this.label6.Text = "Box 2.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "Box 3.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "Box 4.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 48;
            this.label9.Text = "Box 5.";
            // 
            // btnImageSend
            // 
            this.btnImageSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImageSend.Location = new System.Drawing.Point(684, 186);
            this.btnImageSend.Name = "btnImageSend";
            this.btnImageSend.Size = new System.Drawing.Size(146, 23);
            this.btnImageSend.TabIndex = 17;
            this.btnImageSend.Text = "Image Send";
            this.btnImageSend.UseVisualStyleBackColor = true;
            this.btnImageSend.Click += new System.EventHandler(this.btnImageSend_Click);
            // 
            // pbViewImage
            // 
            this.pbViewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbViewImage.Location = new System.Drawing.Point(3, 17);
            this.pbViewImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbViewImage.Name = "pbViewImage";
            this.pbViewImage.Size = new System.Drawing.Size(843, 373);
            this.pbViewImage.TabIndex = 5;
            this.pbViewImage.TabStop = false;
            this.pbViewImage.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(529, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Image Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucTcpip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucTcpip";
            this.Size = new System.Drawing.Size(1069, 662);
            this.Load += new System.EventHandler(this.ucTcpip_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbViewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTcpipOpen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTcpipOpenPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTcpipOpenIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTcpipConnect;
        private System.Windows.Forms.Button btnTcpipPing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTcpipTargetPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTcpipTargetIp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSendBox1;
        private System.Windows.Forms.CheckBox cbSendBox1;
        private System.Windows.Forms.TextBox tbSendBox1;
        private System.Windows.Forms.Button btnSendBox4;
        private System.Windows.Forms.CheckBox cbSendBox4;
        private System.Windows.Forms.TextBox tbSendBox4;
        private System.Windows.Forms.Button btnSendBox3;
        private System.Windows.Forms.CheckBox cbSendBox3;
        private System.Windows.Forms.TextBox tbSendBox3;
        private System.Windows.Forms.Button btnSendBox2;
        private System.Windows.Forms.CheckBox cbSendBox2;
        private System.Windows.Forms.TextBox tbSendBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbViewPoint;
        private System.Windows.Forms.TextBox tbTcpipStatus;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbSendSpeed5;
        private System.Windows.Forms.TextBox tbSendSpeed4;
        private System.Windows.Forms.TextBox tbSendSpeed3;
        private System.Windows.Forms.TextBox tbSendSpeed2;
        private System.Windows.Forms.TextBox tbSendSpeed1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnImageSend;
        private System.Windows.Forms.PictureBox pbViewImage;
        private System.Windows.Forms.Button button1;
    }
}
