using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SportsGalaxy
{
    public partial class ResetPassword : Form
    {
        private string email;
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        PrivateFontCollection pfc = new PrivateFontCollection();
        public ResetPassword(string email)
        {
            InitializeComponent();
            LoadCustomFont();
            this.email = email;
        }

        private void LoadCustomFont()
        {
            pfc.AddFontFile(@"Fonts\PixelifySans-Regular.ttf");
            pfc.AddFontFile(@"Fonts\PixelifySans-Bold.ttf");

            // Apply to your controls
            lblResetPassword.Font = new Font(pfc.Families[0], 20, FontStyle.Bold);
            lblNewPassword.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblHi.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            newPasswdTxtBox.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            closeLinkLbl.Font = new Font(pfc.Families[0], 8, FontStyle.Bold);
            resetBtn.Font = new Font(pfc.Families[0], 8, FontStyle.Bold);
        }

        private void closeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT user_name FROM [USER] WHERE email = @Email";
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", this.email);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string userName = result.ToString();
                        lblHi.Text += " " + userName;
                    }
                    else
                    {
                        MessageBox.Show("Email not found. Please check your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE [User] SET password = @Password WHERE email = @Email";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    if (string.IsNullOrWhiteSpace(newPasswdTxtBox.Text))
                    {
                        MessageBox.Show("Please enter a new password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cmd.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(newPasswdTxtBox.Text));
                    cmd.Parameters.AddWithValue("@Email", this.email);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password reset successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error resetting password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
