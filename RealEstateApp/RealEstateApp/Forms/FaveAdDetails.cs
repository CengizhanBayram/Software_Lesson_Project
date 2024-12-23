using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateApp.Forms
{
    public partial class FaveAdDetails : Form
    {
        private int adIDF;
        private int userIDF = Login.userId; // Kullanıcı ID'si, burada statik bir değer kullandık. Gerçek uygulamada oturum yönetimi ile alınmalı.
        private bool isFavedF = false; // Favori durumu

        // Yapıcı metot
        public FaveAdDetails(int adIDF)
        {
            InitializeComponent();
            this.adIDF = adIDF; // Parametreyi sınıf değişkenine atıyoruz
            LoadAdDetailsF(); // İlan detaylarını yüklemek için bir metot çağırıyoruz
        }

        private void LoadAdDetailsF()
        {
            string connectionStringF = "Server=localhost;Database=appınfos;Uid=root;Pwd=123456;"; // Veritabanı bağlantı dizesi

            try
            {
                using (MySqlConnection connectionF = new MySqlConnection(connectionStringF))
                {
                    connectionF.Open();

                    // İlan detaylarını çek
                    string adQueryF = @"
                SELECT 
                    Title, Description, Price, Location, SquareMeters, 
                    RoomCount, FloorNo, Elevator, CreatedAt
                FROM ads
                WHERE AdID = @adIDF";

                    using (MySqlCommand commandF = new MySqlCommand(adQueryF, connectionF))
                    {
                        commandF.Parameters.AddWithValue("@adIDF", adIDF);

                        using (MySqlDataReader readerF = commandF.ExecuteReader())
                        {
                            if (readerF.Read())
                            {
                                // Verileri UI öğelerine atıyoruz
                                labelTitle.Text = readerF["Title"].ToString();
                                labelDesription.Text = readerF["Description"].ToString();
                                labelDbPrice.Text = $" {readerF["Price"]} TL";
                                labelDbLocation.Text = $" {readerF["Location"]}";
                                labelDbSquareMeters.Text = $"{readerF["SquareMeters"]} m²";
                                labelDbRoomCount.Text = $" {readerF["RoomCount"]}";
                                labelDbFloorNo.Text = $" {readerF["FloorNo"]}";
                                labelDbElevator.Text = $" {(readerF["Elevator"].ToString() == "1" ? "Yes" : "No")}";
                            }
                        }
                    }

                    // Kullanıcının favorilerinde bu ilan var mı kontrol et
                    string checkFavoriteQueryF = @"
                SELECT COUNT(*) 
                FROM favorites 
                WHERE UserID = @userIDF AND AdID = @adIDF";

                    using (MySqlCommand checkFavoriteCommandF = new MySqlCommand(checkFavoriteQueryF, connectionF))
                    {
                        checkFavoriteCommandF.Parameters.AddWithValue("@userIDF", userIDF); // Kullanıcı ID'si
                        checkFavoriteCommandF.Parameters.AddWithValue("@adIDF", adIDF); // İlan ID'si

                        // Favori kaydını kontrol et
                        int favoriteCountF = Convert.ToInt32(checkFavoriteCommandF.ExecuteScalar());

                        // Favori kaydı varsa, butonu dolu kalp yap
                        if (favoriteCountF > 0)
                        {
                            isFavedF = true;
                            buttonFave.BackgroundImage = Image.FromFile(@"C:\Users\ASUS\Desktop\Swe project\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\fullHeart.png");
                        }
                        else
                        {
                            isFavedF = false;
                            buttonFave.BackgroundImage = Image.FromFile(@"C:\Users\ASUS\Desktop\Swe project\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\emptyHeart.png");
                        }

                        buttonFave.BackgroundImageLayout = ImageLayout.Stretch; // Resmin butonun tamamını kaplamasını sağla
                    }

                    // İlan fotoğraflarını çek
                    string photosQueryF = "SELECT PhotoPath FROM adphotos WHERE AdID = @adIDF";
                    using (MySqlCommand photoCommandF = new MySqlCommand(photosQueryF, connectionF))
                    {
                        photoCommandF.Parameters.AddWithValue("@adIDF", adIDF);

                        using (MySqlDataReader photoReaderF = photoCommandF.ExecuteReader())
                        {
                            // Fotoğrafları ekliyoruz
                            while (photoReaderF.Read())
                            {
                                string photoPathF = photoReaderF["PhotoPath"].ToString();

                                // Dinamik bir PictureBox oluşturuyoruz
                                PictureBox pictureBoxF = new PictureBox
                                {
                                    ImageLocation = photoPathF,  // Resim yolu
                                    SizeMode = PictureBoxSizeMode.StretchImage,  // Resmin doğru şekilde görünmesi için
                                    Width = 550,  // Resmin genişliği
                                    Height = 350, // Resmin yüksekliği
                                    Margin = new Padding(5) // Resim aralarındaki boşluk
                                };

                                // FlowLayoutPanel'e ekliyoruz
                                flowLayoutPanelPhotos.Controls.Add(pictureBoxF);
                            }
                        }
                    }
                }
            }
            catch (Exception exF)
            {
                MessageBox.Show($"An error occurred: {exF.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Parent form üzerinden Homepage'e geçiş yap
            if (this.ParentForm is Main mainForm)
            {
                mainForm.ShowFormInPanel(new Favorites()); // Homepage formunu göster
            }
        }

        private void buttonFave_Click(object sender, EventArgs e)
        {
            isFavedF = !isFavedF;

            // Duruma göre favoriye ekle veya çıkar
            if (isFavedF)
            {
                AddToFavorites();
            }
            else
            {
                RemoveFromFavorites();
            }

            // Butonun arka plan resmini değiştir
            string pathF = isFavedF
                ? @"C:\Users\ASUS\Desktop\Swe project\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\fullHeart.png" // Dolu kalp resmi
                : @"C:\Users\ASUS\Desktop\Swe project\Software_Lesson_Project\RealEstateApp\RealEstateApp\Resources\emptyHeart.png"; // Boş kalp resmi

            buttonFave.BackgroundImage = Image.FromFile(pathF); // Resmi yükle
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
            string connectionStringF = "Server=localhost;Database=appınfos;Uid=root;Pwd=123456;"; // Veritabanı bağlantı dizesi

            try
            {
                using (MySqlConnection connectionF = new MySqlConnection(connectionStringF))
                {
                    connectionF.Open();

                    // Veritabanına favori ekleme sorgusu
                    string addFavoriteQueryF = @"
                        INSERT INTO favorites (UserID, AdID, CreatedAt)
                        VALUES (@userIDF, @adIDF, NOW())";

                    using (MySqlCommand commandF = new MySqlCommand(addFavoriteQueryF, connectionF))
                    {
                        // Parametreleri ekliyoruz
                        commandF.Parameters.AddWithValue("@userIDF", userIDF); // Kullanıcı ID'si
                        commandF.Parameters.AddWithValue("@adIDF", adIDF); // İlan ID'si

                        // Sorguyu çalıştır
                        commandF.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception exF)
            {
                MessageBox.Show($"An error occurred while adding to favorites: {exF.Message}");
            }
        }

        private void RemoveFromFavorites()
        {
            string connectionStringF = "Server=localhost;Database=appınfos;Uid=root;Pwd=123456;"; // Veritabanı bağlantı dizesi

            try
            {
                using (MySqlConnection connectionF = new MySqlConnection(connectionStringF))
                {
                    connectionF.Open();

                    // Veritabanından favoriyi kaldırma sorgusu
                    string removeFavoriteQueryF = @"
                        DELETE FROM favorites 
                        WHERE UserID = @userIDF AND AdID = @adIDF";

                    using (MySqlCommand command = new MySqlCommand(removeFavoriteQueryF, connectionF))
                    {
                        // Parametreleri ekliyoruz
                        command.Parameters.AddWithValue("@userIDF", userIDF); // Kullanıcı ID'si
                        command.Parameters.AddWithValue("@adIDF", adIDF); // İlan ID'si

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

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            // Parent form üzerinden Homepage'e geçiş yap
            if (this.ParentForm is Main mainForm)
            {
                mainForm.ShowFormInPanel(new Favorites()); // Homepage formunu göster
            }
        }
    }
}
