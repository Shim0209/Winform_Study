using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System;

namespace RectTrackerSharp
{
    public partial class RectTracker : UserControl
    {
        // 현재 컨트롤
        Control currentControl;

        // 디폴트 점 
        Rectangle baseRect;

        // 경계선 위 점 8개 값
        Rectangle[] SmallRect = new Rectangle[8];

        // 외곽 경계선을 갖는 사각형
        Rectangle ControlRect;

        // 점 크기
        Size Sqare = new Size(6,6);

        // 그래픽 객체
        Graphics graphics;

        // 폼에서 사전에 마우스 왼쪽 클릭한 위치 값을 저장
        // 이 값으로 움직인 값을 계산한다.
        private Point prevLeftClick;

        // 첫 드래그 인지를 판별
        private bool isFirst = true;

        // 현재 마우스 위치 크기 조정
        private RESIZE_BORDER CurrBorder;

        // 컨트롤 크기의 사각형과 외곽 경계선 위의 점8개
        public Rectangle Rect
        {
            get { return baseRect; }
            set
            {
                int X = Sqare.Width;
                int Y = Sqare.Height;
                int Height = value.Height;
                int Width = value.Width;
                baseRect = new Rectangle(X, Y, Width, Height);

                // 점 8개 설정
                SetRectangles();
            }
        }

        // 박스의 크기를 조정할 테두리를 추적
        enum RESIZE_BORDER
        {
            RB_NONE = 0,
            RB_TOP = 1,
            RB_RIGHT = 2,
            RB_BOTTOM = 3,
            RB_LEFT = 4,
            RB_TOPLEFT = 5,
            RB_TOPRIGHT = 6,
            RB_BOTTOMLEFT = 7,
            RB_BOTTOMRIGHT = 8
        }

        // 트랙커 사각형 위에 있는 점 8개
        void SetRectangles()
        {
            // TopLeft
            SmallRect[0] = new Rectangle(new Point(baseRect.X - Sqare.Width, baseRect.Y - Sqare.Height), Sqare);

            // TopRight
            SmallRect[1] = new Rectangle(new Point(baseRect.X + baseRect.Width, baseRect.Y - Sqare.Height), Sqare);

            // BottomLeft
            SmallRect[2] = new Rectangle(new Point(baseRect.X - Sqare.Width, baseRect.Y + baseRect.Height), Sqare);

            // BottomRight
            SmallRect[3] = new Rectangle(new Point(baseRect.X + baseRect.Width, baseRect.Y + baseRect.Height), Sqare);

            // TopMiddle
            SmallRect[4] = new Rectangle(new Point(baseRect.X + ((baseRect.Width / 2) - (Sqare.Width / 2)), baseRect.Y - Sqare.Height), Sqare);

            // BottomMiddle
            SmallRect[5] = new Rectangle(new Point(baseRect.X + ((baseRect.Width / 2) - (Sqare.Width / 2)), baseRect.Y + Sqare.Height), Sqare);

            // LeftMiddle
            SmallRect[6] = new Rectangle(new Point(baseRect.X - Sqare.Width, baseRect.Y + ((baseRect.Height / 2)-(Sqare.Height / 2))), Sqare);

            // RightMiddle
            SmallRect[7] = new Rectangle(new Point(baseRect.X + baseRect.Width, baseRect.Y + ((baseRect.Height / 2) - (Sqare.Height / 2))), Sqare);

            // 외곽 경계선 사각형
            ControlRect = new Rectangle(new Point(0, 0), this.Bounds.Size);
        }

        // 
        private GraphicsPath BuildFrame()
        {
            //make the tracker to "contain" the control like this:
            //
            //+++++++++++++++++++++++
            //+						+
            //+						+
            //+	 	 CONTROL		+
            //+						+
            //+						+
            //+++++++++++++++++++++++
            //
            GraphicsPath path = new GraphicsPath();

            // Top Rectangle
            path.AddRectangle(new Rectangle(0,0, currentControl.Width + (Sqare.Width*2)+1, Sqare.Height+1));

            // Left Rectangle
            path.AddRectangle(new Rectangle(0, Sqare.Height+1, Sqare.Width + 1, currentControl.Bounds.Height + Sqare.Height+1));

            // Bottom Rectangle
            path.AddRectangle(new Rectangle(Sqare.Width+1, currentControl.Bounds.Height + Sqare.Height, currentControl.Width + Sqare.Width + 1, Sqare.Height + 1));

            // Right Rectangle
            path.AddRectangle(new Rectangle(currentControl.Bounds.Width + Sqare.Width, Sqare.Height+1, Sqare.Width + 1, currentControl.Height - 2));

            return path;
        }

