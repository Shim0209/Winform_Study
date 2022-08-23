using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFlatUI
{
    public partial class panelSideMenu : Form
    {
        public panelSideMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        #region Left Panel
        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible)
                panelMediaSubMenu.Visible = false;
            if (panelPlaylistSubMenu.Visible)
                panelPlaylistSubMenu.Visible = false;
            if (panelToolsSubMenu.Visible)
                panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void openChildForm()
        {
            // https://www.youtube.com/watch?v=JP5rgXO_5Sk 13:45부터
        }
    }
}
