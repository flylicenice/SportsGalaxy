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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.startLinkLbl = new System.Windows.Forms.LinkLabel();
            this.subredditTreeView = new ReaLTaiizor.Controls.ForeverTreeView();
            this.nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            this.title = new System.Windows.Forms.Label();
            this.logOutLinkLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.splitContainer2.Panel1.Controls.Add(this.startLinkLbl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.splitContainer2.Size = new System.Drawing.Size(207, 535);
            this.splitContainer2.SplitterDistance = 267;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 2;
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
            this.startLinkLbl.Location = new System.Drawing.Point(33, 18);
            this.startLinkLbl.Name = "startLinkLbl";
            this.startLinkLbl.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.startLinkLbl.Size = new System.Drawing.Size(149, 27);
            this.startLinkLbl.TabIndex = 1;
            this.startLinkLbl.TabStop = true;
            this.startLinkLbl.Text = "Start an Event";
            this.startLinkLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.startLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startLinkLbl_LinkClicked);
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
            this.nightPanel1.Controls.Add(this.logOutLinkLbl);
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
            // logOutLinkLbl
            // 
            this.logOutLinkLbl.AutoSize = true;
            this.logOutLinkLbl.BackColor = System.Drawing.Color.Transparent;
            this.logOutLinkLbl.Image = global::SportsGalaxy.Properties.Resources.arrow_right;
            this.logOutLinkLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutLinkLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.logOutLinkLbl.LinkColor = System.Drawing.Color.White;
            this.logOutLinkLbl.Location = new System.Drawing.Point(931, 22);
            this.logOutLinkLbl.Name = "logOutLinkLbl";
            this.logOutLinkLbl.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.logOutLinkLbl.Size = new System.Drawing.Size(70, 13);
            this.logOutLinkLbl.TabIndex = 0;
            this.logOutLinkLbl.TabStop = true;
            this.logOutLinkLbl.Text = "Log Out";
            this.logOutLinkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logOutLinkLbl_LinkClicked);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.nightPanel1);
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.nightPanel1.ResumeLayout(false);
            this.nightPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ReaLTaiizor.Controls.ForeverTreeView subredditTreeView;
        private System.Windows.Forms.LinkLabel startLinkLbl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private System.Windows.Forms.LinkLabel logOutLinkLbl;
        private System.Windows.Forms.Label title;
    }
}