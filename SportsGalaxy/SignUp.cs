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
        PrivateFontCollection pfc = new PrivateFontCollection();
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
        string userID = Guid.NewGuid().ToString();
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
            string insertQuery = "INSERT INTO [User] (user_id, user_name, password, email, created_at, phone_number, full_name, gender, matric_no) VALUES (@user_id, @user_name, @password, @email, @created_at, @phone_number, @full_name, @gender, @matric_no)";

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                { 
                    command.Parameters.AddWithValue("@user_id", userID);
                    command.Parameters.AddWithValue("@user_name", userNameTxtBox.Text);
                    command.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(passwordTxtBox.Text));
                    command.Parameters.AddWithValue("@email", emailTxtBox.Text);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);
                    command.Parameters.AddWithValue("@phone_number", phoneNoTextBox.Text);
                    command.Parameters.AddWithValue("@full_name", fullNameTxtBox.Text);
                    command.Parameters.AddWithValue("@gender", genderComboBox.SelectedItem?.ToString() ?? "Not Specified");
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
            phoneNoTextBox.Text = "";
            fullNameTxtBox.Text = "";
            genderComboBox.SelectedIndex = -1;
            matricNoTxtBox.Text = "";
        }

        private void LoadCustomFont()
        {
            // Apply to your controls
            skyLabel1.Font = CustomFonts.BodyFont;
            skyLabel2.Font = CustomFonts.BodyFont;
            skyLabel3.Font = CustomFonts.TitleFont;
            skyLabel4.Font = CustomFonts.BodyFont;
            skyLabel5.Font = CustomFonts.BodyFont;
            skyLabel6.Font = CustomFonts.BodyFont;
            skyLabel7.Font = CustomFonts.BodyFont;
            skyLabel8.Font = CustomFonts.BodyFont;
            skyLabel9.Font = CustomFonts.BodyFont;
            errorLbl.Font = CustomFonts.BodyFont;
            userNameTxtBox.Font = CustomFonts.SmallFont;
            fullNameTxtBox.Font = CustomFonts.SmallFont;
            emailTxtBox.Font = CustomFonts.SmallFont;
            phoneNoTextBox.Font = CustomFonts.SmallFont;
            matricNoTxtBox.Font = CustomFonts.SmallFont;
            genderComboBox.Font = CustomFonts.SmallFont;
            signUpBtn.Font = CustomFonts.BodyFont;
            cancelLinkLbl.Font = CustomFonts.SmallFont;
        }

        private void userNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void fullNameTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(fullNameTxtBox.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(fullNameTxtBox, "Full name is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(fullNameTxtBox, "");
            }
        }

        private void emailTxtBox_Validating(object sender, CancelEventArgs e)
        {
            int userCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        private void phoneNoTxtBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNoTextBox.Text))
            {
                e.Cancel = true;
                errorProvider5.SetError(phoneNoTextBox, "Phone number is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(phoneNoTextBox, "");
            }
        }

        private void userNameTxtBox_Click(object sender, EventArgs e)
        {

        }
    }
}
