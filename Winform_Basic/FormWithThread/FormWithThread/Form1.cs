using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWithThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void MainThreadTB_TextChanged(object sender, EventArgs e)
        {
            MainThreadTB2.Text = MainThreadTB.Text;
        }

        private async void OnBtn_Click(object sender, EventArgs e)
        {
            MainThreadCall();
        }

        private void OffBtn_Click(object sender, EventArgs e)
        {

        }

        public async Task MainThreadCall()
        {
            await Task.Run(() => MainThread());
        }

        public async Task MainThread()
        {
            Action act1 = Count;
            Action act2 = RCount;
            await Task.Run(act1);
            await Task.Run(act2);

            int i = 0;
            while (true)
            {
                if (Sub0ThreadTB.InvokeRequired)
                {
                    Sub0ThreadTB.Invoke(new MethodInvoker(delegate ()
                    {
                        Sub0ThreadTB.Text += i.ToString() + "\r\n";
                    }));
                }
                else
                {
                    Sub0ThreadTB.Text += i.ToString() + "\r\n";
                }
                i++;
                await Task.Delay(500);
            }
        }


        public async void Count()
        {
            int i = 0;
            while (true)
            {
                if (Sub1ThreadTB.InvokeRequired)
                {
                    Sub1ThreadTB.Invoke(new MethodInvoker(delegate ()
                    {
                        Sub1ThreadTB.Text += i.ToString() + "\r\n";
                    }));
                }
                else
                {
                    Sub1ThreadTB.Text += i.ToString() + "\r\n";
                }
                i++;
                await Task.Delay(1000);
            }
        }

        public async void RCount()
        {
            int i = 1000000000;
            while (true)
            {
                if (sub2ThreadTB.InvokeRequired)
                {
                    sub2ThreadTB.Invoke(new MethodInvoker(delegate ()
                    {
                        sub2ThreadTB.Text += i.ToString() + "\r\n";
                    }));
                }
                else
                {
                    sub2ThreadTB.Text += i.ToString() + "\r\n";
                }
                i--;
                await Task.Delay(2000);
            }
        }
    }
}
