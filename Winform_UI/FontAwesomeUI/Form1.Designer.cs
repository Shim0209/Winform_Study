namespace FontAwesomeUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnectstatus = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnRun = new FontAwesome.Sharp.IconButton();
            this.btnData = new FontAwesome.Sharp.IconButton();
            this.btnView = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusNetwork = new FontAwesome.Sharp.IconButton();
            this.statusDB = new FontAwesome.Sharp.IconButton();
            this.statusDataread = new FontAwesome.Sharp.IconButton();
            this.statusHeartbeat = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.panelMain.Controls.Add(this.panel4);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.btnRun);
            this.panelMain.Controls.Add(this.btnData);
            this.panelMain.Controls.Add(this.btnView);
            this.panelMain.Controls.Add(this.btnDashboard);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(200, 1041);
            this.panelMain.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 400);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(200, 591);
            this.panel4.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(200, 425);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "[12:06:10] Connect Success\r\n[12:06:05] Program Start\r\n[12:06:10] Run\r\n[12:06:10] " +
    "Save\r\n\r\n";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 50);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "2021 10 28(목) 00:00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConnectstatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 991);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 6;
            // 
            // btnConnectstatus
            // 
            this.btnConnectstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnConnectstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectstatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnectstatus.FlatAppearance.BorderSize = 0;
            this.btnConnectstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectstatus.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnConnectstatus.IconChar = FontAwesome.Sharp.IconChar.Signal5;
            this.btnConnectstatus.IconColor = System.Drawing.Color.GreenYellow;
            this.btnConnectstatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnectstatus.IconSize = 36;
            this.btnConnectstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnectstatus.Location = new System.Drawing.Point(0, 0);
            this.btnConnectstatus.Name = "btnConnectstatus";
            this.btnConnectstatus.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnConnectstatus.Size = new System.Drawing.Size(200, 50);
            this.btnConnectstatus.TabIndex = 6;
            this.btnConnectstatus.Text = "Connect Status";
            this.btnConnectstatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnectstatus.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(238)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnSave.IconColor = System.Drawing.Color.GreenYellow;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 36;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSave.Size = new System.Drawing.Size(200, 60);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(238)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.Transparent;
            this.btnRun.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnRun.IconColor = System.Drawing.Color.GreenYellow;
            this.btnRun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRun.IconSize = 36;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(0, 280);
            this.btnRun.Name = "btnRun";
            this.btnRun.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRun.Size = new System.Drawing.Size(200, 60);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(238)))));
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.Transparent;
            this.btnData.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnData.IconColor = System.Drawing.Color.White;
            this.btnData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnData.IconSize = 36;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.Location = new System.Drawing.Point(0, 220);
            this.btnData.Name = "btnData";
            this.btnData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnData.Size = new System.Drawing.Size(200, 60);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "Data";
            this.btnData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(238)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Transparent;
            this.btnView.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnView.IconColor = System.Drawing.Color.White;
            this.btnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnView.IconSize = 36;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(0, 160);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnView.Size = new System.Drawing.Size(200, 60);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(159)))), ((int)(((byte)(238)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.White;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 36;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DashBoard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Size = new System.Drawing.Size(200, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1704, 50);
            this.panel5.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel13.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.btnSetting, 2, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(1704, 50);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.LightSlateGray;
            this.labelTitle.Location = new System.Drawing.Point(258, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1186, 50);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "실험명";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.statusNetwork, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusDB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusDataread, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusHeartbeat, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // statusNetwork
            // 
            this.statusNetwork.BackColor = System.Drawing.Color.White;
            this.statusNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusNetwork.FlatAppearance.BorderSize = 0;
            this.statusNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusNetwork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.statusNetwork.IconChar = FontAwesome.Sharp.IconChar.ArrowsSpin;
            this.statusNetwork.IconColor = System.Drawing.Color.LawnGreen;
            this.statusNetwork.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusNetwork.IconSize = 30;
            this.statusNetwork.Location = new System.Drawing.Point(0, 0);
            this.statusNetwork.Margin = new System.Windows.Forms.Padding(0);
            this.statusNetwork.Name = "statusNetwork";
            this.statusNetwork.Size = new System.Drawing.Size(63, 50);
            this.statusNetwork.TabIndex = 5;
            this.statusNetwork.Text = "네트워크";
            this.statusNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.statusNetwork.UseVisualStyleBackColor = false;
            // 
            // statusDB
            // 
            this.statusDB.BackColor = System.Drawing.Color.White;
            this.statusDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDB.FlatAppearance.BorderSize = 0;
            this.statusDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.statusDB.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.statusDB.IconColor = System.Drawing.Color.Red;
            this.statusDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusDB.IconSize = 30;
            this.statusDB.Location = new System.Drawing.Point(189, 0);
            this.statusDB.Margin = new System.Windows.Forms.Padding(0);
            this.statusDB.Name = "statusDB";
            this.statusDB.Size = new System.Drawing.Size(66, 50);
            this.statusDB.TabIndex = 4;
            this.statusDB.Text = "데이터";
            this.statusDB.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.statusDB.UseVisualStyleBackColor = false;
            // 
            // statusDataread
            // 
            this.statusDataread.BackColor = System.Drawing.Color.White;
            this.statusDataread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDataread.FlatAppearance.BorderSize = 0;
            this.statusDataread.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusDataread.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusDataread.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.statusDataread.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.statusDataread.IconColor = System.Drawing.Color.Red;
            this.statusDataread.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusDataread.IconSize = 30;
            this.statusDataread.Location = new System.Drawing.Point(126, 0);
            this.statusDataread.Margin = new System.Windows.Forms.Padding(0);
            this.statusDataread.Name = "statusDataread";
            this.statusDataread.Size = new System.Drawing.Size(63, 50);
            this.statusDataread.TabIndex = 1;
            this.statusDataread.Text = "센서정보";
            this.statusDataread.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.statusDataread.UseVisualStyleBackColor = false;
            // 
            // statusHeartbeat
            // 
            this.statusHeartbeat.BackColor = System.Drawing.Color.White;
            this.statusHeartbeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusHeartbeat.FlatAppearance.BorderSize = 0;
            this.statusHeartbeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusHeartbeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusHeartbeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(78)))));
            this.statusHeartbeat.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.statusHeartbeat.IconColor = System.Drawing.Color.Red;
            this.statusHeartbeat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusHeartbeat.IconSize = 30;
            this.statusHeartbeat.Location = new System.Drawing.Point(63, 0);
            this.statusHeartbeat.Margin = new System.Windows.Forms.Padding(0);
            this.statusHeartbeat.Name = "statusHeartbeat";
            this.statusHeartbeat.Size = new System.Drawing.Size(63, 50);
            this.statusHeartbeat.TabIndex = 0;
            this.statusHeartbeat.Text = "분사가스";
            this.statusHeartbeat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.statusHeartbeat.UseVisualStyleBackColor = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSetting.IconColor = System.Drawing.Color.Black;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 36;
            this.btnSetting.Location = new System.Drawing.Point(1626, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 44);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 50);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1704, 991);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnConnectstatus;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnRun;
        private FontAwesome.Sharp.IconButton btnData;
        private FontAwesome.Sharp.IconButton btnView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton statusHeartbeat;
        private FontAwesome.Sharp.IconButton statusNetwork;
        private FontAwesome.Sharp.IconButton statusDB;
        private FontAwesome.Sharp.IconButton statusDataread;
        private FontAwesome.Sharp.IconButton btnSetting;
    }
}

