namespace TAP
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
            this.Coffee_LB = new System.Windows.Forms.Label();
            this.Egg_LB = new System.Windows.Forms.Label();
            this.Toast_LB = new System.Windows.Forms.Label();
            this.Butter_LB = new System.Windows.Forms.Label();
            this.Jam_LB = new System.Windows.Forms.Label();
            this.OJ_LB = new System.Windows.Forms.Label();
            this.lv1_Btn = new System.Windows.Forms.Button();
            this.lv2_Btn = new System.Windows.Forms.Button();
            this.lv3_Btn = new System.Windows.Forms.Button();
            this.lv4_Btn = new System.Windows.Forms.Button();
            this.Bacon_LB = new System.Windows.Forms.Label();
            this.Status_TB = new System.Windows.Forms.TextBox();
            this.Reset_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Coffee_LB
            // 
            this.Coffee_LB.AutoSize = true;
            this.Coffee_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Coffee_LB.Location = new System.Drawing.Point(83, 152);
            this.Coffee_LB.Name = "Coffee_LB";
            this.Coffee_LB.Size = new System.Drawing.Size(39, 16);
            this.Coffee_LB.TabIndex = 0;
            this.Coffee_LB.Text = "커피";
            this.Coffee_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Egg_LB
            // 
            this.Egg_LB.AutoSize = true;
            this.Egg_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Egg_LB.Location = new System.Drawing.Point(83, 189);
            this.Egg_LB.Name = "Egg_LB";
            this.Egg_LB.Size = new System.Drawing.Size(39, 16);
            this.Egg_LB.TabIndex = 1;
            this.Egg_LB.Text = "계란";
            this.Egg_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Toast_LB
            // 
            this.Toast_LB.AutoSize = true;
            this.Toast_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Toast_LB.Location = new System.Drawing.Point(77, 267);
            this.Toast_LB.Name = "Toast_LB";
            this.Toast_LB.Size = new System.Drawing.Size(55, 16);
            this.Toast_LB.TabIndex = 2;
            this.Toast_LB.Text = "토스트";
            this.Toast_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Butter_LB
            // 
            this.Butter_LB.AutoSize = true;
            this.Butter_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Butter_LB.Location = new System.Drawing.Point(86, 304);
            this.Butter_LB.Name = "Butter_LB";
            this.Butter_LB.Size = new System.Drawing.Size(39, 16);
            this.Butter_LB.TabIndex = 3;
            this.Butter_LB.Text = "버터";
            this.Butter_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Jam_LB
            // 
            this.Jam_LB.AutoSize = true;
            this.Jam_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Jam_LB.Location = new System.Drawing.Point(93, 342);
            this.Jam_LB.Name = "Jam_LB";
            this.Jam_LB.Size = new System.Drawing.Size(23, 16);
            this.Jam_LB.TabIndex = 4;
            this.Jam_LB.Text = "잼";
            this.Jam_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OJ_LB
            // 
            this.OJ_LB.AutoSize = true;
            this.OJ_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OJ_LB.Location = new System.Drawing.Point(61, 378);
            this.OJ_LB.Name = "OJ_LB";
            this.OJ_LB.Size = new System.Drawing.Size(87, 16);
            this.OJ_LB.TabIndex = 5;
            this.OJ_LB.Text = "오렌지쥬스";
            this.OJ_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lv1_Btn
            // 
            this.lv1_Btn.Location = new System.Drawing.Point(28, 29);
            this.lv1_Btn.Name = "lv1_Btn";
            this.lv1_Btn.Size = new System.Drawing.Size(75, 23);
            this.lv1_Btn.TabIndex = 7;
            this.lv1_Btn.Text = "Level1";
            this.lv1_Btn.UseVisualStyleBackColor = true;
            this.lv1_Btn.Click += new System.EventHandler(this.lv1_Btn_Click);
            // 
            // lv2_Btn
            // 
            this.lv2_Btn.Location = new System.Drawing.Point(109, 29);
            this.lv2_Btn.Name = "lv2_Btn";
            this.lv2_Btn.Size = new System.Drawing.Size(75, 23);
            this.lv2_Btn.TabIndex = 8;
            this.lv2_Btn.Text = "Level2";
            this.lv2_Btn.UseVisualStyleBackColor = true;
            this.lv2_Btn.Click += new System.EventHandler(this.lv2_Btn_Click);
            // 
            // lv3_Btn
            // 
            this.lv3_Btn.Location = new System.Drawing.Point(28, 58);
            this.lv3_Btn.Name = "lv3_Btn";
            this.lv3_Btn.Size = new System.Drawing.Size(75, 23);
            this.lv3_Btn.TabIndex = 9;
            this.lv3_Btn.Text = "Level3";
            this.lv3_Btn.UseVisualStyleBackColor = true;
            this.lv3_Btn.Click += new System.EventHandler(this.lv3_Btn_Click);
            // 
            // lv4_Btn
            // 
            this.lv4_Btn.Location = new System.Drawing.Point(109, 58);
            this.lv4_Btn.Name = "lv4_Btn";
            this.lv4_Btn.Size = new System.Drawing.Size(75, 23);
            this.lv4_Btn.TabIndex = 10;
            this.lv4_Btn.Text = "Level4";
            this.lv4_Btn.UseVisualStyleBackColor = true;
            this.lv4_Btn.Click += new System.EventHandler(this.lv4_Btn_Click);
            // 
            // Bacon_LB
            // 
            this.Bacon_LB.AutoSize = true;
            this.Bacon_LB.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Bacon_LB.Location = new System.Drawing.Point(77, 229);
            this.Bacon_LB.Name = "Bacon_LB";
            this.Bacon_LB.Size = new System.Drawing.Size(55, 16);
            this.Bacon_LB.TabIndex = 11;
            this.Bacon_LB.Text = "베이컨";
            this.Bacon_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status_TB
            // 
            this.Status_TB.Location = new System.Drawing.Point(209, 29);
            this.Status_TB.Multiline = true;
            this.Status_TB.Name = "Status_TB";
            this.Status_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Status_TB.Size = new System.Drawing.Size(244, 452);
            this.Status_TB.TabIndex = 12;
            // 
            // Reset_Btn
            // 
            this.Reset_Btn.Location = new System.Drawing.Point(28, 87);
            this.Reset_Btn.Name = "Reset_Btn";
            this.Reset_Btn.Size = new System.Drawing.Size(75, 23);
            this.Reset_Btn.TabIndex = 13;
            this.Reset_Btn.Text = "Reset";
            this.Reset_Btn.UseVisualStyleBackColor = true;
            this.Reset_Btn.Click += new System.EventHandler(this.Reset_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 498);
            this.Controls.Add(this.Reset_Btn);
            this.Controls.Add(this.Status_TB);
            this.Controls.Add(this.Bacon_LB);
            this.Controls.Add(this.lv4_Btn);
            this.Controls.Add(this.lv3_Btn);
            this.Controls.Add(this.lv2_Btn);
            this.Controls.Add(this.lv1_Btn);
            this.Controls.Add(this.OJ_LB);
            this.Controls.Add(this.Jam_LB);
            this.Controls.Add(this.Butter_LB);
            this.Controls.Add(this.Toast_LB);
            this.Controls.Add(this.Egg_LB);
            this.Controls.Add(this.Coffee_LB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Coffee_LB;
        private System.Windows.Forms.Label Egg_LB;
        private System.Windows.Forms.Label Toast_LB;
        private System.Windows.Forms.Label Butter_LB;
        private System.Windows.Forms.Label Jam_LB;
        private System.Windows.Forms.Label OJ_LB;
        private System.Windows.Forms.Button lv1_Btn;
        private System.Windows.Forms.Button lv2_Btn;
        private System.Windows.Forms.Button lv3_Btn;
        private System.Windows.Forms.Button lv4_Btn;
        private System.Windows.Forms.Label Bacon_LB;
        private System.Windows.Forms.TextBox Status_TB;
        private System.Windows.Forms.Button Reset_Btn;
    }
}

