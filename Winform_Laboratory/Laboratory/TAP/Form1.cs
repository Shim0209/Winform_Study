using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAP
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

        #region Event
        private void lv1_Btn_Click(object sender, EventArgs e)
        {
            string time = Level1();
            WriteStatus($"동기적처리 경과시간 => {time}\r\n");
        }
        private void lv2_Btn_Click(object sender, EventArgs e)
        {

        }

        private void lv3_Btn_Click(object sender, EventArgs e)
        {

        }

        private void lv4_Btn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Processor
        // 동기적
        private string Level1()
        {
            DateTime startTime = DateTime.Now;

            Coffee cup = PourCoffee();
            WriteStatus("=> Coffee is ready\r\n");

            Egg eggs = FryEggs(2);
            WriteStatus("=> Eggs is ready\r\n");

            Bacon bacon = FryBacon(3);
            WriteStatus("=> Bacon is ready\r\n");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            WriteStatus("=> Toast is ready\r\n");

            Juice oj = PourOJ();
            WriteStatus("=> OrangeJuice is ready\r\n");

            WriteStatus("=> Breakfast is ready\r\n");

            TimeSpan endTime = DateTime.Now - startTime;
            return String.Format("{0:hh\\:mm\\:ss}", endTime);
        }

        // 차단하는 대신 대기
        private async Task<string> Level2()
        {
            DateTime startTime = DateTime.Now;

            Coffee cup = PourCoffee();
            WriteStatus("=> Coffee is ready\r\n");

            Egg eggs = await Fry
            WriteStatus("=> Eggs is ready\r\n");
            WriteStatus("=> Bacon is ready\r\n");
            WriteStatus("=> Toast is ready\r\n");
            WriteStatus("=> OrangeJuice is ready\r\n");
            WriteStatus("=> Breakfast is ready\r\n");
            TimeSpan endTime = DateTime.Now - startTime;
            return string.Format("{0:hh\\:mm\\:ss}", endTime);
        }

        private string Level3()
        {
            DateTime startTime = DateTime.Now;
            WriteStatus("=> Coffee is ready\r\n");
            WriteStatus("=> Eggs is ready\r\n");
            WriteStatus("=> Bacon is ready\r\n");
            WriteStatus("=> Toast is ready\r\n");
            WriteStatus("=> OrangeJuice is ready\r\n");
            WriteStatus("=> Breakfast is ready\r\n");

            TimeSpan endTime = DateTime.Now - startTime;
            return string.Format("{0:hh\\:mm\\:ss}", endTime);
        }

        private string Level4()
        {
            DateTime startTime = DateTime.Now;
            WriteStatus("=> Coffee is ready\r\n");
            WriteStatus("=> Eggs is ready\r\n");
            WriteStatus("=> Bacon is ready\r\n");
            WriteStatus("=> Toast is ready\r\n");
            WriteStatus("=> OrangeJuice is ready\r\n");
            WriteStatus("=> Breakfast is ready\r\n");

            TimeSpan endTime = DateTime.Now - startTime;
            return string.Format("{0:hh\\:mm\\:ss}", endTime);
        }
        #endregion

        #region action method
        private Juice PourOJ()
        {
            WriteStatus("Pouring orange juice");
            Task.Delay(1000).Wait();

            OJ_LB.BackColor = Color.Green;
            return new Juice(); 
        }

        private void ApplyJam(Toast toast)
        {
            WriteStatus("Putting Jam on the toast");
            Task.Delay(1000).Wait();

            Jam_LB.BackColor = Color.Green;
        }

        private void ApplyButter(Toast toast)
        {
            WriteStatus("Putting butter on the toast");
            Task.Delay(1000).Wait();

            Butter_LB.BackColor = Color.Green;
        }

        private Toast ToastBread(int slices)
        {
            for(int slice = 0; slice < slices; slice++)
            {
                WriteStatus("Putting a slice of bread in the toaster");
            }
            WriteStatus("Start toasting...");
            Task.Delay(3000).Wait();
            WriteStatus("Remove toast from toaster");

            Toast_LB.BackColor = Color.Green;
            return new Toast();
        }

        private Bacon FryBacon(int slices)
        {
            WriteStatus($"Putting {slices} slices of bacon in the pan");
            WriteStatus("Cooing first side of bacon");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                WriteStatus("Flippinga slice of bacoe");
            }
            WriteStatus("Cooking the second side of bacon");
            Task.Delay(3000).Wait();
            WriteStatus("Put bacon on plate");

            Bacon_LB.BackColor = Color.Green;
            return new Bacon();
        }

        private Egg FryEggs(int howMany)
        {
            WriteStatus("Waiming the egg pan...");
            Task.Delay(3000).Wait();
            WriteStatus($"Cracking {howMany} eggs");
            WriteStatus("Cooking the eggs ...");
            Task.Delay(3000).Wait();
            WriteStatus("Put eggs on plate");

            Egg_LB.BackColor = Color.Green; 
            return new Egg();
        }

        private Coffee PourCoffee()
        {
            WriteStatus("Pouring coffee");
            Task.Delay(1000).Wait();

            Coffee_LB.BackColor = Color.Green;
            return new Coffee();    
        }
        #endregion


        public void WriteStatus(string message)
        {
            Status_TB.Text += message + "\r\n";
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Status_TB.Clear();
            Coffee_LB.BackColor = Color.White;
            OJ_LB.BackColor = Color.White;
            Jam_LB.BackColor = Color.White;
            Butter_LB.BackColor = Color.White;
            Bacon_LB.BackColor = Color.White;
            Egg_LB.BackColor= Color.White;
            Toast_LB.BackColor = Color.White;
        }
    }

    internal class Coffee { };
    internal class Bacon { };
    internal class Egg { };
    internal class Toast { };
    internal class Juice { };
}
