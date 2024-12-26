using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RealEstateApp.Forms
{
    public partial class Homepage : Form
    {
        string connectionString = GlobalSettings.ConnectionString;

        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            LoadAds();
            ConfigureFilterTextBoxPrice(textBoxPriceMin, "min");
            ConfigureFilterTextBoxPrice(textBoxPriceMax, "max");

            // combox box location
            string[] iller = GlobalSettings.iller;
            comboBoxLocationFilter.Items.AddRange(iller);
            comboBoxLocationFilter.DropDownHeight = 150;


            // combo box room
            string[] roomNumber = GlobalSettings.roomNumber;
            comboBoxRoom.Items.AddRange(roomNumber);
            comboBoxRoom.DropDownHeight = 150;


            // combo box filter
            string[] floorNumbers = GlobalSettings.floorNumbers;
            comboBoxFloor.Items.AddRange(floorNumbers);
            comboBoxFloor.DropDownHeight = 150;


            // combox box elevator
            comboBoxElevator.Items.AddRange(["Yes", "No"]);


            // square meter text box
            textBoxSquareMeter.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;

                if (char.IsDigit(e.KeyChar) && textBoxSquareMeter.Text.Length >= 5)
                    e.Handled = true;
            };

            textBoxSquareMeter.TextChanged += (s, e) =>
            {
                if (textBoxSquareMeter.Text.Length > 5)
                {
                    textBoxSquareMeter.Text = textBoxSquareMeter.Text.Substring(0, 5);
                    textBoxSquareMeter.SelectionStart = textBoxSquareMeter.Text.Length; 
                }
            };
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

                        Panel adPanel = new Panel
                        {
                            Width = 350,
                            Height = 300,
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
                            Tag = adID
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
                            Tag = adID
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
                            Tag = adID
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
                            Tag = adID
                        };


                        lblSquareMeters.Click += AdPanel_Click;
                        // Panelleri birleştirme
                        adPanel.Controls.Add(imageBox);
                        adPanel.Controls.Add(lblTitle);
                        adPanel.Controls.Add(lblPrice);
                        adPanel.Controls.Add(lblSquareMeters);

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
            int adID = 0;
            if (sender is Control control && control.Tag != null)
            {
                adID = (int)control.Tag;
            }

            if (adID > 0)
            {
                Main mainForm = (Main)this.ParentForm;
                mainForm.ShowFormInPanel(new AdDetails(adID));
            }
        }

        private void ConfigureFilterTextBoxPrice(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            // Placeholder ayarı
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };

            // Sadece 10 haneli sayı girişi kontrolü
            textBox.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Sadece rakamlara izin ver
                    e.Handled = true;
                }

                // En fazla 10 hane kontrolü
                if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 10)
                {
                    e.Handled = true;
                }
            };

            textBox.TextChanged += (s, e) =>
            {
                // Eğer uzunluk 10 karakteri geçerse kırp
                if (textBox.Text.Length > 10 && textBox.ForeColor == Color.Black)
                {
                    textBox.Text = textBox.Text.Substring(0, 10);
                    textBox.SelectionStart = textBox.Text.Length; // İmleci sona taşı
                }
            };
        }

    }
}
