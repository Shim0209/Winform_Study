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

        #region �̺�Ʈ
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
                    MessageBox.Show("Client�� �����Ͽ����ϴ�.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ClientIP�� Port�� Ȯ���ϼ���.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            client.Close();

            IsConnected = false;

            ClientIpTB.Enabled = true;
            ClientPortTB.Enabled = true;

            MessageBox.Show("Client���� ������ �����Ͽ����ϴ�.");
        }

        private void RotationBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Client���� ������ Ȯ���ϼ���.");
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
                MessageBox.Show("Px, RotationNo, Data ���� Ȯ���ϼ���.");
            }
        }
        #endregion

        #region Listener
        async Task AsyncListener()
        {
            Debug.WriteLine("Client_AsyncListener()_1");
            TcpListener listener = new TcpListener(IPAddress.Parse(MyIP), Default_MyPortNo);
            listener.Start();

            IpPortInfoTB.Text = $"{MyIP}<{Default_MyPortNo}>�� �������ϴ�.";

            while (true)
            {
                Debug.WriteLine("Client_AsyncListener()_2");
                // �񵿱� Accept
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                Debug.WriteLine("Client_AsyncListener()_3");
                // ó���� MessageUtil�� Receive �޼ҵ忡�� ��.
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

        // MessageUtil.WriteLog Action�� �Ѱ��� �޼ҵ�
        public void WriteLog(string message, string flag)
        {
            Debug.WriteLine("Client_WriteLog()_1 : " + message + " " + flag);
            if (flag == "send") // ���� �޼��� (�۽�)
            {
                Debug.WriteLine("Client_WriteLog()_2-1 : " + flag);
                LogTB.Text += "�۽� �޼��� : " + message + "\r\n";
            }
            else if (flag == "result") // ������� �޼��� (�۽� �� ���)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "�۽� ��� �޼��� : " + message + "\r\n";
                LogTB.Text += Environment.NewLine;
            }
            else if (flag == "rec") // ���� �޼��� (����)

            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "���� �޼��� : " + message + "\r\n";
            }
            else // resp ������ �޼��� (���� �� ����)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "���� �� ���� �޼��� : " + message + "\r\n";
            }
        }
        #endregion

        
    }
}