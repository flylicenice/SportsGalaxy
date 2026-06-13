using Microsoft.Extensions.Logging;
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
    public partial class EventBlock : UserControl
    {
        private string userid;

        public EventBlock(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            loadCustomFont();
        }

        public void FillData(string name, string location, string date, string time, int current, int max)
        {
            nameLbl.Text = name;
            locationLbl.Text = location;
            dateLbl.Text = date;
            timeLbl.Text = time;
            maxLabel.Text = $"Slots: {current} / {max}";

            if (current >= max)
            {
                joinBtn.Text = "Full";
                joinBtn.Enabled = false;
            }
            choosePic(location);
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            JoinEvent joinForm = new JoinEvent(userid);
            joinForm.ShowDialog();
        }

        private void loadCustomFont()
        {
            nameLbl.Font = CustomFonts.SmallFont;
            locationLbl.Font = CustomFonts.SmallFont;
            dateLbl.Font = CustomFonts.SmallFont;
            timeLbl.Font = CustomFonts.SmallFont;
            maxLabel.Font = CustomFonts.SmallFont;
        }

        private void choosePic(string location)
        { 
            if (location == "Gym")
            {
                pictureBox.Image = Properties.Resources.football;
            }
            else if (location == "Football Field")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Basketball Court")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Badminton Court")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Netball Court")
            {
                pictureBox.Image = Properties.Resources.football;
            }
        }
    }
}
