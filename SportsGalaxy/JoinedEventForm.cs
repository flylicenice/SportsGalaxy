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
    public partial class JoinedEventForm : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        string currentMatricNo;
        public JoinedEventForm(string matricNo)
        {
            InitializeComponent();
            LoadCustomFont();
            currentMatricNo = matricNo;
        }

        private void form_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            string optimizedQuery = @"
            SELECT 
            e.EventId, 
            e.EventName, 
            e.EventDate, 
            e.EventTime,
            e.Location
            FROM [Event] e
            INNER JOIN [JOIN_EVENTS] j ON e.EventId = j.EventId
            WHERE j.matric_no = @matricNo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand eventCmd = new SqlCommand(optimizedQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        eventCmd.Parameters.AddWithValue("@matricNo", currentMatricNo);
                        using (SqlDataReader reader = eventCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int eventId = int.Parse(reader["EventId"].ToString());
                                string name = reader["EventName"].ToString();
                                string location = reader["Location"].ToString();
                                string date = reader["EventDate"].ToString();
                                string time = reader["EventTime"].ToString();

                                EventBlockHori eventBlock = new EventBlockHori(currentMatricNo);
                                eventBlock.FillData(eventId, name, location, date, time);

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

        public void refreshEvent()
        {
            flowLayoutPanel1.Controls.Clear();

            string optimizedQuery = @"
            SELECT 
            e.EventId, 
            e.EventName, 
            e.EventDate, 
            e.EventTime,
            e.Location
            FROM [Event] e
            INNER JOIN [JOIN_EVENTS] j ON e.EventId = j.EventId
            WHERE j.matric_no = @matricNo";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand eventCmd = new SqlCommand(optimizedQuery, conn))
                {
                    try
                    {
                        conn.Open();
                        eventCmd.Parameters.AddWithValue("@matricNo", currentMatricNo);
                        using (SqlDataReader reader = eventCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int eventId = int.Parse(reader["EventId"].ToString());
                                string name = reader["EventName"].ToString();
                                string location = reader["Location"].ToString();
                                string date = reader["EventDate"].ToString();
                                string time = reader["EventTime"].ToString();

                                EventBlockHori eventBlock = new EventBlockHori(currentMatricNo);
                                eventBlock.FillData(eventId, name, location, date, time);

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

        private void LoadCustomFont()
        {
        }
    }
}
