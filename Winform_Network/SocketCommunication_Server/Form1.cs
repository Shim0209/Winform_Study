using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace SocketCommunication_Server
{
    public struct RespSet
    {
        public string requestData;
        public Socket requestSocket;
    }
    public partial class VisionPC : Form
    {
        private Socket m_ClientSocket; // 클라이언트소켓(송신용)
        private Socket m_ServerSocket; // 서버소켓(수신용)
        private Queue<RespSet> m_ClientSockets; // 요청한 클라이언트 소켓, 메세지 큐. 순서대로 응답하기 위함(수신용)
        private byte[] buff; // 클라이언트 요청 데이터 수신용 버퍼(수신용)
        private byte[] recBuff; // 요청후 결과 데이터 수신용 버퍼(송신용)
        private string HostIp = "";
        private int HostPort = 7000;
        private Socket cbSock;

        // 메인스레드에서 실행중인 Control에 다른 스레드가 접근시 에러발생 => 해결을 위한 델리게이트
        delegate void ctrl_Invoke(TextBox ctrl, string message, string netMessage);

        public VisionPC()
        {
            InitializeComponent();
        }

        private void VisionPC_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("VisionPC_Load()");
            m_ClientSockets = new Queue<RespSet>();
            m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // @@@수정필요@@@ 테스트용 IP 할당 => 원래 HostIp는 따로 할당해줘야함.
            HostIp = GetLocalIP();
            IPAddress ServerIP = IPAddress.Parse(HostIp);

            IPEndPoint ipep = new IPEndPoint(ServerIP, 7000);
            m_ServerSocket.Bind(ipep);
            m_ServerSocket.Listen(100);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs(); // 소켓이벤트
            args.Completed += new EventHandler<SocketAsyncEventArgs>(Accept_Completed); // 접속 이벤트 발생시 Accept_Completed 실행
            m_ServerSocket.AcceptAsync(args); // 접속 대기

            showMessage(Rx_ReceiveTB, $"{ServerIP}<7000>을 열었습니다.", "");
            //MessageBox.Show($"{ServerIP}<7000>을 열었습니다.");
        }

        private void Accept_Completed(object sender, SocketAsyncEventArgs e)
        {
            Debug.WriteLine("Accept_Completed()");
            Socket ClientSocket = e.AcceptSocket;

            if (ClientSocket != null)
            {
                SocketAsyncEventArgs args = new SocketAsyncEventArgs();
                buff = new byte[1024];
                args.SetBuffer(buff, 0, buff.Length);
                args.UserToken = e.AcceptSocket;
                args.Completed += new EventHandler<SocketAsyncEventArgs>(Receive_Completed);
                ClientSocket.ReceiveAsync(args); // 수락된 소켓의 데이터수신 대기
            }
            else
            {
                e.AcceptSocket = null;
                m_ServerSocket.AcceptAsync(e); // 요청 소켓 처리 후 다시 접속 대기
            }
        }

        private void Receive_Completed(object sender, SocketAsyncEventArgs e)
        {
            Debug.WriteLine("Receive_Completed()");
            Socket ClientSocket = (Socket)sender;
            if(ClientSocket.Connected && e.BytesTransferred > 0) // 소켓 접속 유무 확인 및 수신한 데이터 크기 체크
            {
                byte[] buff = e.Buffer; // 데이터 수신
                string strData = Encoding.Unicode.GetString(buff);

                // 수신한 데이터 STX, ETX 체크
                if(strData.IndexOf("<") != 0 || strData.IndexOf(">") == -1) // '<'로 시작 안하거나, '>' 포함안되어 있으면 NG 
                {
                    ClientSocket.Disconnect(false); // 소켓재사용 X
                    MessageBox.Show($"{strData}는 잘못된 형식의 메세지입니다. {ClientSocket.RemoteEndPoint.ToString()}의 연결이 끊어졌습니다.");
                }
                else
                {
                    // Queue에 저장
                    RespSet respSet;
                    respSet.requestData = strData;
                    respSet.requestSocket = ClientSocket;
                    m_ClientSockets.Enqueue(respSet);
                    
                    // 버퍼 초기화 및 다시 데이터 수신대기
                    for(int i = 0; i < buff.Length; i++)
                    {
                        buff[i] = 0;
                    }
                    e.SetBuffer(buff, 0, buff.Length);
                    ClientSocket.ReceiveAsync(e);

                    // ReceiveTB 출력
                    Write_ReceiveTB();
                }
            }
        }

        private void Write_ReceiveTB()
        {
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Debug.WriteLine("Write_ReceiveTB()");
            if (m_ClientSockets.Count != 0)
            {
                // Queue에서 가장 앞에있는 값을 출력
                RespSet nextSocketData = m_ClientSockets.First();

                showMessage(Rx_ReceiveTB, nextSocketData.requestData, "");
                //Rx_ReceiveTB.Text = nextSocketData.requestData;
            }
            else
            {
                showMessage(Rx_ReceiveTB, "", "");
                //Rx_ReceiveTB.Text = "";
            }
        }

        private void Rx_RespBtn_Click(object sender, EventArgs e)
        {
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            Debug.WriteLine("Rx_RespBtn_Click()");
            if(m_ClientSockets.Count != 0)
            {
                // 어떤 요청인지에 따라 폼 검사
                RespSet nextSocketData = m_ClientSockets.Dequeue();
                string strData = nextSocketData.requestData;
                strData.Replace("<", "").Replace(">","");
                string[] splitData = strData.Split(',');
                string respData = "";

                if(Rx_DataCB.Text == "ACK")
                {
                    if (splitData[2] == "REQUEST")
                    {
                        //picker, vision, command, data, x, y, z
                        if(Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "" && Rx_X_TB.Text != "" && Rx_Y_TB.Text != "" && Rx_Z_TB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + "," + Rx_X_TB.Text + "," + Rx_Y_TB.Text + "," + Rx_Z_TB.Text + ">";
                        }
                    }
                    else
                    {
                        //picker, vision, command, data
                        if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + ">";
                        }
                    }
                }
                else // NCK
                {
                    // picker, vision, command, data, message
                    //picker, vision, command, data
                    if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "" && Rx_MessageTB.Text != "")
                    {
                        respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + "," + Rx_MessageTB.Text + ">";
                    }
                }

                // 전송
                byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                nextSocketData.requestSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
                Write_ReceiveTB();
                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            }
            else
            {
                MessageBox.Show("응답할 요청이 없습니다.");
            }
        }

        private string GetLocalIP()
        {
            Debug.WriteLine("GetLocalIP()");
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            return localIP;
        }

        private void Tx_SendBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Tx_SendBtn_Click()");
            recBuff = new byte[4096];
            // 서버연결
            this.DoConnect();
        }

        public void DoConnect()
        {
            Debug.WriteLine("DoConnect()");
            m_ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.BeginConnect();
        }

        public void BeginConnect()
        {
            Debug.WriteLine("BeginConnect()");
            showMessage(Tx_ResultTB, "서버 접속 대기 중...", "");
            try
            {
                // 비동기 방식
                m_ClientSocket.BeginConnect(HostIp, HostPort, new AsyncCallback(ConnectCallBack), m_ClientSocket);
            }
            catch(SocketException e)
            {
                showMessage(Tx_ResultTB, "서버 접속 실패...", e.NativeErrorCode + "");
                this.DoConnect();
            }
        }
        private void ConnectCallBack(IAsyncResult IAR)
        {
            Debug.WriteLine("ConnectCallBack()");
            try
            {
                // 보류중인 연결을 완성
                Socket tempSocket = (Socket)IAR.AsyncState;
                IPEndPoint serverEP = (IPEndPoint)tempSocket.RemoteEndPoint;

                showMessage(Tx_ResultTB, "서버 접속 성공", serverEP.Address + "");

                //tempSocket.EndAccept(IAR);
                cbSock = tempSocket;
                cbSock.BeginReceive(recBuff, 0, recBuff.Length, SocketFlags.None, new AsyncCallback(OnReceiveCallBack), cbSock);

                // VisionPC용
                // 문자열 점검 
                // 문자열 만들어서 전송
                /*if(Tx_PickerCB.Text != null && Tx_VisionCB.Text != null && Tx_CommandCB.Text != null && Tx_DataTB != null)
                {
                    this.BeginSend("<" + Tx_PickerCB.Text + "," + Tx_VisionCB.Text + "," + Tx_CommandCB.Text + "," + Tx_DataTB.Text + ">");
                }
                else
                {
                    showMessage(Tx_ResultTB, "메세지 구조를 선택하세요.", "");
                }*/


                // 테스트용
                // 테스트후 Machine으로 옮길것
                if (GetComboBox(Tx_PickerCB) != null && GetComboBox(Tx_VisionCB) != null && GetComboBox(Tx_CommandCB) != null)
                {
                    if(GetComboBox(Tx_CommandCB) == "START")
                    {
                        if (GetTextBox(Tx_DataTB) != null)
                            this.BeginSend("<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + "," + GetTextBox(Tx_DataTB) + ">");
                        else
                        {
                            showMessage(Tx_ResultTB, "메세지 데이터를 입력하세요", "");
                        }
                    }
                    else
                    {
                        this.BeginSend("<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + ">");
                    }
                }
                else
                {
                    showMessage(Tx_ResultTB, "메세지 데이터를 입력하세요.", "");
                }


            }
            catch(SocketException e)
            {
                if(e.SocketErrorCode == SocketError.NotConnected)
                {
                    showMessage(Tx_ResultTB, "서버 접속 실패", e.Message);
                    this.BeginConnect();
                }
            }
        }

        public void BeginSend(string message)
        {
            Debug.WriteLine("BeginSend()");
            try
            {
                if (m_ClientSocket.Connected)
                {
                    byte[] buffer = Encoding.Unicode.GetBytes(message);

                    // 비동기 전송
                    m_ClientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), message);
                }
            }
            catch(SocketException e)
            {
                showMessage(Tx_ResultTB, "전송에러", e.Message);
            }
        }

        private void SendCallBack(IAsyncResult IAR)
        {
            Debug.WriteLine("SendCallBack()");
            string message = (string)IAR.AsyncState;
            showMessage(Tx_ResultTB, "전송완료 CallBack", message);
        }

        private void OnReceiveCallBack(IAsyncResult IAR)
        {
            Debug.WriteLine("OnReceiveCallBack()");
            try
            {
                Socket tempSocket = (Socket)IAR.AsyncState;
                int nReadSize = tempSocket.EndReceive(IAR);
                if(nReadSize != 0)
                {
                    string strData = Encoding.Unicode.GetString(recBuff, 0, nReadSize);
                    showMessage(Tx_ResultTB, strData, "");
                }
            }
            catch(SocketException e)
            {
                if(e.SocketErrorCode == SocketError.ConnectionReset)
                {
                    this.BeginConnect();
                }
            }
        }

        #region 크로스 스레드 방지 메소드
        private void showMessage(TextBox textBox, string message, string netMessage)
        {
            Debug.WriteLine("showMessage() : " + message);
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new ctrl_Invoke(showMessage), textBox, message, netMessage);
            }
            else
            {
                textBox.Clear();
                textBox.Text = (message + netMessage);
            }
        }

        public static string GetTextBox(TextBox tb)
        {
            string result = "";
            // 생성된 스레드가 아닌 다른 스레드에서 호출될 경우 true
            if (tb.InvokeRequired)
            {
                tb.Invoke(new MethodInvoker(delegate ()
                {
                    result = tb.Text;
                }));
            }
            else
            {
                result = tb.Text;
            }
            return result;
        }

        public static string GetComboBox(ComboBox cb)
        {
            string result = "";
            // 생성된 스레드가 아닌 다른 스레드에서 호출될 경우 true
            if (cb.InvokeRequired)
            {
                cb.Invoke(new MethodInvoker(delegate ()
                {
                    result = cb.Text;
                }));
            }
            else
            {
                result = cb.Text;
            }
            return result;
        }
        #endregion
    }
}
