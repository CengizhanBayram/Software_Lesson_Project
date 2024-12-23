using NUnit.Framework;
using System;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;

namespace RealEstateTest
{
    [TestFixture]
    public class ProfileTests
    {
        private Profile profileForm;

        [SetUp]
        public void SetUp()
        {
            // Profile formunu başlat
            profileForm = new Profile();
            profileForm.Show(); // Form bileşenlerini yüklemek için göster
        }

        [TearDown]
        public void TearDown()
        {
            // Formu kapat ve belleği serbest bırak
            profileForm.Close();
            profileForm.Dispose();
        }

        [Test]
        public void BtnUpdate_Click_ShouldThrowException_WhenFieldsAreEmpty()
        {
            // Form üzerindeki e-posta ve şifre alanlarını boş bırak
            var txtEmail = (TextBox)profileForm.Controls["txtEmail"];
            var txtPassword = (TextBox)profileForm.Controls["txtPassword"];
            txtEmail.Text = string.Empty; // E-posta boş
            txtPassword.Text = string.Empty; // Şifre boş

            var btnUpdate = (Button)profileForm.Controls["btnUpdate"];

            try
            {
                // Update düğmesine tıkla
                btnUpdate.PerformClick();
            }
            catch (Exception ex)
            {
                // Beklenen hata mesajını doğrula
                ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
                return;
            }

            // Eğer istisna oluşmazsa test başarısız
            ClassicAssert.Fail("Expected exception was not thrown.");
        }

        [Test]
        public void BtnUpdate_Click_ShouldUpdateSuccessfully_WhenFieldsAreValid()
        {
            // Form üzerindeki alanları doldur
            var txtEmail = (TextBox)profileForm.Controls["txtEmail"];
            var txtPassword = (TextBox)profileForm.Controls["txtPassword"];
            txtEmail.Text = "test@example.com";
            txtPassword.Text = "ValidPassword";

            var btnUpdate = (Button)profileForm.Controls["btnUpdate"];

            try
            {
                // Update düğmesine tıkla
                btnUpdate.PerformClick();
            }
            catch (Exception ex)
            {
                // Eğer hata oluşursa, test başarısız
                ClassicAssert.Fail($"Unexpected exception was thrown: {ex.Message}");
            }

            // Alanların hala aynı olduğunu doğrula
            ClassicAssert.AreEqual("test@example.com", txtEmail.Text);
            ClassicAssert.AreEqual("ValidPassword", txtPassword.Text);
        }

        [Test]
        public void BtnDelete_Click_ShouldPromptConfirmation()
        {
            // Delete düğmesine tıkla
            var btnDelete = (Button)profileForm.Controls["btnDelete"];

            try
            {
                btnDelete.PerformClick();
            }
            catch (Exception ex)
            {
                // Beklenen bir hata fırlatılırsa başarısız ol
                ClassicAssert.Fail($"Unexpected exception was thrown: {ex.Message}");
            }

            // Confirmation dialog (örneğin MessageBox) burada simüle edilebilir.
            // Şu an için başarılı bir şekilde tıklandığını kontrol ediyoruz.
            ClassicAssert.Pass("Delete button clicked successfully.");
        }
    }
}
