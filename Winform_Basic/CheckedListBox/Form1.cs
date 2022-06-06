using System.Diagnostics;
/*
 * CheckedListBox 컨트롤
 *  - 여러개의 CheckBox들이 ListBox안에 들어 있는 Items Collection 컨트롤(일반적으로 Items라는 속성을 가지며, Items안에 Child 컨트롤들을 갖는다)으로서 일종의 컨테이너 컨트롤이다.
 *  - Items에 고정된 소량의 데이터를 넣기 위해서는 속성 창의 Items 프로퍼티를 설정하거나, 초기화 코드에서 직접 넣을 수 있다.
 *  - 가변적인 데이터를 넣기 위해서는 주로 데이타 바인딩을 사용한다.
 *  - 속성
 *      - CheckOnClick : false는 더블클릭해야 체크됨 / true는 한번만 클랙해도 체크됨
 *  - 이벤트
 *      - SelectedIndexChanged : 컨테이너 내부 아이템들 중에서 어떤 아이템을 선택했을 때 발생하는 이벤트.
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
                MessageBox.Show($"{index} - {item} 선택 해제됨");
                Debug.WriteLine($"{index} - {item} 선택 해제됨");
            }
            else
            {
                MessageBox.Show($"{index} - {item} 선택됨");
                Debug.WriteLine($"{index} - {item} 선택됨");
            }

        }
    }
}