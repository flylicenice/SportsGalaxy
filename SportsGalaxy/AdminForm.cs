using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsGalaxy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventAdmin formEventAdmin = new EventAdmin();
            formEventAdmin.MdiParent = this;
            formEventAdmin.Dock = DockStyle.Fill;
            formEventAdmin.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminAdd formAddAdmin = new AdminAdd();
            formAddAdmin.MdiParent = this;
            formAddAdmin.Dock = DockStyle.Fill;
            formAddAdmin.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
