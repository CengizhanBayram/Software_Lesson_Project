using Microsoft.VisualBasic.ApplicationServices;
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

        private string connectionString = GlobalSettings.ConnectionString;
        int userId = (int)GlobalSettings.UserID;

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
                            ads.CreatedAt
                        FROM 
                            ads
                        WHERE 
                            ads.UserID = @userId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewAds.Rows.Clear();
                    dataGridViewAds.Columns.Clear();

                    foreach (DataColumn column in dataTable.Columns)
                    {
                        dataGridViewAds.Columns.Add(column.ColumnName, column.ColumnName);
                    }

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int rowIndex = dataGridViewAds.Rows.Add();
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            dataGridViewAds.Rows[rowIndex].Cells[i].Value = row[i].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ads: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    foreach (DataGridViewRow row in dataGridViewAds.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int adID = Convert.ToInt32(row.Cells["AdID"].Value);
                        string title = row.Cells["Title"].Value?.ToString() ?? "";
                        string description = row.Cells["Description"].Value?.ToString() ?? "";
                        decimal price = decimal.TryParse(row.Cells["Price"].Value?.ToString(), out var parsedPrice) ? parsedPrice : 0;
                        string location = row.Cells["Location"].Value?.ToString() ?? "";
                        int square = int.TryParse(row.Cells["SquareMeters"].Value?.ToString(), out var parsedSquare) ? parsedSquare : 0;

                        string floorNo = row.Cells["FloorNo"].Value?.ToString() ?? "";
                        string roomCount = row.Cells["RoomCount"].Value?.ToString() ?? "";

                        string elevatorValue = row.Cells["Elevator"].Value?.ToString() ?? "false";
                        bool elevator = elevatorValue.ToLower() switch
                        {
                            "true" => true,
                            "false" => false,
                            "1" => true,
                            "0" => false,
                            _ => false
                        };

                        string status = row.Cells["Status"].Value?.ToString() ?? "active";

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
                            command.Parameters.AddWithValue("@SquareMeters", square);
                            command.Parameters.AddWithValue("@RoomCount", roomCount);
                            command.Parameters.AddWithValue("@FloorNo", floorNo);
                            command.Parameters.AddWithValue("@Elevator", elevator ? 1 : 0);
                            command.Parameters.AddWithValue("@Status", status);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Ads updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating ads: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewAds.SelectedRows.Count > 0)
            {
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

                            string deleteAdQuery = "DELETE FROM ads WHERE AdID = @AdID;";
                            using (MySqlCommand adCommand = new MySqlCommand(deleteAdQuery, connection))
                            {
                                adCommand.Parameters.AddWithValue("@AdID", adID);
                                adCommand.ExecuteNonQuery();
                            }

                            MessageBox.Show("Ad deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataGridViewAds.Rows.RemoveAt(selectedRowIndex);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting ad: " + ex.Message);
                    }
                }
            }
        }
    }
}
