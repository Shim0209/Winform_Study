using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontAwesomeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            openChildForm(new View());
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            openChildForm(new Data());
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(btnRun.IconChar == FontAwesome.Sharp.IconChar.Play)
            {
                btnRun.IconChar = FontAwesome.Sharp.IconChar.Stop;
                btnRun.IconColor = Color.Red;
                btnRun.Text = "Stop";
            }
            else
            {
                btnRun.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnRun.IconColor = Color.GreenYellow;
                btnRun.Text = "Run";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.IconChar == FontAwesome.Sharp.IconChar.Play)
            {
                btnSave.IconChar = FontAwesome.Sharp.IconChar.Stop;
                btnSave.IconColor = Color.Red;
                btnSave.Text = "Stop Save";
            }
            else
            {
                btnSave.IconChar = FontAwesome.Sharp.IconChar.Play;
                btnSave.IconColor = Color.GreenYellow;
                btnSave.Text = "Save";
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Form titleModal = new TitleModal(labelTitle);
            titleModal.StartPosition = FormStartPosition.CenterScreen;
            titleModal.ShowDialog();
        }

        private void btnSetting_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hi");
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form settingModal = new SettingModal();
            settingModal.StartPosition = FormStartPosition.CenterScreen;
            settingModal.ShowDialog();
        }
    }
}
