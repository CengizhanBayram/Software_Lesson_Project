using Microsoft.VisualBasic.Logging;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using RealEstateApp.Forms;
using System;

namespace RealEstateAppTests
{
    /// <summary>
    /// Test class to verify the functionality of the Login class.
    /// Includes tests for user authentication using various scenarios.
    /// </summary>
    /// 
    
  

    [TestFixture]
    public class LoginTests
    {

        /// <summary>
        private Login login;

        /// Sets up the Login object before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            login = new Login();
        }
        [TearDown]
        
        /// <summary>
        /// Tests if valid credentials authenticate successfully.
        /// </summary>
        [Test]
        public void AuthenticateUser_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = "123456";

            // Act
            bool result = login.AuthenticateUser(email, password);

            // Assert
            ClassicAssert.IsTrue(result, "Valid credentials should return true.");
        }

        /// <summary>
        /// Tests if invalid credentials fail to authenticate.
        /// </summary>
        [Test]
        public void AuthenticateUser_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            string email = "invalid_user@example.com";
            string password = "wrong_password";

            // Act
            bool result = login.AuthenticateUser(email, password);

            // Assert
            ClassicAssert.IsFalse(result, "Invalid credentials should return false.");
        }

        /// <summary>
        /// Tests if empty email throws an ArgumentException.
        /// </summary>
        [Test]
        public void AuthenticateUser_EmptyEmail_ThrowsArgumentException()
        {
            // Arrange
            string email = "";
            string password = "123456";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
           ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
        }

        /// <summary>
        /// Tests if a null password throws an ArgumentException.
        /// </summary>
        [Test]
        public void AuthenticateUser_NullPassword_ThrowsArgumentException()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = null;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
            ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
        }

        /// <summary>
        /// Tests if an empty password throws an ArgumentException.
        /// </summary>
        [Test]
        public void AuthenticateUser_EmptyPassword_ThrowsArgumentException()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = string.Empty;

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
            ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
        }

        /// <summary>
        /// Tests if whitespace-only email throws an ArgumentException.
        /// </summary>
        [Test]
        public void AuthenticateUser_WhitespaceEmail_ThrowsArgumentException()
        {
            // Arrange
            string email = "   ";
            string password = "123456";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
            ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
        }
        [Test]
        public void try_is_accept()
        {
            Assert.Pass();
        }
        [Test]
        public void AuthenticateUser_WhitespacePassword_ThrowsArgumentException()
        {
            // Arrange
            string email = "valid_user@example.com";
            string password = "   ";

            // Act & Assert
            var ex = Assert.Throws<ArgumentException>(() => login.AuthenticateUser(email, password));
           ClassicAssert.AreEqual("Email and password cannot be empty.", ex.Message);
        }
        [TearDown]
        public void TearDown()
        {
            // Login nesnesini dispose edin
            login?.Dispose();
        }
    }
}
