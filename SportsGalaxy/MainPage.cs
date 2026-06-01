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
        private string connectionStringSql = @"Server=localhost;Database=sports_galaxy;Uid=root;Pwd=12345678;";
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
            pfc.AddFontFile(@"Fonts\PixelifySans-Regular.ttf");
            pfc.AddFontFile(@"Fonts\PixelifySans-Bold.ttf");

            // Apply to your controls
            title.Font = new Font(pfc.Families[0], 24, FontStyle.Bold);
            startLinkLbl.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            logOutLinkLbl.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
        }

        private void startLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void logOutLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
