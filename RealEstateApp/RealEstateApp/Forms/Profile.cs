using MySql.Data.MySqlClient;
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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();

        }
        int userId = Login.userId;
        private string connectionString = "Server=localhost;Database=appınfos;Uid=root;Pwd=123456;";
        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcı bilgilerini çekmek için sorgu
                    string query = "SELECT username, email, password, CreatedAt FROM users WHERE userID = @id;";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // TextBox'lara verileri yerleştir
                                txtUsername.Text = reader["username"].ToString();
                                txtEmail.Text = reader["email"].ToString();
                                txtPassword.Text = reader["password"].ToString();
                                txtCreate.Text = reader["CreatedAt"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET username = @name, email = @mail WHERE userID = @id;";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", txtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                    command.Parameters.AddWithValue("@id", userId);


                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user data: " + ex.Message);
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Yeni şifre güncelleme sorgusu
                    string updateQuery = "UPDATE users SET password = @newPassword WHERE userID = @id;";
                    MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);

                    updateCommand.Parameters.AddWithValue("@newPassword", txtPassword.Text.Trim());
                    updateCommand.Parameters.AddWithValue("@id", userId);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Account Information(s) updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Password update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete your account?\r\n", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM users WHERE userID = @id;";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", userId);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit(); // Uygulamayı kapatın veya Login ekranına yönlendirin
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting account: " + ex.Message);
                }
            }
        }
    }
}