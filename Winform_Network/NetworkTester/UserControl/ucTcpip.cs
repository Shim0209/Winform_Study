using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTester
{
    public partial class ucTcpip : UserControl
    {
        Thread serverThread;
        Thread clientThread;
        StreamReader serverReader;
        StreamWriter clientWriter;
        TcpClient tcpClient;
        bool autoSend = false;

        public ucTcpip()
        {
            InitializeComponent();
        }

        private void ucTcpip_Load(object sender, EventArgs e)
        {
            tbTcpipOpenIp.Text = GetLocalIP();
            tbTcpipOpenPort.Text = "7001";
        }

        #region 서버 Open/Close
        private void btnTcpipOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serverThread = new Thread(OpenPort);
                serverThread.IsBackground = true;
                serverThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open Error [" + ex.Message + "]");
            }
        }

        private void btnTcpipClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (serverReader != null)
                {
                    serverReader.Close();
                }

                tbTcpipStatus.Invoke(new MethodInvoker(delegate
                {
                    tbTcpipStatus.AppendText(tbTcpipOpenIp.Text + "[" + tbTcpipOpenPort.Text + "]로 서버를 닫았습니다.\r\n");
                }));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Close Error [" + ex.Message + "]");
            }
        }

        private void OpenPort()
        {
            byte[] data = new byte[1048576];
            int receivedDataSize = 0;
            try
            {
                TcpListener tcpListener = new TcpListener(IPAddress.Parse(tbTcpipOpenIp.Text), int.Parse(tbTcpipOpenPort.Text));
                tbTcpipStatus.Invoke(new MethodInvoker ( delegate
                {
                    tbTcpipStatus.AppendText(tbTcpipOpenIp.Text + "[" + tbTcpipOpenPort.Text + "]로 서버를 오픈했습니다.\r\n");
                }));
                tcpListener.Start(); // 서버 시작
                TcpClient client = tcpListener.AcceptTcpClient(); // 클라이언트 접속 확인

                NetworkStream networkStream = client.GetStream();

                if (networkStream.CanRead)
                {
                    byte[] dataSize = new byte[sizeof(int)];

                    networkStream.Read(dataSize, 0, dataSize.Length);
                    Console.WriteLine("check - "+dataSize.Length);
                    do
                    {
                        receivedDataSize += networkStream.Read(data, receivedDataSize, data.Length);
                    } while (networkStream.DataAvailable);
                }

                MemoryStream memoryStream = new MemoryStream(data, 0, receivedDataSize); 
                Bitmap bitmap = new Bitmap(memoryStream);

                pbViewImage.Image = bitmap;
                pbViewImage.Visible = true;
            }
            catch(Exception ex)
            {
                if(serverReader != null) 
                { 
                    serverReader.Close();
                }
                tbTcpipStatus.Invoke(new MethodInvoker(delegate
                {
                    tbTcpipStatus.AppendText(tbTcpipOpenIp.Text + "[" + tbTcpipOpenPort.Text + "] 서버와의 연결이 끊겼습니다.\r\n");
                }));
            }
        }

        public Bitmap ByteToImage(byte[] blob)
        {
            using(MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(blob, 0, blob.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);

                Bitmap bm = new Bitmap(memoryStream);
                return bm;
            }
        }

        private void WriteToViewPoint(string str)
        {
            tbViewPoint.Invoke(new MethodInvoker(delegate
            {
                tbViewPoint.AppendText(str + "\r\n");
            }));
        }
        #endregion

        #region 클라이언트 Connect/Disconnect
        private void btnTcpipConnect_Click(object sender, EventArgs e)
        {
            try
            {
                clientThread = new Thread(ConnectToServer);
                clientThread.IsBackground = true;
                clientThread.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Error ["+ ex.Message+"]");
            }
        }

        private void btnTcpipDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(clientWriter != null)
                {
                    clientWriter.Close();
                }
                if(clientThread != null)
                {
                    clientThread.Abort();
                }
                tbViewPoint.Invoke(new MethodInvoker(delegate
                {
                    tbViewPoint.AppendText(tbTcpipTargetIp.Text + "[" + tbTcpipTargetPort.Text + "] 서버와 연결을 해제했습니다.\r\n");
                }));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Disconnect Error [" + ex.Message + "]");
            }
        }

        private void ConnectToServer()
        {
            tcpClient = new TcpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(tbTcpipTargetIp.Text), int.Parse(tbTcpipTargetPort.Text));
            tcpClient.Connect(iPEndPoint);

            tbViewPoint.Invoke(new MethodInvoker(delegate
            {
                tbViewPoint.AppendText(tbTcpipTargetIp.Text + "[" + tbTcpipTargetPort.Text + "] 서버와 연결했습니다.\r\n");
            }));

            clientWriter = new StreamWriter(tcpClient.GetStream());
            clientWriter.AutoFlush = true;
        }

        private void btnImageSend_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            Image image = null;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(ofd.FileName);
            }

            Bitmap bitmap = new Bitmap(image);
            byte[] data = ImageToByte(bitmap);

            NetworkStream networkStream = tcpClient.GetStream();
            if (networkStream.CanWrite)
            {
                byte[] dataSize = BitConverter.GetBytes(data.Length);
                networkStream.Write(dataSize, 0, dataSize.Length);

                networkStream.Write(data, 0, data.Length);
            }
        }

        private byte[] ImageToByte(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Jpeg);
            return memoryStream.ToArray();
        }

        private object lockObject = new object();
        private void btnSendBox1_Click(object sender, EventArgs e)
        {
            string msg = tbSendBox1.Text;
            for (int i = 0; i < int.Parse(tbSendSpeed1.Text); i++)
            {
                lock (lockObject)
                {
                    clientWriter.WriteLine(msg + " - " + i);
                }
            }
        }

        private void btnSendBox2_Click(object sender, EventArgs e)
        {
            string msg = tbSendBox2.Text;
            for (int i = 0; i < int.Parse(tbSendSpeed2.Text); i++)
            {
                lock (lockObject)
                {
                    clientWriter.WriteLine(msg + " - " + i);
                }
            }
        }

        private void btnSendBox3_Click(object sender, EventArgs e)
        {
            string msg = tbSendBox3.Text;
            for (int i = 0; i < int.Parse(tbSendSpeed3.Text); i++)
            {
                lock (lockObject)
                {
                    clientWriter.WriteLine(msg + " - " + i);
                }
            }
        }

        private void btnSendBox4_Click(object sender, EventArgs e)
        {
            string msg = tbSendBox4.Text;
            for (int i = 0; i < int.Parse(tbSendSpeed4.Text); i++)
            {
                lock (lockObject)
                {
                    clientWriter.WriteLine(msg + " - " + i);
                }
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            tbSendBox1.Text = "";
            tbSendBox2.Text = "";
            tbSendBox3.Text = "";
            tbSendBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbSendSpeed1.Text = "1000";
            tbSendSpeed2.Text = "1000";
            tbSendSpeed3.Text = "1000";
            tbSendSpeed4.Text = "1000";
        }
        #endregion

        #region 유틸
        private void btnTcpipPing_Click(object sender, EventArgs e)
        {
            if (PingTest(tbTcpipTargetIp.Text))
            {
                MessageBox.Show(tbTcpipTargetIp + "[" + IPStatus.Success + "]");
            }
            else
            {
                MessageBox.Show(tbTcpipTargetIp + "[ 실패 ]");
            }
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

        public bool PingTest(string ip)
        {
            // [용어]
            // ICMP (인터넷 제어 메시지 프로토콜)
            // Ttl (패킷의 생존 시간)
            //      라우터를 하나 지날때마다 -1이 된다.
            //          예) KT DNS로 핑을 때렸는데 64 -> 58로 바뀌면, 중간에 라우터 6개를 지난거임.
            //      기본값 64, 최대 255


            // ICMP 에코 요청 메시지의 결과를 설명하는 상태 코드를 정의
            Ping ping = new Ping();

            // 요청 패킬을 전달할 수 있는 횟수(Ttl) 및 조각화 DontFragment 할수 있는지 여부를 제어하는 설정을 구성하거나 검색할 수 있다.
            PingOptions options = new PingOptions();
            options.DontFragment = true;

            byte[] buf = Encoding.ASCII.GetBytes("Test");

            try
            {
                // ICMP 에코 요청의 결과를 포함
                PingReply reply = ping.Send(ip, 1000, buf, options);

                return (reply.Status == IPStatus.Success);
            }
            catch (PingException ex)
            {
                Console.WriteLine($"PingTest Error ({ex.Message})");
                return false;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            pbViewImage.Image = null;
            pbViewImage.Visible = false;
        }
    }
}
