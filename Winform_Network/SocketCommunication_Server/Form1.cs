using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCommunication_Server
{
    // 서버의 비동기 응답을 위한 자료구조
    public partial class VisionPC : Form
    {
        

        #region 속성 초기화
        // 새로운 버전
        private Queue<ClientInfo> m_clientInfo;

        // 송신
        private string Client_IP = "";
        private int Client_Port = 0;
        private Socket m_MachineSocket; // Machine으로 요청할 때 사용 (요청용)

        // 수신
        private string Server_IP = "";
        private int Server_Port = 0;
        private Socket m_VisionPCSocket; // Machine에서 요청하는 데이터를 수신할 때 사용 (요청 수신용)

        // ini 파일
        const string iniSavePath = @"C:\DPS\SocketCommunication_VisionPC.ini";
        #endregion

        #region 폼 생성자, 폼 로드
        public VisionPC()
        {
            InitializeComponent();
        }

        private void VisionPC_Load(object sender, EventArgs e)
        {
            // ini 파일로드
            Client_IP = IniFile.GetValue(iniSavePath, "Client", "IP", GetLocalIP());
            Client_Port = int.Parse(IniFile.GetValue(iniSavePath, "Client", "Port", "7001"));
            //Server_IP = IniFile.GetValue(iniSavePath, "Server", "IP", GetLocalIP());
            Server_IP = GetLocalIP();
            Server_Port = int.Parse(IniFile.GetValue(iniSavePath, "Server", "Port", "7000"));

            IniFile.SetValue(iniSavePath, "Client", "IP", Client_IP);
            IniFile.SetValue(iniSavePath, "Client", "Port", Client_Port.ToString());
            IniFile.SetValue(iniSavePath, "Server", "IP", Server_IP);
            IniFile.SetValue(iniSavePath, "Server", "Port", Server_Port.ToString());

            // 클라이언트(Machine) Socket, message 저장소
            m_clientInfo = new Queue<ClientInfo>();

            // 수신 서버 시작
            OpenServer();
        }
        #endregion

        #region 수신
        // 서버 Open
        private async void OpenServer()
        {
            IPAddress ServerIP = IPAddress.Parse(Server_IP);

            m_VisionPCSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(ServerIP, Server_Port);

            m_VisionPCSocket.Bind(ipep);
            m_VisionPCSocket.Listen(100);

            var task = AsyncServer();
            await task;
        }

        // 서버 수신 처리
        private async Task AsyncServer()
        {
            while (true)
            {
                Socket client = await m_VisionPCSocket.AcceptAsync();

                new Task(() =>
                {
                    // 클라이언트 EndPoint 정보 취득
                    var ip = client.RemoteEndPoint as IPEndPoint;

                    // 클라이언트 접속정보 출력
                    showMessage(Rx_ReceiveTB, $"{ip.Address}<{ip.Port}>에서 접속하였습니다.", $" - [{DateTime.Now}]");

                    var sb = new StringBuilder();

                    using (client)
                    {
                        while (true)
                        {
                            var binary = new byte[1024];

                            client.Receive(binary);

                            var data = Encoding.Unicode.GetString(binary);

                            if(data.IndexOf(">") != -1)
                            {
                                sb.Append(data);

                                showMessage(Rx_ReceiveTB, $"받은 데이터 {sb}", "");

                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.socket = client;
                                clientInfo.message = sb.ToString();
                                m_clientInfo.Enqueue(clientInfo);

                                Rx_BoxDataWrite();
                                Rx_RequestMsgWrite();

                                sb.Clear();
                            }
                            else
                            {
                                sb.Append(data);
                            }
                        }
                    }
                }).Start();
            }
        }


        private void Rx_RespBtn_Click(object sender, EventArgs e)
        {
            if(m_clientInfo.Count > 0)
            {
                ClientInfo clientInfo = m_clientInfo.Peek();
                Socket currentSocket = clientInfo.socket;
                string message = clientInfo.message;

                message = message.Replace("<", "").Replace(">", "");
                string[] splitData = message.Split(',');
                
                string respData = "";
                bool errorFlag = false;

                if (Rx_DataCB.Text == "ACK")
                {
                    if (splitData[2].Trim('\0') == "REQUEST")
                    {
                        //picker, vision, command, data, x, y, z
                        if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "" && Rx_X_TB.Text != "" && Rx_Y_TB.Text != "" && Rx_Z_TB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + "," + Rx_X_TB.Text + "," + Rx_Y_TB.Text + "," + Rx_Z_TB.Text + ">";
                        }
                        else
                        {
                            errorFlag = true;
                        }
                    }
                    else
                    {
                        //picker, vision, command, data
                        if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + ">";
                        }
                        else
                        {
                            errorFlag = true;
                        }
                    }
                }
                else // NCK
                {
                    // picker, vision, command, data, message
                    //picker, vision, command, data
                    if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "" && Rx_MessageTB.Text != "")
                    {
                        respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + "," + Rx_MessageTB.Text + ">";
                    }
                    else
                    {
                        errorFlag = true;
                    }
                }

                if (errorFlag)
                {
                    showMessage(Rx_ReceiveTB, "누락된 데이터가 있습니다.", "");
                }
                else
                {
                    // 전송
                    byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                    currentSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
                    showMessage(Rx_ReceiveTB, $"응답한 데이터 {respData}", "");

                    m_clientInfo.Dequeue();

                    Rx_BoxDataWrite();
                    Rx_RequestMsgWrite();
                }
            }
            else
            {
                MessageBox.Show("응답할 메세지가 없습니다.");
            }
        }

        // 응답해야할 메세지 출력
        private void Rx_RequestMsgWrite()
        {
            if (m_clientInfo.Count > 0)
            {
                ClientInfo current = m_clientInfo.Peek();

                // 크로스 스레드 방지
                if (Rx_RequestMsgTB.InvokeRequired)
                {
                    Rx_RequestMsgTB.Invoke(new MethodInvoker(delegate ()
                    {
                        Rx_RequestMsgTB.Text = current.message;
                    }));
                }
                else
                {
                    Rx_RequestMsgTB.Text = current.message;
                }
            }
            else
            {
                Rx_RequestMsgTB.Text = "응답할 메세지가 없습니다.";
            }
        }

        private void Rx_BoxDataWrite()
        {
            if(m_clientInfo.Count > 0)
            {
                ClientInfo current = m_clientInfo.Peek();

                string message = current.message;
                message = message.Replace("<", "").Replace(">", "");
                string[] splitData = message.Split(',');

                SetComboBox(Rx_PickerCB, splitData[0]);
                SetComboBox(Rx_VisionCB, splitData[1]);
                SetComboBox(Rx_CommandCB, splitData[2]);
            }
            else
            {
                SetComboBox(Rx_PickerCB, "");
                SetComboBox(Rx_VisionCB, "");
                SetComboBox(Rx_CommandCB, "");
            }
        }
        #endregion

        #region 송신
        // 클라이언트 Open
        private async void Tx_OpenBtn_Click(object sender, EventArgs e)
        {
            if (m_MachineSocket == null)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(Client_IP), Client_Port);

                m_MachineSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    m_MachineSocket.Connect(ipep);
                    Tx_OpenBtn.Enabled = false;
                }
                catch (SocketException se)
                {
                    showMessage(Tx_ResultTB, se.Message, $" - [{DateTime.Now}]");
                }
                var Task = AsyncClient();
                await Task;
            }
        }

        private void Tx_SendBtn_Click(object sender, EventArgs e)
        {
            if (m_MachineSocket != null)
            {
                string message = CreateMessage();
                if (message != "")
                {
                    m_MachineSocket.Send(Encoding.Unicode.GetBytes(message));
                    showMessage(Tx_ResultTB, $"보낸 데이터 {message}", "");
                }
                else
                {
                    MessageBox.Show("메세지 구성요소를 전부 입력하세요.");
                }
            }
        }

        private async Task AsyncClient()
        {
            try
            {
                new Task(() =>
                {
                    var sb = new StringBuilder();

                    using (m_MachineSocket)
                    {
                        while (true)
                        {
                            var binary = new byte[1024];

                            m_MachineSocket.Receive(binary);

                            var data = Encoding.Unicode.GetString(binary);

                            if (data.IndexOf(">") != -1)
                            {
                                sb.Append(data);

                                showMessage(Tx_ResultTB, $"응답 데이터 {sb}", "");

                                sb.Clear();
                            }
                            else
                            {
                                sb.Append(data);
                            }
                        }
                    }
                }).Start();
            }
            catch (SocketException se)
            {

            }
        }
        #endregion

        #region 유틸
        private string CreateMessage()
        {
            string result = "";
            if (GetComboBox(Tx_PickerCB) != "" && GetComboBox(Tx_VisionCB) != "" && GetComboBox(Tx_CommandCB) != "" && GetTextBox(Tx_DataTB) != "")
            {
                result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + "," + GetTextBox(Tx_DataTB) + ">";
            }
            else
            {
                result = "";
            }
            return result;
        }
        // 로컬 아이피 주소 가져오기
        private string GetLocalIP()
        {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }
        private void showMessage(TextBox textBox, string message, string netMessage)
        {
            if (textBox.InvokeRequired)
            {
                //textBox.Invoke(new ctrl_Invoke(showMessage), textBox, message, netMessage);

                textBox.Invoke(new MethodInvoker(delegate ()
                {
                    string data = textBox.Text.Length == 0 ? (message + netMessage) : "\r\n" + (message + netMessage);
                    textBox.Text += data;
                }));
            }
            else
            {
                string data = textBox.Text.Length == 0 ? (message + netMessage) : "\r\n" + (message + netMessage);
                textBox.Text += data;
            }
        }
        public string GetTextBox(TextBox tb)
        {
            string result = "";
            // 생성된 스레드가 아닌 다른 스레드에서 호출될 경우 true
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate ()
                {
                    result = tb.Text;
                }));
            }
            else
            {
                result = tb.Text;
            }
            return result;
        }
        public static string GetComboBox(ComboBox cb)
        {
            string result = "";
            // 생성된 스레드가 아닌 다른 스레드에서 호출될 경우 true
            if (cb.InvokeRequired)
            {
                cb.Invoke(new MethodInvoker(delegate ()
                {
                    result = cb.Text;
                }));
            }
            else
            {
                result = cb.Text;
            }
            return result;
        }
        public void SetTextBox(TextBox tb, string data)
        {
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate ()
                {
                    tb.Text = data;
                }));
            }
            else
            {
                tb.Text = data;
            }
        }
        public void SetComboBox(ComboBox cb, string data)
        {
            if (cb.InvokeRequired)
            {
                cb.Invoke(new MethodInvoker(delegate ()
                {
                    cb.Text = data;
                }));
            }
            else
            {
                cb.Text = data;
            }
        }
        #endregion
    }
    public struct ClientInfo
    {
        public string message;
        public Socket socket;

        public ClientInfo(string message, Socket socket)
        {
            this.message = message;
            this.socket = socket;
        }
    }
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
}
