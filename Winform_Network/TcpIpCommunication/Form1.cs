using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace TcpIpCommunication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            ServerIpTB.Text = GetLocalIP();
            ServerPortTB.Text = Default_ServerPortNo.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #endregion

        #region 전역변수
        TcpListener listener;
        string clientServerIp;
        int clientServerPort;

        const int Default_ServerPortNo = 7000;
        const string Default_ServerIP = "127.0.0.1";
        const int FirstServerConnect = 0;
        const int ServerConnect = 1;
        #endregion

        #region 클라이언트
        // Client ServerIP, Port 체크
        private bool checkServerIPPORT()
        {
            if (clientServerPort != 0 && clientServerIp != "")
                return true;
            return false;
        }

        // Client Open btn이벤트
        private void ClientOpenBtn_Click(object sender, EventArgs e)
        {
            clientServerIp = ClientIpTB.Text.Length == 0 ? "" : ClientIpTB.Text;
            clientServerPort = ClientPortTB.Text.Length == 0 ? 0 : int.Parse(ClientPortTB.Text);

            if (checkServerIPPORT())
            {
                // IP,Port 상태 업그레이드
                ClientIpPortTB.Text = ClientIpTB.Text + "<" + int.Parse(ClientPortTB.Text) + ">";

                try
                {
                    string msg = $"{GetLocalIP()}에서 서버에 접속하였습니다.";
                    MsgProcess(clientServerIp, clientServerPort, msg, FirstServerConnect);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"서버 {clientServerIp}<{clientServerPort}>의 연결 상태를 확인하세요.");
                }
            }
            else
            {
                MessageBox.Show("ServerIp와 Port를 확인하세요.");
            }


        }

        // Client Send btn이벤트
        private void ClientSendBtn_Click(object sender, EventArgs e)
        {
            Client();
        }

        // Client와 Server 접속 체크
        private void Client()
        {
            if (checkServerIPPORT())
            {
                try
                {
                    string msg = ClientMsgTB.Text;
                    MsgProcess(clientServerIp, clientServerPort, msg, ServerConnect);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"서버 {clientServerIp}<{clientServerPort}>의 연결 상태를 확인하세요.");
                }
            }
            else
            {
                MessageBox.Show("ServerIp와 Port를 확인하세요.");
            }
        }

        // Client에서 Server로 보내는 메세지
        private void MsgProcess(string clientServerIp, int clientServerPort, string msg, int flag)
        {
            TcpClient client = new TcpClient(clientServerIp, clientServerPort);

            byte[] buff = Encoding.UTF8.GetBytes(msg);

            NetworkStream stream = client.GetStream();

            // 스트림에 바이트 데이터 전송
            stream.Write(buff, 0, buff.Length);

            // 스트림으로부터 바이트 데이터 읽기
            byte[] outbuf = new byte[1024];
            int nbytes = stream.Read(outbuf, 0, outbuf.Length);
            string output = Encoding.UTF8.GetString(outbuf);

            if (flag == 0)
            {
                WriteClientDisplayTB($"{clientServerIp}<{clientServerPort}>에 접속하였습니다.");
            }
            else
            {
                WriteClientDisplayTB(msg);
            }

            stream.Close();
            client.Close();


            /*if (IsServerConnected(client))
            {
                
            }
            else
            {
                MessageBox.Show($"{clientServerIp}<{clientServerPort}>서버와 연결되어 있지 않습니다.");
            }*/
        }

        // Client 출력창 메세지 표시
        private void WriteClientDisplayTB(string msg)
        {
            ClientDisplayTB.Text += msg + "\r\n";
        }

        // Client Close btn 이벤트
        private void ClientCloseBtn_Click(object sender, EventArgs e)
        {
            clientServerIp = "";
            clientServerPort = 0;

            // IP,Port 상태 업그레이드
            ClientIpPortTB.Text = "";
        }
        #endregion

        #region 서버
        // Server Open btn 이벤트
        private void ServerOpenBtn_Click(object sender, EventArgs e)
        {
            AsyncServer();
        }

        // Server 비동기 클라이언트 접속
        private async Task AsyncServer()
        {
            // 서버 Default IP = 127.0.0.1, Default Port = 7000
            IPAddress serverIp = ServerIpTB.Text.Length == 0 ? IPAddress.Parse(GetLocalIP()) : IPAddress.Parse(ServerIpTB.Text);
            int serverPort = ServerPortTB.Text.Length == 0 ? Default_ServerPortNo : int.Parse(ServerPortTB.Text);

            listener = new TcpListener(serverIp, serverPort);

            // IP,Port 상태 업그레이드
            ServerIpPortTB.Text = serverIp + "<" + serverPort + ">";

            try
            {
                listener.Start();
                MessageBox.Show("서버 시작됨");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            byte[] buff = new byte[1024];

            while (true)
            {
                // Client의 요청을 받아들여 서버에서 새 TcpClient 객체를 생성하여 리턴
                TcpClient client = await listener.AcceptTcpClientAsync().ConfigureAwait(false);

                //ServerDisplayTB.Text = $"{client.Client.LocalEndPoint}, {client.Client.RemoteEndPoint}, {client.Client.LocalEndPoint.AddressFamily.ToString()}\r\n";

                Task.Factory.StartNew(AsyncTcpProcess, client);
            }
        }

        // Server 비동기 메세지 수신 및 송신
        async void AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;

            int MAX_SIZE = 1024;
            NetworkStream stream = tc.GetStream();
            string msg = "";
            var buff = new byte[MAX_SIZE];
            var nbytes = await stream.ReadAsync(buff, 0, buff.Length).ConfigureAwait(false);
            if (nbytes > 0)
            {
                msg = Encoding.UTF8.GetString(buff, 0, nbytes);

                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
            }

            WriteServerDisplayTB(msg);

            stream.Close();
        }

        // Server 출력창 메세지 표시
        private void WriteServerDisplayTB(string msg)
        {
            ServerDisplayTB.Invoke((MethodInvoker)delegate
            {
                ServerDisplayTB.Text += msg + "\r\n";
            });
        }



        // Server Cloese btn 이벤트
        private void ServerCloseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listener.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // IP,Port 상태 업그레이드
            ServerIpPortTB.Text = "";
        }
        #endregion

        #region 유틸
        // 로컬 IP 가져오는 메소드
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

        // 현재 연결중인 TCP의 연결 상태를 가졍는 메소드
        private bool IsServerConnected(TcpClient client)
        {
            // 로컬 PC에 연결된 모든 TCP 커넥션 정보를 가져온다.
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();

            TcpConnectionInformation[] tcpConnections;

            try
            {
                // 특정 IP와의 통신 상태 여부를 위해 받아온 client의 연결정보를 가져온다.
                tcpConnections = ipProperties.GetActiveTcpConnections()
                    .Where(x => x.LocalEndPoint.Equals(client.Client.LocalEndPoint) && x.RemoteEndPoint.Equals(client.Client.RemoteEndPoint))
                    .ToArray();
            }
            catch
            {
                // 서버와 연결 안됨
                return false;
            }

            if (tcpConnections != null && tcpConnections.Length > 0)
            {
                // TCP 상태 가져오기
                TcpState stateOfConnection = tcpConnections.First().State;
                if (stateOfConnection == TcpState.Established)
                    return true;
                else
                    return false;
            }

            // 서버와 연결 안됨
            return false;
        }
        #endregion

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
