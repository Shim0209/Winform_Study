using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Protocol_01;

namespace Protocol_01_Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        #region Variable
        // sender
        int ServerPortNo;
        string ServerIP;

        // listener
        int Default_MyPortNo = 7000;
        string MyIP;

        TcpClient client;
        bool IsConnected = false;
        #endregion

        #region Form
        private void Client_Load(object sender, EventArgs e)
        {
            // Form 실행과 동시에 Listener 동작
            MyIP = GetLocalIP();
            AsyncListener();
            // Log작성 메소드 등록
            MessageUtil.WriteLog += WriteLog;
        }
        #endregion

        #region 이벤트
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            ServerIP = ServerIpTB.Text.Length == 0 ? "" : ServerIpTB.Text;
            ServerPortNo = ServerPortTB.Text.Length == 0 ? 0 : int.Parse(ServerPortTB.Text);

            if (checkServerIPPORT())
            {
                try
                {
                    client = new TcpClient(ServerIP, ServerPortNo);
                    ServerIpTB.Enabled = false;
                    ServerPortTB.Enabled = false;
                    IsConnected = true;
                    MessageBox.Show("Server와 연결하였습니다.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
            else
            {
                MessageBox.Show("ServerIp와 Port를 확인하세요.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            client.Close();

            IsConnected = false;

            ServerIpTB.Enabled = true;
            ServerPortTB.Enabled = true;

            MessageBox.Show("Server와의 연결을 해제하였습니다.");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
                return;
            }

            if (!client.Connected)
            {
                client = new TcpClient(ServerIP, ServerPortNo);
            }

            if (DataTB.Text != "")
            {
                try
                {
                    Protocol_01.Message message = MessageUtil.GetStartMsg(DataTB.Text);
                    MessageUtil.Send(client, message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Data를 입력하세요.");
            }
            
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
                return;
            }

            if (!client.Connected)
            {
                client = new TcpClient(ServerIP, ServerPortNo);
            }
            
            try
            {
                Protocol_01.Message message = MessageUtil.GetEndMsg();
                MessageUtil.Send(client, message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
                return;
            }
            if (!client.Connected)
            {
                client = new TcpClient(ServerIP, ServerPortNo);
            }
            
            if(PxCB.Text != "" && VisionCB.Text != "")
            {
                Protocol_01.Message message = MessageUtil.GetRequestMsg(PxCB.Text, VisionCB.Text);
                MessageUtil.Send(client, message);
            }
            else
            {
                MessageBox.Show("Px와 VISION 값을 선택하세요.");
            }
        }
        #endregion

        #region Listener
        async Task AsyncListener()
        {
            Debug.WriteLine("Client_AsyncListener()_1");
            TcpListener listener = new TcpListener(IPAddress.Parse(MyIP), Default_MyPortNo);
            listener.Start();

            IpPortInfoTB.Text = $"{MyIP}<{Default_MyPortNo}>를 열었습니다.";

            while (true)
            {
                Debug.WriteLine("Client_AsyncListener()_2");
                // 비동기 Accept
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                Debug.WriteLine("Client_AsyncListener()_3");
                // 처리는 MessageUtil의 Receive 메소드에서 함.
                Task.Factory.StartNew(MessageUtil.Receive, tc);
                
                Debug.WriteLine("Client_AsyncListener()_4");
            }
        }
        #endregion

        #region Utile
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
        private bool checkServerIPPORT()
        {
            if (ServerPortNo != 0 && ServerIP != "")
                return true;
            return false;
        }

        // MessageUtil.WriteLog Action에 넘겨줄 메소드
        public void WriteLog(string message, string flag)
        {
            Debug.WriteLine("Client_WriteLog()_1 : " + message + " " + flag);
            if (flag == "send") // 보낸 메세지 (송신)
            {
                Debug.WriteLine("Client_WriteLog()_2-1 : " + flag);
                LogTB.Text += "송신 메세지 : " + message +"\r\n";
            }
            else if(flag == "result") // 응답받은 메세지 (송신 후 결과)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "송신 결과 메세지 : " + message + "\r\n";
                LogTB.Text += Environment.NewLine;
            }
            else if(flag == "rec") // 받은 메세지 (수신)

            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "수신 메세지 : " + message + "\r\n";
            }
            else // resp 응답한 메세지 (수신 후 응답)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "수신 후 응답 메세지 : " + message +"\r\n";
            }
        }
        #endregion
    }
}