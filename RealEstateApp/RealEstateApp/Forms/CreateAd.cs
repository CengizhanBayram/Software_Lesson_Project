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
        string connectionString = GlobalSettings.ConnectionString;
        List<string> photoPaths = new List<string>();

        public CreateAd()
        {
            InitializeComponent();
        }

        private void CreateAd_Load(object sender, EventArgs e)
        {
            string[] iller = GlobalSettings.iller;
            comboBoxLocation.Items.AddRange(iller);
            comboBoxLocation.DropDownHeight = 150;

            string[] roomNumber = GlobalSettings.roomNumber;
            comboBoxRoomNumber.Items.AddRange(roomNumber);
            comboBoxRoomNumber.DropDownHeight = 150;

            string[] floorNumbers = GlobalSettings.floorNumbers;
            comboBoxFloorNo.Items.AddRange(floorNumbers);
            comboBoxFloorNo.DropDownHeight = 150;

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
                            Width = 200,
                            Height = 200
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
                string description = richTextBoxDescription.Text;
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
                        cmd.Parameters.AddWithValue("@UserID", GlobalSettings.UserID);  

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
