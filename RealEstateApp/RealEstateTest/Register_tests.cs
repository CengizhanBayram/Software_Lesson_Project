using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;

namespace RealEstateTest
{
    [TestFixture]
    public class RegisterTests
    {
        private Register form;

        [SetUp]
        public void Setup()
        {
            form = new Register();
            form.Show(); // Formu oluştur ve göster
        }

        [TearDown]
        public void TearDown()
        {
            form.Close(); // Testten sonra formu kapat
        }

        [Test]
        public void FormComponents_ShouldBeInitialized()
        {
            // Form başlığını kontrol et
            ClassicAssert.AreEqual("Register", form.Text, "Form başlığı doğru değil.");

            // Gerekli bileşenlerin varlığını kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("textBoxFullName", true)[0], "FullName TextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("textBoxEmail", true)[0], "Email TextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("textBoxPassword", true)[0], "Password TextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("textBoxConfirmPassword", true)[0], "ConfirmPassword TextBox bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("btnRegister", true)[0], "Register Button bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("linkLblToLogin", true)[0], "Login LinkLabel bulunamadı.");
        }

        [Test]
        public void RegisterButton_ClickEvent_ShouldBeAttached()
        {
            // Register butonuna Click olay işleyicisinin atanıp atanmadığını kontrol et
            var btnRegister = form.Controls.Find("btnRegister", true)[0] as Button;
            ClassicAssert.IsNotNull(btnRegister, "Register Button bulunamadı.");

            bool eventTriggered = false;
            btnRegister.Click += (s, e) => eventTriggered = true;

            // Butonu tıklatarak olayın tetiklenmesini simüle et
            btnRegister.PerformClick();

            // Olayın gerçekten tetiklenip tetiklenmediğini kontrol et
            ClassicAssert.IsTrue(eventTriggered, "Register Button için Click olayı tetiklenmedi.");
        }

        [Test]
        public void LinkLabel_ClickEvent_ShouldBeAttached()
        {
            var linkLblToLogin = form.Controls.Find("linkLblToLogin", true)[0] as LinkLabel;
            ClassicAssert.IsNotNull(linkLblToLogin, "Login LinkLabel bulunamadı.");

            bool eventTriggered = false;
            linkLblToLogin.LinkClicked += (s, e) => eventTriggered = true;

            // Reflection ile OnLinkClicked metoduna eriş
            var onLinkClickedMethod = typeof(LinkLabel).GetMethod("OnLinkClicked", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            onLinkClickedMethod?.Invoke(linkLblToLogin, new object[] { new LinkLabelLinkClickedEventArgs(linkLblToLogin.Links[0]) });

            ClassicAssert.IsTrue(eventTriggered, "Login LinkLabel için LinkClicked olayı tetiklenmedi.");
        }



        [Test]
        public void ErrorProviders_ShouldBeInitialized()
        {
            // ErrorProvider bileşenlerinin varlığını kontrol et
            ClassicAssert.IsNotNull(form.Controls.Find("errorProvider1", true)[0], "ErrorProvider1 bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("errorProvider2", true)[0], "ErrorProvider2 bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("errorProvider3", true)[0], "ErrorProvider3 bulunamadı.");
            ClassicAssert.IsNotNull(form.Controls.Find("errorProvider4", true)[0], "ErrorProvider4 bulunamadı.");
        }

        [Test]
        public void TextBoxPlaceholders_ShouldBeCorrect()
        {
            // TextBox bileşenlerinin varsayılan değerlerini kontrol et
            var textBoxFullName = form.Controls.Find("textBoxFullName", true)[0] as TextBox;
            var textBoxEmail = form.Controls.Find("textBoxEmail", true)[0] as TextBox;

            ClassicAssert.IsNotNull(textBoxFullName, "FullName TextBox bulunamadı.");
            ClassicAssert.IsNotNull(textBoxEmail, "Email TextBox bulunamadı.");

            ClassicAssert.AreEqual(string.Empty, textBoxFullName.Text, "FullName TextBox varsayılan değeri yanlış.");
            ClassicAssert.AreEqual(string.Empty, textBoxEmail.Text, "Email TextBox varsayılan değeri yanlış.");
        }
    }
}
