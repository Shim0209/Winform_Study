using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;

namespace LightController
{
    public partial class Form1 : Form
    { 
        #region Form Init
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        SerialPort m_SerialPort;
        const string iniSavePath = @"C:\DPS\LightController.ini";
        private bool chOnePower = false; // LIGHT CH1 On/Off Status
        private bool chTwoPower = false; // LIGHT CH2 On/Off Status
        
        const int CH1 = 1;
        const int CH2 = 2;
        const int CH3 = 3;
        const int CH4 = 4;

        // 시리얼통신 읽기를 위한 변수
        /*private Object thisLock = new object(); // 동시에 들어오는 데이터들 충돌안나게 Object로 Lock걸어주는 thisLock
        const char _02 = (char)0x02; // 시리얼데이터 내용이 시작된다는 0x02(STX) 문자
        const char _0D = (char)0x0D; // 시리얼데이터 내용이 끝이라는 0x0D 와 0x0A 두개의 문자
        const char _0A = (char)0x0A; // 내용이 막 끊어져서 들어와도 조합해서 제대로된 데이터를 저장할 용도
        string inStream = "";*/
        #endregion

        #region Form Load and Close
        private void Form1_Load(object sender, EventArgs e)
        {   
            // Serial Port setting
            m_SerialPort = new SerialPort();
            m_SerialPort.PortName = "COM1";
            m_SerialPort.BaudRate = 9600;
            m_SerialPort.DataBits = 8;
            m_SerialPort.Parity = System.IO.Ports.Parity.None;
            m_SerialPort.StopBits = System.IO.Ports.StopBits.One;
            m_SerialPort.Open();
            
            // 전에 사용하던 조명 값 읽어오기
            int LightOneValue = int.Parse(IniFile.GetValue(iniSavePath, "Value", "LightCH1", "0"));
            int LightTwoValue = int.Parse(IniFile.GetValue(iniSavePath, "Value", "LightCH2", "0"));

            // 값 저장 (없으면 새로 만들의도로 작성)
            IniFile.SetValue(iniSavePath, "Value", "LightCH1", LightOneValue.ToString());
            IniFile.SetValue(iniSavePath, "Value", "LightCH2", LightTwoValue.ToString());

            // 사용하던 값으로 초기화
            LightOneNUD.Value = Decimal.Parse(LightOneValue.ToString());
            LightTwoNUD.Value = Decimal.Parse(LightTwoValue.ToString());
            LightOneSB.Value = int.Parse(LightOneValue.ToString());
            LightTwoSB.Value = int.Parse(LightTwoValue.ToString());

            // 조명 ON (자동 ON)
            LightOn(CH1);
            LightOn(CH2);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 조명 값 저장
            IniFile.SetValue(iniSavePath, "Value", "LightCH1", LightOneSB.Value.ToString().ToString());
            IniFile.SetValue(iniSavePath, "Value", "LightCH2", LightTwoSB.Value.ToString().ToString());

            // 조명 OFF
            LightOff(CH1);
            LightOff(CH2);
        }
        #endregion

        #region Button Event
        private void LightOneBtn_Click(object sender, EventArgs e)
        {
            LightOnOff(1);
        }

        private void LightTwoBtn_Click(object sender, EventArgs e)
        {
            LightOnOff(2);
        }
        #endregion

        #region SliderBar Event
        private void LightCh1_ValueChanged(object sender, decimal value)
        {
            // 현재 값 불러오기
            int currentValue = LightOneSB.Value;

            // Form 출력 값 변경
            LightOneNUD.Value = currentValue;

            // 컨트롤러에 변경된 값 전달
            SendLightValue(1, currentValue);
        }

        private void LightCh2_ValueChanged(object sender, decimal value)
        {
            // 현재 값 불러오기
            int currentValue = LightTwoSB.Value;

            // Form 출력 값 변경
            LightTwoNUD.Value = currentValue;

            // 컨트롤러에 변경된 값 전달
            SendLightValue(2, currentValue);
        }
        #endregion

