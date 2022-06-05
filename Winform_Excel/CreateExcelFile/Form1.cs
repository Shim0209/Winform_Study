using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

/*
 * C#���� ���� ���� �����ϱ�
 *  1. ������Ʈ�� ���� ���� ���̺귯�� �߰��ϱ�
 *     - ������Ʈ �޴� -> ������Ʈ ���� �߰� -> COM �޴� -> Microsoft Excel xx.0 Obejct Library �߰�
 *  2. using ���� (��� ����)
 *  3. �ڵ� ����
 *  
 * # COM interop : ������Ʈ ������Ʈ ��(COM) ��ü�� ��ȣ ����� �� �ְ� ����� ����̴�.
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
            // 1. �� ����
            Excel.Application xlApp = new Excel.Application();

            // ���� ���� �Ǿ����� �˻�
            if(xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value; // ??

            // 2. ��ũ�� ����
            xlWorkBook = xlApp.Workbooks.Add(misValue);
                       
            // 3. ��ũ��Ʈ 1�� ��������
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // 4. ��ũ��Ʈ 1���� �� �ֱ�
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[2, 1] = "1";
            xlWorkSheet.Cells[2, 2] = "One";
            xlWorkSheet.Cells[3, 1] = "2";
            xlWorkSheet.Cells[3, 2] = "Two";

            // 5. ��ũ�� ���� (���, �̸� ���)
            xlWorkBook.SaveAs(@"C:\Users\sim55\Desktop\test.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            // 6. ���ҽ� ����
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            MessageBox.Show(@"Excel file created, you can find the file Desktop\test.xls");
        }
    }
}