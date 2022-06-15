using Protocol_01;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace Protocol_01_Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        #region Variable
        // sender
        int ClientPortNo;
        string ClientIP;

        // listener
        int Default_MyPortNo = 7001;
        string MyIP;

        TcpClient client;
        bool IsConnected = false;
        #endregion
        
        #region Form
        private void Server_Load(object sender, EventArgs e)
        {
            MyIP = GetLocalIP();
            AsyncListener();

            MessageUtil.WriteLog += WriteLog;
        }
        #endregion

        #region 이벤트
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            ClientIP = ClientIpTB.Text.Length == 0 ? "" : ClientIpTB.Text;
            ClientPortNo = ClientPortTB.Text.Length == 0 ? 0 : int.Parse(ClientPortTB.Text);

            if (checkClientIPPORT())
            {
                try
                {
                    client = new TcpClient(ClientIP, ClientPortNo);
                    ClientIpTB.Enabled = false;
                    ClientPortTB.Enabled = false;
                    IsConnected = true;
                    MessageBox.Show("Client와 연결하였습니다.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ClientIP와 Port를 확인하세요.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            client.Close();

            IsConnected = false;

            ClientIpTB.Enabled = true;
            ClientPortTB.Enabled = true;

            MessageBox.Show("Client와의 연결을 해제하였습니다.");
        }

        private void RotationBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Client와의 연결을 확인하세요.");
                return;
            }

            if (!client.Connected)
            {
                client = new TcpClient(ClientIP, ClientPortNo);
            }

            if (PxCB.Text != "" && RxCB.Text != "" && DataTB.Text != "")
            {
                Protocol_01.Message message = MessageUtil.GetRotationMsg(PxCB.Text, RxCB.Text, DataTB.Text);
                MessageUtil.Send(client, message);
            }
            else
            {
                MessageBox.Show("Px, RotationNo, Data 값을 확인하세요.");
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
        private bool checkClientIPPORT()
        {
            if (ClientPortNo != 0 && ClientIP != "")
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
                LogTB.Text += "송신 메세지 : " + message + "\r\n";
            }
            else if (flag == "result") // 응답받은 메세지 (송신 후 결과)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "송신 결과 메세지 : " + message + "\r\n";
                LogTB.Text += Environment.NewLine;
            }
            else if (flag == "rec") // 받은 메세지 (수신)

            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "수신 메세지 : " + message + "\r\n";
            }
            else // resp 응답한 메세지 (수신 후 응답)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "수신 후 응답 메세지 : " + message + "\r\n";
            }
        }
        #endregion

        
    }
}