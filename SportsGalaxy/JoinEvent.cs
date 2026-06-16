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
using System.Transactions;
using System.Windows.Forms;
using System.Xml.XPath;
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.ForeColor;

namespace SportsGalaxy
{
    public partial class JoinEvent : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        string currentMatricNo;
        int eventId;
        
        public JoinEvent(string matricNo, int eventId, string eventName, string eventDate, string eventTime, string eventDesc, string location, int currentAtt, int maxAtt)
        {
            InitializeComponent();
            LoadCustomFont();
            this.eventId = eventId;
            currentMatricNo = matricNo;
            nameLbl.Text = eventName;
            eventTxtBox.Text = eventDesc;
            dateTxtBox.Text = eventDate;
            timeTxtBox.Text = eventTime;
            locationTxtBox.Text = location;
            currentLbl.Text = currentAtt.ToString();
            maxLbl.Text = maxAtt.ToString();
        }
    

        private void LoadCustomFont()
        {
            nameLbl.Font = CustomFonts.TitleFont;
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to register for this sports event?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO [JOIN_EVENTS] (EventId, matric_no) VALUES (@EventID, @matric_no)", conn))
                    {
                        conn.Open();
                        try
                        {
                            int eventId = this.eventId;
                            cmd.Parameters.AddWithValue("@EventId", eventId);
                            cmd.Parameters.AddWithValue("@matric_no", currentMatricNo);
                            int insertedRow = cmd.ExecuteNonQuery();

                            if (insertedRow > 0)
                            {
                                MessageBox.Show("Join Successfully!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("You have already joined the event.");
                        }
                    }
                }
            }
        }
    }
}
