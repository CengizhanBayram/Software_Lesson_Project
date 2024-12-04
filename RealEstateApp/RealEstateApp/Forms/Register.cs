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
        string connectionString = "Server=localhost;Database=real_estate;Uid=root;Pwd=123456;";

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            linkLblToLogin.Text = "If you already have an account, click here to log in.";
            linkLblToLogin.LinkArea = new LinkArea(38, 4);
        }


        private void linkLblToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Main mainForm = (Main)this.ParentForm;
            mainForm.ShowFormInPanel(new Login());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxFullName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmPassword = textBoxConfirmPassword.Text.Trim();
            bool isValid = true;


            if(string.IsNullOrEmpty(username))
            {
                errorProvider1.SetError(textBoxFullName, "This field cannot be empty.");
                isValid = false;
            }
            else
                errorProvider1.Clear();


            if (string.IsNullOrEmpty(email))
            {
                errorProvider2.SetError(textBoxEmail, "This field cannot be empty.");
                isValid = false;
            }
            else
                errorProvider2.Clear();


            if (string.IsNullOrEmpty(password))
            {
                errorProvider3.SetError(textBoxPassword, "This field cannot be empty.");
                isValid = false;
            }
            else
                errorProvider3.Clear();


            if (string.IsNullOrEmpty(confirmPassword))
            {
                errorProvider4.SetError(textBoxConfirmPassword, "This field cannot be empty.");
                isValid = false;
            }
            else
                errorProvider4.Clear();



            if (isValid)
            {

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
                        string checkQuery = "SELECT COUNT(*) FROM Users WHERE email = @email";

                        using (MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@email", email);
                            long emailExists = (long)checkCommand.ExecuteScalar();

                            if (emailExists > 0)
                            {
                                MessageBox.Show("An account with this email address already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }


                        string query = "INSERT INTO Users (username, email, password) VALUES (@username, @email, @password)";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Parametreleri ekle
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@email", email);
                            command.Parameters.AddWithValue("@password", password);

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Main mainForm = (Main)this.ParentForm;
                                mainForm.ShowFormInPanel(new Login());
                            }
                            else
                            {
                                MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Regex 
            return Regex.IsMatch(email, emailPattern);
        }

    }
}
