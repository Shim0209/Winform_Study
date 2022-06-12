using System.Net;
using System.Net.Sockets;
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
        const int Default_ServerPortNo = 7001;
        const string Default_ServerIP = "127.0.0.1";

        // listener
        const int Default_MyPortNo = 7000;
        const string Default_MyIP = "127.0.0.1";
        #endregion

        #region Form
        private void Client_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Listener
        async Task AsyncListener()
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(Default_MyIP), Default_MyPortNo);
            listener.Start();

            while (true)
            {
                // 비동기 Accept
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                // 처리는 MessageUtil의 Receive 메소드에서 함.
                await MessageUtil.Receive(tc, StartResult, EndResult, RequestResult, RotationResult, WriteLog);
            }
        }
        #endregion

        #region Sender

        #endregion

        #region Deligate
        // Client 단에서 사용안함.
        public bool StartResult() { return true; }
        // Client 단에서 사용안함.
        public bool EndResult() { return true; }
        // Client 단에서 사용안함.
        public Value RequestResult(string pickerNo, string visionName) { return new Value("", "", ""); }
        
        
        public bool RotationResult(string pickerNo, string rotationNo)
        {
            // @@구현해야함
            return true;
        }

        public void WriteLog(string message, string flag)
        {
            if(flag == "rec") // 받은 메세지
            {
                LogTB.Text = "받은메세지 : "+message;
            }
            else // 보낼 메세지
            {
                LogTB.Text = "응답한메세지 : " + message;
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
        #endregion
    }
}