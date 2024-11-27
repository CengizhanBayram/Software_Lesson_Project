using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace RealEstateApp.Forms
{
    public partial class Login : Form
    {

        // Veritabanı bağlantı bilgileri
        string connectionString = "Server=localhost;Database=real_estate;Uid=root;Pwd=123456;";
        
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            linkLblToRegister.Text = "If you don't have an account please click here to register.";
            linkLblToRegister.LinkArea = new LinkArea(42, 4);
            CenterPanel();
        }

        private void CenterPanel()
        {
            // Formun genişliği ve yüksekliği
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Panelin genişliği ve yüksekliği
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            // Panelin sol üst köşesini hesapla
            int panelX = (formWidth - panelWidth) / 2;
            int panelY = (formHeight - panelHeight) / 2;

            // Panelin yeni konumunu ayarla
            panel1.Location = new Point(panelX, panelY);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill the email and password fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE email = @email AND password = @password;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Homepage hp= new Homepage();
                            hp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Invalid User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }


        private void linkLblToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }


        internal object btnLogin_Click()
        {
            throw new NotImplementedException();
        }
        public bool AuthenticateUser(string email, string password)
        {
            if (email == "valid_user@example.com" && password == "123456")
                return true;

            return false;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }
    }
}
