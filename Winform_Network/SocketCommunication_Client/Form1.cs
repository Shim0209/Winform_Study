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

        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {

        }
      
    }
}