        #region Numeric UpDown Event
        private void LightOneNUD_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = Decimal.ToInt32(LightOneNUD.Value);
            LightOneSB.Value = currentValue;
            SendLightValue(1, currentValue);
        }

        private void LightTwoNUD_ValueChanged(object sender, EventArgs e)
        {
            int currentValue = Decimal.ToInt32(LightTwoNUD.Value);
            LightTwoSB.Value = currentValue;
            SendLightValue(2, currentValue);
        }
        #endregion

        #region 동작 Method
        private void LightOnOff(int chNo)
        {
            if (chNo == 1)
            {
                if (!chOnePower) // off 라면
                {
                    LightOn(chNo);
                }
                else // on 이라면
                {
                    LightOff(chNo);

                }
            }
            else
            {
                if (!chTwoPower) // off 라면
                {
                    LightOn(chNo);
                }
                else // on 이라면
                {
                    LightOff(chNo);
                }
            }
        }

        private void LightOn(int chNo)
        {
            TxData("]0" + chNo + "1");
            if (chNo == 1)
            {
                chOnePower = true;
                LightOneBtn.BackColor = Color.Green;
            }
            else
            {
                chTwoPower = true;
                LightTwoBtn.BackColor = Color.Green;
            }
        }
        private void LightOff(int chNo)
        {
            TxData("]0" + chNo + "0");
            if (chNo == 1)
            {
                chOnePower = false;
                LightOneBtn.BackColor = Color.White;
            }
            else
            {
                chTwoPower = false;
                LightTwoBtn.BackColor = Color.White;
            }
        }

        // 데이터 전송 메소드
        private void TxData(string strOutputData)
        {
            // 데이터 전송
            try
            {
                m_SerialPort.Write(strOutputData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // 비동기 데이터 전송 메소드
        /*private async void AsyncTxData(string strOutputData)
        {
            try
            {
                await Task.Run(() =>
                {
                    serialPort1.Write(strOutputData);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/

        // 컨트롤러에 값을 전달
        private void SendLightValue(int chNo, int value)
        {
            // 포트 열기
            checkPort();

            // 보낼 데이터 만들기
            // [
            // 00 (채널)
            // 000 (값)
            string strOutputData = "[0" + chNo.ToString() + DigitChange(value);

            // 데이터 전송
            TxData(strOutputData);
        }
        #endregion

        #region Utile
        // 데이터 자릿수를 세자리로 맞춰주는 메소드
        // 5 => 005, 65 => 064
        private string DigitChange(int value)
        {
            string result = "";
            if(value < 10)
            {
                result = "00" + value.ToString();
            }
            else if (value >= 10 && value < 100)
            {
                result = "0" + value.ToString();
            }
            else if(value >= 100 && value <= 255)
            {
                result = value.ToString();
            }
            else
            {
                MessageBox.Show("입력값이 잘못되었습니다.");
            }

            return result;
        }

        // 포트 확인 메소드
        private void checkPort()
        {
            if (!m_SerialPort.IsOpen)
            {
                try
                {
                    m_SerialPort.Open();
                    MessageBox.Show(m_SerialPort.PortName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        #endregion

        #region Native Dll
        public class IniFile
        {
            [DllImport("kernel32.dll")] // 윈도우즈 기본 API
            private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

            [DllImport("kernel32.dll")]
            private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
            public static void SetValue(string path, string Section, string Key, string Value)
            {
                WritePrivateProfileString(Section, Key, Value, path);
            }

            public static string GetValue(string path, string Section, string Key, string Default)
            {
                StringBuilder temp = new StringBuilder(255);

                int i = GetPrivateProfileString(Section, Key, Default, temp, 255, path);

                if (temp != null && temp.Length > 0)
                {
                    return temp.ToString();
                }
                else
                {
                    return Default;
                }
            }
        }
        #endregion


    }
}
