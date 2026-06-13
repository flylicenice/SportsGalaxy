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
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.ForeColor;

namespace SportsGalaxy
{
    public partial class AddEvent : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        public AddEvent()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            insertIntoDatabase();
        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            titleLbl.Font = CustomFonts.TitleFont;
            addButton.Font = CustomFonts.BodyFont;
            startDate.Font = CustomFonts.BodyFont;
            startTime.Font = CustomFonts.BodyFont;
            nameLbl.Font = CustomFonts.BodyFont;
            locationLbl.Font = CustomFonts.BodyFont;
            descLbl.Font = CustomFonts.BodyFont;
            timeLbl.Font = CustomFonts.BodyFont;
            dateLbl.Font = CustomFonts.BodyFont;
            locationComboBx.Font = CustomFonts.SmallFont;
        }

        private void nameTxtBx_validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxtBox.Text))
            {
                errorProvider1.SetError(nameTxtBox, "Event name is required.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(nameTxtBox, "");
            }
        }

        private void descTxtBox_validating(object sender, CancelEventArgs e)
        {
            if (descTxtBox.Text.Length > 200)
            {
                errorProvider1.SetError(descTxtBox, "Description cannot exceed 200 characters.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(descTxtBox, "");
            }
        }

        private void startDate_validating(object sender, CancelEventArgs e)
        {
            if (startDate.Value.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(startDate, "Start date cannot be in the past.");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(startDate, "");
            }
        }

        private void insertIntoDatabase()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Event] (EventName, EventDate, Location, Description, MaxAttendees) VALUES (@name, @date, @location, @desc, @attendees)", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@name", nameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@date", startDate.Value.Date);
                        cmd.Parameters.AddWithValue("@location", locationComboBx.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@desc", descTxtBox.Text);
                        cmd.Parameters.AddWithValue("@attendees", attendeesBox.Value);

                        int rowsInserted = cmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
