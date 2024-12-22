using Moq;
using NUnit.Framework;
using RealEstateApp.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NUnit.Framework.Legacy;

namespace RealEstateTest
{
    [TestFixture]
    public class ProfileTests
    {
        private Profile form;
        private Mock<MySqlConnection> mockConnection;
        private Mock<MySqlCommand> mockCommand;

        [SetUp]
        public void Setup()
        {
            // Formu oluştur
            form = new Profile();
            form.Show();

            // Mock MySqlConnection ve MySqlCommand
            mockConnection = new Mock<MySqlConnection>("Server=localhost;Database=emlak;Uid=root;Pwd=16072001;");
            mockCommand = new Mock<MySqlCommand>();
        }

        [TearDown]
        public void TearDown()
        {
            // Test sonrası formu kapat
            form.Close();
        }

        [Test]
        public void Profile_Load_ShouldRetrieveUserData()
        {
            // Mock MySqlDataReader
            var mockReader = new Mock<IDataReader>();
            mockReader.SetupSequence(r => r.Read())
                .Returns(true) // İlk okuma başarılı
                .Returns(false); // İkinci okuma başarısız (sonuç bitti)

            mockReader.Setup(r => r["username"]).Returns("testuser");
            mockReader.Setup(r => r["email"]).Returns("testuser@example.com");
            mockReader.Setup(r => r["password"]).Returns("testpassword");
            mockReader.Setup(r => r["CreatedAt"]).Returns("2023-01-01");

            mockCommand.Setup(c => c.ExecuteReader()).Returns(mockReader.Object);

            // Formu yükle ve verilerin doğru şekilde yüklendiğini kontrol et
            form.Profile_Load(null, EventArgs.Empty);
            
            ClassicAssert.AreEqual("testuser", form.Controls.Find("txtUsername", true)[0].Text, "Username yanlış.");
            ClassicAssert.AreEqual("testuser@example.com", form.Controls.Find("txtEmail", true)[0].Text, "Email yanlış.");
            ClassicAssert.AreEqual("testpassword", form.Controls.Find("txtPassword", true)[0].Text, "Password yanlış.");
            ClassicAssert.AreEqual("2023-01-01", form.Controls.Find("txtCreate", true)[0].Text, "CreatedAt yanlış.");
        }

        [Test]
        public void BtnUpdate_Click_ShouldUpdateUserData()
        {
            // Mock ExecuteNonQuery
            mockCommand.Setup(c => c.ExecuteNonQuery()).Returns(1);

            // Update işlemini tetikle
            form.Controls.Find("txtUsername", true)[0].Text = "newuser";
            form.Controls.Find("txtEmail", true)[0].Text = "newuser@example.com";
            form.Controls.Find("txtPassword", true)[0].Text = "newpassword";

            form.btnUpdate_Click(null, EventArgs.Empty);

            // ExecuteNonQuery çağrısını kontrol et
            mockCommand.Verify(c => c.ExecuteNonQuery(), Times.AtLeastOnce(), "Update sorgusu çalıştırılmadı.");
        }

        [Test]
        public void BtnDelete_Click_ShouldDeleteUserAccount()
        {
            // Mock ExecuteNonQuery
            mockCommand.Setup(c => c.ExecuteNonQuery()).Returns(1);

            // Silme işlemini tetikle
            form.btnDelete_Click(null, EventArgs.Empty);

            // ExecuteNonQuery çağrısını kontrol et
            mockCommand.Verify(c => c.ExecuteNonQuery(), Times.Once, "Delete sorgusu çalıştırılmadı.");
        }

        [Test]
        public void Profile_Load_ShouldHandleExceptions()
        {
            // Mock hata fırlatma
            mockCommand.Setup(c => c.ExecuteReader()).Throws(new Exception("Test Exception"));

            // Formu yükle ve hata mesajını kontrol et
            Assert.DoesNotThrow(() => form.Profile_Load(null, EventArgs.Empty), "Exception yönetimi başarısız.");
        }
    }
}
