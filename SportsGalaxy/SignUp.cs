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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class SignUp : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString2 = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        
        public SignUp()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        private void closeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            // Check empty fields
            if (string.IsNullOrWhiteSpace(userNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(emailTxtBox.Text) ||
                string.IsNullOrWhiteSpace(matricNoTxtBox.Text) ||
                string.IsNullOrWhiteSpace(passwordTxtBox.Text) ||
                string.IsNullOrWhiteSpace(confirmPassTxtBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            string insertQuery = "INSERT INTO [User] (matric_no, user_name, password, email) VALUES (@matric_no, @user_name, @password, @email)";

            if (passwordTxtBox.Text != confirmPassTxtBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxtBox.Text = "";
                confirmPassTxtBox.Text = "";
                return;
            } else if (errorLbl.Visible == true)
            {
                MessageBox.Show("Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            //Initialize connection and command 
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                { 
                    command.Parameters.AddWithValue("@user_name", userNameTxtBox.Text);
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(passwordTxtBox.Text));
                    command.Parameters.AddWithValue("@email", emailTxtBox.Text);
                    command.Parameters.AddWithValue("@matric_no", matricNoTxtBox.Text);
                    
                    try
                    {
                        connection.Open();

                        int insertedRow = command.ExecuteNonQuery();

                        if (insertedRow > 0)
                        {
                            MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearForm();
                            connection.Close();
                        }

                        this.Close();

                    } catch (Exception ex)
                    {
                        MessageBox.Show("There was an error creating your account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void clearForm()
        {
            userNameTxtBox.Text = "";
            passwordTxtBox.Text = "";
            confirmPassTxtBox.Text = "";
            emailTxtBox.Text = "";
            matricNoTxtBox.Text = "";
        }

        private void passwordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            //Password creation requirement for user
            string password = passwordTxtBox.Text;

            if (string.IsNullOrEmpty(password))
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTxtBox, "Password is required");
            }
            else if (password.Length < 8 ) //Check passsword length, let user insert at least 8 characters 
            {
                e.Cancel = true;
                errorProvider1.SetError(passwordTxtBox, "Password must be at least 8 characters long.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTxtBox, "");
            }

        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            lblUsername.Font = CustomFonts.BodyFont;
            lblSignUp.Font = CustomFonts.TitleFont;
            lblEmail.Font = CustomFonts.BodyFont;
            lblMatricNumber.Font = CustomFonts.BodyFont;
            lblConfirmPassword.Font = CustomFonts.BodyFont;
            lblPassword.Font = CustomFonts.BodyFont;
            errorLbl.Font = CustomFonts.BodyFont;
            userNameTxtBox.Font = CustomFonts.SmallFont;
            emailTxtBox.Font = CustomFonts.SmallFont;
            matricNoTxtBox.Font = CustomFonts.SmallFont;
            signUpBtn.Font = CustomFonts.BodyFont;
            cancelLinkLbl.Font = CustomFonts.SmallFont;
        }

        private void userNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE user_name = @user_name", connection))
                {
                    command.Parameters.AddWithValue("@user_name", userNameTxtBox.Text);

                    try
                    {
                        connection.Open();
                        userCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error checking the username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (string.IsNullOrEmpty(userNameTxtBox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(userNameTxtBox, "Username is required.");
            }
            else if (userCount > 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(userNameTxtBox, "Username is already taken. Please choose another.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(userNameTxtBox, "");
            }
        }

        private void emailTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", emailTxtBox.Text);

                    try
                    {
                        connection.Open();
                        userCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error checking the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (string.IsNullOrEmpty(emailTxtBox.Text))
            {
                e.Cancel = true;
                errorProvider3.SetError(emailTxtBox, "Email is required.");
            }
            else if (userCount > 0)
            {
                e.Cancel = true;
                errorProvider3.SetError(emailTxtBox, "Email is already registered. Please use another.");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(emailTxtBox, "");
            }
        }

        private void matricNoTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString2))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE matric_no = @matricNo", connection))
                {
                    command.Parameters.AddWithValue("@matricNo", matricNoTxtBox.Text);

                    try
                    {
                        connection.Open();
                        userCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error checking the matric number: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (string.IsNullOrEmpty(matricNoTxtBox.Text))
            {
                e.Cancel = true;
                errorProvider4.SetError(matricNoTxtBox, "Matric number is required.");
            }
            else if (userCount > 0)
            {
                e.Cancel = true;
                errorProvider4.SetError(matricNoTxtBox, "Matric number is already registered. Please use another.");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(matricNoTxtBox, "");
            }
        }
    }
}
