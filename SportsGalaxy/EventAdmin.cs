using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class EventAdmin : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public EventAdmin()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsGalaxyDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter1.Fill(this.sportsGalaxyDataSet.Event);
            // TODO: This line of code loads data into the 'sportsGalaxyDB.Event' table. You can move, or remove it, as needed.

        }

        private void eventDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTxtBox.Text = eventDGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            nameTxtBox.Text = eventDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            locationTxtBox.Text = eventDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTxtBox.Text = eventDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            timeTxtBox.Text = eventDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void chartRefresh()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Event]", conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    eventDGV.DataSource = dt;
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM [EVENT] WHERE EventId = @EventId", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@EventId", IDTxtBox.Text);

                    try
                    {
                        int affectedRow = cmd.ExecuteNonQuery();

                        if (affectedRow > 0)
                        {
                            MessageBox.Show("Deleted Successfully!");
                            chartRefresh();
                        }
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
        UPDATE [Event] 
        SET 
            EventDate = @EventDate, 
            EventTime = @EventTime, 
            Location = @Location 
        WHERE EventId = @EventId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@EventId", IDTxtBox.Text);
                    cmd.Parameters.AddWithValue("@EventDate", startDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EventTime", startTime.Value.ToShortTimeString());
                    cmd.Parameters.AddWithValue("@Location", locationComboBx.SelectedItem.ToString()); // Dropdown facility choice

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chartRefresh();
                        }
                        else
                        {
                            MessageBox.Show("No event was found with that ID.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to update database record: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void item_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
