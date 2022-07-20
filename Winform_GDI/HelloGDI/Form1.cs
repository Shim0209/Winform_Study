using RectTrackerSharp;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

// [[ Graphics객체를 만드는 방법 ]]
//      1. Form의 Paint 이벤트
//          Graphics객체를 만들어 PaintEventArgs의 Graphics를 참조
//          graphics = e.Graphics;
//      2. CreateGraphics 메서드
//          g = this.CreateGraphics();
//      3. 이미지 개체에서 만들기
//          Bitmap myBitmap = new Bitmap(@"C:\Documents and Settings\Joe\Pics\myPic.bmp");
//          Graphics g = Graphics.FromImage(myBitmap);
//
// [[ Graphics객체로 도형, 이미지 그리기 및 조작 ]]
//      pen 클래스 - 선을 그리거나, 도형을 간략하게 표시하거나, 다른 기하학적 표현을 렌더링하는데 사용됨.
//      Brush 클래스 - 채워진 도형, 이미지 또는 텍스트와 같은 그래픽 영역을 채우는데 사용됨.
//      Font 클래스 - 텍스트를 렌더링할 때 사용할 도형에 대한 설명을 제공함.
//      Color 클래스 - 표시할 다른 색을 나타냄.
//
// [[ 리소스 해제 ]]
//      시스템 리소스를 사용하는 모든 객체에서 항상 Dispose를 출력해야 한다.
namespace HelloGDI
{
    public partial class Form1 : Form
    {
        RectTracker CSharpTracker;
        MyRectTracker MyRectTracker;

        public Form1()
        {
            InitializeComponent();
        }

        #region FormClear
        private void Btn_FormClear_Click(object sender, EventArgs e)
        {
            Graphics FormGraphics = this.CreateGraphics();
            Graphics PanelGraphics = Pn_DrawImage.CreateGraphics();

            FormGraphics.Clear(this.BackColor);
            PanelGraphics.Clear(this.BackColor);

            FormGraphics.Dispose();
            PanelGraphics.Dispose();
        }
        #endregion

        #region DrawLine
        private void Btn_DrawLine_Click(object sender, EventArgs e)
        {
            DrawLine();
        }
        private void DrawLine()
        {
            // 생성
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            
            // 그리기
            graphics.DrawLine(pen, 20, 10, 300, 100);

            // 해제
            pen.Dispose();
            graphics.Dispose();
        }
        #endregion

        #region DrawEllipse
        private void Btn_DrawEllipse_Click(object sender, EventArgs e)
        {
            DrawEllipse("Default");
        }
        private void Btn_DrawFillEllipse_Click(object sender, EventArgs e)
        {
            DrawEllipse("Fill");
        }
        private void DrawEllipse(string flag)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen;
            Brush brush;

            if(flag == "Default")
            {
                pen = new Pen(Color.DarkBlue);
                graphics.DrawEllipse(pen, new Rectangle(0, 0, 200, 300));
                pen.Dispose();
            }
            else if(flag == "Fill")
            {
                brush = new SolidBrush(Color.DarkBlue);
                graphics.FillEllipse(brush, new Rectangle(0, 0, 200, 300));
                brush.Dispose();
            }

            graphics.Dispose();
        }
        #endregion

        #region DrawRectangle
        private void Btn_DrawRectangle_Click(object sender, EventArgs e)
        {
            DrawRectangle("Default");
        }
        private void Btn_DrawFillRectangle_Click(object sender, EventArgs e)
        {
            DrawRectangle("Fill");
        }
        private void DrawRectangle(string flag)
        {
            Graphics graphics = this.CreateGraphics();
            Pen pen;
            Brush brush;

            // 그리기
            if(flag == "Default")
            {
                pen = new Pen(Color.Red);
                graphics.DrawRectangle(pen, new Rectangle(0, 0, 200, 300));
                pen.Dispose();
            }
            else if(flag == "Fill")
            {
                brush = new SolidBrush(Color.Red);
                graphics.FillRectangle(brush, new Rectangle(0, 0, 200, 300));
                brush.Dispose();
            }

            graphics.Dispose();
        }
        
        #endregion

