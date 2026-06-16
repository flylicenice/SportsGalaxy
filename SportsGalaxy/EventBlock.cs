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
        string eventName, location, eventDate, eventTime, eventDesc;
        int current, max, eventid;
        private string userid;

        public EventBlock(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            loadCustomFont();
        }

        public void FillData(string name, int eventid, string location, string date, string time, string desc, int current, int max)
        {
            nameLbl.Text = name;
            locationLbl.Text = location;
            dateLbl.Text = date;
            timeLbl.Text = time;
            maxLabel.Text = $"Slots: {current} / {max}";

            this.eventid = eventid;  eventName = name; this.location = location; eventDate = date; eventTime = time; this.eventDesc = desc; this.current = current; this.max = max;

            if (current >= max)
            {
                joinBtn.Text = "Full";
                joinBtn.Enabled = false;
            }
            choosePic(location);
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            JoinEvent joinForm = new JoinEvent(userid, eventid, eventName, eventDate, eventTime, eventDesc, location, current, max);
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
                pictureBox.Image = Properties.Resources.dumbell;
            }
            else if (location == "Football Field")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Basketball Court")
            {
                pictureBox.Image = Properties.Resources.basketball;
            } else if (location == "Badminton Court")
            {
                pictureBox.Image = Properties.Resources.football;
            } else if (location == "Netball Court")
            {
                pictureBox.Image = Properties.Resources.football;
            }
        }

        public void disableJoinBtn()
        {
            joinBtn.Enabled = false;
            joinBtn.Text = "Full";
        }
    }
}
