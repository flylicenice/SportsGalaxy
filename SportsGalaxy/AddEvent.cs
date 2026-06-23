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
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";

        string currentMatricNo;
        public AddEvent(string matricNo)
        {
            InitializeComponent();
            LoadCustomFont();
            currentMatricNo = matricNo;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                insertIntoDatabase();
            }
        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            titleLbl.Font = CustomFonts.TitleFont;
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
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text))
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
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [Event] (EventName, EventDate, EventTime, Location, Description, MaxAttendees, matric_no) VALUES (@name, @date, @time, @location, @desc, @attendees, @matricNo)", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@name", nameTxtBox.Text);
                        cmd.Parameters.AddWithValue("@date", startDate.Value.Date);
                        cmd.Parameters.AddWithValue("@time", startTime.Value.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@location", locationComboBx.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@desc", descTxtBox.Text);
                        cmd.Parameters.AddWithValue("@attendees", attendeesBox.Value);
                        cmd.Parameters.AddWithValue("@matricNo", currentMatricNo);

                        int rowsInserted = cmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            clearTxtBox();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            clearTxtBox();
            this.Hide();
        }

        private void clearTxtBox()
        {
            nameTxtBox.Text = "";
            descTxtBox.Text = "";
            locationComboBx.SelectedIndex = -1;
            attendeesBox.Value = attendeesBox.Minimum;
            startDate.Value = DateTime.Now;
            startTime.Value = DateTime.Now;

            errorProvider1.Clear();
        }

        private void locationComboBx_Validating(object sender, CancelEventArgs e)
        {
            if (locationComboBx.SelectedIndex == -1)
            {
                errorProvider1.SetError(locationComboBx,
                    "Please select a location.");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(locationComboBx, "");
            }
        }

        private void startTime_Validating(object sender, CancelEventArgs e)
        {
            DateTime eventDateTime = startDate.Value.Date + startTime.Value.TimeOfDay;

            if (eventDateTime < DateTime.Now)
            {
                errorProvider1.SetError(startTime, "Event time cannot be in the past.");

                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(startTime, "");
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
