using RealEstateApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateApp
{
    public partial class navbar : UserControl
    {
        public navbar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox1, new Point(0, pictureBox1.Height));
        }

        private void MenuItemProfile_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.ShowFormInPanel(new Profile());
        }

        private void MenuItemAdverts_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.ShowFormInPanel(new OwnAds());
        }

        private void MenuItemFavorites_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.ShowFormInPanel(new Favorites());
        }

        private void linkLblCreateAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.ShowFormInPanel(new CreateAd());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];
            mainForm.ShowFormInPanel(new Homepage());
        }
    }
}
