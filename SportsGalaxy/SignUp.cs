using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace SportsGalaxy
{
    public partial class SignUp : Form
    {
        private string connectionStringSql = @"Server=localhost;Database=sports_galaxy;Uid=root;Pwd=12345678;";
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\oknev\source\repos\SportsGalaxy\SportsGalaxy\Database.mdf;Integrated Security=True";
        string userID = Guid.NewGuid().ToString();
        public SignUp()
        {
            InitializeComponent();
        }

        private void closeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO user (user_id, user_name, password, email, created_at, phone_number, full_name, gender, matric_no) VALUES (@user_id, @user_name, @password, @email, @created_at, @phone_number, @full_name, @gender, @matric_no)";

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
            using (MySqlConnection connection = new MySqlConnection(connectionStringSql))
            {
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
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

        private void userNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionStringSql))
            {
                using (MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM user WHERE user_name = @user_name", connection))
                {
                    command.Parameters.AddWithValue("@user_name", userNameTxtBox.Text);

                    try
                    {
                        connection.Open();
                        long userCount = (long)command.ExecuteScalar();
                        if (userCount > 0)
                        {
                            errorLbl.Text = "Username is already taken. Please choose another.";
                            errorLbl.Visible = true;
                        }
                        else if (userNameTxtBox.Text.Length > 20)
                        {
                            errorLbl.Text = "Username cannot exceed 20 characters.";
                            errorLbl.Visible = true;
                        } else
                        {
                            errorLbl.Visible = false;
                        }

                    } catch (Exception ex)
                    {
                        MessageBox.Show("There was an error checking the username: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (fullNameTxtBox.Text.Length > 50)
            {
                errorLbl.Text = "Full name cannot exceed 50 characters.";
                errorLbl.Visible = true;
            }
        }
    }
}
