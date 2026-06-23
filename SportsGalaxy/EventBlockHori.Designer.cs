namespace SportsGalaxy
{
    partial class EventBlockHori
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pcBxLocation = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.locationLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.ticketBtn = new ReaLTaiizor.Controls.MoonButton();
            this.cancelBtn = new ReaLTaiizor.Controls.MoonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBxLocation
            // 
            this.pcBxLocation.Image = global::SportsGalaxy.Properties.Resources.starry;
            this.pcBxLocation.Location = new System.Drawing.Point(17, 15);
            this.pcBxLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcBxLocation.Name = "pcBxLocation";
            this.pcBxLocation.Size = new System.Drawing.Size(64, 59);
            this.pcBxLocation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBxLocation.TabIndex = 0;
            this.pcBxLocation.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(108, 15);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(127, 28);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Event Name";
            // 
            // locationLbl
            // 
            this.locationLbl.AutoSize = true;
            this.locationLbl.Location = new System.Drawing.Point(109, 48);
            this.locationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLbl.Name = "locationLbl";
            this.locationLbl.Size = new System.Drawing.Size(58, 16);
            this.locationLbl.TabIndex = 2;
            this.locationLbl.Text = "Location";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(109, 76);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(73, 16);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Event Date";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(109, 103);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(75, 16);
            this.timeLbl.TabIndex = 4;
            this.timeLbl.Text = "Event Time";
            // 
            // ticketBtn
            // 
            this.ticketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketBtn.Customization = "/////9PT0//w8PD/gICA/w==";
            this.ticketBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ticketBtn.Image = null;
            this.ticketBtn.Location = new System.Drawing.Point(337, 48);
            this.ticketBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ticketBtn.Name = "ticketBtn";
            this.ticketBtn.NoRounding = false;
            this.ticketBtn.Size = new System.Drawing.Size(127, 32);
            this.ticketBtn.TabIndex = 5;
            this.ticketBtn.Text = "Ticket";
            this.ticketBtn.Transparent = false;
            this.ticketBtn.Click += new System.EventHandler(this.ticketBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Customization = "/////9PT0//w8PD/gICA/w==";
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelBtn.Image = null;
            this.cancelBtn.Location = new System.Drawing.Point(337, 85);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.NoRounding = false;
            this.cancelBtn.Size = new System.Drawing.Size(127, 32);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.Transparent = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // EventBlockHori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.ticketBtn);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.locationLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pcBxLocation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventBlockHori";
            this.Size = new System.Drawing.Size(479, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pcBxLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBxLocation;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label locationLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label timeLbl;
        private ReaLTaiizor.Controls.MoonButton ticketBtn;
        private ReaLTaiizor.Controls.MoonButton cancelBtn;
    }
}
