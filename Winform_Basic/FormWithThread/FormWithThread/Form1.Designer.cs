namespace FormWithThread
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
            this.Sub0ThreadTB = new System.Windows.Forms.TextBox();
            this.Sub1ThreadTB = new System.Windows.Forms.TextBox();
            this.OnBtn = new System.Windows.Forms.Button();
            this.OffBtn = new System.Windows.Forms.Button();
            this.sub2ThreadTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sub1Thread = new System.Windows.Forms.Label();
            this.sub2Thread = new System.Windows.Forms.Label();
            this.CountBtn = new System.Windows.Forms.Button();
            this.RCountBtn = new System.Windows.Forms.Button();
            this.MainThreadTB = new System.Windows.Forms.TextBox();
            this.MainThreadTB2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sub0ThreadTB
            // 
            this.Sub0ThreadTB.Location = new System.Drawing.Point(12, 131);
            this.Sub0ThreadTB.Multiline = true;
            this.Sub0ThreadTB.Name = "Sub0ThreadTB";
            this.Sub0ThreadTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sub0ThreadTB.Size = new System.Drawing.Size(219, 318);
            this.Sub0ThreadTB.TabIndex = 2;
            // 
            // Sub1ThreadTB
            // 
            this.Sub1ThreadTB.Location = new System.Drawing.Point(253, 131);
            this.Sub1ThreadTB.Multiline = true;
            this.Sub1ThreadTB.Name = "Sub1ThreadTB";
            this.Sub1ThreadTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Sub1ThreadTB.Size = new System.Drawing.Size(219, 151);
            this.Sub1ThreadTB.TabIndex = 6;
            // 
            // OnBtn
            // 
            this.OnBtn.Location = new System.Drawing.Point(30, 78);
            this.OnBtn.Name = "OnBtn";
            this.OnBtn.Size = new System.Drawing.Size(75, 23);
            this.OnBtn.TabIndex = 10;
            this.OnBtn.Text = "ON";
            this.OnBtn.UseVisualStyleBackColor = true;
            this.OnBtn.Click += new System.EventHandler(this.OnBtn_Click);
            // 
            // OffBtn
            // 
            this.OffBtn.Location = new System.Drawing.Point(117, 78);
            this.OffBtn.Name = "OffBtn";
            this.OffBtn.Size = new System.Drawing.Size(75, 23);
            this.OffBtn.TabIndex = 11;
            this.OffBtn.Text = "OFF";
            this.OffBtn.UseVisualStyleBackColor = true;
            this.OffBtn.Click += new System.EventHandler(this.OffBtn_Click);
            // 
            // sub2ThreadTB
            // 
            this.sub2ThreadTB.Location = new System.Drawing.Point(253, 298);
            this.sub2ThreadTB.Multiline = true;
            this.sub2ThreadTB.Name = "sub2ThreadTB";
            this.sub2ThreadTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sub2ThreadTB.Size = new System.Drawing.Size(219, 151);
            this.sub2ThreadTB.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sub00 Thread";
            // 
            // Sub1Thread
            // 
            this.Sub1Thread.AutoSize = true;
            this.Sub1Thread.Location = new System.Drawing.Point(251, 113);
            this.Sub1Thread.Name = "Sub1Thread";
            this.Sub1Thread.Size = new System.Drawing.Size(83, 12);
            this.Sub1Thread.TabIndex = 14;
            this.Sub1Thread.Text = "Sub01 Thread";
            // 
            // sub2Thread
            // 
            this.sub2Thread.AutoSize = true;
            this.sub2Thread.Location = new System.Drawing.Point(251, 285);
            this.sub2Thread.Name = "sub2Thread";
            this.sub2Thread.Size = new System.Drawing.Size(83, 12);
            this.sub2Thread.TabIndex = 15;
            this.sub2Thread.Text = "Sub02 Thread";
            // 
            // CountBtn
            // 
            this.CountBtn.Location = new System.Drawing.Point(253, 78);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(75, 23);
            this.CountBtn.TabIndex = 3;
            this.CountBtn.Text = "Count";
            this.CountBtn.UseVisualStyleBackColor = true;
            // 
            // RCountBtn
            // 
            this.RCountBtn.Location = new System.Drawing.Point(349, 78);
            this.RCountBtn.Name = "RCountBtn";
            this.RCountBtn.Size = new System.Drawing.Size(75, 23);
            this.RCountBtn.TabIndex = 7;
            this.RCountBtn.Text = "RCount";
            this.RCountBtn.UseVisualStyleBackColor = true;
            // 
            // MainThreadTB
            // 
            this.MainThreadTB.Location = new System.Drawing.Point(30, 36);
            this.MainThreadTB.Name = "MainThreadTB";
            this.MainThreadTB.Size = new System.Drawing.Size(162, 21);
            this.MainThreadTB.TabIndex = 16;
            this.MainThreadTB.TextChanged += new System.EventHandler(this.MainThreadTB_TextChanged);
            // 
            // MainThreadTB2
            // 
            this.MainThreadTB2.Location = new System.Drawing.Point(208, 12);
            this.MainThreadTB2.Multiline = true;
            this.MainThreadTB2.Name = "MainThreadTB2";
            this.MainThreadTB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainThreadTB2.Size = new System.Drawing.Size(264, 60);
            this.MainThreadTB2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "Main Thread";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MainThreadTB2);
            this.Controls.Add(this.MainThreadTB);
            this.Controls.Add(this.sub2Thread);
            this.Controls.Add(this.Sub1Thread);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sub2ThreadTB);
            this.Controls.Add(this.OffBtn);
            this.Controls.Add(this.OnBtn);
            this.Controls.Add(this.RCountBtn);
            this.Controls.Add(this.Sub1ThreadTB);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.Sub0ThreadTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Sub0ThreadTB;
        private System.Windows.Forms.TextBox Sub1ThreadTB;
        private System.Windows.Forms.Button OnBtn;
        private System.Windows.Forms.Button OffBtn;
        private System.Windows.Forms.TextBox sub2ThreadTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Sub1Thread;
        private System.Windows.Forms.Label sub2Thread;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Button RCountBtn;
        private System.Windows.Forms.TextBox MainThreadTB;
        private System.Windows.Forms.TextBox MainThreadTB2;
        private System.Windows.Forms.Label label2;
    }
}

