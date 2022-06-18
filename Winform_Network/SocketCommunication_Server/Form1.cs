using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCommunication_Server
{
    public partial class VisionPC : Form
    {
        #region 초기화 및 속성, 델리게이트
        // 송신
        private Socket m_MachineSocket; // Machine으로 요청할 때 사용 (요청용)
        private Socket cbSock; // Machine에게 요청 후 결과 데이터를 받을 때 사용 (결과값 수신용)
        private byte[] recBuff; // 요청 후 받을 결과값용 버퍼
        private string VisionPC_IP = "";
        private int VisionPC_Port = 7001;

        // 수신
        private Socket m_VisionPCSocket; // Machine에서 요청하는 데이터를 수신할 때 사용 (요청 수신용)
        private Socket m_ReceiveSocket; // Machine의 요청에 대한 결과를 응답할 때 사용 (요청 응답용)
        private byte[] buff; // 수신용 버퍼
        private string receiveData; // 받은 요청 데이터를 저장

        // 메인스레드에서 실행중인 Control에 다른 스레드가 접근시 에러발생 => 해결을 위한 델리게이트
        //delegate void ctrl_Invoke(TextBox ctrl, string message, string netMessage);

        public VisionPC()
        {
            InitializeComponent();
        }

        private void VisionPC_Load(object sender, EventArgs e)
        {
            m_VisionPCSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // @@@수정필요@@@ 테스트용 IP 할당 => 원래 VisionPC_IP는 따로 할당해줘야함.
            VisionPC_IP = GetLocalIP();
            IPAddress ServerIP = IPAddress.Parse(VisionPC_IP);

            IPEndPoint ipep = new IPEndPoint(ServerIP, 7000);
            m_VisionPCSocket.Bind(ipep);
            m_VisionPCSocket.Listen(100);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs(); // 소켓이벤트
            args.Completed += new EventHandler<SocketAsyncEventArgs>(Accept_Completed); // 접속 이벤트 발생시 Accept_Completed 실행
            m_VisionPCSocket.AcceptAsync(args); // 접속 대기

            showMessage(Rx_ReceiveTB, $"{ServerIP}<7000>을 열었습니다.", "");
            //MessageBox.Show($"{ServerIP}<7000>을 열었습니다.");
        }
        #endregion

        #region 수신
        // Machine의 연결요청 허락
        private void Accept_Completed(object sender, SocketAsyncEventArgs e)
        {
            Socket ClientSocket = e.AcceptSocket;
            
            m_ReceiveSocket = ClientSocket;
            if (ClientSocket != null)
            {
                showMessage(Rx_ReceiveTB, "연결된 소켓 : ", ClientSocket.RemoteEndPoint.ToString());
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
                m_VisionPCSocket.AcceptAsync(e); // 요청 소켓 처리 후 다시 접속 대기
            }
        }

        // Machine의 요청 데이터 수신
        private void Receive_Completed(object sender, SocketAsyncEventArgs e)
        {
            Socket ClientSocket = (Socket)sender;

            if (ClientSocket.Connected && e.BytesTransferred > 0) // 소켓 접속 유무 확인 및 수신한 데이터 크기 체크
            {
                byte[] buff = e.Buffer; // 데이터 수신
                receiveData = Encoding.Unicode.GetString(buff);

                // 수신한 데이터 STX, ETX 체크
                if (receiveData.IndexOf("<") == 0 || receiveData.IndexOf(">") != -1)
                {
                    // ReceiveTB 출력
                    showMessage(Rx_ReceiveTB, "받은 데이터 : " , receiveData);

                    // 버퍼 초기화 및 다시 데이터 수신대기
                    //SocketAsyncEventArgs args = new SocketAsyncEventArgs();
                    for (int i = 0; i < buff.Length; i++)
                    {
                        buff[i] = 0;
                    }
                    e.SetBuffer(buff, 0, 1024);
                    ClientSocket.ReceiveAsync(e);
                }
                else
                {
                    ClientSocket.Disconnect(false);
                    m_ReceiveSocket = null;
                    showMessage(Rx_ReceiveTB, "연결 끊김 : ", ClientSocket.RemoteEndPoint.ToString());
                }
            }
        }

        // Machine의 요청에 대한 응답을 보내는 클릭이벤트
        private void Rx_RespBtn_Click(object sender, EventArgs e)
        {
            if(receiveData != null)
            {
                string strData = receiveData;
                strData.Replace("<", "").Replace(">", "");
                string[] splitData = strData.Split(',');
                string respData = "";
                bool errorFlag = false;

                if (Rx_DataCB.Text == "ACK")
                {
                    if (splitData[2] == "REQUEST")
                    {
                        //picker, vision, command, data, x, y, z
                        if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "" && Rx_X_TB.Text != "" && Rx_Y_TB.Text != "" && Rx_Z_TB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + "," + Rx_X_TB.Text + "," + Rx_Y_TB.Text + "," + Rx_Z_TB.Text + ">";
                        }
                        else
                        {
                            errorFlag = true;
                        }
                    }
                    else
                    {
                        //picker, vision, command, data
                        if (Rx_PickerCB.Text != "" && Rx_VisionCB.Text != "" && Rx_CommandCB.Text != "" && Rx_DataCB.Text != "")
                        {
                            respData = "<" + Rx_PickerCB.Text + "," + Rx_VisionCB.Text + "," + Rx_CommandCB.Text + "," + Rx_DataCB.Text + ">";
                        }
                        else
                        {
                            errorFlag = true;
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
                    else
                    {
                        errorFlag = true;
                    }
                }

                if (errorFlag)
                {
                    showMessage(Rx_ReceiveTB, "누락된 데이터가 있습니다.", "");
                }
                else
                {
                    // 전송
                    byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                    m_ReceiveSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
                    showMessage(Rx_ReceiveTB, "응답한 데이터 : ", respData);
                }
            }
            else
            {
                showMessage(Rx_ReceiveTB, "응답할 요청이 없습니다.", "");
            }

            //m_ReceiveSocket.BeginSend(byteRespData, 0, byteRespData.Length, SocketFlags.None, new AsyncCallback(RespCallBack), respData);
        }

        /*private void RespCallBack(IAsyncResult IAR)
        {
            Debug.WriteLine("RespCallBack()");
            string message = (string)IAR.AsyncState;
            showMessage(Rx_ReceiveTB, "응답한 데이터 : ", message);
        }*/
        #endregion

        #region 송신
        // Machine에게 요청하는 클릭이벤트
        private void Tx_SendBtn_Click(object sender, EventArgs e)
        {
            recBuff = new byte[1024];
            // 서버연결
            this.DoConnect();
        }

        // Machine과 연결하기 위한 소켓 생성
        public void DoConnect()
        {
            if (m_MachineSocket == null)
            {
                m_MachineSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.BeginConnect();
            }
            else // 연속받기 핵심
            {
                BeginSend(CreateMessage());
            }
        }

        // Machine과 소켓 연결
        public void BeginConnect()
        {
            showMessage(Tx_ResultTB, "서버 접속 대기 중...", "");
            try
            {
                showMessage(Tx_ResultTB, "서버 접속 성공", "");
                // 비동기 방식
                m_MachineSocket.BeginConnect(VisionPC_IP, VisionPC_Port, new AsyncCallback(ConnectCallBack), m_MachineSocket);

            }
            catch (SocketException e)
            {
                showMessage(Tx_ResultTB, "서버 접속 실패...", e.NativeErrorCode + "");
                this.DoConnect();
            }
        }

        // 요청에 대한 응답을 받기위한 버퍼 및 이벤트 등록
        // 요청하기 위한 메세지 생성
        private void ConnectCallBack(IAsyncResult IAR)
        {
            try
            {
                // 보류중인 연결을 완성
                Socket tempSocket = (Socket)IAR.AsyncState;
                IPEndPoint serverEP = (IPEndPoint)tempSocket.RemoteEndPoint;

                tempSocket.EndConnect(IAR);
                cbSock = tempSocket;
                cbSock.BeginReceive(this.recBuff, 0, this.recBuff.Length, SocketFlags.None, new AsyncCallback(OnReceiveCallBack), cbSock);

                string tempData = CreateMessage();
                this.BeginSend(tempData);
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.NotConnected)
                {
                    showMessage(Tx_ResultTB, "서버 접속 실패", e.Message);
                    this.BeginConnect();
                }
            }
        }

        // 테스트용
        // 테스트후 Machine으로 옮기고 여기는 내용수정
        // 데이터 생성
        private string CreateMessage()
        {
            string result = "";
            if (GetComboBox(Tx_PickerCB) != "" && GetComboBox(Tx_VisionCB) != "" && GetComboBox(Tx_CommandCB) != "" && GetTextBox(Tx_DataTB) != "")
            {
                result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + "," + GetTextBox(Tx_DataTB) + ">";
            }
            else
            {
                result = "";
            }
            return result;
        }

        // Machine에게 요청

        public void BeginSend(string message)
        {
            try
            {
                if (m_MachineSocket.Connected %% message != "")
                {
                    byte[] buffer = Encoding.Unicode.GetBytes(message);

                    // 비동기 전송
                    m_MachineSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), message);
                }
                else
                {
                    showMessage(Tx_ResultTB, "데이터가 누락되었습니다.", "");
                }
            }
            catch (SocketException e)
            {
                showMessage(Tx_ResultTB, "전송에러", e.Message);
            }
        }

        private void SendCallBack(IAsyncResult IAR)
        {
            string message = (string)IAR.AsyncState;
            showMessage(Tx_ResultTB, "전송한 데이터 : ", message);
        }

        // Machine과의 지속적인 통신을 위한 수신이벤트 등록
        public void Receive()
        {
            cbSock.BeginReceive(recBuff, 0, recBuff.Length, SocketFlags.None, new AsyncCallback(OnReceiveCallBack), cbSock);
        }
        
        // 수신이벤트
        private void OnReceiveCallBack(IAsyncResult IAR)
        {
            try
            {
                Socket tempSocket = (Socket)IAR.AsyncState;
                int nReadSize = tempSocket.EndReceive(IAR);
                
                if (nReadSize > 0)
                {
                    string strData = Encoding.Unicode.GetString(recBuff, 0, nReadSize);
                    showMessage(Tx_ResultTB, "응답받은 결과 : " , strData);
                }

                // 연속받기 핵심
                this.Receive();
            }
            catch (SocketException e)
            {
                if (e.SocketErrorCode == SocketError.ConnectionReset)
                {
                    this.BeginConnect();
                }
            }
        }
        #endregion

        #region 유틸
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

        #region 크로스 스레드 방지 메소드
        private void showMessage(TextBox textBox, string message, string netMessage)
        {
            if (textBox.InvokeRequired)
            {
                //textBox.Invoke(new ctrl_Invoke(showMessage), textBox, message, netMessage);

                textBox.Invoke(new MethodInvoker(delegate ()
                {
                    string data = textBox.Text.Length == 0 ? (message + netMessage) : "\r\n" + (message + netMessage);
                    textBox.Text += data;
                }));
            }
            else
            {
                string data = textBox.Text.Length == 0 ? (message + netMessage) : "\r\n" + (message + netMessage);
                textBox.Text += data;
            }
        }

        public string GetTextBox(TextBox tb)
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

        #endregion
    }
}
