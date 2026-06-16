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
    public partial class AdminAdd : Form
    {
        private static string projectRootFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        private string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={System.IO.Path.Combine(projectRootFolder, "Database.mdf")};Integrated Security=True;";
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsGalaxyDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.sportsGalaxyDataSet.Admin);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string adminId = IDTxtBox.Text.Trim();
            string plainPassword = passwordTxtBox.Text;

            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(plainPassword))
            {
                MessageBox.Show("Please fill in both Admin ID and Password.", "Error");
                return;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(plainPassword);

            string insertQuery = "INSERT INTO [Admin] (AdminID, Password) VALUES (@AdminId, @Password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminId", adminId);
                    cmd.Parameters.AddWithValue("@Password", passwordHash);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Admin registered successfully!", "Success");

                        refreshDGV();

                        IDTxtBox.Clear();
                        passwordTxtBox.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Registration failed: " + ex.Message, "Error");
                    }
                }
            }
        }

        private void refreshDGV()
        {
            string query = "SELECT * FROM [ADMIN]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    adminDGV.DataSource = dt;
                }
            }
        }
    }
}
