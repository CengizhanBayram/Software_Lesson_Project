using NUnit.Framework;
using RealEstateApp.Forms;
using System;

namespace RealEstateAppTests
{
    [TestFixture]
    public class LoginTests
    {
        private Login login;

        [SetUp]
        public void SetUp()
        {
            login = new Login();
        }

        [Test]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = "123456";

            // Act
            bool result = login.AuthenticateUser(email, password);

            // Assert
            Assert.IsTrue(result, "Valid credentials should return true.");
        }

        [Test]
        public void AuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string email = "invalid_user@example.com";
            string password = "wrong_password";

            // Act
            bool result = login.AuthenticateUser(email, password);

            // Assert
            Assert.IsFalse(result, "Invalid credentials should return false.");
        }

        [Test]
        public void AuthenticateUser_EmptyEmail_ThrowsArgumentException()
        {
            // Arrange
            string email = "";
            string password = "123456";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
            Assert.AreEqual("Email and password cannot be empty.", ex.Message);
        }

        [Test]
        public void AuthenticateUser_NullPassword_ThrowsArgumentException()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = null;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
            Assert.AreEqual("Email and password cannot be empty.", ex.Message);
        }
    }
}
