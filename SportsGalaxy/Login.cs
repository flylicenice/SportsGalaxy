using BCrypt.Net;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class Login : Form
    {
        PrivateFontCollection pfc = new PrivateFontCollection();
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.ShowDialog();
        }

        private void closeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void emailTxtBox_textChanged(object sender, EventArgs e)
        {
            if (userNameTxtBox.Text == "")
            {
                userNameTxtBox.Text = "UTeM Email";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM [User] WHERE user_name = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", userNameTxtBox.Text);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string storedHash = reader["password"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(passwordTxtBox.Text, storedHash))
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Main_Page main = new Main_Page(reader["matric_no"].ToString());
                                this.Hide();
                                main.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void passwordTxtBox_Enter(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text == "Password")
            {
                passwordTxtBox.Text = "";
                passwordTxtBox.UseSystemPasswordChar = true;
            }
        }

        private void passwordTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxtBox.Text))
            {
                passwordTxtBox.UseSystemPasswordChar = false;
                passwordTxtBox.Text = "Password";
            }
        }

        private void userNameTxtBox_Enter(object sender, EventArgs e)
        {
            if (userNameTxtBox.Text == "Username")
            {
                userNameTxtBox.Text = "";
            }
        }

        private void userNameTxtBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTxtBox.Text))
            {
                userNameTxtBox.Text = "Username";
            }
        }

        private void forgotPasswdLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPasswordForm = new ForgetPassword();
            forgetPasswordForm.ShowDialog();
        }

        private void LoadCustomFont()
        {
            pfc.AddFontFile(@"Fonts\PixelifySans-Regular.ttf");
            pfc.AddFontFile(@"Fonts\PixelifySans-Bold.ttf");

            // Apply to your controls
            userNameTxtBox.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            passwordTxtBox.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            loginBtn.Font = new Font(pfc.Families[0], 12, FontStyle.Bold);
            skyLabel1.Font = new Font(pfc.Families[0], 48, FontStyle.Bold);
            signUpLink.Font = new Font(pfc.Families[0], 9, FontStyle.Bold);
            forgotPasswdLink.Font = new Font(pfc.Families[0], 9, FontStyle.Bold);
            closeLinkLbl.Font = new Font(pfc.Families[0], 9, FontStyle.Bold);
        }

        private void adminLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            this.Hide();
            adminLoginForm.ShowDialog();
            this.Show();
        }
    }
}
