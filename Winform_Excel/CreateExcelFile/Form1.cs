using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

/*
 * C#에서 엑셀 파일 생성하기
 *  1. 프로젝트에 엑셀 참조 라이브러리 추가하기
 *     - 프로젝트 메뉴 -> 프로젝트 참조 추가 -> COM 메뉴 -> Microsoft Excel xx.0 Obejct Library 추가
 *  2. using 선언 (상단 참고)
 *  3. 코드 참고
 *  
 * # COM interop : 컴포넌트 오브젝트 모델(COM) 객체를 상호 운용할 수 있게 만드는 기술이다.
 */
namespace CreateExcelFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 앱 생성
            Excel.Application xlApp = new Excel.Application();

            // 앱이 생성 되었는지 검사
            if(xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value; // ??

            // 2. 워크북 생성
            xlWorkBook = xlApp.Workbooks.Add(misValue);
                       
            // 3. 워크시트 1번 가져오기
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // 4. 워크시트 1번에 값 넣기
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[2, 1] = "1";
            xlWorkSheet.Cells[2, 2] = "One";
            xlWorkSheet.Cells[3, 1] = "2";
            xlWorkSheet.Cells[3, 2] = "Two";

            // 5. 워크북 저장 (경로, 이름 등등)
            xlWorkBook.SaveAs(@"C:\Users\sim55\Desktop\test.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            // 6. 리소스 해제
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show(@"Excel file created, you can find the file Desktop\test.xls");
        }
    }
}