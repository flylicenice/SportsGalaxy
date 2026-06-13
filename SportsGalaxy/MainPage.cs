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
        private AddEvent addEventForm;
        private eventForm eventForm;
        string currentUserID;
        public Main_Page(string userID)
        {
            InitializeComponent();
            LoadCustomFont();
            currentUserID = userID;
        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            title.Font = CustomFonts.TitleFont;
            startLinkLbl.Font = CustomFonts.BodyFont;
            logOutLinkLbl.Font = CustomFonts.SmallFont;
            joinLinkLbl.Font = CustomFonts.BodyFont;
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
            addEventForm = new AddEvent(currentUserID);
            addEventForm.TopLevel = false;
            addEventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(addEventForm);
            addEventForm.Parent = splitContainer1.Panel2;
            addEventForm.Hide();

            eventForm = new eventForm(currentUserID);
            eventForm.TopLevel = false;
            eventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(eventForm);
            eventForm.Parent = splitContainer1.Panel2;
            eventForm.Show();
        }

        private void joinLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addEventForm.Hide();
            eventForm.Show();
            eventForm.BringToFront();
        }
    }
}
