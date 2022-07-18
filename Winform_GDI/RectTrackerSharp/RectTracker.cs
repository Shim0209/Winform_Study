using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RectTrackerSharp
{
    public partial class RectTracker : UserControl
    {
        Control currentControl;

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
    }
}
