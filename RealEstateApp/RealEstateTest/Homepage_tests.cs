using NUnit.Framework;
using System.Windows.Forms;
using RealEstateApp.Forms;
using NUnit.Framework.Legacy;

namespace RealEstateTests
{
    [TestFixture]
    public class HomepageTests
    {
        private Homepage homepageForm;

        [SetUp]
        public void Setup()
        {
            homepageForm = new Homepage();
            homepageForm.Show();
        }

        [TearDown]
        public void TearDown()
        {
            homepageForm.Close();
        }

        [Test]
        public void SearchTitleField_ShouldBeEmptyOnLoad()
        {
            // Arrange & Act
            var searchTitleField = homepageForm.Controls.Find("textBoxSearchTitle", true)[0] as TextBox;

            // Assert
            ClassicAssert.IsNotNull(searchTitleField);
            ClassicAssert.IsEmpty(searchTitleField.Text);
        }

        [Test]
        public void SearchFilterButton_ShouldTriggerEventOnClick()
        {
            // Arrange
            var searchFilterButton = homepageForm.Controls.Find("buttonSearchFilter", true)[0] as Button;
            ClassicAssert.IsNotNull(searchFilterButton);

            bool eventTriggered = false;
            searchFilterButton.Click += (s, e) => { eventTriggered = true; };

            // Act
            searchFilterButton.PerformClick();

            // Assert
            ClassicAssert.IsTrue(eventTriggered);
        }



        [Test]

        public void Navbar_ShouldBePresent()
        {
            // Arrange & Act
            var navbar = homepageForm.Controls.Find("navbar2", true)[0];

            // Assert
            ClassicAssert.IsNotNull(navbar);
        }
    }
}
