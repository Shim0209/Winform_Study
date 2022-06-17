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
    public struct RespSet
    {
        public string requestData;
        public Socket requestSocket;
    }
    public partial class Machine : Form
    {
        /*private Socket m_MachineSocket; // Machine으로 요청할 때 사용 (요청용)
        private Socket m_VisionPCSocket; // Machine에서 요청하는 데이터를 수신할 때 사용 (요청 수신용)
        private Socket m_ReceiveSocket; // Machine의 요청에 대한 결과를 응답할 때 사용 (요청 응답용)
        private Socket cbSock; // Machine에게 요청 후 결과 데이터를 받을 때 사용 (결과값 수신용)
        private byte[] buff; // 수신용 버퍼
        private byte[] recBuff; // 요청 후 받을 결과값용 버퍼
        private string VisionPC_IP = "";
        private int VisionPC_Port = 7000;
        private string receiveData; /*/

        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {

        }
      
    }
}
