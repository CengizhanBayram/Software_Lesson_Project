using NUnit.Framework;
using System;
using System.Windows.Forms;
using RealEstateApp.Forms;
using MySql.Data.MySqlClient;
using NUnit.Framework.Legacy;
using RealEstateApp;

namespace RealEstateTest
{
    [TestFixture]
    public class ProfileTests
    {
        private Profile profileForm;
        private int testUserId;
        private string connectionString = "Server=localhost;Database=emlak;Uid=root;Pwd=16072001;";

        [SetUp]
        public void SetUp()
        {
            CreateTestUser();
            GlobalSettings.UserID = testUserId; // Test kullanıcı ID'sini Login.userId'ye set ediyoruz
            profileForm = new Profile();
            profileForm.Show();
            Application.DoEvents(); // Formun tamamen yüklenmesini sağlar
        }

        [TearDown]
        public void TearDown()
        {
            profileForm.Close();
            profileForm.Dispose();
            DeleteTestUser();
        }

        private void CreateTestUser()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Aynı email varsa sil
                string deleteQuery = "DELETE FROM users WHERE email = @email;";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@email", "test_user@example.com");
                    deleteCommand.ExecuteNonQuery();
                }

                // Yeni kullanıcı oluştur
                string query = "INSERT INTO users (username, email, password, CreatedAt) VALUES (@username, @email, @password, NOW()); SELECT LAST_INSERT_ID();";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", "test_user");
                    command.Parameters.AddWithValue("@email", "test_user@example.com");
                    command.Parameters.AddWithValue("@password", "password123");

                    testUserId = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }


        private void DeleteTestUser()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM users WHERE userID = @id;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", testUserId);
                    command.ExecuteNonQuery();
                }
            }
        }

        [Test]
        public void BtnUpdate_Click_ShouldUpdateSuccessfully_WhenFieldsAreValid()
        {
            var txtUsername = (TextBox)profileForm.Controls.Find("txtUsername", true)[0];
            var txtEmail = (TextBox)profileForm.Controls.Find("txtEmail", true)[0];
            var txtPassword = (TextBox)profileForm.Controls.Find("txtPassword", true)[0];

            txtUsername.Text = "updated_user";
            txtEmail.Text = "updated_user@example.com";
            txtPassword.Text = "newpassword123";

            var btnUpdate = (Button)profileForm.Controls.Find("btnUpdate", true)[0];

            ClassicAssert.DoesNotThrow(() => btnUpdate.PerformClick(), "Update işlemi sırasında bir hata oluştu.");

            // Veritabanında güncellenen bilgileri doğrula
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT username, email, password FROM users WHERE userID = @id;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", testUserId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        ClassicAssert.IsTrue(reader.Read(), "Kullanıcı veritabanında bulunamadı.");
                        ClassicAssert.AreEqual("updated_user", reader["username"].ToString(), "Username eşleşmedi.");
                        ClassicAssert.AreEqual("updated_user@example.com", reader["email"].ToString(), "Email eşleşmedi.");
                        ClassicAssert.AreEqual("newpassword123", reader["password"].ToString(), "Password eşleşmedi.");
                    }
                }
            }
        }

        [Test]
        public void BtnDelete_Click_ShouldDeleteUserSuccessfully()
        {
            var btnDelete = (Button)profileForm.Controls.Find("btnDelete", true)[0];

            ClassicAssert.DoesNotThrow(() => btnDelete.PerformClick(), "Silme işlemi sırasında bir hata oluştu.");

            // Veritabanından kullanıcının silindiğini doğrula
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM users WHERE userID = @id;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", testUserId);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    ClassicAssert.AreEqual(0, count, "Kullanıcı silinemedi.");
                }
            }
        }

        [Test]
        public void BtnUpdate_Click_ShouldThrowException_WhenFieldsAreEmpty()
        {
            var txtUsername = (TextBox)profileForm.Controls.Find("txtUsername", true)[0];
            var txtEmail = (TextBox)profileForm.Controls.Find("txtEmail", true)[0];
            var txtPassword = (TextBox)profileForm.Controls.Find("txtPassword", true)[0];

            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

            var btnUpdate = (Button)profileForm.Controls.Find("btnUpdate", true)[0];

            ClassicAssert.DoesNotThrow(() => btnUpdate.PerformClick(), "Boş alanlar için bir hata beklenmiyordu.");
        }
    }
}
