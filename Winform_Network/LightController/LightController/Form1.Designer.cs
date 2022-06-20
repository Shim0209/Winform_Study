namespace LightController
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
            this.LightOneSB = new XComponent.SliderBar.MACTrackBar();
            this.LightTwoSB = new XComponent.SliderBar.MACTrackBar();
            this.LightOneNUD = new System.Windows.Forms.NumericUpDown();
            this.LightTwoNUD = new System.Windows.Forms.NumericUpDown();
            this.LightOneBtn = new System.Windows.Forms.Button();
            this.LightTwoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LightOneNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTwoNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // LightOneSB
            // 
            this.LightOneSB.BackColor = System.Drawing.Color.Transparent;
            this.LightOneSB.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.LightOneSB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightOneSB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.LightOneSB.IndentHeight = 6;
            this.LightOneSB.Location = new System.Drawing.Point(22, 117);
            this.LightOneSB.Maximum = 255;
            this.LightOneSB.Minimum = 0;
            this.LightOneSB.Name = "LightOneSB";
            this.LightOneSB.Size = new System.Drawing.Size(544, 47);
            this.LightOneSB.TabIndex = 1;
            this.LightOneSB.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.LightOneSB.TickFrequency = 20;
            this.LightOneSB.TickHeight = 4;
            this.LightOneSB.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.LightOneSB.TrackerSize = new System.Drawing.Size(16, 16);
            this.LightOneSB.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.LightOneSB.TrackLineHeight = 3;
            this.LightOneSB.Value = 0;
            this.LightOneSB.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.LightCh1_ValueChanged);
            // 
            // LightTwoSB
            // 
            this.LightTwoSB.BackColor = System.Drawing.Color.Transparent;
            this.LightTwoSB.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.LightTwoSB.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightTwoSB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.LightTwoSB.IndentHeight = 6;
            this.LightTwoSB.Location = new System.Drawing.Point(22, 290);
            this.LightTwoSB.Maximum = 255;
            this.LightTwoSB.Minimum = 0;
            this.LightTwoSB.Name = "LightTwoSB";
            this.LightTwoSB.Size = new System.Drawing.Size(544, 47);
            this.LightTwoSB.TabIndex = 2;
            this.LightTwoSB.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.LightTwoSB.TickFrequency = 20;
            this.LightTwoSB.TickHeight = 4;
            this.LightTwoSB.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.LightTwoSB.TrackerSize = new System.Drawing.Size(16, 16);
            this.LightTwoSB.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.LightTwoSB.TrackLineHeight = 3;
            this.LightTwoSB.Value = 0;
            this.LightTwoSB.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.LightCh2_ValueChanged);
            // 
            // LightOneNUD
            // 
            this.LightOneNUD.Location = new System.Drawing.Point(606, 117);
            this.LightOneNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LightOneNUD.Name = "LightOneNUD";
            this.LightOneNUD.ReadOnly = true;
            this.LightOneNUD.Size = new System.Drawing.Size(68, 21);
            this.LightOneNUD.TabIndex = 5;
            this.LightOneNUD.ValueChanged += new System.EventHandler(this.LightOneNUD_ValueChanged);
            // 
            // LightTwoNUD
            // 
            this.LightTwoNUD.Location = new System.Drawing.Point(606, 290);
            this.LightTwoNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.LightTwoNUD.Name = "LightTwoNUD";
            this.LightTwoNUD.ReadOnly = true;
            this.LightTwoNUD.Size = new System.Drawing.Size(68, 21);
            this.LightTwoNUD.TabIndex = 6;
            this.LightTwoNUD.ValueChanged += new System.EventHandler(this.LightTwoNUD_ValueChanged);
            // 
            // LightOneBtn
            // 
            this.LightOneBtn.Location = new System.Drawing.Point(24, 88);
            this.LightOneBtn.Name = "LightOneBtn";
            this.LightOneBtn.Size = new System.Drawing.Size(75, 23);
            this.LightOneBtn.TabIndex = 7;
            this.LightOneBtn.Text = "LIGHT CH1";
            this.LightOneBtn.UseVisualStyleBackColor = true;
            this.LightOneBtn.Click += new System.EventHandler(this.LightOneBtn_Click);
            // 
            // LightTwoBtn
            // 
            this.LightTwoBtn.Location = new System.Drawing.Point(24, 261);
            this.LightTwoBtn.Name = "LightTwoBtn";
            this.LightTwoBtn.Size = new System.Drawing.Size(75, 23);
            this.LightTwoBtn.TabIndex = 8;
            this.LightTwoBtn.Text = "LIGHT CH2";
            this.LightTwoBtn.UseVisualStyleBackColor = true;
            this.LightTwoBtn.Click += new System.EventHandler(this.LightTwoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.LightTwoBtn);
            this.Controls.Add(this.LightOneBtn);
            this.Controls.Add(this.LightTwoNUD);
            this.Controls.Add(this.LightOneNUD);
            this.Controls.Add(this.LightTwoSB);
            this.Controls.Add(this.LightOneSB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LightOneNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTwoNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XComponent.SliderBar.MACTrackBar LightOneSB;
        private XComponent.SliderBar.MACTrackBar LightTwoSB;
        private System.Windows.Forms.NumericUpDown LightOneNUD;
        private System.Windows.Forms.NumericUpDown LightTwoNUD;
        private System.Windows.Forms.Button LightOneBtn;
        private System.Windows.Forms.Button LightTwoBtn;
    }
}

