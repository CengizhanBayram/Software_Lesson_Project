﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateApp.Forms
{
    public partial class OwnAds : Form
    {
        public OwnAds()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=localhost;Database=emlak;Uid=root;Pwd=16072001;";
        int userId = Login.userId;

        private void OwnAds_Load(object sender, EventArgs e)
        {
            try
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            string query = @"
                SELECT 
                    ads.AdID, 
                    ads.Title, 
                    ads.Description, 
                    ads.Price, 
                    ads.Location,
                    ads.SquareMeters,
                    ads.RoomCount,
                    ads.FloorNo,
                    ads.Elevator,
                    ads.Status,
                    ads.CreatedAt,
                    MIN(adphotos.PhotoPath) AS PhotoPath
                FROM 
                    ads 
                LEFT JOIN 
                    adphotos 
                ON 
                    ads.AdID = adphotos.AdID 
                WHERE 
                    ads.UserID = @userId
                GROUP BY 
                    ads.AdID, ads.Title, ads.Description, ads.Price, ads.Location, 
                    ads.SquareMeters, ads.RoomCount, ads.FloorNo, ads.Elevator, 
                    ads.Status, ads.CreatedAt";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@userId", userId);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridViewAds.Rows.Clear();
            dataGridViewAds.Columns.Clear();

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "ImageColumn",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridViewAds.Columns.Add(imgColumn);

            foreach (DataColumn column in dataTable.Columns)
            {
                if (column.ColumnName != "PhotoPath")
                {
                    dataGridViewAds.Columns.Add(column.ColumnName, column.ColumnName);
                }
            }

            foreach (DataRow row in dataTable.Rows)
            {
                string photoPath = row["PhotoPath"].ToString();
                Image adImage = Properties.Resources.DefaultImage; // Default resim

                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    using (var stream = new MemoryStream(File.ReadAllBytes(photoPath)))
                    {
                        adImage = Image.FromStream(stream);
                    }
                }

                int rowIndex = dataGridViewAds.Rows.Add();
                dataGridViewAds.Rows[rowIndex].Cells["ImageColumn"].Value = adImage;
                int colIndex = 1;

                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.ColumnName != "PhotoPath")
                    {
                        dataGridViewAds.Rows[rowIndex].Cells[colIndex].Value = row[column.ColumnName].ToString();
                        colIndex++;
                    }
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading ads with images: " + ex.Message);
    }
}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow row in dataGridViewAds.Rows)
                    {
                        if (row.IsNewRow) continue; // Yeni satır yoksa atla

                        int adID = Convert.ToInt32(row.Cells["AdID"].Value);
                        string title = row.Cells["Title"].Value?.ToString() ?? "";
                        string description = row.Cells["Description"].Value?.ToString() ?? "";
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value ?? 0);
                        string location = row.Cells["Location"].Value?.ToString() ?? "";
                        int square = Convert.ToInt32(row.Cells["SquareMeters"].Value);
                        int room = Convert.ToInt32(row.Cells["RoomCount"].Value);
                        int floor = Convert.ToInt32(row.Cells["FloorNo"].Value);

                        bool elevatorValue = Convert.ToBoolean(row.Cells["Elevator"].Value);
                        int elevator = elevatorValue ? 1 : 0; // True ise 1, False ise 0

                        string status = row.Cells["Status"].Value?.ToString() ?? "active"; // Status değeri




                        string updateQuery = @"
                            UPDATE ads
                            SET 
                                Title = @Title, 
                                Description = @Description, 
                                Price = @Price, 
                                Location = @Location,
                                SquareMeters = @SquareMeters,
                                RoomCount = @RoomCount,
                                FloorNo = @FloorNo,
                                Elevator = @Elevator,
                                Status = @Status
                            WHERE 
                                AdID = @AdID";

                        using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@AdID", adID);
                            command.Parameters.AddWithValue("@Title", title);
                            command.Parameters.AddWithValue("@Description", description);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Location", location);
                            command.Parameters.AddWithValue("SquareMeters", square);
                            command.Parameters.AddWithValue("RoomCount", room);
                            command.Parameters.AddWithValue("FloorNo", floor);
                            command.Parameters.AddWithValue("Elevator", elevator);
                            command.Parameters.AddWithValue("@Status", status); // Yeni Status parametresi
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Ads updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ads: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAds.SelectedRows.Count > 0)
            {
                // Seçili satırdaki AdID'yi al
                int selectedRowIndex = dataGridViewAds.SelectedRows[0].Index;
                int adID = Convert.ToInt32(dataGridViewAds.Rows[selectedRowIndex].Cells["AdID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this ad?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            connection.Open();

                            // Resim dosyalarının yollarını veritabanından al
                            List<string> photoPaths = new List<string>();
                            string getPhotoPathsQuery = "SELECT PhotoPath FROM adphotos WHERE AdID = @AdID;";
                            using (MySqlCommand getPhotoCommand = new MySqlCommand(getPhotoPathsQuery, connection))
                            {
                                getPhotoCommand.Parameters.AddWithValue("@AdID", adID);
                                using (MySqlDataReader reader = getPhotoCommand.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        photoPaths.Add(reader["PhotoPath"].ToString());
                                    }
                                }
                            }

                            // Resim verisini silme
                            string deletePhotoQuery = "DELETE FROM adphotos WHERE AdID = @AdID;";
                            using (MySqlCommand photoCommand = new MySqlCommand(deletePhotoQuery, connection))
                            {
                                photoCommand.Parameters.AddWithValue("@AdID", adID);
                                photoCommand.ExecuteNonQuery();
                            }

                            // İlan verisini silme
                            string deleteAdQuery = "DELETE FROM ads WHERE AdID = @AdID;";
                            using (MySqlCommand adCommand = new MySqlCommand(deleteAdQuery, connection))
                            {
                                adCommand.Parameters.AddWithValue("@AdID", adID);
                                adCommand.ExecuteNonQuery();
                            }

                            // Resim dosyalarını fiziksel olarak sil
                            foreach (string photoPath in photoPaths)
                            {
                                if (File.Exists(photoPath))
                                {
                                    try
                                    {
                                        File.Delete(photoPath);
                                    }
                                    catch (Exception fileEx)
                                    {
                                        MessageBox.Show($"Error deleting file '{photoPath}': {fileEx.Message}");
                                    }
                                }
                            }

                            MessageBox.Show("Ad and associated images deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Satırı DataGridView'den kaldır
                            dataGridViewAds.Rows.RemoveAt(selectedRowIndex);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting ad: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an ad to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}






