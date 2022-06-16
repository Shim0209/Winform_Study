using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketCommunication_Client
{
    public partial class Machine : Form
    {
        private byte[] buff;
        private const int MaxSize = 4096;
        private string Host = "172.30.1.57";
        private int Port = 7000;
        
        public Machine()
        {
            InitializeComponent();
        }

        private void Machine_Load(object sender, EventArgs e)
        {

        }
    }
}
