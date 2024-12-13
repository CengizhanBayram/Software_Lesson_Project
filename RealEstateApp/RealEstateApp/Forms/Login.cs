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
        public static int userId = 0;

        // Veritabanı bağlantı bilgileri
        string connectionString = "Server=localhost;Database=emlak;Uid=root;Pwd=16072001;";

        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            linkLblToRegister.Text = "If you don't have an account please click here to register.";
            linkLblToRegister.LinkArea = new LinkArea(42, 4);
            textBoxEmail.Text = "ferhat3169@hotmail.com";
            textBoxPassword.Text = "123456";
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            bool isValid = true;

            if (string.IsNullOrEmpty(email))
            {
                errorProviderEmail.SetError(textBoxEmail, "Email field cannot be empty.");
                isValid = false;
            }
            else
                errorProviderEmail.Clear();

            if (string.IsNullOrEmpty(password))
            {
                errorProviderPassword.SetError(textBoxPassword, "Password field cannot be empty.");
                isValid = false;
            }
            else
                errorProviderPassword.Clear();

            if (isValid)
            {
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
                                string idQuery = "SELECT UserID FROM users WHERE email = @email AND password = @password;";
                                MySqlCommand idCommand = new MySqlCommand(idQuery, connection);
                                idCommand.Parameters.AddWithValue("@email", email);
                                idCommand.Parameters.AddWithValue("@password", password);

                                object result = idCommand.ExecuteScalar();
                                userId = result != null ? Convert.ToInt32(result) : 0; // Kullanıcı ID'sini global değişkene atama

                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Main mainForm = (Main)this.ParentForm;
                                mainForm.ShowFormInPanel(new Homepage());
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
        }


        private void linkLblToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.ShowFormInPanel(new Register());
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
            Main mainForm = (Main)this.ParentForm;
            mainForm.ShowFormInPanel(new Homepage());
        }

    }
}
