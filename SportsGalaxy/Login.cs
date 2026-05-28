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
    public partial class Login : Form
    {
        private string connectionStringSql = @"Server=localhost;Database=sports_galaxy;Uid=root;Pwd=12345678;";
        public Login()
        {
            InitializeComponent();
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
            string selectQuery = "SELECT * FROM user WHERE user_name = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionStringSql))
            {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", userNameTxtBox.Text);
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string storedHash = reader["password"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(passwordTxtBox.Text, storedHash))
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Main_Page main = new Main_Page();
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

        private void passwordTxtBox_Click(object sender, EventArgs e)
        {
            passwordTxtBox.Text = "";
            passwordTxtBox.UseSystemPasswordChar = true;
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
    }
}
