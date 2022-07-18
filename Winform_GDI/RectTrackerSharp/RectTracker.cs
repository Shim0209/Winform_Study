using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

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

        // 디폴트 점과 외곽 경계선 위 점8개
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
                SetRectangles();
            }
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
            // create tracker bounds
            int x = currentControl.Bounds.X - Sqare.Width;
            int y = currentControl.Bounds.Y - Sqare.Height;
            int Width = currentControl.Bounds.Width + (Sqare.Width * 2);
            int Height = currentControl.Bounds.Height + (Sqare.Height * 2);

            // 컨트롤 외곽 경계선 사각형
            this.Bounds = new Rectangle(x, y, Width+1, Height+1);

            this.BringToFront();

            // 컨트롤 경계선 사각형
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

        }
    }
}
