using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCommunication_Client
{
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
    public partial class Machine : Form
    {
        #region 속성 초기화
        // Queue
        private Queue<ClientInfo> m_clientInfo;

        // 송신
        private Socket m_VisionPCSocket; // VisionPC로 요청할 때 사용 (요청용)
        private string Machine_IP = "";

        // 수신
        private Socket m_MachineSocket; // VisionPC에서 요청하는 데이터를 수신할 때 사용 (요청 수신용)
        #endregion

        #region 폼 생성자, 폼 로드
        public Machine()
        {
            InitializeComponent();
        }
        private void Machine_Load(object sender, EventArgs e)
        {
            m_clientInfo = new Queue<ClientInfo>();
            OpenServer();
        }


        #endregion

        #region 수신
        private async void OpenServer()
        {
            Machine_IP = GetLocalIP();
            IPAddress ServerIP = IPAddress.Parse(Machine_IP);

            m_MachineSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(ServerIP, 7001);

            m_MachineSocket.Bind(ipep);
            m_MachineSocket.Listen(100);

            var task = AsyncServer();
            await task;
        }

        private async Task AsyncServer()
        {
            while (true)
            {
                Socket client = await m_MachineSocket.AcceptAsync();

                new Task(() =>
                {
                    showMessage(Rx_ReceiveTB, "1", "");
                    // 클라이언트 EndPoint 정보 취득
                    var ip = client.RemoteEndPoint as IPEndPoint;

                    // 클라이언트 접속정보 출력
                    showMessage(Rx_ReceiveTB, $"{ip.Address}<{ip.Port}>에서 접속하였습니다.", $"접속 시간{DateTime.Now}");

                    var sb = new StringBuilder();

                    using (client)
                    {
                        showMessage(Rx_ReceiveTB, "2", "");
                        while (true)
                        {
                            showMessage(Rx_ReceiveTB, "3", "");
                            var binary = new byte[1024];

                            client.Receive(binary);

                            var data = Encoding.Unicode.GetString(binary);

                            if (data.IndexOf(">") != -1)
                            {
                                showMessage(Rx_ReceiveTB, $"요청 메세지 끝", $"받은 시간{DateTime.Now}");
                                sb.Append(data);

                                showMessage(Rx_ReceiveTB, $"받은 데이터 {sb}", $"받은 시간{DateTime.Now}");

                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.socket = client;
                                clientInfo.message = sb.ToString();
                                m_clientInfo.Enqueue(clientInfo);

                                Rx_BoxDataWrite();
                                Rx_RequestMsgWrite();

                                sb.Clear();
                            }
                            else if (data.IndexOf("<") == 0)
                            {
                                showMessage(Rx_ReceiveTB, $"요청 메세지 시작", $"받은 시간{DateTime.Now}");

                                sb.Append(data);
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
            if (m_clientInfo.Count > 0)
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
                else // NCK
                {
                    // picker, vision, command, data, message
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
                    byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                    currentSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
                    showMessage(Rx_ReceiveTB, $"응답한 데이터 {respData}", $"응답 시간{DateTime.Now}");

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
            if (m_clientInfo.Count > 0)
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
        private async void Tx_OpenBtn_Click(object sender, EventArgs e)
        {
            if (m_VisionPCSocket == null)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(Machine_IP), 7000);

                m_VisionPCSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    m_VisionPCSocket.Connect(ipep);
                    Tx_OpenBtn.Enabled = false;
                }
                catch (SocketException se)
                {
                    showMessage(Tx_ResultTB, se.Message, $"Error 시간{DateTime.Now}");
                }
                var Task = AsyncClient();
                await Task;
            }
        }
        private void Tx_SendBtn_Click(object sender, EventArgs e)
        {
            if (m_VisionPCSocket != null)
            {
                string message = CreateMessage();
                if (message != null)
                {
                    m_VisionPCSocket.Send(Encoding.Unicode.GetBytes(message));
                    showMessage(Tx_ResultTB, $"보낸 데이터 {message}", $"보낸 시간{DateTime.Now}");
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

                    using (m_VisionPCSocket)
                    {
                        while (true)
                        {
                            var binary = new byte[1024];

                            m_VisionPCSocket.Receive(binary);

                            var data = Encoding.Unicode.GetString(binary);

                            if (data.IndexOf(">") != -1)
                            {
                                showMessage(Tx_ResultTB, $"응답 메세지 끝", $"받은 시간{DateTime.Now}");
                                sb.Append(data);

                                showMessage(Tx_ResultTB, $"응답 데이터 {sb}", $"받은 시간{DateTime.Now}");

                                sb.Clear();
                            }
                            else if (data.IndexOf("<") == 0)
                            {
                                showMessage(Tx_ResultTB, $"응답 메세지 시작", $"받은 시간{DateTime.Now}");

                                sb.Append(data);
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
            if (GetComboBox(Tx_PickerCB) != "" && GetComboBox(Tx_VisionCB) != "" && GetComboBox(Tx_CommandCB) != "")
            {
                if (GetComboBox(Tx_CommandCB) == "START")
                {
                    if (GetTextBox(Tx_DataTB) != "")
                        result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + "," + GetTextBox(Tx_DataTB) + ">";
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + ">";
                }
            }
            else
            {
                return "";
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
}
