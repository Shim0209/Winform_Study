namespace ComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboSimple = new System.Windows.Forms.ComboBox();
            this.comboDropDown = new System.Windows.Forms.ComboBox();
            this.comboDropDownList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSimple
            // 
            this.comboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboSimple.FormattingEnabled = true;
            this.comboSimple.Location = new System.Drawing.Point(12, 143);
            this.comboSimple.Name = "comboSimple";
            this.comboSimple.Size = new System.Drawing.Size(121, 150);
            this.comboSimple.TabIndex = 0;
            // 
            // comboDropDown
            // 
            this.comboDropDown.FormattingEnabled = true;
            this.comboDropDown.Location = new System.Drawing.Point(139, 143);
            this.comboDropDown.Name = "comboDropDown";
            this.comboDropDown.Size = new System.Drawing.Size(121, 23);
            this.comboDropDown.TabIndex = 1;
            this.comboDropDown.SelectedIndexChanged += new System.EventHandler(this.comboDropDown_SelectedIndexChanged);
            // 
            // comboDropDownList
            // 
            this.comboDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDropDownList.FormattingEnabled = true;
            this.comboDropDownList.Location = new System.Drawing.Point(266, 143);
            this.comboDropDownList.Name = "comboDropDownList";
            this.comboDropDownList.Size = new System.Drawing.Size(121, 23);
            this.comboDropDownList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Simple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "DropDown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DropDownList";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDropDownList);
            this.Controls.Add(this.comboDropDown);
            this.Controls.Add(this.comboSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSimple;
        private System.Windows.Forms.ComboBox comboDropDown;
        private System.Windows.Forms.ComboBox comboDropDownList;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}