using MySql.Data.MySqlClient; //database
using System.Text.RegularExpressions; //regex

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace RealEstateApp.Forms
{
    public partial class Register : Form
    {
        // Veritabanı bağlantı bilgileri
        string connectionString = "Server=localhost;Database=test_db;Uid=root;Pwd=123456;";

        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            linkLblToLogin.Text = "If you already have an account, click here to log in.";
            linkLblToLogin.LinkArea = new LinkArea(38, 4);
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

        private void linkLblToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill the required fields.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords does not match.");
                return;
            }

            

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // checking Email is used before
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Email", email);
                        long emailExists = (long)checkCommand.ExecuteScalar();

                        if (emailExists > 0)
                        {
                            MessageBox.Show("An account with this email address already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    string query = "INSERT INTO Users (FullName, Email, Password) VALUES (@FullName, @Email, @Password)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int result = command.ExecuteNonQuery();
                        Console.WriteLine("@@@@@@@@@@@@@@@@@@"+result);

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Register formunu kapat
                            Login login = new Login();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex 
            return Regex.IsMatch(email, emailPattern);
        }

    }
}
