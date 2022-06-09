using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // COM값 PortName Combobox에 넣어주기
            string[] PortNames = SerialPort.GetPortNames();
            foreach(string PortName in PortNames)
            {
                PortCB.Items.Add(PortName);
            }

            // Btn 색상 변경
            OnOffBtnColor(OFF);
        }
        #endregion

        #region Properties
        const int ON = 1;
        const int OFF = 0;
        #endregion

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = PortCB.SelectedItem.ToString();
            serialPort1.BaudRate = int.Parse(BaudRateCB.SelectedItem.ToString());
            serialPort1.DataBits = int.Parse(DataBitsCB.SelectedItem.ToString());
            serialPort1.StopBits = (StopBits)StopBitsCB.SelectedItem;
            serialPort1.Parity = (Parity)ParityCB.SelectedItem;

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    OnOffBtnColor(ON);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        #region Tx
        private void TxBtn_Click(object sender, EventArgs e)
        {
            string msg = TxTB.Text;
            serialPort1.WriteLine(msg);
        }
        #endregion

        #region Rx

        #endregion

        #region Utile

        #endregion

        #region Design
        private void OnOffBtnColor(int state)
        {
            if (state == ON)
            {
                OpenBtn.BackColor = Color.Green;
                CloseBtn.BackColor = Color.White;
            }
            else if (state == OFF)
            {
                OpenBtn.BackColor = Color.White;
                CloseBtn.BackColor= Color.Red;
            }
        }
        #endregion 
    }
}
