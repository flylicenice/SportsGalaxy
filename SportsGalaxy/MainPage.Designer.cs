namespace SportsGalaxy
{
    partial class Main_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.subredditTreeView = new ReaLTaiizor.Controls.ForeverTreeView();
            this.nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            this.title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.userLbl = new System.Windows.Forms.Label();
            this.contactLinkLbl = new System.Windows.Forms.LinkLabel();
            this.logOutLinkLbl = new System.Windows.Forms.LinkLabel();
            this.eventJoinedLinkLbl = new System.Windows.Forms.LinkLabel();
            this.startLinkLbl = new System.Windows.Forms.LinkLabel();
            this.joinLinkLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.nightPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(-6, 67);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.subredditTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Size = new System.Drawing.Size(1042, 535);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.contactLinkLbl);
            this.panel1.Controls.Add(this.userLbl);
            this.panel1.Controls.Add(this.welcomeLbl);
            this.panel1.Controls.Add(this.logOutLinkLbl);
            this.panel1.Controls.Add(this.eventJoinedLinkLbl);
            this.panel1.Controls.Add(this.startLinkLbl);
            this.panel1.Controls.Add(this.joinLinkLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 535);
            this.panel1.TabIndex = 1;
            // 
            // subredditTreeView
            // 
            this.subredditTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.subredditTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subredditTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subredditTreeView.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.subredditTreeView.ForeColor = System.Drawing.Color.White;
            this.subredditTreeView.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.subredditTreeView.Location = new System.Drawing.Point(0, 0);
            this.subredditTreeView.Name = "subredditTreeView";
            this.subredditTreeView.Size = new System.Drawing.Size(207, 535);
            this.subredditTreeView.TabIndex = 0;
            // 
            // nightPanel1
            // 
            this.nightPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nightPanel1.Controls.Add(this.title);
            this.nightPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightPanel1.LeftSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.nightPanel1.Location = new System.Drawing.Point(-6, -1);
            this.nightPanel1.Name = "nightPanel1";
            this.nightPanel1.RightSideColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
            this.nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left;
            this.nightPanel1.Size = new System.Drawing.Size(1042, 70);
            this.nightPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(14, 13);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(69, 13);
            this.title.TabIndex = 1;
            this.title.Text = "SportsGalaxy";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.ForeColor = System.Drawing.Color.White;
            this.welcomeLbl.Location = new System.Drawing.Point(31, 29);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(83, 13);
            this.welcomeLbl.TabIndex = 4;
            this.welcomeLbl.Text = "Welcome Back!";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Look here to see the event joined!";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.ForeColor = System.Drawing.Color.White;
            this.userLbl.Location = new System.Drawing.Point(31, 57);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(83, 13);
            this.userLbl.TabIndex = 5;
            this.userLbl.Text = "Welcome Back!";
            // 
            // contactLinkLbl
            // 
            this.contactLinkLbl.AutoSize = true;
            this.contactLinkLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.contactLinkLbl.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLinkLbl.ForeColor = System.Drawing.Color.Transparent;
            this.contactLinkLbl.Image = global::SportsGalaxy.Properties.Resources.cry;
            this.contactLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contactLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.contactLinkLbl.LinkColor = System.Drawing.Color.Wheat;
            this.contactLinkLbl.Location = new System.Drawing.Point(29, 476);
            this.contactLinkLbl.Name = "contactLinkLbl";
            this.contactLinkLbl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.contactLinkLbl.Size = new System.Drawing.Size(246, 27);
            this.contactLinkLbl.TabIndex = 6;
            this.contactLinkLbl.TabStop = true;
            this.contactLinkLbl.Text = "Any Problem? Contact Us";
            this.contactLinkLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip3.SetToolTip(this.contactLinkLbl, "Start an event to let othet users join!");
            this.contactLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.contactLinkLbl_LinkClicked);
            // 
            // logOutLinkLbl
            // 
            this.logOutLinkLbl.AutoSize = true;
            this.logOutLinkLbl.BackColor = System.Drawing.Color.Transparent;
            this.logOutLinkLbl.Image = global::SportsGalaxy.Properties.Resources.arrow_right;
            this.logOutLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.logOutLinkLbl.LinkColor = System.Drawing.Color.White;
            this.logOutLinkLbl.Location = new System.Drawing.Point(31, 376);
            this.logOutLinkLbl.Name = "logOutLinkLbl";
            this.logOutLinkLbl.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.logOutLinkLbl.Size = new System.Drawing.Size(70, 13);
            this.logOutLinkLbl.TabIndex = 0;
            this.logOutLinkLbl.TabStop = true;
            this.logOutLinkLbl.Text = "Log Out";
            this.logOutLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutLinkLbl_LinkClicked);
            // 
            // eventJoinedLinkLbl
            // 
            this.eventJoinedLinkLbl.AutoSize = true;
            this.eventJoinedLinkLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.eventJoinedLinkLbl.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventJoinedLinkLbl.ForeColor = System.Drawing.Color.Transparent;
            this.eventJoinedLinkLbl.Image = global::SportsGalaxy.Properties.Resources.smug;
            this.eventJoinedLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eventJoinedLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.eventJoinedLinkLbl.LinkColor = System.Drawing.Color.Wheat;
            this.eventJoinedLinkLbl.Location = new System.Drawing.Point(29, 294);
            this.eventJoinedLinkLbl.Name = "eventJoinedLinkLbl";
            this.eventJoinedLinkLbl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.eventJoinedLinkLbl.Size = new System.Drawing.Size(138, 27);
            this.eventJoinedLinkLbl.TabIndex = 3;
            this.eventJoinedLinkLbl.TabStop = true;
            this.eventJoinedLinkLbl.Text = "Event Joined";
            this.eventJoinedLinkLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip3.SetToolTip(this.eventJoinedLinkLbl, "View the event you joined!");
            this.eventJoinedLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // startLinkLbl
            // 
            this.startLinkLbl.AutoSize = true;
            this.startLinkLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.startLinkLbl.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLinkLbl.ForeColor = System.Drawing.Color.Transparent;
            this.startLinkLbl.Image = global::SportsGalaxy.Properties.Resources.angry;
            this.startLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.startLinkLbl.LinkColor = System.Drawing.Color.Wheat;
            this.startLinkLbl.Location = new System.Drawing.Point(29, 144);
            this.startLinkLbl.Name = "startLinkLbl";
            this.startLinkLbl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.startLinkLbl.Size = new System.Drawing.Size(149, 27);
            this.startLinkLbl.TabIndex = 1;
            this.startLinkLbl.TabStop = true;
            this.startLinkLbl.Text = "Start an Event";
            this.startLinkLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip3.SetToolTip(this.startLinkLbl, "Start an event to let othet users join!");
            this.startLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startLinkLbl_LinkClicked);
            // 
            // joinLinkLbl
            // 
            this.joinLinkLbl.AutoSize = true;
            this.joinLinkLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.joinLinkLbl.Font = new System.Drawing.Font("Microsoft Himalaya", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLinkLbl.ForeColor = System.Drawing.Color.Transparent;
            this.joinLinkLbl.Image = global::SportsGalaxy.Properties.Resources.calendar;
            this.joinLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.joinLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.joinLinkLbl.LinkColor = System.Drawing.Color.Wheat;
            this.joinLinkLbl.Location = new System.Drawing.Point(29, 218);
            this.joinLinkLbl.Name = "joinLinkLbl";
            this.joinLinkLbl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.joinLinkLbl.Size = new System.Drawing.Size(144, 27);
            this.joinLinkLbl.TabIndex = 2;
            this.joinLinkLbl.TabStop = true;
            this.joinLinkLbl.Text = "Join an Event";
            this.joinLinkLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.joinLinkLbl, "Join event held by other users!");
            this.joinLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.joinLinkLbl_LinkClicked);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.nightPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nightPanel1.ResumeLayout(false);
            this.nightPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.ForeverTreeView subredditTreeView;
        private System.Windows.Forms.LinkLabel startLinkLbl;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private System.Windows.Forms.LinkLabel logOutLinkLbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.LinkLabel joinLinkLbl;
        private System.Windows.Forms.LinkLabel eventJoinedLinkLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.LinkLabel contactLinkLbl;
    }
}