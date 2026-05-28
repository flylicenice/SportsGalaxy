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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void homeBtn_MouseLeave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.White;
            homeBtn.ForeColor = Color.Black;
        }

        private void homeBtn_MouseEnter(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.Black;
            homeBtn.ForeColor = Color.White;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Gray, 0.5f))
            {
                e.Graphics.DrawLine(pen, 0, 60, this.Width, 60);
            }
        }
    }
}
