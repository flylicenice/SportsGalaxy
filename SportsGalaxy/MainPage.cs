using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class Main_Page : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        private AddEvent addEventForm;
        private eventForm EventForm;
        private JoinedEventForm joinedEventForm;
        string currentMatricNo;
        public Main_Page(string matricNo)
        {
            InitializeComponent();
            LoadCustomFont();
            currentMatricNo = matricNo;
        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            title.Font = CustomFonts.TitleFont;
            startLinkLbl.Font = CustomFonts.BodyFont;
            logOutLinkLbl.Font = CustomFonts.SmallFont;
            joinLinkLbl.Font = CustomFonts.BodyFont;
            eventJoinedLinkLbl.Font = CustomFonts.BodyFont;
            userLbl.Font = CustomFonts.BodyFont;
            contactLinkLbl.Font = CustomFonts.SmallFont;
        }


        private void logOutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {
            addEventForm = new AddEvent(currentMatricNo);
            addEventForm.TopLevel = false;
            addEventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(addEventForm);
            addEventForm.Parent = splitContainer1.Panel2;
            addEventForm.Hide();

            EventForm = new eventForm(currentMatricNo);
            EventForm.TopLevel = false;
            EventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(EventForm);
            EventForm.Parent = splitContainer1.Panel2;
            EventForm.Show();

            joinedEventForm = new JoinedEventForm(currentMatricNo);
            joinedEventForm.TopLevel = false;
            joinedEventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(joinedEventForm);
            joinedEventForm.Parent = splitContainer1.Panel2;
            joinedEventForm.Hide();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT user_name FROM [USER] WHERE matric_no = @matricNo", conn))
                {
                    conn.Open();
                    try
                    {
                        cmd.Parameters.AddWithValue("@matricNo", currentMatricNo);
                        string userName = cmd.ExecuteScalar().ToString();
                        userLbl.Text = userName;
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
        }

        private void startLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventForm.Hide();
            joinedEventForm.Hide();

            addEventForm.Show();
            addEventForm.BringToFront();
        }

        private void joinLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EventForm.refreshEvent();

            addEventForm.Hide();
            joinedEventForm.Hide();

            EventForm.Show();
            EventForm.BringToFront();
        }

        private void eventJoinedLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            joinedEventForm.refreshEvent();

            addEventForm.Hide();
            EventForm.Hide();

            joinedEventForm.Show();
            joinedEventForm.BringToFront();
        }

        private void contactLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
        }
    }
}
