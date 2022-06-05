using Excel = Microsoft.Office.Interop.Excel;

/*
 * C#에서 엑셀 파일 열기
 */
namespace OpenExcelFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. 엑셀 응용프로그램 객체 생성
            Excel.Application xlApp = new Excel.Application();

            // 2. 해당 파일 불러오기
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\sim55\Desktop\test.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            // 3. 엑셀 파일의 첫번째 시트 가져오기
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // 4. 해당 시트의 (A1, A1) 좌표값을 출력
            MessageBox.Show(xlWorkSheet.get_Range("A1", "A1").Value2.ToString());

            // 5. 워크북과 엑셀 종료 및 COM객체 해제
            xlWorkBook.Close();
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        // COM객체 해제하는 메소드
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch(Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}