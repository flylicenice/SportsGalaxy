namespace SportsGalaxy
{
    partial class AdminAdd
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
            this.adminDGV = new System.Windows.Forms.DataGridView();
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsGalaxyDataSet = new SportsGalaxy.SportsGalaxyDataSet();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.adminTableAdapter1 = new SportsGalaxy.SportsGalaxyDataSetTableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDGV
            // 
            this.adminDGV.AutoGenerateColumns = false;
            this.adminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIdDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.adminDGV.DataSource = this.adminBindingSource1;
            this.adminDGV.Location = new System.Drawing.Point(16, 15);
            this.adminDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.RowHeadersWidth = 51;
            this.adminDGV.Size = new System.Drawing.Size(376, 242);
            this.adminDGV.TabIndex = 0;
            this.adminDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminDGV_CellClick);
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            this.adminIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            this.adminBindingSource1.DataSource = this.sportsGalaxyDataSet;
            // 
            // sportsGalaxyDataSet
            // 
            this.sportsGalaxyDataSet.DataSetName = "SportsGalaxyDataSet";
            this.sportsGalaxyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Location = new System.Drawing.Point(16, 276);
            this.lblAdminID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(61, 16);
            this.lblAdminID.TabIndex = 9;
            this.lblAdminID.Text = "Admin ID";
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(140, 272);
            this.IDTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(251, 22);
            this.IDTxtBox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.Location = new System.Drawing.Point(16, 366);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(160, 49);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 318);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(140, 314);
            this.passwordTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(251, 22);
            this.passwordTxtBox.TabIndex = 14;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.Location = new System.Drawing.Point(232, 366);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 49);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 465);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.adminDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAdd";
            this.Load += new System.EventHandler(this.AdminAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.TextBox IDTxtBox;
        private ReaLTaiizor.Controls.ThunderButton addBtn;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private ReaLTaiizor.Controls.ThunderButton deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private SportsGalaxyDataSet sportsGalaxyDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private SportsGalaxyDataSetTableAdapters.AdminTableAdapter adminTableAdapter1;
    }
}