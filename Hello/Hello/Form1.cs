/*
 * 1. Button 이벤트 등록
 *  - ToolBox에서 Button을 드래그하여 폼에 끌어다 둔다.
 * 
 * 2. Button에 이미지 등록
 *  - ToolBox에서 ImagList를 드래그하여 폼에 끌어다 둔다.
 *  - ImageList를 클릭하여 속성창에서 Image에 이미지들을 넣는다.
 *  - ImageList의 속성창에서 ImageSize를 변경하여 크기를 조정한다.
 *  - Button 속성창에서 ImageList를 지정한다.
 *  - ImageList 안에 포함된 이미지의 인덱스를 ImageIndex에 지정한다.
 */
namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                button1.ImageIndex = 2;
                button1.Text = "Stop";
                button1.BackColor = Color.Green;
                flag = 1;
            }
            else
            {
                button1.ImageIndex = 1;
                button1.Text = "Start";
                button1.BackColor = Color.White;
                flag = 0;
            }
        }
    }
}