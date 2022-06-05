

using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

/*
 * C#으로 엑셀 파일 읽기
 *  - 사용중인 시트의 모든 값을 읽는법
 */
namespace ReadExcelFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\sim55\Desktop\test.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);

            // 워크시트에서 사용하는 범위 정보를 가져온다.
            range = xlWorkSheet.UsedRange;

            // 가져온 정보로 row, column 값을 얻는다.
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            // 이중 for문을 통하여 값을 출력한다.
            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    str = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
                    MessageBox.Show(str);
                }
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }
    }
}