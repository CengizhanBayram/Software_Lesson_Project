using System;
using System.Windows.Forms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using RealEstateApp.Forms; // Register formunun bulunduğu namespace'i eklediğinizden emin olun

namespace RealEstateApp.Tests
{
    [TestFixture]
    public class RegisterFormTests
    {
        private Register _registerForm;

        [SetUp]
        public void SetUp()
        {
            // Register formu nesnesini oluşturuyoruz
            _registerForm = new Register();
            _registerForm.Show(); // Formun görünür olduğundan emin olun
        }

        [TearDown]
        public void TearDown()
        {
            // Testlerden sonra formu kapatıyoruz
            _registerForm.Close();
        }

        [Test]
        public void Test_FullNameLabel_ShouldExist()
        {
            // Arrange
            var lblFullName = GetControl<Label>(_registerForm, "lblFullName");

            // Act & Assert
            ClassicAssert.IsNotNull(lblFullName, "Full Name label formda mevcut olmalı.");
        }

        [Test]
        public void Test_FullNameTextBox_ShouldExist()
        {
            // Arrange
            var textBoxFullName = GetControl<TextBox>(_registerForm, "textBoxFullName");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxFullName, "Full Name TextBox formda mevcut olmalı.");
        }

        [Test]
        public void Test_EmailLabel_ShouldExist()
        {
            // Arrange
            var lblEmail = GetControl<Label>(_registerForm, "lblEmail");

            // Act & Assert
            ClassicAssert.IsNotNull(lblEmail, "Email label formda mevcut olmalı.");
        }

        [Test]
        public void Test_EmailTextBox_ShouldExist()
        {
            // Arrange
            var textBoxEmail = GetControl<TextBox>(_registerForm, "textBoxEmail");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxEmail, "Email TextBox formda mevcut olmalı.");
        }

        [Test]
        public void Test_PasswordLabel_ShouldExist()
        {
            // Arrange
            var lblPassword = GetControl<Label>(_registerForm, "lblPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(lblPassword, "Password label formda mevcut olmalı.");
        }

        [Test]
        public void Test_PasswordTextBox_ShouldExist()
        {
            // Arrange
            var textBoxPassword = GetControl<TextBox>(_registerForm, "textBoxPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxPassword, "Password TextBox formda mevcut olmalı.");
        }

        [Test]
        public void Test_ConfirmPasswordLabel_ShouldExist()
        {
            // Arrange
            var lblConfirmPassword = GetControl<Label>(_registerForm, "lblConfirmPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(lblConfirmPassword, "Confirm Password label formda mevcut olmalı.");
        }

        [Test]
        public void Test_ConfirmPasswordTextBox_ShouldExist()
        {
            // Arrange
            var textBoxConfirmPassword = GetControl<TextBox>(_registerForm, "textBoxConfirmPassword");

            // Act & Assert
            ClassicAssert.IsNotNull(textBoxConfirmPassword, "Confirm Password TextBox formda mevcut olmalı.");
        }

        [Test]
        public void Test_RegisterButton_ShouldExist()
        {
            // Arrange
            var btnRegister = GetControl<Button>(_registerForm, "btnRegister");

            // Act & Assert
            ClassicAssert.IsNotNull(btnRegister, "Register butonu formda mevcut olmalı.");
        }

        [Test]
        public void Test_LinkToLogin_ShouldExist()
        {
            // Arrange
            var linkLblToLogin = GetControl<LinkLabel>(_registerForm, "linkLblToLogin");

            // Act & Assert
            ClassicAssert.IsNotNull(linkLblToLogin, "Login linki formda mevcut olmalı.");
        }

        [Test]
        public void Test_Panel1_ShouldExist()
        {
            // Arrange
            var panel1 = GetControl<Panel>(_registerForm, "panel1");

            // Act & Assert
            ClassicAssert.IsNotNull(panel1, "Panel1 formda mevcut olmalı.");
        }

        [Test]
        public void Test_Panel2_ShouldExist()
        {
            // Arrange
            var panel2 = GetControl<Panel>(_registerForm, "panel2");

            // Act & Assert
            ClassicAssert.IsNotNull(panel2, "Panel2 formda mevcut olmalı.");
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