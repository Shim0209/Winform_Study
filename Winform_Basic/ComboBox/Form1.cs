/*
 * ComboBox ��Ʈ��
 *  - �������� �����۵� �߿� �ϳ��� �� �� ����Ѵ�.
 *  - Items Collection ��Ʈ�� �̹Ƿ� Items �Ӽ��� �����͸� �����Ѵ�.
 *  - 3���� UI ��带 ������ �� �ִ�. (DropDownStyle �Ӽ����� ����)
 *      - Simple
 *      - DropDown : Item�� �� �߿� �ϳ��� �����ϰų� ����ڰ� ���� �ٸ� ���� ���� �� �ִ� ���
 *      - DropDownList : ���� ���� �����۵��߿��� �ϳ��� ������ �� �ִ� ���
 *  - �̺�Ʈ
 *      - SelectedIndexChanged 
 *      
 * ComboBox ������ ���ε� (DB���� ���� �ڵ�� ������ �߰� ����)
 *  - ComboBox�� �����͸� ���ε��ؼ� ���� �� �ִ�. Ư�� DB���� �����͸� �����ͼ� ���� ComboBox�� ���� ��� ���� ���ȴ�.
 *  - ComboBox.DataSource �Ӽ��� DataTable�� ���� ��ü�� �Ҵ��ϸ� �޺��ڽ��� �����ۿ� ������ �ڵ����� ���� �ȴ�.
 *      - comboBox1.DataSource = GetDataTable();
 *  - �������� ���� ���ο��� ����ϴ� ���� �ٸ��� �� �� �ִ�.
 *      - comboBox1.DisplayMember = "name"; => �������� ���� name �ʵ�
 *      - comboBox1.ValueMember = "id"; => ���ο����� ���� id �ʵ�
 */
namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "���", "�丶��", "����", "��", "������" };

            // �� �޺��ڽ��� �����͸� �ʱ�ȭ
            comboSimple.Items.AddRange(data);
            comboDropDown.Items.AddRange(data);
            comboDropDownList.Items.AddRange(data);

            // ó�� ���ð� ����.  ù° ������ ����
            comboSimple.SelectedIndex = 0;
            comboDropDown.SelectedIndex = 0;
            comboDropDownList.SelectedIndex = 0;
        }

        // ���õ� �������� �����͸� Ŭ���� �ʵ忡 �ִ� �޼ҵ�
        private string? itemSelected;
        private void comboDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDropDown.SelectedIndex >= 0)
            {
                this.itemSelected = comboDropDown.SelectedItem as string;
            }
        }

        //  ComboBox ������ ���ε� (DB ���� �ڵ�� ������ �߰�)
        /*
         * �ڵ� �߰� ����
         */
    }
}