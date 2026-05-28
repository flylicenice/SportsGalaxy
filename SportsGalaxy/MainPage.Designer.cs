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
            this.extendedPanel1 = new ReaLTaiizor.Controls.ExtendedPanel();
            this.extendedPanel2 = new ReaLTaiizor.Controls.ExtendedPanel();
            this.SuspendLayout();
            // 
            // extendedPanel1
            // 
            this.extendedPanel1.BackColor = System.Drawing.Color.Transparent;
            this.extendedPanel1.DrawMode = ReaLTaiizor.Controls.ExtendedPanel.Drawer.Default;
            this.extendedPanel1.Location = new System.Drawing.Point(-1, 9);
            this.extendedPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.extendedPanel1.MostInterval = 100;
            this.extendedPanel1.Name = "extendedPanel1";
            this.extendedPanel1.Opacity = 50;
            this.extendedPanel1.Size = new System.Drawing.Size(1033, 100);
            this.extendedPanel1.TabIndex = 2;
            this.extendedPanel1.TopMost = true;
            // 
            // extendedPanel2
            // 
            this.extendedPanel2.BackColor = System.Drawing.Color.Transparent;
            this.extendedPanel2.DrawMode = ReaLTaiizor.Controls.ExtendedPanel.Drawer.Default;
            this.extendedPanel2.Location = new System.Drawing.Point(-1, 109);
            this.extendedPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.extendedPanel2.MostInterval = 100;
            this.extendedPanel2.Name = "extendedPanel2";
            this.extendedPanel2.Opacity = 50;
            this.extendedPanel2.Size = new System.Drawing.Size(176, 480);
            this.extendedPanel2.TabIndex = 3;
            this.extendedPanel2.TopMost = true;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 590);
            this.Controls.Add(this.extendedPanel2);
            this.Controls.Add(this.extendedPanel1);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ExtendedPanel extendedPanel1;
        private ReaLTaiizor.Controls.ExtendedPanel extendedPanel2;
    }
}