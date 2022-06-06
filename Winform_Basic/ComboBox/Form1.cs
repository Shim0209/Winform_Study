/*
 * ComboBox 컨트롤
 *  - 여려개의 아이템들 중에 하나를 고를 때 사용한다.
 *  - Items Collection 컨트롤 이므로 Items 속성에 데이터를 지정한다.
 *  - 3가지 UI 모드를 설정할 수 있다. (DropDownStyle 속성에서 지정)
 *      - Simple
 *      - DropDown : Item값 들 중에 하나를 선택하거나 사용자가 직접 다른 값을 넣을 수 있는 모드
 *      - DropDownList : 단지 기존 아이템들중에서 하나만 선택할 수 있는 모드
 *  - 이벤트
 *      - SelectedIndexChanged 
 *      
 * ComboBox 데이터 바인딩 (DB연동 관련 코드는 다음에 추가 예정)
 *  - ComboBox에 데이터를 바인딩해서 넣을 수 있다. 특히 DB에서 데이터를 가져와서 직접 ComboBox에 넣을 경우 많이 사용된다.
 *  - ComboBox.DataSource 속성에 DataTable과 같은 객체를 할당하면 콤보박스의 아이템에 값들이 자동으로 들어가게 된다.
 *      - comboBox1.DataSource = GetDataTable();
 *  - 보여지는 값과 내부에서 사용하는 값을 다르게 할 수 있다.
 *      - comboBox1.DisplayMember = "name"; => 보여지는 값은 name 필드
 *      - comboBox1.ValueMember = "id"; => 내부에서의 값은 id 필드
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
            string[] data = { "사과", "토마토", "포도", "배", "복숭아" };

            // 각 콤보박스에 데이터를 초기화
            comboSimple.Items.AddRange(data);
            comboDropDown.Items.AddRange(data);
            comboDropDownList.Items.AddRange(data);

            // 처음 선택값 지정.  첫째 아이템 선택
            comboSimple.SelectedIndex = 0;
            comboDropDown.SelectedIndex = 0;
            comboDropDownList.SelectedIndex = 0;
        }

        // 선택된 아이템의 데이터를 클래스 필드에 넣는 메소드
        private string? itemSelected;
        private void comboDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboDropDown.SelectedIndex >= 0)
            {
                this.itemSelected = comboDropDown.SelectedItem as string;
            }
        }

        //  ComboBox 데이터 바인딩 (DB 관련 코드는 다음에 추가)
        /*
         * 코드 추가 예정
         */
    }
}