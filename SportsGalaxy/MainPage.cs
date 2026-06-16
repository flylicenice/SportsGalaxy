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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        private AddEvent addEventForm;
        private eventForm eventForm;
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

        private void startLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            eventForm.Hide();
            addEventForm.Show();
            addEventForm.BringToFront();
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

            eventForm = new eventForm(currentMatricNo);
            eventForm.TopLevel = false;
            eventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(eventForm);
            eventForm.Parent = splitContainer1.Panel2;
            eventForm.Show();

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

        private void joinLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            eventForm.refreshEvent();
            addEventForm.Hide();
            eventForm.Show();
            eventForm.BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            joinedEventForm.refreshEvent();
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
