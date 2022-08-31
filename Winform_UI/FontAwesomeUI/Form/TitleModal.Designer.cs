namespace FontAwesomeUI
{
    partial class TitleModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.btnSetTitle = new System.Windows.Forms.Button();
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "[ 실험명 설정 ]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.ForeColor = System.Drawing.Color.Black;
            this.textBoxTitle.Location = new System.Drawing.Point(9, 43);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(212, 23);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Location = new System.Drawing.Point(9, 75);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(212, 33);
            this.comboBoxTitle.TabIndex = 2;
            this.comboBoxTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxTitle_SelectedIndexChanged);
            // 
            // btnSetTitle
            // 
            this.btnSetTitle.BackColor = System.Drawing.Color.White;
            this.btnSetTitle.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSetTitle.FlatAppearance.BorderSize = 0;
            this.btnSetTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnSetTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnSetTitle.Location = new System.Drawing.Point(9, 116);
            this.btnSetTitle.Name = "btnSetTitle";
            this.btnSetTitle.Size = new System.Drawing.Size(212, 47);
            this.btnSetTitle.TabIndex = 3;
            this.btnSetTitle.Text = "실험명으로 설정";
            this.btnSetTitle.UseVisualStyleBackColor = false;
            this.btnSetTitle.Click += new System.EventHandler(this.btnSetTitle_Click);
            // 
            // btnDeleteTitle
            // 
            this.btnDeleteTitle.BackColor = System.Drawing.Color.White;
            this.btnDeleteTitle.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDeleteTitle.FlatAppearance.BorderSize = 0;
            this.btnDeleteTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnDeleteTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
            this.btnDeleteTitle.Location = new System.Drawing.Point(9, 172);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(212, 47);
            this.btnDeleteTitle.TabIndex = 4;
            this.btnDeleteTitle.Text = "선택된 실험명 삭제";
            this.btnDeleteTitle.UseVisualStyleBackColor = false;
            this.btnDeleteTitle.Click += new System.EventHandler(this.btnDeleteTitle_Click);
            // 
            // TitleModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(228, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.btnSetTitle);
            this.Controls.Add(this.btnDeleteTitle);
            this.Name = "TitleModal";
            this.Text = "실험명 설정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.Button btnSetTitle;
        private System.Windows.Forms.Button btnDeleteTitle;
    }
}