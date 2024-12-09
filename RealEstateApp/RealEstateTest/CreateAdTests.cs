using NUnit.Framework;
using Moq;
using RealEstateApp.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace RealEstateAppTests
{
    [TestFixture]
    public class CreateAdTests
    {
        private Mock<MySqlConnection> _mockConnection;
        private Mock<MySqlCommand> _mockCommand;
        private CreateAd _createAd;

        [SetUp]
        public void Setup()
        {
            // Mock nesneler oluşturulur
            _mockConnection = new Mock<MySqlConnection>();
            _mockCommand = new Mock<MySqlCommand>();

            // Test edilecek sınıfın örneği
            _createAd = new CreateAd();
        }

        [TearDown]
        public void TearDown()
        {
            // Mock nesnelerini manuel olarak Dispose et
            _mockConnection?.Object.Dispose();
            _mockCommand?.Object.Dispose();

            // Kullanılan diğer kaynaklar temizlenir
            _createAd?.Dispose();
        }

        [Test]
        public void SavePhotoPathsToDatabase_ShouldSavePhotoPaths()
        {
            // Arrange
            int adID = 1;
            List<string> photoPaths = new List<string>
            {
                @"C:\Photos\image1.jpg",
                @"C:\Photos\image2.jpg"
            };

            // Act
            _createAd.SavePhotoPathsToDatabase(adID, photoPaths);

            // Assert
            foreach (string photoPath in photoPaths)
            {
                _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@AdID", adID), Times.Once);
                _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@PhotoPath", photoPath), Times.Once);
            }
        }

        [Test]
        public void btnSaveAdvert_ShouldInsertAdAndSavePhotos()
        {
            // Arrange
            _createAd.textBoxTitle.Text = "Test Ad";
            _createAd.textBoxPrice.Text = "100000";
            _createAd.textBoxSquareMeters.Text = "120";
            _createAd.comboBoxLocation.SelectedItem = "Ankara";
            _createAd.comboBoxRoomNumber.SelectedItem = "3+1";
            _createAd.comboBoxFloorNo.SelectedItem = "1st";
            _createAd.comboBoxElevator.SelectedItem = "Yes";
            _createAd.photoPaths = new List<string> { @"C:\Photos\image1.jpg" };

            // Act
            _createAd.btnSaveAdvert_Click(null, null);

            // Assert
            _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@Title", "Test Ad"), Times.Once);
            _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@Price", 100000), Times.Once);
            _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@Location", "Ankara"), Times.Once);
            _mockCommand.Verify(cmd => cmd.Parameters.AddWithValue("@SquareMeters", 120), Times.Once);
        }
    }
}
