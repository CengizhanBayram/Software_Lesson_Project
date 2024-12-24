using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateApp.Forms
{
    public partial class AdDetails : Form
    {
        private int adID;
        private int userID = (int)GlobalSettings.UserID; 
        private bool isFaved = false; 
        string connectionString = GlobalSettings.ConnectionString;
        private string fullHeartImagePath =  GlobalSettings.ResourcePath + "fullHeart.png"; // Dolu kalp resminin yolu
        private string emptyHeartImagePath = GlobalSettings.ResourcePath + "emptyHeart.png"; // Boş kalp resminin yolu
        
        // Yapıcı metot
        public AdDetails(int adID)
        {
            InitializeComponent();
            this.adID = adID; // Parametreyi sınıf değişkenine atıyoruz
            LoadAdDetails(); // İlan detaylarını yüklemek için bir metot çağırıyoruz
        }

        private void LoadAdDetails()
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // İlan detaylarını çek
                    string adQuery = @"
                        SELECT 
                            Title, Description, Price, Location, SquareMeters, 
                            RoomCount, FloorNo, Elevator, CreatedAt
                        FROM ads
                        WHERE AdID = @adID";

                    using (MySqlCommand command = new MySqlCommand(adQuery, connection))
                    {
                        command.Parameters.AddWithValue("@adID", adID);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Verileri UI öğelerine atıyoruz
                                labelTitle.Text = reader["Title"].ToString();
                                labelDesription.Text = reader["Description"].ToString();
                                labelDbPrice.Text = $" {reader["Price"]} TL";
                                labelDbLocation.Text = $" {reader["Location"]}";
                                labelDbSquareMeters.Text = $"{reader["SquareMeters"]} m²";
                                labelDbRoomCount.Text = $" {reader["RoomCount"]}";
                                labelDbFloorNo.Text = $" {reader["FloorNo"]}";
                                labelDbElevator.Text = $" {(reader["Elevator"].ToString() == "1" ? "Yes" : "No")}";
                            }
                        }
                    }

                    // Kullanıcının favorilerinde bu ilan var mı kontrol et
                    string checkFavoriteQuery = @"
                        SELECT COUNT(*) 
                        FROM favorites 
                        WHERE UserID = @userID AND AdID = @adID";

                    using (MySqlCommand checkFavoriteCommand = new MySqlCommand(checkFavoriteQuery, connection))
                    {
                        checkFavoriteCommand.Parameters.AddWithValue("@userID", userID); // Kullanıcı ID'si
                        checkFavoriteCommand.Parameters.AddWithValue("@adID", adID); // İlan ID'si

                        // Favori kaydını kontrol et
                        int favoriteCount = Convert.ToInt32(checkFavoriteCommand.ExecuteScalar());

                        // Favori kaydı varsa, butonu dolu kalp yap
                        if (favoriteCount > 0)
                        {
                            isFaved = true;
                            buttonFave.BackgroundImage = Image.FromFile(fullHeartImagePath);
                        }
                        else
                        {
                            isFaved = false;
                            buttonFave.BackgroundImage = Image.FromFile(emptyHeartImagePath);
                        }

                        buttonFave.BackgroundImageLayout = ImageLayout.Stretch; // Resmin butonun tamamını kaplamasını sağla
                    }

                    // İlan fotoğraflarını çek
                    string photosQuery = "SELECT PhotoPath FROM adphotos WHERE AdID = @adID";
                    using (MySqlCommand photoCommand = new MySqlCommand(photosQuery, connection))
                    {
                        photoCommand.Parameters.AddWithValue("@adID", adID);

                        using (MySqlDataReader photoReader = photoCommand.ExecuteReader())
                        {
                            // Fotoğrafları ekliyoruz
                            while (photoReader.Read())
                            {
                                string photoPath = photoReader["PhotoPath"].ToString();

                                // Dinamik bir PictureBox oluşturuyoruz
                                PictureBox pictureBox = new PictureBox
                                {
                                    ImageLocation = photoPath,  // Resim yolu
                                    SizeMode = PictureBoxSizeMode.StretchImage,  // Resmin doğru şekilde görünmesi için
                                    Width = 550,  // Resmin genişliği
                                    Height = 350, // Resmin yüksekliği
                                    Margin = new Padding(5) // Resim aralarındaki boşluk
                                };

                                // FlowLayoutPanel'e ekliyoruz
                                flowLayoutPanelPhotos.Controls.Add(pictureBox);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Parent form üzerinden Homepage'e geçiş yap
            if (this.ParentForm is Main mainForm)
            {
                mainForm.ShowFormInPanel(new Homepage()); // Homepage formunu göster
            }
        }

        private void buttonFave_Click(object sender, EventArgs e)
        {
            isFaved = !isFaved;

            // Duruma göre favoriye ekle veya çıkar
            if (isFaved)
            {
                AddToFavorites();
            }
            else
            {
                RemoveFromFavorites();
            }

            // Butonun arka plan resmini değiştir
            string path = isFaved ? fullHeartImagePath : emptyHeartImagePath; // Boş kalp resmi

            buttonFave.BackgroundImage = Image.FromFile(path); // Resmi yükle
            buttonFave.BackgroundImageLayout = ImageLayout.Stretch; // Resmin butonun tamamını kaplamasını sağla
        }
        // Form üzerindeki diğer event handler'lar
        private void labelTitle_Click(object sender, EventArgs e) { }
        private void pictureBoxAdPhotos_Click(object sender, EventArgs e) { }
        private void labelDesription_Click(object sender, EventArgs e) { }
        private void labelDbPrice_Click(object sender, EventArgs e) { }
        private void labelDbLocation_Click(object sender, EventArgs e) { }
        private void labelDbSquareMeters_Click(object sender, EventArgs e) { }
        private void labelDbRoomCount_Click(object sender, EventArgs e) { }
        private void labelDbFloorNo_Click(object sender, EventArgs e) { }
        private void labelDbElevator_Click(object sender, EventArgs e) { }

        private void AddToFavorites()
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanına favori ekleme sorgusu
                    string addFavoriteQuery = @"
                        INSERT INTO favorites (UserID, AdID, CreatedAt)
                        VALUES (@userID, @adID, NOW())";

                    using (MySqlCommand command = new MySqlCommand(addFavoriteQuery, connection))
                    {
                        // Parametreleri ekliyoruz
                        command.Parameters.AddWithValue("@userID", userID); // Kullanıcı ID'si
                        command.Parameters.AddWithValue("@adID", adID); // İlan ID'si

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding to favorites: {ex.Message}");
            }
        }

        private void RemoveFromFavorites()
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanından favoriyi kaldırma sorgusu
                    string removeFavoriteQuery = @"
                        DELETE FROM favorites 
                        WHERE UserID = @userID AND AdID = @adID";

                    using (MySqlCommand command = new MySqlCommand(removeFavoriteQuery, connection))
                    {
                        // Parametreleri ekliyoruz
                        command.Parameters.AddWithValue("@userID", userID); // Kullanıcı ID'si
                        command.Parameters.AddWithValue("@adID", adID); // İlan ID'si

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing from favorites: {ex.Message}");
            }
        }
    }
}
