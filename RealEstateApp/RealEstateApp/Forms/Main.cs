using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateApp.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Main_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new Login());
        }

        public void ShowFormInPanel(Form formToShow)
        {
            panel1.Controls.Clear();
            formToShow.TopLevel = false; // Formu ana formun içine göm
            formToShow.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldır
            formToShow.Dock = DockStyle.Fill; // Paneli tamamen kapla
            panel1.Controls.Add(formToShow);
            formToShow.Show();
        }
    }
}
