/*
 * CheckBox 컨트롤
 *  - CheckBox는 체크상자와 라벨로 이루어져 있다.
 *  - 프로퍼티
 *      - Checked : Check 상태를 True, False로 지정할 수 있다.
 *      - Enabled : 활성화 여부
 *      - CheckState : Checked, Unchecked, Indeterminate 3가지 중 하나의 속성을 가질 수 있다.
 *  - 이벤트
 *      - CheckedChanged : 사용자가 체크박스를 클릭하여 체크 상태가 변경된 경우에 호출된다.
 *      
 *  코드설명
 *   - 체크박스 1번은 체크, 언체크시 각각 다른 내용의 메시지박스를 출력한다.
 *   - 체크박스 2번은 기본적으로 비활성화 되어있다.
 *   - 체크박스 2번은 체크박스 3, 4번중 하나가 체크되면 자동으로 체크된다.
 *   - 체크박스 3, 4번은 중복 체크가 불가능하다.
 */
namespace CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("메일 수신을 동의했습니다.");
            else
                MessageBox.Show("메일 수신 동의를 해제하였습니다.");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Enabled = false;
                checkBox2.Checked = true;
            }
            else
            {
                checkBox4.Enabled = true;
                checkBox2.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Enabled = false;
                checkBox2.Checked = true;
            }
            else
            {
                checkBox3.Enabled = true;
                checkBox2.Checked = false;
            }
        }
    }
}