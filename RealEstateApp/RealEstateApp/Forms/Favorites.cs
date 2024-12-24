using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateApp.Forms
{
    public partial class Favorites : Form
    {
        string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=123456;";

        public Favorites()
        {
            InitializeComponent();
            LoadAds();
        }

        private void Favorites_Load(object sender, EventArgs e)
        {
            LoadAds(); // Form yüklendiğinde ilanları getir
        }

        private void LoadAds()
        {
            flowLayoutPanelFaves.Controls.Clear();

            // Giriş yapan kullanıcının UserID'sini burada alıyoruz.
            int userID = Login.userId; // Bu metodu kendinize göre implement edebilirsiniz.

        string query = @"
        SELECT 
            ads.AdID,
            ads.Title,
            ads.Price,
            ads.SquareMeters,
            MIN(adphotos.PhotoPath) AS PhotoPath
        FROM 
            ads
        LEFT JOIN 
            adphotos ON ads.AdID = adphotos.AdID
        INNER JOIN 
            favorites ON ads.AdID = favorites.AdID
        WHERE 
            ads.Status = 'Active' 
            AND favorites.UserID = @UserID
        GROUP BY 
            ads.AdID, ads.Title, ads.Price, ads.SquareMeters
    ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID); // Parametreyi ekliyoruz

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int adId = reader.GetInt32(0);
                        string title = reader.GetString(1);
                        decimal price = reader.GetDecimal(2);
                        int squareMeters = reader.GetInt32(3);
                        string photoPath = reader.IsDBNull(4) ? null : reader.GetString(4);

                        AddAdToPanel(adId, title, price, squareMeters, photoPath);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        // Bu metodu, giriş yapan kullanıcının UserID'sini almak için implement edebilirsiniz.
      


        private void AddAdToPanel(int adId, string title, decimal price, int squareMeters, string photoPath)
        {
            Panel adPanel = new Panel
            {
                Width = 350,
                Height = 300, // 250 -> 300 oldu
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(15),
                BackColor = Color.White,
                Tag = adId // AdID'yi panelin Tag özelliğine ekliyoruz
            };
            // Click olayı için handler ekle
            adPanel.Click += AdPanel_Click;

            PictureBox pictureBox = new PictureBox
            {
                Width = adPanel.Width,
                Height = 150,
                BackColor = Color.LightGray,
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Tag = adId // AdID'yi PictureBox'un Tag özelliğine ekliyoruz
            };

            if (!string.IsNullOrEmpty(photoPath) && System.IO.File.Exists(photoPath))
            {
                pictureBox.Image = Image.FromFile(photoPath);
            }
            // Click olayı için handler ekle
            pictureBox.Click += AdPanel_Click;

            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Arial", 12, FontStyle.Bold),
                AutoSize = false,
                Width = adPanel.Width - 20,
                Height = 30,
                Location = new Point(10, 160),
                TextAlign = ContentAlignment.MiddleLeft,
                Tag = adId // AdID'yi Label'in Tag özelliğine ekliyoruz
            };
            // Click olayı için handler ekle
            titleLabel.Click += AdPanel_Click;

            Label priceLabel = new Label
            {
                Text = $"Price: {price} TL",
                Font = new Font("Arial", 10),
                AutoSize = false,
                Width = adPanel.Width - 20,
                Height = 20,
                Location = new Point(10, 190),
                TextAlign = ContentAlignment.MiddleLeft,
                Tag = adId // AdID'yi Label'in Tag özelliğine ekliyoruz
            };
            priceLabel.Click += AdPanel_Click;

            Label squareMetersLabel = new Label
            {
                Text = $"Size: {squareMeters} m²",
                Font = new Font("Arial", 10),
                AutoSize = false,
                Width = adPanel.Width - 20,
                Height = 20,
                Location = new Point(10, 220),
                TextAlign = ContentAlignment.MiddleLeft,
                Tag = adId // AdID'yi Label'in Tag özelliğine ekliyoruz
            };
            squareMetersLabel.Click += AdPanel_Click;

            adPanel.Controls.Add(pictureBox);
            adPanel.Controls.Add(titleLabel);
            adPanel.Controls.Add(priceLabel);
            adPanel.Controls.Add(squareMetersLabel);

            flowLayoutPanelFaves.Controls.Add(adPanel);
        }
        private void AdPanel_Click(object sender, EventArgs e)
        {
            // Tıklanan kontrolün AdID'sini alıyoruz
            int adID = 0;
            if (sender is Control control && control.Tag != null)
            {
                adID = (int)control.Tag;
            }

            if (adID > 0)
            {
                // Main formundaki ShowFormInPanel metodunu kullanarak geçiş yapıyoruz
                Main mainForm = (Main)this.ParentForm; // Ana forma erişiyoruz
                mainForm.ShowFormInPanel(new FaveAdDetails(adID)); // AdDetails formunu panele yüklüyoruz
            }
        }

    }
}
