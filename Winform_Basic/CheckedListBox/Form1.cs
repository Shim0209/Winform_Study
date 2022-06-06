using System.Diagnostics;
/*
 * CheckedListBox ��Ʈ��
 *  - �������� CheckBox���� ListBox�ȿ� ��� �ִ� Items Collection ��Ʈ��(�Ϲ������� Items��� �Ӽ��� ������, Items�ȿ� Child ��Ʈ�ѵ��� ���´�)���μ� ������ �����̳� ��Ʈ���̴�.
 *  - Items�� ������ �ҷ��� �����͸� �ֱ� ���ؼ��� �Ӽ� â�� Items ������Ƽ�� �����ϰų�, �ʱ�ȭ �ڵ忡�� ���� ���� �� �ִ�.
 *  - �������� �����͸� �ֱ� ���ؼ��� �ַ� ����Ÿ ���ε��� ����Ѵ�.
 *  - �Ӽ�
 *      - CheckOnClick : false�� ����Ŭ���ؾ� üũ�� / true�� �ѹ��� Ŭ���ص� üũ��
 *  - �̺�Ʈ
 *      - SelectedIndexChanged : �����̳� ���� �����۵� �߿��� � �������� �������� �� �߻��ϴ� �̺�Ʈ.
 */

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            string? item = checkedListBox1.SelectedItem.ToString();
            
            if(checkedListBox1.CheckedItems.IndexOf(item) == -1)
            {
                MessageBox.Show($"{index} - {item} ���� ������");
                Debug.WriteLine($"{index} - {item} ���� ������");
            }
            else
            {
                MessageBox.Show($"{index} - {item} ���õ�");
                Debug.WriteLine($"{index} - {item} ���õ�");
            }

        }
    }
}