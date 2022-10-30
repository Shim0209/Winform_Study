using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTester
{
    public partial class ucTcpip : UserControl
    {
        Form1 form1 = null;

        StreamReader StreamReader;
        StreamWriter StreamWriter;

        public ucTcpip(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }

        private void ucTcpip_Load(object sender, EventArgs e)
        {
            
        }

        #region 서버 Open/Close
        private void btnTcpipOpen_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(OpenPort);
            serverThread.IsBackground = true;
            serverThread.Start();
        }

        private void btnTcpipClose_Click(object sender, EventArgs e)
        {

        }

        private void OpenPort()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse(tbTcpipOpenIp.Text), int.Parse(tbTcpipOpenPort.Text));

            tcpListener.Start(); // 서버 시작
            // 로그 작성

            TcpClient tcpClient = tcpListener.AcceptTcpClient(); // 클라이언트 접속 확인
            // 로그 작성

            StreamReader reader = new StreamReader(tcpClient.GetStream());

            while (tcpClient.Connected)
            {
                string receiveMsg = reader.ReadLine();
                WriteToViewPoint(receiveMsg);
            }
        }

        private void WriteToViewPoint(string str)
        {
            form1.tbViewPoint.Invoke((MethodInvoker)delegate { form1.tbViewPoint.AppendText(str + "\r\n"); });
        }
        #endregion

        #region 클라이언트 Connect/Disconnect
        private void btnTcpipConnect_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(ConnectToServer);
            

        }

        private void btnTcpipDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void ConnectToServer()
        {
            TcpClient tcpClient = new TcpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(tbTcpipTargetIp.Text), int.Parse(tbTcpipTargetPort.Text));
            tcpClient.Connect(iPEndPoint);
            // 로그 작성

            StreamWriter = new StreamWriter(tcpClient.GetStream());
            StreamWriter.AutoFlush = true;

            @@@@@@@@@@@@@@@@@@
            센트버튼 메인폼에 만들고 버튼 눌리면 uctcpip의 메소드 실행되도록 만들어보기
        }
        #endregion

        #region 유틸
        private void btnTcpipPing_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
