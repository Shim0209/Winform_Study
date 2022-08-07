using System.Windows.Forms;

// 동적 Layout
// - Monitor 및 Window Tab 등 Display Device의 종류가 다양해 짐에 따라 화면 비율을 동적으로 변환 시킬 필요가 생김
// - TableLayoutPanel
//      Talbe 형태의 Layout을 지정
// - SplitContainer   
//      이동이 가능 한 Split Panel을 지정
namespace DynamicLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
