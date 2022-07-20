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
        
        private bool isFirst = true;
        private Point prevLeftClick;
        bool reSizerect = false;
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
        //currently resize mouse location
        private RESIZE_BORDER CurrBorder;
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

            TrackerCreate();

            Console.WriteLine("MyRectTracker(Control control) - End");
        }
        #endregion


        #region Tracker
        private void TrackerCreate()
        {
            // Control 크기에 맞춰 Tracker 크기값 구하기 and Tracker 크기 변경
            ChangeTrackerSize();


            // Tracker Point 8개 값 구하기
            SetTrackerPoint();

            // Control 크기의 사각도형(baseRect)값, Tracker 크기의 사각도형(trackerRect)값 구하기
            SetBaseRect();
            SetTrackerRect();

            // Tracker 선(Frame) 만들기 
            CreateTrackerFrame();

            // Graphics 객체 생성
            SetGraphicsObj();
        }
        private void ChangeTrackerSize()
        {
            Console.WriteLine("ChangeTrackerSize() - Start");
            int X = _currentControl.Bounds.X;
            int Y = _currentControl.Bounds.Y;
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
            _graphics.Clear(Color.Red);
            //this.Location = new Point(this.Left, this.Top);
            Console.WriteLine("OnDeFocus() - End");
        }

        #endregion

        #region DoMethod
        private void Mouse_Move(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Console.WriteLine("Mouse_Move() - Start");
            //minimum size for the control is 8x8
            if (_currentControl.Height < 8)
            {
                _currentControl.Height = 8;
                return;
            }
            else if (_currentControl.Width < 8)
            {
                _currentControl.Width = 8;
                return;
            }

            if (_currentControl.Height > this.Height)
            {
                _currentControl.Height = this.Height;
                return;
            }
            else if (_currentControl.Width > this.Width)
            {
                _currentControl.Width = this.Width;
                return;
            }

            switch (this.CurrBorder)
            {
                case RESIZE_BORDER.RB_TOP:
                    reSizerect = true;
                    _currentControl.Height = _currentControl.Height - e.Y + prevLeftClick.Y;
                    if (_currentControl.Height > 8)
                        _currentControl.Top = _currentControl.Top + e.Y - prevLeftClick.Y;
                    break;
                case RESIZE_BORDER.RB_TOPLEFT:
                    reSizerect = true;
                    _currentControl.Height = _currentControl.Height - e.Y + prevLeftClick.Y;
                    if (_currentControl.Height > 8)
                        _currentControl.Top = _currentControl.Top + e.Y - prevLeftClick.Y;
                    _currentControl.Width = _currentControl.Width - e.X + prevLeftClick.X;
                    if (_currentControl.Width > 8)
                        _currentControl.Left = _currentControl.Left + e.X - prevLeftClick.X;
                    break;
                case RESIZE_BORDER.RB_TOPRIGHT:
                    reSizerect = true;
                    _currentControl.Height = _currentControl.Height - e.Y + prevLeftClick.Y;
                    if (_currentControl.Height > 8)
                        _currentControl.Top = _currentControl.Top + e.Y - prevLeftClick.Y;
                    _currentControl.Width = _currentControl.Width + e.X - prevLeftClick.X;

                    if (_currentControl.Width + _currentControl.Left >= this.Width)
                    {
                        _currentControl.Width = this.Width - _currentControl.Left;
                        _currentControl.Left = _currentControl.Left;
                    }

                    break;
                case RESIZE_BORDER.RB_RIGHT:
                    reSizerect = true;
                    _currentControl.Width = _currentControl.Width + e.X - prevLeftClick.X;
                    if (_currentControl.Width + _currentControl.Left >= this.Width)
                    {
                        _currentControl.Width = this.Width - _currentControl.Left;
                        _currentControl.Left = _currentControl.Left;
                    }

                    break;
                case RESIZE_BORDER.RB_BOTTOM:
                    reSizerect = true;
                    _currentControl.Height = _currentControl.Height + e.Y - prevLeftClick.Y;

                    if (_currentControl.Height + _currentControl.Top >= this.Height)
                    {
                        _currentControl.Height = this.Height - _currentControl.Top;
                        _currentControl.Top = _currentControl.Top;
                    }
                    break;
                case RESIZE_BORDER.RB_BOTTOMLEFT:
                    reSizerect = true;

                    _currentControl.Height = _currentControl.Height + e.Y - prevLeftClick.Y;
                    _currentControl.Width = _currentControl.Width - e.X + prevLeftClick.X;
                    if (_currentControl.Width > 8)
                        _currentControl.Left = _currentControl.Left + e.X - prevLeftClick.X;

                    if (_currentControl.Height + _currentControl.Top >= this.Height)
                    {
                        _currentControl.Height = this.Height - _currentControl.Top;
                        _currentControl.Top = _currentControl.Top;
                    }
                    break;
                case RESIZE_BORDER.RB_BOTTOMRIGHT:
                    reSizerect = true;
                    _currentControl.Height = _currentControl.Height + e.Y - prevLeftClick.Y;
                    _currentControl.Width = _currentControl.Width + e.X - prevLeftClick.X;

                    if (_currentControl.Width + _currentControl.Left >= this.Width)
                    {
                        _currentControl.Width = this.Width - _currentControl.Left;
                        _currentControl.Left = _currentControl.Left;
                    }

                    if (_currentControl.Height + _currentControl.Top >= this.Height)
                    {
                        _currentControl.Height = this.Height - _currentControl.Top;
                        _currentControl.Top = _currentControl.Top;
                    }

                    break;
                case RESIZE_BORDER.RB_LEFT:
                    reSizerect = true;
                    _currentControl.Width = _currentControl.Width - e.X + prevLeftClick.X;
                    if (_currentControl.Width > 8)
                        _currentControl.Left = _currentControl.Left + e.X - prevLeftClick.X;
                    break;
                case RESIZE_BORDER.RB_NONE:
                    reSizerect = false;
                    _currentControl.Location = new Point(_currentControl.Location.X + e.X - prevLeftClick.X, _currentControl.Location.Y + e.Y - prevLeftClick.Y);
                    break;
            }

            Console.WriteLine("Mouse_Move() - End");
        }

        public bool Hit_Test(Point point)
        {
            Console.WriteLine("Hit_Test() - Start");
            //Check if the point is somewhere on the tracker
            if (!_trackerRect.Contains(point))
            {
                //should never happen
                Cursor.Current = Cursors.Arrow;

                return false;
            }
            else if (_trackerPoint[0].Contains(point))      // Cursor on TopLeft Point
            {
                Cursor.Current = Cursors.SizeNWSE;
                CurrBorder = RESIZE_BORDER.RB_TOPLEFT;
            }
            else if (_trackerPoint[3].Contains(point))      // Cursor on BottomRight Point
            {
                Cursor.Current = Cursors.SizeNWSE;
                CurrBorder = RESIZE_BORDER.RB_BOTTOMRIGHT;
            }
            else if (_trackerPoint[1].Contains(point))      // Cursor on TopRight Point
            {
                Cursor.Current = Cursors.SizeNESW;
                CurrBorder = RESIZE_BORDER.RB_TOPRIGHT;
            }
            else if (_trackerPoint[2].Contains(point))      // Cursor on BottomLeft Point
            {
                Cursor.Current = Cursors.SizeNESW;
                CurrBorder = RESIZE_BORDER.RB_BOTTOMLEFT;
            }
            else if (_trackerPoint[4].Contains(point))      // Cursor on TopMiddle Point
            {
                Cursor.Current = Cursors.SizeNS;
                CurrBorder = RESIZE_BORDER.RB_TOP;
            }
            else if (_trackerPoint[5].Contains(point))      // Cursor on BottomMiddle Point
            {
                Cursor.Current = Cursors.SizeNS;
                CurrBorder = RESIZE_BORDER.RB_BOTTOM;
            }
            else if (_trackerPoint[6].Contains(point))      // Cursor on LeftMiddle Point
            {
                Cursor.Current = Cursors.SizeWE;
                CurrBorder = RESIZE_BORDER.RB_LEFT;
            }
            else if (_trackerPoint[7].Contains(point))      // // Cursor on RightMiddle Point
            {
                Cursor.Current = Cursors.SizeWE;
                CurrBorder = RESIZE_BORDER.RB_RIGHT;
            }
            else if (_trackerRect.Contains(point))
            {
                Cursor.Current = Cursors.SizeAll;
                CurrBorder = RESIZE_BORDER.RB_NONE;

            }

            Console.WriteLine("Hit_Test() - End");
            return true;
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
            this.Cursor = Cursors.Arrow;

            if (e.Button == MouseButtons.Left)
            {
                // If this is the first mouse move event for left click dragging of the form,
                // store the current point clicked so that we can use it to calculate the form's
                // new location in subsequent mouse move events due to left click dragging of the form
                if (isFirst == true)
                {
                    // Store previous left click position
                    prevLeftClick = new Point(e.X, e.Y);

                    //Create();
                    // Subsequent mouse move events will not be treated as first time, until the
                    // left mouse click is released or other mouse click occur
                    isFirst = false;
                }
                else
                {
                    //hide tracker

                    this.Visible = true;
                    //forward mouse position to append changes
                    Mouse_Move(this, e);

                    // Store new previous left click position
                    //prevLeftClick = new Point(e.X, e.Y);
                    if (!reSizerect)
                    {
                        TrackerCreate();

                        //prevLeftClick = new Point(e.X, e.Y);

                        //this.roiLabel.Location = new Point(this.Left, this.Top - 15);
                    }
                    else if (reSizerect)
                    {
                        TrackerCreate();
                        prevLeftClick = new Point(e.X, e.Y);
                    }
                }
            }
            else
            {
                // This is a new mouse move event so reset flag
                isFirst = true;
                //show the tracker
                this.Visible = true;

                //update the mouse pointer to other cursors by checking it's position
                Hit_Test(new Point(e.X, e.Y));
            }
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
