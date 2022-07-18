using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectTrackerSharp
{
    public partial class Form1 : Form
    {
        RectTracker CSharpTracker;

        public Form1()
        {
            InitializeComponent();

            CSharpTracker = new RectTracker();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Controls.Remove(CSharpTracker);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BringToFront();
            
            button1.Capture = false;
            
            if(this.Controls.Contains(CSharpTracker))
                this.Controls.Remove(CSharpTracker);
            CSharpTracker = new RectTracker((Controls)button1);

            this.Controls.Add(CSharpTracker);
            CSharpTracker.BringToFront();
            CSharpTracker.Draw();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BringToFront();

            button2.Capture = false;

            if (this.Controls.Contains(CSharpTracker))
                this.Controls.Remove(CSharpTracker);
            CSharpTracker = new RectTracker((Controls)button2);

            this.Controls.Add(CSharpTracker);
            CSharpTracker.BringToFront();
            CSharpTracker.Draw();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.BringToFront();

            label1.Capture = false;

            if (this.Controls.Contains(CSharpTracker))
                this.Controls.Remove(CSharpTracker);
            CSharpTracker = new RectTracker((Controls)label1);

            this.Controls.Add(CSharpTracker);
            CSharpTracker.BringToFront();
            CSharpTracker.Draw();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.BringToFront();

            textBox1.Capture = false;
            if (this.Controls.Contains(CSharpTracker))
                this.Controls.Remove(CSharpTracker);
            CSharpTracker = new RectTracker(textBox1);

            this.Controls.Add(CSharpTracker);
            CSharpTracker.BringToFront();
            CSharpTracker.Draw();
        }
    }
}
