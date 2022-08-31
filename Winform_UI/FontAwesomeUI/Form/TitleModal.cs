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
    public partial class TitleModal : Form
    {
        private Control labelTitle;

        public TitleModal(Control control)
        {
            InitializeComponent();
            labelTitle = control;

            //@ inifile에서 실험명 읽어서 comboBoxTitle item에 넣기
        }

        private void btnSetTitle_Click(object sender, EventArgs e)
        {
            if(textBoxTitle.Text != null && textBoxTitle.Text != "")
            {
                //@ inifile에 저장 기능 추가

                labelTitle.Text = textBoxTitle.Text;

                this.Close();
            }
            else
            {
                MessageBox.Show("실험명을 입력해주세요.");
            }
        }

        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text != null && textBoxTitle.Text != "")
            {
                //@ inifile에 저장된 실헝명 삭제

                textBoxTitle.Text = "";
            }
            else
            {
                MessageBox.Show("실험명을 입력해주세요.");
            }
        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxTitle.Text = comboBoxTitle.SelectedText;
        }
    }
}
