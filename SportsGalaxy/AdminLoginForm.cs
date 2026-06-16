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

namespace SportsGalaxy
{
    public partial class AdminLoginForm : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDTxtBox.Text.Trim()) || string.IsNullOrEmpty(passwordTxtBox.Text))
            {
                MessageBox.Show("Please fill in both Admin ID and Password.", "Validation Error");
                return;
            }

            string loginQuery = "SELECT [password] FROM [Admin] WHERE [AdminId] = @AdminId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(loginQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminId", IDTxtBox.Text.Trim());

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                string storedHash = reader["password"].ToString();

                                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(passwordTxtBox.Text, storedHash);

                                if (isPasswordCorrect)
                                {
                                    MessageBox.Show("Login Successful!\nWelcome back, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Hide();

                                    AdminForm adminForm = new AdminForm();
                                    adminForm.ShowDialog();

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid Admin ID or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Admin ID or Password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An operational error occurred: " + ex.Message, "Database Error");
                    }
                }
            }
        }
    }
}
