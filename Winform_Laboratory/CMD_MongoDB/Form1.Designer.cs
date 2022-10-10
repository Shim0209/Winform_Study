namespace CMD_MongoDB
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.tbResultView = new System.Windows.Forms.TextBox();
            this.tbHistory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 11);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(93, 11);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(543, 21);
            this.tbCommand.TabIndex = 2;
            // 
            // tbResultView
            // 
            this.tbResultView.Location = new System.Drawing.Point(93, 40);
            this.tbResultView.Multiline = true;
            this.tbResultView.Name = "tbResultView";
            this.tbResultView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultView.Size = new System.Drawing.Size(543, 307);
            this.tbResultView.TabIndex = 3;
            // 
            // tbHistory
            // 
            this.tbHistory.Location = new System.Drawing.Point(642, 40);
            this.tbHistory.Multiline = true;
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHistory.Size = new System.Drawing.Size(446, 305);
            this.tbHistory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Command History";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHistory);
            this.Controls.Add(this.tbResultView);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.TextBox tbResultView;
        private System.Windows.Forms.TextBox tbHistory;
        private System.Windows.Forms.Label label1;
    }
}

