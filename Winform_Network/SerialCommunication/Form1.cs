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


        #region Tx, Rx
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = PortCB.SelectedItem.Equals(null) ? "COM1" : PortCB.SelectedItem.ToString();
            serialPort1.BaudRate = BaudRateCB.SelectedItem.Equals(null) ? 9600 : int.Parse(BaudRateCB.SelectedItem.ToString());
            serialPort1.DataBits = DataBitsCB.SelectedItem.Equals(null) ? 8 : int.Parse(DataBitsCB.SelectedItem.ToString());
            serialPort1.StopBits = StopBitsCB.SelectedItem.Equals(null) ? StopBits.One : GetStopBits(StopBitsCB.SelectedItem);
            serialPort1.Parity = ParityCB.SelectedItem.Equals(null) ? Parity.None : GetParity(ParityCB.SelectedItem);

            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    OnOffBtnColor(ON);
                    StartRx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    OnOffBtnColor(OFF);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void TxBtn_Click(object sender, EventArgs e)
        {
            string msg = TxTB.Text;
            if (!serialPort1.IsOpen)
            {
                MessageBox.Show("Port가 닫혀있습니다.");
            }
            serialPort1.WriteLine(msg);
        }
        private void StartRx()
        {
            serialPort1.DataReceived += (sender, e) =>
            {
                SerialPort port = (SerialPort)sender;
                // 도착한 데이터 모두 읽기
                string data = port.ReadExisting();

                RxTB.Text += data;
            };
        }
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

        #region Utile
        private StopBits GetStopBits(object obj)
        {
            int value = int.Parse(obj.ToString());  
            StopBits result;
            if(value == 0)
            {
                result = StopBits.None;
            }else if(value == 1)
            {
                result = StopBits.One;
            }else if(value == 2)
            {
                result = ~StopBits.Two;
            }else
            {
                result = StopBits.OnePointFive;
            }
            return result;
        }
        private Parity GetParity(object obj)
        {
            string value = obj.ToString();
            Parity result;
            if(value == "None")
            {
                result = Parity.None;
            }else if(value == "Odd")
            {
                result = Parity.Odd;
            }else if(value == "Even")
            {
                result = Parity.Even;
            }else if(value == "Mark")
            {
                result = Parity.Mark;
            }else
            {
                result = Parity.Space;
            }
            return result;
        }
        #endregion
    }
}
