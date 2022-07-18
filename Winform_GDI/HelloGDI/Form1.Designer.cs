namespace HelloGDI
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
            this.Btn_DrawLine = new System.Windows.Forms.Button();
            this.Btn_FormClear = new System.Windows.Forms.Button();
            this.Btn_DrawEllipse = new System.Windows.Forms.Button();
            this.Btn_DrawRectangle = new System.Windows.Forms.Button();
            this.Btn_DrawString = new System.Windows.Forms.Button();
            this.Btn_DrawImage = new System.Windows.Forms.Button();
            this.Pn_DrawImage = new System.Windows.Forms.Panel();
            this.Btn_DrawFillEllipse = new System.Windows.Forms.Button();
            this.Btn_DrawFillRectangle = new System.Windows.Forms.Button();
            this.Btn_CreateNewRegion = new System.Windows.Forms.Button();
            this.Btn_Test = new System.Windows.Forms.Button();
            this.Btn_CreateNewRectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DrawLine
            // 
            this.Btn_DrawLine.Location = new System.Drawing.Point(563, 12);
            this.Btn_DrawLine.Name = "Btn_DrawLine";
            this.Btn_DrawLine.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawLine.TabIndex = 0;
            this.Btn_DrawLine.Text = "DrawLine";
            this.Btn_DrawLine.UseVisualStyleBackColor = true;
            this.Btn_DrawLine.Click += new System.EventHandler(this.Btn_DrawLine_Click);
            // 
            // Btn_FormClear
            // 
            this.Btn_FormClear.Location = new System.Drawing.Point(563, 315);
            this.Btn_FormClear.Name = "Btn_FormClear";
            this.Btn_FormClear.Size = new System.Drawing.Size(161, 23);
            this.Btn_FormClear.TabIndex = 1;
            this.Btn_FormClear.Text = "Clear";
            this.Btn_FormClear.UseVisualStyleBackColor = true;
            this.Btn_FormClear.Click += new System.EventHandler(this.Btn_FormClear_Click);
            // 
            // Btn_DrawEllipse
            // 
            this.Btn_DrawEllipse.Location = new System.Drawing.Point(563, 41);
            this.Btn_DrawEllipse.Name = "Btn_DrawEllipse";
            this.Btn_DrawEllipse.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawEllipse.TabIndex = 2;
            this.Btn_DrawEllipse.Text = "DrawEllipse";
            this.Btn_DrawEllipse.UseVisualStyleBackColor = true;
            this.Btn_DrawEllipse.Click += new System.EventHandler(this.Btn_DrawEllipse_Click);
            // 
            // Btn_DrawRectangle
            // 
            this.Btn_DrawRectangle.Location = new System.Drawing.Point(563, 99);
            this.Btn_DrawRectangle.Name = "Btn_DrawRectangle";
            this.Btn_DrawRectangle.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawRectangle.TabIndex = 3;
            this.Btn_DrawRectangle.Text = "DrawRectangle";
            this.Btn_DrawRectangle.UseVisualStyleBackColor = true;
            this.Btn_DrawRectangle.Click += new System.EventHandler(this.Btn_DrawRectangle_Click);
            // 
            // Btn_DrawString
            // 
            this.Btn_DrawString.Location = new System.Drawing.Point(563, 157);
            this.Btn_DrawString.Name = "Btn_DrawString";
            this.Btn_DrawString.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawString.TabIndex = 4;
            this.Btn_DrawString.Text = "DrawString";
            this.Btn_DrawString.UseVisualStyleBackColor = true;
            this.Btn_DrawString.Click += new System.EventHandler(this.Btn_DrawString_Click);
            // 
            // Btn_DrawImage
            // 
            this.Btn_DrawImage.Location = new System.Drawing.Point(563, 186);
            this.Btn_DrawImage.Name = "Btn_DrawImage";
            this.Btn_DrawImage.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawImage.TabIndex = 5;
            this.Btn_DrawImage.Text = "DrawImage";
            this.Btn_DrawImage.UseVisualStyleBackColor = true;
            this.Btn_DrawImage.Click += new System.EventHandler(this.Btn_DrawImage_Click);
            // 
            // Pn_DrawImage
            // 
            this.Pn_DrawImage.Location = new System.Drawing.Point(315, 12);
            this.Pn_DrawImage.Name = "Pn_DrawImage";
            this.Pn_DrawImage.Size = new System.Drawing.Size(242, 326);
            this.Pn_DrawImage.TabIndex = 6;
            // 
            // Btn_DrawFillEllipse
            // 
            this.Btn_DrawFillEllipse.Location = new System.Drawing.Point(563, 70);
            this.Btn_DrawFillEllipse.Name = "Btn_DrawFillEllipse";
            this.Btn_DrawFillEllipse.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawFillEllipse.TabIndex = 7;
            this.Btn_DrawFillEllipse.Text = "DrawFillEllipse";
            this.Btn_DrawFillEllipse.UseVisualStyleBackColor = true;
            this.Btn_DrawFillEllipse.Click += new System.EventHandler(this.Btn_DrawFillEllipse_Click);
            // 
            // Btn_DrawFillRectangle
            // 
            this.Btn_DrawFillRectangle.Location = new System.Drawing.Point(563, 128);
            this.Btn_DrawFillRectangle.Name = "Btn_DrawFillRectangle";
            this.Btn_DrawFillRectangle.Size = new System.Drawing.Size(161, 23);
            this.Btn_DrawFillRectangle.TabIndex = 8;
            this.Btn_DrawFillRectangle.Text = "DrawFillRectangle";
            this.Btn_DrawFillRectangle.UseVisualStyleBackColor = true;
            this.Btn_DrawFillRectangle.Click += new System.EventHandler(this.Btn_DrawFillRectangle_Click);
            // 
            // Btn_CreateNewRegion
            // 
            this.Btn_CreateNewRegion.Location = new System.Drawing.Point(563, 215);
            this.Btn_CreateNewRegion.Name = "Btn_CreateNewRegion";
            this.Btn_CreateNewRegion.Size = new System.Drawing.Size(161, 23);
            this.Btn_CreateNewRegion.TabIndex = 9;
            this.Btn_CreateNewRegion.Text = "CreateNewRegion";
            this.Btn_CreateNewRegion.UseVisualStyleBackColor = true;
            this.Btn_CreateNewRegion.Click += new System.EventHandler(this.Btn_CreateNewRegion_Click);
            // 
            // Btn_Test
            // 
            this.Btn_Test.Location = new System.Drawing.Point(211, 315);
            this.Btn_Test.Name = "Btn_Test";
            this.Btn_Test.Size = new System.Drawing.Size(98, 23);
            this.Btn_Test.TabIndex = 10;
            this.Btn_Test.Text = "Test Button";
            this.Btn_Test.UseVisualStyleBackColor = true;
            // 
            // Btn_CreateNewRectangle
            // 
            this.Btn_CreateNewRectangle.Location = new System.Drawing.Point(563, 244);
            this.Btn_CreateNewRectangle.Name = "Btn_CreateNewRectangle";
            this.Btn_CreateNewRectangle.Size = new System.Drawing.Size(161, 23);
            this.Btn_CreateNewRectangle.TabIndex = 11;
            this.Btn_CreateNewRectangle.Text = "CreateNewRectangle";
            this.Btn_CreateNewRectangle.UseVisualStyleBackColor = true;
            this.Btn_CreateNewRectangle.Click += new System.EventHandler(this.Btn_CreateNewRectangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 344);
            this.Controls.Add(this.Btn_CreateNewRectangle);
            this.Controls.Add(this.Btn_Test);
            this.Controls.Add(this.Btn_CreateNewRegion);
            this.Controls.Add(this.Btn_DrawFillRectangle);
            this.Controls.Add(this.Btn_DrawFillEllipse);
            this.Controls.Add(this.Pn_DrawImage);
            this.Controls.Add(this.Btn_DrawImage);
            this.Controls.Add(this.Btn_DrawString);
            this.Controls.Add(this.Btn_DrawRectangle);
            this.Controls.Add(this.Btn_DrawEllipse);
            this.Controls.Add(this.Btn_FormClear);
            this.Controls.Add(this.Btn_DrawLine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DrawLine;
        private System.Windows.Forms.Button Btn_FormClear;
        private System.Windows.Forms.Button Btn_DrawEllipse;
        private System.Windows.Forms.Button Btn_DrawRectangle;
        private System.Windows.Forms.Button Btn_DrawString;
        private System.Windows.Forms.Button Btn_DrawImage;
        private System.Windows.Forms.Panel Pn_DrawImage;
        private System.Windows.Forms.Button Btn_DrawFillEllipse;
        private System.Windows.Forms.Button Btn_DrawFillRectangle;
        private System.Windows.Forms.Button Btn_CreateNewRegion;
        private System.Windows.Forms.Button Btn_Test;
        private System.Windows.Forms.Button Btn_CreateNewRectangle;
    }
}

