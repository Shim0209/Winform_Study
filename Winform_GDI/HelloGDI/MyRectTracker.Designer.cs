﻿namespace HelloGDI
{
    partial class MyRectTracker
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
            this.Lb_Main = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lb_Main
            // 
            this.Lb_Main.AutoSize = true;
            this.Lb_Main.Location = new System.Drawing.Point(21, 15);
            this.Lb_Main.Name = "Lb_Main";
            this.Lb_Main.Size = new System.Drawing.Size(53, 12);
            this.Lb_Main.TabIndex = 0;
            this.Lb_Main.Text = "Lb_Main";
            // 
            // MyRectTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.Lb_Main);
            this.Name = "MyRectTracker";
            this.LocationChanged += new System.EventHandler(this.MyRectTracker_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.MyRectTracker_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.MyRectTracker_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MyRectTracker_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyRectTracker_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MyRectTracker_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyRectTracker_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Main;
    }
}
