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
    public partial class eventForm : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        private string currentMatricNo;
        public eventForm(string matricNo)
        {
            InitializeComponent();
            this.currentMatricNo = matricNo;
        }

        private void eventForm_load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            // Combined query using LEFT JOIN to get the event details AND the count at the same time
            string optimizedQuery = @"
            SELECT 
            e.EventID, 
            e.EventName, 
            e.Location, 
            e.EventDate, 
            e.EventTime, 
            e.Description,
            e.MaxAttendees,
            COUNT(j.EventID) AS CurrentAttendees
            FROM [Event] e
            LEFT JOIN [JOIN_EVENTS] j ON e.EventID = j.EventID
            GROUP BY 
            e.EventID, e.EventName, e.Location, e.EventDate, e.EventTime, e.Description, e.MaxAttendees";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand eventCmd = new SqlCommand(optimizedQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = eventCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int eventId = int.Parse(reader["EventId"].ToString());
                                string name = reader["EventName"].ToString();
                                string location = reader["Location"].ToString();
                                string date = reader["EventDate"].ToString();
                                string time = reader["EventTime"].ToString();
                                string desc = reader["Description"].ToString();
                                int maxAttendees = Convert.ToInt32(reader["MaxAttendees"]);
                                int currentAttendees = Convert.ToInt32(reader["CurrentAttendees"]);

                                EventBlock eventBlock = new EventBlock(currentMatricNo);
                                eventBlock.FillData(name, eventId, location, date, time, desc, currentAttendees, maxAttendees);

                                if (currentAttendees >= maxAttendees)
                                {
                                    eventBlock.disableJoinBtn();
                                }

                                DateTime.TryParse(date, out DateTime eventDate);

                                if (eventDate.Date >= DateTime.Today)
                                {
                                    flowLayoutPanel1.Controls.Add(eventBlock);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading events: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void refreshEvent()
        {
            flowLayoutPanel1.Controls.Clear();

            string Query = @"
            SELECT 
            e.EventID, 
            e.EventName, 
            e.Location, 
            e.EventDate, 
            e.EventTime,
            e.Description,
            e.MaxAttendees,
            COUNT(j.EventID) AS CurrentAttendees
            FROM [Event] e
            LEFT JOIN [JOIN_EVENTS] j ON e.EventID = j.EventID
            GROUP BY 
            e.EventID, e.EventName, e.Location, e.EventDate, e.EventTime, e.Description, e.MaxAttendees";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand eventCmd = new SqlCommand(Query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = eventCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int eventId = int.Parse(reader["EventId"].ToString());
                                string name = reader["EventName"].ToString();
                                string location = reader["Location"].ToString();
                                string date = Convert.ToDateTime(reader["EventDate"]).ToString("dd/MM/yyyy");
                                string time = reader["EventTime"].ToString();
                                string desc = reader["Description"].ToString();
                                int maxAttendees = Convert.ToInt32(reader["MaxAttendees"]);
                                int currentAttendees = Convert.ToInt32(reader["CurrentAttendees"]);

                                EventBlock eventBlock = new EventBlock(currentMatricNo);
                                eventBlock.FillData(name, eventId, location, date, time, desc, currentAttendees, maxAttendees);

                                if (currentAttendees >= maxAttendees)
                                {
                                    eventBlock.disableJoinBtn();
                                }

                                DateTime.TryParse(date.ToString(), out DateTime eventDate);

                                if (eventDate.Date >= DateTime.Today)
                                {
                                    flowLayoutPanel1.Controls.Add(eventBlock);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading events: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
