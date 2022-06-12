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
                // �񵿱� Accept
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                // ó���� MessageUtil�� Receive �޼ҵ忡�� ��.
                await MessageUtil.Receive(tc, StartResult, EndResult, RequestResult, RotationResult, WriteLog);
            }
        }
        #endregion

        #region Sender

        #endregion

        #region Deligate
        // Client �ܿ��� ������.
        public bool StartResult() { return true; }
        // Client �ܿ��� ������.
        public bool EndResult() { return true; }
        // Client �ܿ��� ������.
        public Value RequestResult(string pickerNo, string visionName) { return new Value("", "", ""); }
        
        
        public bool RotationResult(string pickerNo, string rotationNo)
        {
            // @@�����ؾ���
            return true;
        }

        public void WriteLog(string message, string flag)
        {
            if(flag == "rec") // ���� �޼���
            {
                LogTB.Text = "�����޼��� : "+message;
            }
            else // ���� �޼���
            {
                LogTB.Text = "�����Ѹ޼��� : " + message;
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