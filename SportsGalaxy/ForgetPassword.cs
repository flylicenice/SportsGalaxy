using Org.BouncyCastle.Asn1.Pkcs;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportsGalaxy
{
    public partial class ForgetPassword : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        PrivateFontCollection pfc = new PrivateFontCollection();
        private string connectionStringSql = @"Server=localhost;Database=sports_galaxy;Uid=root;Pwd=12345678;";
        public ForgetPassword()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        private void backLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetPassword resetPasswordForm = new ResetPassword(emailTxtBox.Text);

            if (emailTxtBox.Text.Length > 0)
            {
                this.Hide();
                resetPasswordForm.ShowDialog();
                this.Show();
            } else { 
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomFont()
        {
            pfc.AddFontFile(@"Fonts\PixelifySans-Regular.ttf");
            pfc.AddFontFile(@"Fonts\PixelifySans-Bold.ttf");

            // Apply to your controls
            label1.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            label2.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            emailTxtBox.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            resetBtn.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            backLinkLbl.Font = new Font(pfc.Families[0], 8, FontStyle.Bold);
        }

        private void emailTxtBox_Validating(object sender, CancelEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", emailTxtBox.Text);
                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Email not found. Please enter a registered email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            e.Cancel = true; // Prevents the control from losing focus
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while validating the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true; // Prevents the control from losing focus
                    }
                }
            }
        }
    }
}
