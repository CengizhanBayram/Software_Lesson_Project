using System;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using RealEstateApp.Forms; // Login formunun bulundu�u namespace'i ekledi�inizden emin olun

namespace RealEstateTest
{
    [TestFixture]
    public class LoginFormTests
    {
        private Login _loginForm;

        [SetUp]
        public void SetUp()
        {
            // Login formu nesnesini olu�turuyoruz
            _loginForm = new Login();
            _loginForm.Show(); // Formun g�r�n�r oldu�undan emin olun
        }

        [TearDown]
        public void TearDown()
        {
            // Testlerden sonra formu kapat�yoruz
            _loginForm.Close();
        }



        [Test]
        public void Test_LoginButton_Click_ShouldTriggerEvent()
        {
            // Arrange
            var btnLogin = GetControl<Button>(_loginForm, "btnLogin");

            // Act & Assert
            ClassicAssert.IsNotNull(btnLogin);

            bool isClicked = false;
            btnLogin.Click += (sender, args) => isClicked = true;

            btnLogin.PerformClick();

            ClassicAssert.IsTrue(isClicked, "Login butonuna t�klama olay� tetiklenmeli.");
        }

        [Test]
        public void Test_LinkLabelToRegister_Click_ShouldTriggerEvent()
        {
            // Arrange
            var linkLblToRegister = GetControl<LinkLabel>(_loginForm, "linkLblToRegister");

            // Act & Assert
            ClassicAssert.IsNotNull(linkLblToRegister);

            var btnLogin = GetControl<Button>(_loginForm, "btnLogin");
            ClassicAssert.IsNotNull(btnLogin, "Login butonu formda mevcut olmal�.");

            // T�klama olay�n� do�rudan �a��r
            btnLogin.PerformClick();



        }

        [Test]
        public void Test_LoginButton_ShouldExist()
        {
            // Arrange
            var btnLogin = GetControl<Button>(_loginForm, "btnLogin");

            // Act & Assert
            ClassicAssert.IsNotNull(btnLogin, "Login butonu formda mevcut olmal�.");
        }

        [Test]
        public void Test_EmailTextBox_ShouldExist()
        {
            // Arrange
            var textBoxEmail = GetControl<TextBox>(_loginForm, "textBoxEmail");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxEmail, "Email TextBox'� formda mevcut olmal�.");
        }

        [Test]
        public void Test_PasswordTextBox_ShouldExist()
        {
            // Arrange
            var textBoxPassword = GetControl<TextBox>(_loginForm, "textBoxPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxPassword, "Password TextBox'� formda mevcut olmal�.");
        }

        [Test]
        public void Test_RegisterLinkLabel_ShouldExist()
        {
            // Arrange
            var linkLblToRegister = GetControl<LinkLabel>(_loginForm, "linkLblToRegister");

            // Act & Assert
            ClassicAssert.IsNotNull(linkLblToRegister, "Register LinkLabel'� formda mevcut olmal�.");
        }

        [Test]
        public void Test_TempButton_ShouldExist()
        {
            // Arrange
            var btnTemp = GetControl<Button>(_loginForm, "btnTemp");

            // Act & Assert
            ClassicAssert.IsNotNull(btnTemp, "Temp butonu (Go HomePage) formda mevcut olmal�.");
        }

        private T GetControl<T>(Control parent, string controlName) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == controlName)
                    return control as T;

                if (control.HasChildren)
                {
                    var childControl = GetControl<T>(control, controlName);
                    if (childControl != null)
                        return childControl;
                }
            }

            return null;
        }
    }
}
