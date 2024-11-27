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
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void MenuItemAdverts_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide();
            OwnAds ownAds = new OwnAds();
            ownAds.Show();
        }

        private void MenuItemFavorites_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide();
            Favorites favorites = new Favorites();
            favorites.Show();
        }

        private void linkLblCreateAd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide(); 
            CreateAd createAd = new CreateAd();
            createAd.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }
    }
}
