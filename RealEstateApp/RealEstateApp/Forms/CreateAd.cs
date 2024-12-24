using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RealEstateApp.Forms
{
    public partial class CreateAd : Form
    {
        // Veritabanı bağlantı bilgileri
        string connectionString = GlobalSettings.ConnectionString;
        List<string> photoPaths = new List<string>();

        public CreateAd()
        {
            InitializeComponent();
        }

        private void CreateAd_Load(object sender, EventArgs e)
        {
            string[] iller = new string[]
            {
                "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya",
                "Artvin", "Aydın", "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
                "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Edirne",
                "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                "Hakkâri", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş",
                "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli",
                "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin",
                "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize",
                "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ",
                "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak"
            };
            comboBoxLocation.Items.AddRange(iller);

            string[] roomNumber = new string[]
            {
                "1+0", "1+1", "2+1", "2+2", "3+1", "3+2", "4+1", "4+2", "5+1",
                "1+0 Dubleks", "1+1 Dubleks", "2+1 Dubleks", "3+1 Dubleks", "4+1 Dubleks",
                "2+0", "3+0", "4+0", "1+1 Penthouse", "2+2 Penthouse", "3+2 Penthouse",
                "3+1 Villa", "4+1 Villa", "5+2", "5+3", "6+1", "6+2", "7+1", "8+2", "9+1",
                "9+2", "10+1"
            };
            comboBoxRoomNumber.Items.AddRange(roomNumber);

            string[] floorNumbers = new string[]
            {
                "Ground Floor", "1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th",
                "10th", "11th", "12th", "13th", "14th", "15th", "16th", "17th", "18th", "19th",
                "20th", "Penthouse", "Attic", "Basement", "Mezzanine", "Upper Floor"
            };
            comboBoxFloorNo.Items.AddRange(floorNumbers);

            comboBoxElevator.Items.AddRange(["Yes", "No"]);
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (ofd.FileNames.Length > 30)
                    {
                        MessageBox.Show("You can choose the most 30 pictures", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // FlowLayoutPanel ayarları
                    flowLayoutPanelPhotos.FlowDirection = FlowDirection.LeftToRight;
                    flowLayoutPanelPhotos.AutoScroll = true;
                    flowLayoutPanelPhotos.WrapContents = false; // Tek satırda kaydırma

                    foreach (string filePath in ofd.FileNames)
                    {
                        string destinationPath = GlobalSettings.DestinationPath + Path.GetFileName(filePath);
                        File.Copy(filePath, destinationPath, true);

                        // FlowLayoutPanel'e fotoğraf ekleme
                        PictureBox pb = new PictureBox
                        {
                            Image = Image.FromFile(filePath),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Width = 150,
                            Height = 150
                        };
                        flowLayoutPanelPhotos.Controls.Add(pb);

                        photoPaths.Add(destinationPath); // for database we keep the list of path
                    }

                    MessageBox.Show("Images upload successfully.");
                }
            }
        }



        private void btnSaveAdvert_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(textBoxTitle.Text))
            {
                errorProviderTitle.SetError(textBoxTitle, "Title field cannot be empty.");
                isValid = false;
            }
            else
                errorProviderTitle.Clear();

            if (string.IsNullOrEmpty(richTextBoxDescription.Text))
            {
                errorProviderDescription.SetError(richTextBoxDescription, "Description field cannot be empty.");
                isValid = false;
            }
            else
                errorProviderDescription.Clear();

            if (string.IsNullOrEmpty(maskedTextBoxPrice.Text))
            {
                errorProviderPrice.SetError(maskedTextBoxPrice, "Price field cannot be empty.");
                isValid = false;
            }
            else
                errorProviderPrice.Clear();

            if (string.IsNullOrEmpty(maskedTextBoxSquareMeters.Text))
            {
                errorProviderSquareMeter.SetError(maskedTextBoxSquareMeters, "SquareMeters cannot be empty.");
                isValid = false;
            }
            else
                errorProviderSquareMeter.Clear();


            if (isValid)
            {
                
                string title = textBoxTitle.Text;
                string description = textBoxTitle.Text;
                int price = Convert.ToInt32(maskedTextBoxPrice.Text);
                int? squareMeters = null;
                string? location = null;
                string? roomNumber = null;
                string? floorNo = null;
                bool? elevator = null;

                if (!string.IsNullOrEmpty(maskedTextBoxSquareMeters.Text))
                    squareMeters = Convert.ToInt32(maskedTextBoxSquareMeters.Text);

                if (!string.IsNullOrEmpty(comboBoxLocation.Text))
                    location = comboBoxLocation.Text;

                if (!string.IsNullOrEmpty(comboBoxRoomNumber.Text))
                    roomNumber = comboBoxRoomNumber.Text;

                if (!string.IsNullOrEmpty (comboBoxFloorNo.Text))
                    floorNo = comboBoxFloorNo.Text;

                if (!string.IsNullOrEmpty(comboBoxElevator.Text))
                    elevator = comboBoxElevator.SelectedItem.ToString() == "Yes" ? true : false;


                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = @"INSERT INTO Ads (Title, Description, Price, Location, SquareMeters, RoomCount, FloorNo, Elevator, UserID)
                                 VALUES (@Title, @Description, @Price, @Location, @SquareMeters, @RoomCount, @FloorNo, @Elevator, @UserID)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Location", location);
                        cmd.Parameters.AddWithValue("@SquareMeters", squareMeters);
                        cmd.Parameters.AddWithValue("@RoomCount", roomNumber);
                        cmd.Parameters.AddWithValue("@FloorNo", floorNo);
                        cmd.Parameters.AddWithValue("@Elevator", elevator);
                        cmd.Parameters.AddWithValue("@UserID", Properties.Settings.Default.UserId);  

                        connection.Open();
                        cmd.ExecuteNonQuery();

                        int adID = (int)cmd.LastInsertedId; // last advert 
                        SavePhotoPathsToDatabase(adID, photoPaths); // save to db
                    }

                    MessageBox.Show("Advert saved successfully.");
                    Main mainForm = (Main)this.ParentForm;
                    mainForm.ShowFormInPanel(new Homepage());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("Error occured: " + ex.Message);
                }
            }
        }


        private void SavePhotoPathsToDatabase(int adID, List<string> photoPaths)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO AdPhotos (AdID, PhotoPath) VALUES (@AdID, @PhotoPath)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();

                foreach (string photoPath in photoPaths)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@AdID", adID);
                    cmd.Parameters.AddWithValue("@PhotoPath", photoPath);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
