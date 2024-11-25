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
        string connectionString = "Server=localhost;Database=test_db;Uid=root;Pwd=123456;";
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            linkLblToRegister.Text = "If you don't have an account please click here to register.";
            linkLblToRegister.LinkArea = new LinkArea(35, 4);

            //lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            //btnLogin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            //linkLblToRegister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill the email and password fields.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE Email = @email AND Password = @password;";
                    
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);

                        int userCount = Convert.ToInt32(command.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // After successfuly login new form will be open 
                            this.Hide();
                            Homepage hp = new Homepage();
                            hp.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error occured: " + ex.Message);
            }
        }


        private void linkLblToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

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

    }
}
