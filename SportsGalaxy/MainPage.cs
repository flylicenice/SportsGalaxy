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
        private PrivateFontCollection pfc = new PrivateFontCollection();
        public Main_Page()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        private void Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            title.Font = CustomFonts.TitleFont;
            startLinkLbl.Font = CustomFonts.BodyFont;
            logOutLinkLbl.Font = CustomFonts.SmallFont;
        }

        private void startLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEvent addEventForm = new AddEvent();
            addEventForm.TopLevel = false;
            addEventForm.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(addEventForm);
            addEventForm.Parent = splitContainer1.Panel2;
            addEventForm.Show();
        }

        private void logOutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