        #region DrawString
        private void Btn_DrawString_Click(object sender, EventArgs e)
        {
            DrawString();
        }
        private void DrawString()
        {
            // 생성
            Graphics graphics = this.CreateGraphics();
            Font font = new Font("Arial", 16);
            Brush brush = new SolidBrush(Color.Black);
            StringFormat stringFormat = new StringFormat();

            // 준비
            string text = "Sample Text";
            float x = 150.0F;
            float y = 50.0F;

            // 그리기
            graphics.DrawString(text, font, brush, x, y, stringFormat);

            // 해제
            stringFormat.Dispose();
            brush.Dispose();
            font.Dispose();
            graphics.Dispose();
        }
        #endregion

        #region DrawImage
        private void Btn_DrawImage_Click(object sender, EventArgs e)
        {
            DrawImage();
        }

        private void DrawImage()
        {
            // 생성
            Graphics graphics = Pn_DrawImage.CreateGraphics(); // Panel의 Graphics로 생성
            Bitmap bitmap = new Bitmap($"C:\\Users\\DPS7\\Desktop\\dd2.png");

            // 그리기
            graphics.DrawImage(bitmap, 1, 1);

            // 해제
            bitmap.Dispose();
            graphics.Dispose();
        }


        #endregion

        #region CreateNewRegion
        private void Btn_CreateNewRegion_Click(object sender, EventArgs e)
        {
            CreateNewRegion();
        }
        private void CreateNewRegion()
        {
            GraphicsPath shape = new GraphicsPath();
            shape.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(shape);

            shape.Dispose();
        }
        #endregion

        #region CreateNewRectangle
        private void Btn_CreateNewRectangle_Click(object sender, EventArgs e)
        {
            CreateNewRectangle();
        }

        private void CreateNewRectangle()
        {
            Size Sqare = new Size(6, 6);

            /*int X = Btn_Test.Bounds.X - Sqare.Width;
            int Y = Btn_Test.Bounds.Y - Sqare.Height;
            int Height = Btn_Test.Bounds.Height + (Sqare.Height * 2);
            int Width = Btn_Test.Bounds.Width + (Sqare.Width * 2);

            this.Bounds = new Rectangle(X, Y, Width + 1, Height + 1);

            this.BringToFront();*/

            GraphicsPath shape = new GraphicsPath();

            // 두께가 있는 작은 사각형을 좌우상하로 만들어 배치 (선의 두께를 위해서?)
            // Top
            shape.AddRectangle(new Rectangle(0,0, Btn_Test.Width + (Sqare.Width*2)+1, Sqare.Height+1));
            // Left
            shape.AddRectangle(new Rectangle(0, Sqare.Height+1, Sqare.Width + 1, Btn_Test.Bounds.Height + Sqare.Height+1));
            // Bottom
            shape.AddRectangle(new Rectangle(Sqare.Width + 1, Btn_Test.Bounds.Height + Sqare.Height + 1, Btn_Test.Width, Sqare.Height + 1));
            // Right
            shape.AddRectangle(new Rectangle(Btn_Test.Width + Sqare.Width, Sqare.Height+1, Sqare.Width+1, Btn_Test.Bounds.Height+ Sqare.Height+1));

            this.Region = new Region(shape);

            shape.Dispose();
        }

        #endregion

        private void Btn_ROI_Click(object sender, EventArgs e)
        {
            Button ROI_Area = new Button();
            Label label = new Label();
            


            ROI_Area.BringToFront();

            ROI_Area.Capture = false;

            if (this.Controls.Contains(CSharpTracker))
                this.Controls.Remove(CSharpTracker);
            CSharpTracker = new RectTracker((Control)ROI_Area);
            label = CSharpTracker.roiLabel;
            label.Text = "hi";
            label.Parent = Pn_DrawImage;

            this.Controls.Add(CSharpTracker);
            CSharpTracker.BringToFront();
            CSharpTracker.Draw(Pn_DrawImage, Brushes.BlueViolet);
        }

        private void Btn_ROI2_Click(object sender, EventArgs e)
        {
            Button ROI_Control = new Button();

            ROI_Control.BringToFront();
            ROI_Control.Capture = false;

            if (this.Controls.Contains(MyRectTracker))
                this.Controls.Remove(MyRectTracker);
            MyRectTracker = new MyRectTracker((Control)ROI_Control);

            this.Controls.Add(MyRectTracker);
            MyRectTracker.BringToFront();
            MyRectTracker.Draw(Pn_DrawImage, Brushes.Blue);
        }
    }
}
