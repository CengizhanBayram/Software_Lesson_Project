using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
            // price text box
            ConfigureFilterTextBox(textBoxPriceMin, "min", 10);
            ConfigureFilterTextBox(textBoxPriceMax, "max", 10);

            // square meter text box
            ConfigureFilterTextBox(textBoxSquareMeterMin ,"min",5);
            ConfigureFilterTextBox(textBoxSquareMeterMax, "max", 5);

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
                    readerAd(reader);
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
                GlobalSettings.PreviousForm = this;
                Main mainForm = (Main)this.ParentForm;
                mainForm.ShowFormInPanel(new AdDetails(adID));
            }
        }

        private void ConfigureFilterTextBox(System.Windows.Forms.TextBox textBox, string placeholder, int textLength)
        {
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

            textBox.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Sadece rakamlara izin ver
                    e.Handled = true;
                }

                // En fazla ... digit kontrolü
                if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= textLength)
                {
                    e.Handled = true;
                }
            };

            textBox.TextChanged += (s, e) =>
            {
                if (textBox.Text.Length > textLength && textBox.ForeColor == Color.Black)
                {
                    textBox.Text = textBox.Text.Substring(0, textLength);
                    textBox.SelectionStart = textBox.Text.Length; // İmleci sona taşı
                }
            };
        }

        private void buttonSearchTitle_Click(object sender, EventArgs e)
        {
            flowLayoutPanelAds.Controls.Clear();
            string searchWord = textBoxSearchTitle.Text;

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
                    AND (ads.Title LIKE @SearchWord or ads.Description LIKE @SearchWord)
                    
                GROUP BY 
                    ads.AdID, ads.Title, ads.Price, ads.SquareMeters
            ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@SearchWord", $"%{searchWord}%");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    readerAd(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading ads: " + ex.Message);
                }
            }
        }
        private void buttonSearchFilter_Click(object sender, EventArgs e)
        {
            flowLayoutPanelAds.Controls.Clear();
            int? minPrice = int.TryParse(textBoxPriceMin.Text, out int tempMinPrice) ? tempMinPrice : null;
            int? maxPrice = int.TryParse(textBoxPriceMax.Text, out int tempMaxPrice) ? tempMaxPrice : null;
            int? minSquareMeter = int.TryParse(textBoxSquareMeterMin.Text, out int tempMinSquare) ? tempMinSquare : null;
            int? maxSquareMeter = int.TryParse(textBoxSquareMeterMax.Text, out int tempMaxSquare) ? tempMaxSquare : null;

            string? location = string.IsNullOrWhiteSpace(comboBoxLocationFilter.Text) ? null : comboBoxLocationFilter.Text;
            string? roomNumber = string.IsNullOrWhiteSpace(comboBoxRoom.Text) ? null : comboBoxRoom.Text;
            string? floorNumber = string.IsNullOrWhiteSpace(comboBoxFloor.Text) ? null : comboBoxFloor.Text;

            int? elevator = null;
            if (comboBoxElevator.Text.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                elevator = 1;
            else if (comboBoxElevator.Text.Equals("No", StringComparison.OrdinalIgnoreCase))
                elevator = 0;

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
                    AND (@minPrice IS NULL OR ads.Price > @minPrice)
                    AND (@maxPrice IS NULL OR ads.Price < @maxPrice)
                    AND (@minSquareMeter IS NULL OR ads.SquareMeters > @minSquareMeter)
                    AND (@maxSquareMeter IS NULL OR ads.SquareMeters < @maxSquareMeter)
                    AND (@location IS NULL OR ads.Location = @location)
                    AND (@roomNumber IS NULL OR ads.RoomCount = @roomNumber)
                    AND (@floorNumber IS NULL OR ads.FloorNo = @floorNumber)
                    AND (@elevator IS NULL OR ads.Elevator = @elevator)
                GROUP BY 
                    ads.AdID, ads.Title, ads.Price, ads.SquareMeters
            ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@minPrice", minPrice ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@minSquareMeter", minSquareMeter ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@maxSquareMeter", maxSquareMeter ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@location", location ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@roomNumber", roomNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@floorNumber", floorNumber ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@elevator", elevator ?? (object)DBNull.Value);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    readerAd(reader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading ads: " + ex.Message);
                }
            }
        }



        private void readerAd(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                // İlan bilgilerini alıyoruz
                int adID = reader.GetInt32("AdID");
                string title = reader.GetString("Title");
                int price = reader.GetInt32("Price");
                int squareMeters = reader.IsDBNull(reader.GetOrdinal("SquareMeters")) ? 0 : reader.GetInt32("SquareMeters");
                string photoPath = reader.IsDBNull(reader.GetOrdinal("PhotoPath")) ? null : reader.GetString("PhotoPath");

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

    }
}
