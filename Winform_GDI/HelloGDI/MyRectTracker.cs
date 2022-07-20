using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HelloGDI
{
    public partial class MyRectTracker : UserControl
    {
        #region Properties
        Control _currentControl; // 현재 컨트롤
        Rectangle _baseRect; // 현재 컨트롤과 같은 크기의 사각 도형
        Rectangle _trackerRect; // Tracker 크기의 사각 도형
        Rectangle[] _trackerPoint = new Rectangle[8]; // 트랙커 포인트 ( 꼭지점 4개, 선 중앙 4개 )
        Rectangle _rect;
        Graphics _graphics; // 그리기 위한 오브젝트
        Brush _brush; // Tracker 프레임 색상
        #endregion





        #region Const
        Size PointSize = new Size(3, 3); // 트랙커 포인트 크기, 트랙커 두께

        #endregion





        #region Class and Struct

        #endregion





        #region Constructor
        public MyRectTracker()
        {
            InitializeComponent();
        }
        public MyRectTracker(Control control)
        {
            Console.WriteLine("MyRectTracker(Control control) - Start");
            InitializeComponent();

            // Control 객체
            _currentControl = control;

            // Control 크기에 맞춰 Tracker 크기값 구하기 and Tracker 크기 변경
            ChangeTrackerSize();

            SetBaseRect();

            // Tracker Point 8개 값 구하기
            SetTrackerPoint();

            // Control 크기의 사각도형(baseRect)값, Tracker 크기의 사각도형(trackerRect)값 구하기
            SetTrackerRect();

            // Tracker 선(Frame) 만들기 
            CreateTrackerFrame();

            // Graphics 객체 생성
            SetGraphicsObj();
            Console.WriteLine("MyRectTracker(Control control) - End");
        }
        #endregion


        #region Tracker
        private void ChangeTrackerSize()
        {
            Console.WriteLine("ChangeTrackerSize() - Start");
            int X = (_currentControl.Bounds.X - PointSize.Width);
            int Y = _currentControl.Bounds.Y - PointSize.Height;
            int Height = _currentControl.Bounds.Height + (PointSize.Height * 2);
            int Width = _currentControl.Bounds.Width + (PointSize.Width * 2);
                
            this.Bounds = new Rectangle(X, Y, Width+1, Height+1);

            this.BringToFront();

            _rect = _currentControl.Bounds;

            Console.WriteLine("ChangeTrackerSize() - End");
        }
        private void SetTrackerPoint()
        {
            Console.WriteLine("SetTrackerPoint() - Start");
            //TopLeft
            _trackerPoint[0] = new Rectangle(new Point(_baseRect.X - PointSize.Width, _baseRect.Y - PointSize.Height), PointSize);
            //TopRight
            _trackerPoint[1] = new Rectangle(new Point(_baseRect.X + _baseRect.Width, _baseRect.Y - PointSize.Height), PointSize);
            //BottomLeft
            _trackerPoint[2] = new Rectangle(new Point(_baseRect.X - PointSize.Width, _baseRect.Y + _baseRect.Height), PointSize);
            //BottomRight
            _trackerPoint[3] = new Rectangle(new Point(_baseRect.X + _baseRect.Width, _baseRect.Y + _baseRect.Height), PointSize);
            //TopMiddle
            _trackerPoint[4] = new Rectangle(new Point(_baseRect.X + (_baseRect.Width / 2) - (PointSize.Width / 2), _baseRect.Y - PointSize.Height), PointSize);
            //BottomMiddle
            _trackerPoint[5] = new Rectangle(new Point(_baseRect.X + (_baseRect.Width / 2) - (PointSize.Width / 2), _baseRect.Y + _baseRect.Height), PointSize);
            //LeftMiddle
            _trackerPoint[6] = new Rectangle(new Point(_baseRect.X - PointSize.Width, _baseRect.Y + (_baseRect.Height / 2) - (PointSize.Height / 2)), PointSize);
            //RightMiddle
            _trackerPoint[7] = new Rectangle(new Point(_baseRect.X + _baseRect.Width, _baseRect.Y + (_baseRect.Height / 2) - (PointSize.Height / 2)), PointSize);
            Console.WriteLine("SetTrackerPoint() - End");
        }
        private void SetBaseRect()
        {
            Console.WriteLine("SetBaseRect() - Start");
            _baseRect = new Rectangle(PointSize.Width, PointSize.Height, _currentControl.Bounds.Width, _currentControl.Bounds.Height);
            Console.WriteLine("SetBaseRect() - End");
        }
        private void SetTrackerRect()
        {
            Console.WriteLine("SetTrackerRect() - Start");
            _trackerRect = new Rectangle(new Point(0, 0), this.Bounds.Size);
            Console.WriteLine("SetTrackerRect() - End");
        }
        private void CreateTrackerFrame()
        {
            Console.WriteLine("CreateTrackerFrame() - Start");
            // Tracker 선으로 만들 사격형 4개 값 구하기 (GraphicsPath) 
            GraphicsPath graphicsPath = new GraphicsPath();

            //Top Rectagle
            graphicsPath.AddRectangle(new Rectangle(0, 0, _currentControl.Width + (PointSize.Width * 2) + 1, PointSize.Height + 1)); ;
            //Left Rectangle
            graphicsPath.AddRectangle(new Rectangle(0, PointSize.Height + 1, PointSize.Width + 1, _currentControl.Bounds.Height + PointSize.Height + 1));
            //Bottom Rectagle
            graphicsPath.AddRectangle(new Rectangle(PointSize.Width + 1, _currentControl.Bounds.Height + PointSize.Height, _currentControl.Width + PointSize.Width + 1, PointSize.Height + 1));
            //Right Rectagle
            graphicsPath.AddRectangle(new Rectangle(_currentControl.Width + PointSize.Width, PointSize.Height + 1, PointSize.Width + 1, _currentControl.Height - 1));

            // Tracker 선 만들기
            this.Region = new Region(graphicsPath);
            Console.WriteLine("CreateTrackerFrame() - End");
        }
        private void SetGraphicsObj()
        {
            Console.WriteLine("SetGraphicsObj() - Start");
            _graphics = this.CreateGraphics();
            Console.WriteLine("SetGraphicsObj() - End");
        }
        #endregion





        #region Draw
        public void Draw(Control parent, Brush color)
        {
            Console.WriteLine("Draw(Control parent, Brush color) - Start");
            try
            {
                // Tracker 크기의 사각도형 그리기
                _graphics.FillRectangle(color, _trackerRect);

                // Tracker Point 그리기
                _graphics.FillRectangles(Brushes.White, _trackerPoint);

                // 부모 컨트롤 설정
                this.Parent = parent; // Tracker가 부모 컨트롤을 벗어날 수 없도록 하기 위함

                // Tracker 프레임 색상 저장
                _brush = color;

                // 포커스 
                this.Focus();

                // 포커스 이벤트 등록
                this.GotFocus += OnFocus;
                this.LostFocus += OnDeFocus;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Draw Error => {ex.Message}");
            }
            Console.WriteLine("Draw(Control parent, Brush color) - End");
        }
        private void OnFocus(object sender, EventArgs e)
        {
            Console.WriteLine("OnFocus() - Start");
            // Tracker Point를 하얀색으로 만들어서 보여주기
            _graphics.FillRectangles(Brushes.White, _trackerPoint);
            //this.Location = new Point(this.Left, this.Top);
            Console.WriteLine("OnFocus() - End");
        }
        private void OnDeFocus(object sender, EventArgs e)
        {
            Console.WriteLine("OnDeFocus() - Start");
            // Tracker Point를 Frame 색상과 동일하게 만들어서 숨기기
            _graphics.FillRectangles(_brush, _trackerPoint);
            //this.Location = new Point(this.Left, this.Top);
            Console.WriteLine("OnDeFocus() - End");
        }



        #endregion

        #region Event

        #endregion

        // 컨트롤을 다시 그리면 발생
        private void MyRectTracker_Paint(object sender, PaintEventArgs e)
        {

        }

        // 마우스 포인터를 컨트롤 위로 이동하면 발생
        private void MyRectTracker_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 커서 화살표 방향 설정
        }

        // Location 속성값이 변경되면 발생
        private void MyRectTracker_LocationChanged(object sender, EventArgs e)
        {
            // Parent Control 범위에서 벗어나지 못하도록 할 것
        }

        // Visible 속성 값이 변경되면 발생
        private void MyRectTracker_VisibleChanged(object sender, EventArgs e)
        {

        }

        // Size 속성 값이 변경되면 발생
        private void MyRectTracker_SizeChanged(object sender, EventArgs e)
        {

        }

        // 방향키 Up 누르면 발생
        private void MyRectTracker_KeyUp(object sender, KeyEventArgs e)
        {

        }

        // 방향키 Down 누르면 발생
        private void MyRectTracker_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
