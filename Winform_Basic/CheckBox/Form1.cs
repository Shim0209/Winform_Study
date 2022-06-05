/*
 * CheckBox ��Ʈ��
 *  - CheckBox�� üũ���ڿ� �󺧷� �̷���� �ִ�.
 *  - ������Ƽ
 *      - Checked : Check ���¸� True, False�� ������ �� �ִ�.
 *      - Enabled : Ȱ��ȭ ����
 *      - CheckState : Checked, Unchecked, Indeterminate 3���� �� �ϳ��� �Ӽ��� ���� �� �ִ�.
 *  - �̺�Ʈ
 *      - CheckedChanged : ����ڰ� üũ�ڽ��� Ŭ���Ͽ� üũ ���°� ����� ��쿡 ȣ��ȴ�.
 *      
 *  �ڵ弳��
 *   - üũ�ڽ� 1���� üũ, ��üũ�� ���� �ٸ� ������ �޽����ڽ��� ����Ѵ�.
 *   - üũ�ڽ� 2���� �⺻������ ��Ȱ��ȭ �Ǿ��ִ�.
 *   - üũ�ڽ� 2���� üũ�ڽ� 3, 4���� �ϳ��� üũ�Ǹ� �ڵ����� üũ�ȴ�.
 *   - üũ�ڽ� 3, 4���� �ߺ� üũ�� �Ұ����ϴ�.
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
                MessageBox.Show("���� ������ �����߽��ϴ�.");
            else
                MessageBox.Show("���� ���� ���Ǹ� �����Ͽ����ϴ�.");
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