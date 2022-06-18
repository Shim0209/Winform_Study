using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCommunication_Client
{
    public partial class Machine : Form
    {
        #region 초기화 및 속성, 델리게이트
        // 송신
        private Socket m_VisionPCSocket; // VisionPC로 요청할 때 사용 (요청용)
        private Socket cbSock; // VisionPC에게 요청 후 결과 데이터를 받을 때 사용 (결과값 수신용)
        private byte[] recBuff; // 요청 후 받을 결과값용 버퍼
        private string Machine_IP = "";
        private int Machine_Port = 7000;
        // 수신
        private Socket m_MachineSocket; // VisionPC에서 요청하는 데이터를 수신할 때 사용 (요청 수신용)
        private Socket m_ReceiveSocket; // VisionPC의 요청에 대한 결과를 응답할 때 사용 (요청 응답용)
        private byte[] buff; // 수신용 버퍼
        private string receiveData;
        public Machine()
        {
            InitializeComponent();
        }
        private void Machine_Load(object sender, EventArgs e)
        {
            m_MachineSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // @@@수정필요@@@
            Machine_IP = GetLocalIP();
            IPAddress ServerIP = IPAddress.Parse(Machine_IP);
            
            IPEndPoint ipep = new IPEndPoint(ServerIP, 7001);
            m_MachineSocket.Bind(ipep);
            m_MachineSocket.Listen(100);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs();
            args.Completed += new EventHandler<SocketAsyncEventArgs>(Accept_Completed);
            m_MachineSocket.AcceptAsync(args);

            showMessage(Rx_ReceiveTB, $"{ServerIP}<7001>을 열었습니다.","");
        }
        #endregion

        #region 수신
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
                ClientSocket.ReceiveAsync(args);
            }
            else
            {
                e.AcceptSocket = null;
                m_MachineSocket.AcceptAsync(e);
            }
        }

        private void Receive_Completed(object sender, SocketAsyncEventArgs e)
        {
            Socket ClientSocket = (Socket)sender;

            if(ClientSocket.Connected && e.BytesTransferred > 0)
            {
                byte[] buff = e.Buffer;
                receiveData = Encoding.Unicode.GetString(buff);

                if(receiveData.IndexOf("<") == 0 || receiveData.IndexOf(">") != -1)
                {
                    showMessage(Rx_ReceiveTB, "받은 데이터 : ", receiveData);

                    for(int i = 0; i < buff.Length; i++)
                    {
                        buff[i] = 0;
                    }
                    e.SetBuffer(buff, 0, 1024);
                    ClientSocket.ReceiveAsync(e);
                }
            }
            else
            {
                ClientSocket.Disconnect(false);
                m_ReceiveSocket = null;
                showMessage(Rx_ReceiveTB, "연결 끊김 : ", ClientSocket.RemoteEndPoint.ToString());
            }
        }

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
                else // NCK
                {
                    // picker, vision, command, data, message
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
                    byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                    m_ReceiveSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
                    showMessage(Rx_ReceiveTB, "응답한 데이터 : ", respData);
                }
            }
            else
            {
                showMessage(Rx_ReceiveTB, "응답할 요청이 없습니다.", "");
            }
            
        }
        #endregion

        #region 송신
        private void Tx_SendBtn_Click(object sender, EventArgs e)
        {
            recBuff = new byte[1024];
            this.DoConnect();
        }

        public void DoConnect()
        {
            if(m_VisionPCSocket == null)
            {
                m_VisionPCSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.BeginConnect();
            }
            else
            {
                BeginSend(CreateMessage());
            }
        }

        public void BeginConnect()
        {
            showMessage(Tx_ResultTB, "서버 접속 대기 중...", "");
            try
            {
                showMessage(Tx_ResultTB, "서버 접속 성공", "");
                m_VisionPCSocket.BeginConnect(Machine_IP, Machine_Port, new AsyncCallback(ConnectCallBack), m_VisionPCSocket);
            }catch(SocketException e)
            {
                showMessage(Tx_ResultTB, "서버 접속 실패...", e.NativeErrorCode + "");
                this.DoConnect();
            }
        }

        private void ConnectCallBack(IAsyncResult IAR)
        {
            try
            {
                Socket tempSocket = (Socket)IAR.AsyncState;
                IPEndPoint serverEP = (IPEndPoint)tempSocket.RemoteEndPoint;

                tempSocket.EndConnect(IAR);
                cbSock = tempSocket;
                cbSock.BeginReceive(this.recBuff, 0, this.recBuff.Length, SocketFlags.None, new AsyncCallback(OnReceiveCallBack), cbSock);

                string tempData = CreateMessage();
                this.BeginSend(tempData);
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

        public void OnReceiveCallBack(IAsyncResult IAR)
        {
            try
            {
                Socket tempSocket = (Socket)IAR.AsyncState;
                int nReadSize = tempSocket.EndReceive(IAR); 

                if(nReadSize > 0)
                {
                    string strData = Encoding.Unicode.GetString(recBuff, 0, nReadSize);
                    showMessage(Tx_ResultTB, "응답받은 결과 : ", strData);
                }

                this.Receive();
            }
            catch(SocketException e)
            {
                if (e.SocketErrorCode == SocketError.ConnectionReset)
                {
                    this.BeginConnect();
                }
            }
        }

        public void Receive()
        {
            cbSock.BeginReceive(this.recBuff, 0, this.recBuff.Length, SocketFlags.None, new AsyncCallback(OnReceiveCallBack), cbSock);
        }

        public void BeginSend(string message)
        {
            try
            {
                if (m_VisionPCSocket.Connected && message != "")
                {
                    byte[] buffer = Encoding.Unicode.GetBytes(message);

                    m_VisionPCSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(SendCallBack), message);
                }else
                {
                    showMessage(Tx_ResultTB, "데이터가 누락되었습니다.", "");
                }
            }
            catch(SocketException e)
            {
                showMessage(Tx_ResultTB, "전송에러 : ", e.Message);
            }
        }

        private void SendCallBack(IAsyncResult IAR)
        {
            string message = (string)IAR.AsyncState;
            showMessage(Tx_ResultTB, "전송한 데이터 : ", message);
        }

        private string CreateMessage()
        {
            string result = "";
            if (GetComboBox(Tx_PickerCB) != "" && GetComboBox(Tx_VisionCB) != "" && GetComboBox(Tx_CommandCB) != "")
            {
                if (GetComboBox(Tx_CommandCB) == "START")
                {
                    if (GetTextBox(Tx_DataTB) != "")
                        result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + "," + GetTextBox(Tx_DataTB) + ">";
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    result = "<" + GetComboBox(Tx_PickerCB) + "," + GetComboBox(Tx_VisionCB) + "," + GetComboBox(Tx_CommandCB) + ">";
                }
            }
            else
            {
                return "";
            }
            return result;
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
