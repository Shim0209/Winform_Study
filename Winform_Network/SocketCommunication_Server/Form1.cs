using System;
using System.Collections.Generic;
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
        private Socket m_ServerSocket; // 서버소켓
        private Queue<RespSet> m_ClientSockets; // 요청한 클라이언트 소켓, 메세지 큐. 순서대로 응답하기 위함
        private byte[] buff; // 클라이언트 데이터 수신용 버퍼

        public VisionPC()
        {
            InitializeComponent();
        }

        private void VisionPC_Load(object sender, EventArgs e)
        {
            m_ClientSockets = new Queue<RespSet>();
            m_ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 7000);
            m_ServerSocket.Bind(ipep);
            m_ServerSocket.Listen(100);

            SocketAsyncEventArgs args = new SocketAsyncEventArgs(); // 소켓이벤트
            args.Completed += new EventHandler<SocketAsyncEventArgs>(Accept_Completed); // 접속 이벤트 발생시 Accept_Completed 실행
            m_ServerSocket.AcceptAsync(args); // 접속 대기
        }

        private void Accept_Completed(object sender, SocketAsyncEventArgs e)
        {
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
            if (m_ClientSockets.Count != 0)
            {
                // Queue에서 가장 앞에있는 값을 출력
                RespSet nextSocketData = m_ClientSockets.First();

                Rx_ReceiveTB.Text = nextSocketData.requestData;
            }
            else
            {
                Rx_ReceiveTB.Text = "";
            }
        }

        private void Rx_RespBtn_Click(object sender, EventArgs e)
        {
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
                        if(Rx_PickerCB.Text != null && Rx_VisionCB.Text != null && Rx_CommandCB != null && Rx_DataCB.Text != null && Rx_X_TB != null && Rx_Y_TB != null && Rx_Z_TB != null)
                        {
                            respData = "<" + Rx_PickerCB.Text + Rx_VisionCB.Text + Rx_CommandCB.Text + Rx_DataCB.Text + Rx_X_TB.Text + Rx_Y_TB.Text + Rx_Z_TB.Text + ">";
                        }
                    }
                    else
                    {
                        //picker, vision, command, data
                        if (Rx_PickerCB.Text != null && Rx_VisionCB.Text != null && Rx_CommandCB != null && Rx_DataCB.Text != null)
                        {
                            respData = "<" + Rx_PickerCB.Text + Rx_VisionCB.Text + Rx_CommandCB.Text + Rx_DataCB.Text + ">";
                        }
                    }
                }
                else // NCK
                {
                    // picker, vision, command, data, message
                    //picker, vision, command, data
                    if (Rx_PickerCB.Text != null && Rx_VisionCB.Text != null && Rx_CommandCB != null && Rx_DataCB.Text != null && Rx_MessageTB.Text != null)
                    {
                        respData = "<" + Rx_PickerCB.Text + Rx_VisionCB.Text + Rx_CommandCB.Text + Rx_DataCB.Text + Rx_MessageTB.Text + ">";
                    }
                }

                // 전송
                byte[] byteRespData = Encoding.Unicode.GetBytes(respData);
                nextSocketData.requestSocket.Send(byteRespData, byteRespData.Length, SocketFlags.None);
            }
            else
            {
                MessageBox.Show("응답할 요청이 없습니다.");
            }
        }
    }
}
;