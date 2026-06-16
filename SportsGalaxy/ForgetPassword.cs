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
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
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
            label1.Font = CustomFonts.TitleFont;
            label2.Font = CustomFonts.BodyFont;
            emailTxtBox.Font = CustomFonts.SmallFont;
            resetBtn.Font = CustomFonts.SmallFont;
            backLinkLbl.Font = CustomFonts.SmallFont;
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