        public Control Control
        {
            get { return currentControl; }
            set 
            { 
                //currentControl = value;
                //Rect = currentControl.Bounds;
            }
        }

        public RectTracker(Control theControl)
        {
            InitializeComponent();

            currentControl = theControl;

            Create();
        }
        public RectTracker()
        {
            InitializeComponent();
        }
        private void Create()
        {
            // 컨트롤 외곽 사각형의 시작점과 가로/세로 길이
            int x = currentControl.Bounds.X - Sqare.Width;
            int y = currentControl.Bounds.Y - Sqare.Height;
            int Width = currentControl.Bounds.Width + (Sqare.Width * 2);
            int Height = currentControl.Bounds.Height + (Sqare.Height * 2);

            // 컨트롤 외곽 경계선 사각형
            this.Bounds = new Rectangle(x, y, Width+1, Height+1);

            this.BringToFront();

            // 컨트롤 경계선 사각형 + 외곽 경계선위의 점 8개
            Rect = currentControl.Bounds;

            // 컨트롤 주변에 투명한 영역을 만든다
            this.Region = new Region(BuildFrame());

            // 그래픽 객체 만들기
            graphics = this.CreateGraphics();
        }


        // Mouse 이벤트

        // Hit

        // 
        public void Draw()
        {
            try
            {
                graphics.FillRectangles(Brushes.White, SmallRect);

                graphics.DrawRectangles(Pens.Black, SmallRect);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // 마우스 포인터가 컨트롤 위에 있을때, 마우스로 눌렀다가 놓으면 MouseUp 이벤트가 발생
        private void RectTracker_MouseUp(object sender, MouseEventArgs e)
        {
            Create();
            this.Visible = true;
        }

        // 컨트롤을 다시 그리면 발생
        private void RectTracker_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }

        private void RectTracker_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;

            if(e.Button == MouseButtons.Left)
            {
                if (isFirst)
                {
                    // 위치 값을 저장
                    prevLeftClick = new Point(e.X, e.Y);

                    // 마우스 왼쪽 클릭이 해제되거나, 다른 마우스 클릭이 발생하기까지 후속 마우스 이동 이벤트는 처음처럼 처리되지 않는다.
                    isFirst = false;
                }
                else
                {
                    // 트랙커 숨기기
                    this.Visible = false;

                    Mouse_Move(this, e);

                    // 이동된 새로운 위치 값으로 갱신한다.
                    prevLeftClick = new Point(e.X, e.Y);
                }
            }
            else
            {
                isFirst = true;
                this.Visible = true;

                Hit_Test(new Point(e.X, e.Y));
            }
        }

        public void Mouse_Move(object sender, MouseEventArgs e)
        {
            // 컨트롤의 최소 크기는 8x8이다.
            if(currentControl.Height < 8)
            {
                currentControl.Height = 8;
                return; 
            }
            else if(currentControl.Width < 8)
            {
                currentControl.Width = 8;
                return;
            }

            switch (this.CurrBorder)
            {
                case RESIZE_BORDER.RB_TOP:
                    currentControl.Height = currentControl.Height - e.Y + prevLeftClick.Y;
                    if(currentControl.Height > 8)
                    {
                        currentControl.Top = currentControl.Top + e.Y - prevLeftClick.Y;
                    }
                    break;
                case RESIZE_BORDER.RB_TOPLEFT:

                    break;
                case RESIZE_BORDER.RB_TOPRIGHT:

                    break;
                case RESIZE_BORDER.RB_RIGHT:

                    break;
                case RESIZE_BORDER.RB_BOTTOM:

                    break;
                case RESIZE_BORDER.RB_BOTTOMLEFT:

                    break;
                case RESIZE_BORDER.RB_BOTTOMRIGHT:

                    break;
                case RESIZE_BORDER.RB_LEFT:

                    break;
                case RESIZE_BORDER.RB_NONE:

                    break;


            }
        }

        public bool Hit_Test(Point point)
        {

            return false;
        }
    }
}
