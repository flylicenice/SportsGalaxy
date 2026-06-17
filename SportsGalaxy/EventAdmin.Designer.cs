namespace SportsGalaxy
{
    partial class EventAdmin
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
            this.eventDGV = new System.Windows.Forms.DataGridView();
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsGalaxyDataSet = new SportsGalaxy.SportsGalaxyDataSet();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parrotClock1 = new ReaLTaiizor.Controls.ParrotClock();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.delBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.updateBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.locationComboBx = new System.Windows.Forms.ComboBox();
            this.eventTableAdapter1 = new SportsGalaxy.SportsGalaxyDataSetTableAdapters.EventTableAdapter();
            this.eventBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAttendeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.eventDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // eventDGV
            // 
            this.eventDGV.AutoGenerateColumns = false;
            this.eventDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.eventDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIdDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.eventTimeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.maxAttendeesDataGridViewTextBoxColumn,
            this.matricnoDataGridViewTextBoxColumn});
            this.eventDGV.DataSource = this.eventBindingSource2;
            this.eventDGV.Location = new System.Drawing.Point(16, 198);
            this.eventDGV.Name = "eventDGV";
            this.eventDGV.Size = new System.Drawing.Size(753, 288);
            this.eventDGV.TabIndex = 1;
            this.eventDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDGV_CellClick);
            // 
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataMember = "Event";
            this.eventBindingSource1.DataSource = this.sportsGalaxyDataSet;
            // 
            // sportsGalaxyDataSet
            // 
            this.sportsGalaxyDataSet.DataSetName = "SportsGalaxyDataSet";
            this.sportsGalaxyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            // 
            // parrotClock1
            // 
            this.parrotClock1.CircleThickness = 6;
            this.parrotClock1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotClock1.DisplayFormat = ReaLTaiizor.Controls.ParrotClock.HourFormat.TwentyFourHour;
            this.parrotClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.parrotClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.parrotClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.parrotClock1.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotClock1.Location = new System.Drawing.Point(16, 51);
            this.parrotClock1.Name = "parrotClock1";
            this.parrotClock1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotClock1.ShowAmPm = false;
            this.parrotClock1.ShowHexagon = true;
            this.parrotClock1.ShowMinutesCircle = true;
            this.parrotClock1.ShowSecondsCircle = true;
            this.parrotClock1.Size = new System.Drawing.Size(119, 130);
            this.parrotClock1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotClock1.TabIndex = 2;
            this.parrotClock1.Text = "parrotClock1";
            this.parrotClock1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotClock1.TimeAMFormat = "hh:mm";
            this.parrotClock1.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.parrotClock1.TimePMFormat = "HH:mm";
            this.parrotClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.parrotClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.parrotClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Event ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Event Name";
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(106, 521);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.ReadOnly = true;
            this.IDTxtBox.Size = new System.Drawing.Size(159, 20);
            this.IDTxtBox.TabIndex = 7;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(106, 555);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(159, 20);
            this.nameTxtBox.TabIndex = 8;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delBtn.Location = new System.Drawing.Point(15, 703);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(120, 40);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "Delete";
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateBtn.Location = new System.Drawing.Point(489, 703);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 40);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(106, 589);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.ReadOnly = true;
            this.locationTxtBox.Size = new System.Drawing.Size(159, 20);
            this.locationTxtBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 624);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Event Time";
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(106, 621);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.ReadOnly = true;
            this.timeTxtBox.Size = new System.Drawing.Size(159, 20);
            this.timeTxtBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Event Date";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Location = new System.Drawing.Point(106, 654);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(159, 20);
            this.dateTxtBox.TabIndex = 16;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(569, 521);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "New Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "New Time";
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(569, 558);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "New Location";
            // 
            // locationComboBx
            // 
            this.locationComboBx.FormattingEnabled = true;
            this.locationComboBx.Items.AddRange(new object[] {
            "Gym",
            "Badminton Court",
            "Football Field",
            "Netball Court",
            "Basketball Court"});
            this.locationComboBx.Location = new System.Drawing.Point(569, 597);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(200, 21);
            this.locationComboBx.TabIndex = 23;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // eventBindingSource2
            // 
            this.eventBindingSource2.DataMember = "Event";
            this.eventBindingSource2.DataSource = this.sportsGalaxyDataSet;
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // maxAttendeesDataGridViewTextBoxColumn
            // 
            this.maxAttendeesDataGridViewTextBoxColumn.DataPropertyName = "MaxAttendees";
            this.maxAttendeesDataGridViewTextBoxColumn.HeaderText = "MaxAttendees";
            this.maxAttendeesDataGridViewTextBoxColumn.Name = "maxAttendeesDataGridViewTextBoxColumn";
            // 
            // matricnoDataGridViewTextBoxColumn
            // 
            this.matricnoDataGridViewTextBoxColumn.DataPropertyName = "matric_no";
            this.matricnoDataGridViewTextBoxColumn.HeaderText = "matric_no";
            this.matricnoDataGridViewTextBoxColumn.Name = "matricnoDataGridViewTextBoxColumn";
            // 
            // EventAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(781, 774);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dateTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parrotClock1);
            this.Controls.Add(this.eventDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView eventDGV;
        private ReaLTaiizor.Controls.ParrotClock parrotClock1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private ReaLTaiizor.Controls.ThunderButton delBtn;
        private ReaLTaiizor.Controls.ThunderButton updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox locationComboBx;
        private SportsGalaxyDataSet sportsGalaxyDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource1;
        private SportsGalaxyDataSetTableAdapters.EventTableAdapter eventTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAttendeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventBindingSource2;
    }
}