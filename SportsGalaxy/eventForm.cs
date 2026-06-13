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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        private string currentUserID;
        public eventForm(string userID)
        {
            InitializeComponent();
            this.currentUserID = userID;
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
            e.MaxAttendees,
            COUNT(j.EventID) AS CurrentAttendees
            FROM [Event] e
            LEFT JOIN [JOIN_EVENTS] j ON e.EventID = j.EventID
            GROUP BY 
            e.EventID, e.EventName, e.Location, e.EventDate, e.EventTime, e.MaxAttendees";

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
                                // 1. Pull data directly from the optimized single reader
                                string name = reader["EventName"].ToString();
                                string location = reader["Location"].ToString();
                                string date = reader["EventDate"].ToString();
                                string time = reader["EventTime"].ToString();
                                int maxAttendees = Convert.ToInt32(reader["MaxAttendees"]);
                                int currentAttendees = Convert.ToInt32(reader["CurrentAttendees"]); // Got it instantly!

                                // 2. Create and fill the block
                                EventBlock eventBlock = new EventBlock(currentUserID);
                                eventBlock.FillData(name, location, date, time, currentAttendees, maxAttendees);

                                flowLayoutPanel1.Controls.Add(eventBlock);
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
