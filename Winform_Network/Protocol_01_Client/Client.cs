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
            // Form ����� ���ÿ� Listener ����
            MyIP = GetLocalIP();
            AsyncListener();
            // Log�ۼ� �޼ҵ� ���
            MessageUtil.WriteLog += WriteLog;
        }
        #endregion

        #region �̺�Ʈ
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
                    MessageBox.Show("Server�� �����Ͽ����ϴ�.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }
            }
            else
            {
                MessageBox.Show("ServerIp�� Port�� Ȯ���ϼ���.");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            client.Close();

            IsConnected = false;

            ServerIpTB.Enabled = true;
            ServerPortTB.Enabled = true;

            MessageBox.Show("Server���� ������ �����Ͽ����ϴ�.");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Server���� ������ Ȯ���ϼ���.");
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
                MessageBox.Show("Data�� �Է��ϼ���.");
            }
            
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                MessageBox.Show("Server���� ������ Ȯ���ϼ���.");
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
                MessageBox.Show("Server���� ������ Ȯ���ϼ���.");
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
                MessageBox.Show("Px�� VISION ���� �����ϼ���.");
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
        private bool checkServerIPPORT()
        {
            if (ServerPortNo != 0 && ServerIP != "")
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
                LogTB.Text += "�۽� �޼��� : " + message +"\r\n";
            }
            else if(flag == "result") // ������� �޼��� (�۽� �� ���)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "�۽� ��� �޼��� : " + message + "\r\n";
                LogTB.Text += Environment.NewLine;
            }
            else if(flag == "rec") // ���� �޼��� (����)

            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "���� �޼��� : " + message + "\r\n";
            }
            else // resp ������ �޼��� (���� �� ����)
            {
                Debug.WriteLine("Client_WriteLog()_2-2 : " + flag);
                LogTB.Text += "���� �� ���� �޼��� : " + message +"\r\n";
            }
        }
        #endregion
    }
}