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

namespace HelloMetroUI
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        Thread t;
        public frmMain()
        {
            t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
        }

        void Loading()
        {
            frmSplashScreen frm = new frmSplashScreen();
            Application.Run(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 임시 조건
            for (int i = 0; i <= 1000; i++)
                Thread.Sleep(10);

            // Complete
            // 프로그램 시작에 필요한 모든게 로딩 완료되면
            // 아래 명령어 실행하여 SplashScreen을 종료하고 Main을 업시킨다.
            t.Abort(); 
        }
    }
}
