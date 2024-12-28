using System;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using RealEstateApp.Forms; // Login formunun bulunduðu namespace'i eklediðinizden emin olun

namespace RealEstateTest
{
    [TestFixture]
    public class LoginFormTests
    {
        private Login _loginForm;

        [SetUp]
        public void SetUp()
        {
            // Login formu nesnesini oluþturuyoruz
            _loginForm = new Login();
            _loginForm.Show(); // Formun görünür olduðundan emin olun
        }

        [TearDown]
        public void TearDown()
        {
            // Testlerden sonra formu kapatýyoruz
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

            ClassicAssert.IsTrue(isClicked, "Login butonuna týklama olayý tetiklenmeli.");
        }

        [Test]
        public void Test_LinkLabelToRegister_Click_ShouldTriggerEvent()
        {
            // Arrange
            var linkLblToRegister = GetControl<LinkLabel>(_loginForm, "linkLblToRegister");

            // Act & Assert
            ClassicAssert.IsNotNull(linkLblToRegister);

            var btnLogin = GetControl<Button>(_loginForm, "btnLogin");
            ClassicAssert.IsNotNull(btnLogin, "Login butonu formda mevcut olmalý.");

            // Týklama olayýný doðrudan çaðýr
            btnLogin.PerformClick();



        }

        [Test]
        public void Test_LoginButton_ShouldExist()
        {
            // Arrange
            var btnLogin = GetControl<Button>(_loginForm, "btnLogin");

            // Act & Assert
            ClassicAssert.IsNotNull(btnLogin, "Login butonu formda mevcut olmalý.");
        }

        [Test]
        public void Test_EmailTextBox_ShouldExist()
        {
            // Arrange
            var textBoxEmail = GetControl<TextBox>(_loginForm, "textBoxEmail");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxEmail, "Email TextBox'ý formda mevcut olmalý.");
        }

        [Test]
        public void Test_PasswordTextBox_ShouldExist()
        {
            // Arrange
            var textBoxPassword = GetControl<TextBox>(_loginForm, "textBoxPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxPassword, "Password TextBox'ý formda mevcut olmalý.");
        }

        [Test]
        public void Test_RegisterLinkLabel_ShouldExist()
        {
            // Arrange
            var linkLblToRegister = GetControl<LinkLabel>(_loginForm, "linkLblToRegister");

            // Act & Assert
            ClassicAssert.IsNotNull(linkLblToRegister, "Register LinkLabel'ý formda mevcut olmalý.");
        }

        [Test]
        public void Test_TempButton_ShouldExist()
        {
            // Arrange
            var btnTemp = GetControl<Button>(_loginForm, "btnTemp");

            // Act & Assert
            ClassicAssert.IsNotNull(btnTemp, "Temp butonu (Go HomePage) formda mevcut olmalý.");
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
