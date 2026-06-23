namespace SportsGalaxy
{
    partial class ResetPassword
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
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.newPasswdTxtBox = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.closeLinkLbl = new System.Windows.Forms.LinkLabel();
            this.lblHi = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Location = new System.Drawing.Point(69, 22);
            this.lblResetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(106, 16);
            this.lblResetPassword.TabIndex = 0;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblNewPassword);
            this.flowLayoutPanel1.Controls.Add(this.newPasswdTxtBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 123);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(195, 63);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(4, 0);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(97, 16);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New Password";
            // 
            // newPasswdTxtBox
            // 
            this.newPasswdTxtBox.Location = new System.Drawing.Point(4, 20);
            this.newPasswdTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswdTxtBox.Name = "newPasswdTxtBox";
            this.newPasswdTxtBox.Size = new System.Drawing.Size(167, 22);
            this.newPasswdTxtBox.TabIndex = 1;
            // 
            // resetBtn
            // 
            this.resetBtn.Image = global::SportsGalaxy.Properties.Resources.undo;
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetBtn.Location = new System.Drawing.Point(171, 193);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.resetBtn.Size = new System.Drawing.Size(119, 43);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // closeLinkLbl
            // 
            this.closeLinkLbl.AutoSize = true;
            this.closeLinkLbl.Location = new System.Drawing.Point(207, 257);
            this.closeLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeLinkLbl.Name = "closeLinkLbl";
            this.closeLinkLbl.Size = new System.Drawing.Size(42, 16);
            this.closeLinkLbl.TabIndex = 3;
            this.closeLinkLbl.TabStop = true;
            this.closeLinkLbl.Text = "Close";
            this.closeLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLinkLbl_LinkClicked);
            // 
            // lblHi
            // 
            this.lblHi.AutoSize = true;
            this.lblHi.Location = new System.Drawing.Point(133, 91);
            this.lblHi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHi.Name = "lblHi";
            this.lblHi.Size = new System.Drawing.Size(26, 16);
            this.lblHi.TabIndex = 4;
            this.lblHi.Text = "Hi! ";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 304);
            this.Controls.Add(this.lblHi);
            this.Controls.Add(this.closeLinkLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblResetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassword";
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResetPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox newPasswdTxtBox;
        private System.Windows.Forms.LinkLabel closeLinkLbl;
        private System.Windows.Forms.Label lblHi;
    }
}