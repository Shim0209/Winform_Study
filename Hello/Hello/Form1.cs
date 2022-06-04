/*
 * 1. Button �̺�Ʈ ���
 *  - ToolBox���� Button�� �巡���Ͽ� ���� ����� �д�.
 * 
 * 2. Button�� �̹��� ���
 *  - ToolBox���� ImagList�� �巡���Ͽ� ���� ����� �д�.
 *  - ImageList�� Ŭ���Ͽ� �Ӽ�â���� Image�� �̹������� �ִ´�.
 *  - ImageList�� �Ӽ�â���� ImageSize�� �����Ͽ� ũ�⸦ �����Ѵ�.
 *  - Button �Ӽ�â���� ImageList�� �����Ѵ�.
 *  - ImageList �ȿ� ���Ե� �̹����� �ε����� ImageIndex�� �����Ѵ�.
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