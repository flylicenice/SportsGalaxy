using Microsoft.Extensions.Logging;
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
    public partial class EventBlock : UserControl
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";

        string eventName, location, eventDate, eventTime, eventDesc;
        int current, max, eventid;
        private string userid;

        public EventBlock(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            loadCustomFont();
        }

        public void FillData(string name, int eventid, string location, string date, string time, string desc, int current, int max)
        {
            DateTime.TryParse(date, out DateTime parsedDate);
            nameLbl.Text = name;
            locationLbl.Text = location;
            dateLbl.Text = parsedDate.ToString("d/M/yyyy");
            timeLbl.Text = time;
            maxLabel.Text = $"Slots: {current} / {max}";

            this.eventid = eventid;  eventName = name; this.location = location; eventDate = date; eventTime = time; this.eventDesc = desc; this.current = current; this.max = max;

            if (current >= max)
            {
                joinBtn.Text = "Full";
                joinBtn.Enabled = false;
            }
            else if(AlreadyJoined(eventid))
            {
                joinBtn.Text = "Joined";
                joinBtn.Enabled = false;
                joinBtn.BackColor = Color.Gray;
            }
            choosePic(location);
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            JoinEvent joinForm = new JoinEvent(userid, eventid, eventName, eventDate, eventTime, eventDesc, location, current, max);
            if (joinForm.ShowDialog() == DialogResult.Yes)
            {
                joinBtn.Text = "Joined";
                joinBtn.Enabled = false;
                joinBtn.BackColor = Color.Gray;
            }
        }

        private void loadCustomFont()
        {
            nameLbl.Font = CustomFonts.SmallFont;
            locationLbl.Font = CustomFonts.SmallFont;
            dateLbl.Font = CustomFonts.SmallFont;
            timeLbl.Font = CustomFonts.SmallFont;
            maxLabel.Font = CustomFonts.SmallFont;
        }

        private bool AlreadyJoined(int eventId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT COUNT(*) FROM [JOIN_EVENTS] WHERE EventId = @eventId AND matric_no = @matric";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventId", eventId);
                    cmd.Parameters.AddWithValue("@matric", userid);
                    conn.Open();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        private void choosePic(string location)
        { 
            if (location == "Gym")
            {
                pictureBox.Image = Properties.Resources.dumbell;
            }
            else if (location == "Football Field")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Basketball Court")
            {
                pictureBox.Image = Properties.Resources.basketball;
            } else if (location == "Badminton Court")
            {
                pictureBox.Image = Properties.Resources.badminton;
            } else if (location == "Netball Court")
            {
                pictureBox.Image = Properties.Resources.netball;
            }
        }

        public void disableJoinBtn()
        {
            joinBtn.Enabled = false;
            joinBtn.Text = "Full";
        }
    }
}
