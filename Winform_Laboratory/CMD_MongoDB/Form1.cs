using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMD_MongoDB
{
    public partial class Form1 : Form
    {
        private Process cmd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string command = tbCommand.Text;
            if(command == null || command == "")
            {
                MessageBox.Show("명령어를 입력하세요.");
                return;
            }

            tbHistory.AppendText(command+"\r\n");

            string[] commands = GetCommand(command);

            startCMD();

            for (int i = 0; i < commands.Length; i++)
            {
                cmd.StandardInput.Write(commands[i] + Environment.NewLine);
            }
            cmd.StandardInput.Close();
            
            string result = cmd.StandardOutput.ReadToEnd();
            tbResultView.AppendText(result + "\n");
        }

        private void startCMD()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.CreateNoWindow = true; // flase가 띄우기, true가 안 띄우기
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            //startInfo.Arguments = "/C" + command;

            cmd = new Process();
            cmd.StartInfo = startInfo;
            cmd.Start();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResultView.Clear();
        }

        private string[] GetCommand(string commands)
        {
            string[] result = commands.Split(',');
            return result;
        }
    }
}
