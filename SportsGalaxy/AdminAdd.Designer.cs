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
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.addBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.adminTableAdapter1 = new SportsGalaxy.SportsGalaxyDataSetTableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
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
            this.adminDGV.Location = new System.Drawing.Point(12, 12);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.Size = new System.Drawing.Size(282, 197);
            this.adminDGV.TabIndex = 0;
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            this.adminIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
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
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin ID";
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(105, 221);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.Size = new System.Drawing.Size(189, 20);
            this.IDTxtBox.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addBtn.Location = new System.Drawing.Point(12, 297);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(120, 40);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(105, 255);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(189, 20);
            this.passwordTxtBox.TabIndex = 14;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteBtn.Location = new System.Drawing.Point(174, 297);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(120, 40);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "Delete";
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // AdminAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 378);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAdd";
            this.Load += new System.EventHandler(this.AdminAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDTxtBox;
        private ReaLTaiizor.Controls.ThunderButton addBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private ReaLTaiizor.Controls.ThunderButton deleteBtn;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private SportsGalaxyDataSet sportsGalaxyDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private SportsGalaxyDataSetTableAdapters.AdminTableAdapter adminTableAdapter1;
    }
}