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
        int Default_ServerPortNo;
        string Default_ServerIP;

        // listener
        int Default_MyPortNo = 7000;
        string Default_MyIP;

        // 
        TcpClient client;
        #endregion

        #region Form
        private void Client_Load(object sender, EventArgs e)
        {
            // Form 실행과 동시에 Listener 동작
            AsyncListener();
            Default_MyIP = GetLocalIP();
            // Log작성 메소드 등록
            MessageUtil.WriteLog += WriteLog;
        }
        #endregion

        #region 이벤트
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            Default_ServerIP = ServerIpTB.Text.Length == 0 ? "" : ServerIpTB.Text;
            Default_ServerPortNo = ServerPortTB.Text.Length == 0 ? 0 : int.Parse(ServerPortTB.Text);

            if (checkServerIPPORT())
            {
                try
                {
                    client = new TcpClient(Default_ServerIP, Default_ServerPortNo);
                    ServerIpTB.Enabled = false;
                    ServerPortTB.Enabled = false;

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

            Default_ServerIP = "";
            Default_ServerPortNo = 0;

            ServerIpTB.Enabled = true;
            ServerPortTB.Enabled = true;

            MessageBox.Show("Server와의 연결을 해제하였습니다.");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                if(DataTB.Text != "")
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        Protocol_01.Message message = MessageUtil.GetStartMsg(DataTB.Text);
                        MessageUtil.Send(stream, message);
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
            else
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
            }
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    Protocol_01.Message message = MessageUtil.GetEndMsg();
                    MessageUtil.Send(stream, message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
            }
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                if(PxCB.Text != "" && VisionCB.Text != "")
                {
                    NetworkStream stream = client.GetStream();
                    Protocol_01.Message message = MessageUtil.GetRequestMsg(PxCB.Text, VisionCB.Text);
                    MessageUtil.Send(stream, message);
                }
                else
                {
                    MessageBox.Show("Px와 VISION 값을 선택하세요.");
                }
            }
            else
            {
                MessageBox.Show("Server와의 연결을 확인하세요.");
            }
        }
        #endregion

        #region Listener
        async Task AsyncListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(Default_MyIP), Default_MyPortNo);
            listener.Start();

            IpPortInfoTB.Text = $"{Default_MyIP}<{Default_MyPortNo}>를 열었습니다.";

            while (true)
            {
                // 비동기 Accept
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                // 처리는 MessageUtil의 Receive 메소드에서 함.
                Task.Factory.StartNew(MessageUtil.Receive, tc);
            }
        }
        #endregion

        #region Sender
        public void SendMsg(Protocol_01.Message message)
        {
            NetworkStream stream = client.GetStream();
            MessageUtil.Send(stream, message);
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
            if (Default_ServerPortNo != 0 && Default_ServerIP != "")
                return true;
            return false;
        }

        // MessageUtil.WriteLog Action에 넘겨줄 메소드
        public void WriteLog(string message, string flag)
        {
            if (flag == "rec") // 받은 메세지
            {
                LogTB.Text = "받은메세지 : " + message;
            }
            else // 보낼 메세지
            {
                LogTB.Text = "응답한메세지 : " + message;
            }
        }
        #endregion
    }
}