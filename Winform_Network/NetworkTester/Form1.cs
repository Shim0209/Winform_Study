using System;
using System.Windows.Forms;

namespace NetworkTester
{
    public partial class Form1 : Form
    {
        ucTcpip ucTcpip = new ucTcpip();
        ucUdp ucUdp = new ucUdp();
        ucSerial ucSerial = new ucSerial();
        ucSetting ucSetting = new ucSetting();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tlpViewPoint.Controls.Add(ucTcpip);
        }

        private void Init_MainForm()
        {

        }

        private void btnTcpip_Click(object sender, EventArgs e)
        {
            tlpViewPoint.Controls.Clear();
            tlpViewPoint.Controls.Add(ucTcpip);
        }

        private void btnUdp_Click(object sender, EventArgs e)
        {
            tlpViewPoint.Controls.Clear();
            tlpViewPoint.Controls.Add(ucUdp);
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            tlpViewPoint.Controls.Clear();
            tlpViewPoint.Controls.Add(ucSerial);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            tlpViewPoint.Controls.Clear();
            tlpViewPoint.Controls.Add(ucSetting);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
