using Excel = Microsoft.Office.Interop.Excel;

/*
 * C#���� ���� ���� ����
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
            // 1. ���� �������α׷� ��ü ����
            Excel.Application xlApp = new Excel.Application();

            // 2. �ش� ���� �ҷ�����
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\sim55\Desktop\test.xls", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            // 3. ���� ������ ù��° ��Ʈ ��������
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            // 4. �ش� ��Ʈ�� (A1, A1) ��ǥ���� ���
            MessageBox.Show(xlWorkSheet.get_Range("A1", "A1").Value2.ToString());

            // 5. ��ũ�ϰ� ���� ���� �� COM��ü ����
            xlWorkBook.Close();
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        // COM��ü �����ϴ� �޼ҵ�
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