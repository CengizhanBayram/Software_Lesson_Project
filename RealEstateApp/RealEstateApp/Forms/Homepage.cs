using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RealEstateApp.Forms
{
    public partial class Homepage : Form
    {
        string connectionString = "Server=localhost;Database=appınfos;Uid=root;Pwd=123456;";

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            LoadAds(); // Form yüklendiğinde ilanları getir
        }

        private void LoadAds()
        {
            flowLayoutPanelAds.Controls.Clear();

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
            adphotos
        ON 
            ads.AdID = adphotos.AdID
        WHERE 
            ads.Status = 'Active'
        GROUP BY 
            ads.AdID, ads.Title, ads.Price, ads.SquareMeters
    ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        // İlan bilgilerini alıyoruz
                        int adID = reader.GetInt32("AdID");
                        string title = reader.GetString("Title");
                        int price = reader.GetInt32("Price");
                        int squareMeters = reader.IsDBNull(reader.GetOrdinal("SquareMeters"))
                                           ? 0
                                           : reader.GetInt32("SquareMeters");
                        string photoPath = reader.IsDBNull(reader.GetOrdinal("PhotoPath"))
                                           ? null
                                           : reader.GetString("PhotoPath");

                        // İlan panelini oluşturuyoruz
                        Panel adPanel = new Panel
                        {
                            Width = 350,
                            Height = 300, // 250 -> 300 oldu
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(15),
                            BackColor = Color.White,
                            Tag = adID // AdID'yi panelin Tag özelliğine ekliyoruz
                        };

                        // Click olayı için handler ekle
                        adPanel.Click += AdPanel_Click;

                        // Resim alanı
                        PictureBox imageBox = new PictureBox
                        {
                            Width = adPanel.Width,
                            Height = 150,
                            BackColor = Color.LightGray,
                            Dock = DockStyle.Top,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Tag = adID // AdID'yi PictureBox'un Tag özelliğine ekliyoruz
                        };

                        // Eğer fotoğraf yolu varsa resmi yükle
                        if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                        {
                            imageBox.Image = Image.FromFile(photoPath);
                        }
                        else
                        {
                            imageBox.Image = Properties.Resources.DefaultImage; // Varsayılan görsel
                        }

                        // Click olayı için handler ekle
                        imageBox.Click += AdPanel_Click;

                        // Başlık etiketi
                        Label lblTitle = new Label
                        {
                            Text = title,
                            Font = new Font("Arial", 12, FontStyle.Bold),
                            AutoSize = false,
                            Width = adPanel.Width - 20,
                            Height = 30,
                            Location = new Point(10, 160),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Tag = adID // AdID'yi Label'in Tag özelliğine ekliyoruz
                        };

                        // Click olayı için handler ekle
                        lblTitle.Click += AdPanel_Click;

                        // Fiyat etiketi
                        Label lblPrice = new Label
                        {
                            Text = $"Price: {price} TL",
                            Font = new Font("Arial", 10),
                            AutoSize = false,
                            Width = adPanel.Width - 20,
                            Height = 20,
                            Location = new Point(10, 190),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Tag = adID // AdID'yi Label'in Tag özelliğine ekliyoruz
                        };
                        // Click olayı için handler ekle
                        lblPrice.Click += AdPanel_Click;
                        // Metrekare etiketi
                        Label lblSquareMeters = new Label
                        {
                            Text = $"Size: {squareMeters} m²",
                            Font = new Font("Arial", 10),
                            AutoSize = false,
                            Width = adPanel.Width - 20,
                            Height = 20,
                            Location = new Point(10, 220),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Tag = adID // AdID'yi Label'in Tag özelliğine ekliyoruz
                        };

                        // Click olayı için handler ekle
                        lblSquareMeters.Click += AdPanel_Click;
                        // Panelleri birleştirme
                        adPanel.Controls.Add(imageBox);
                        adPanel.Controls.Add(lblTitle);
                        adPanel.Controls.Add(lblPrice);
                        adPanel.Controls.Add(lblSquareMeters);

                        // FlowLayoutPanel'e ekleme
                        flowLayoutPanelAds.Controls.Add(adPanel);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading ads: " + ex.Message);
                }
            }
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
                mainForm.ShowFormInPanel(new AdDetails(adID)); // AdDetails formunu panele yüklüyoruz
            }
        }


    }
}
