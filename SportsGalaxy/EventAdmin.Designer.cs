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
            this.eventIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAttendeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsGalaxyDataSet = new SportsGalaxy.SportsGalaxyDataSet();
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parrotClock1 = new ReaLTaiizor.Controls.ParrotClock();
            this.lblEventID = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.IDTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.delBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.updateBtn = new ReaLTaiizor.Controls.ThunderButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.lblEventTime = new System.Windows.Forms.Label();
            this.timeTxtBox = new System.Windows.Forms.TextBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.lblNewTime = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.lblNewLocation = new System.Windows.Forms.Label();
            this.locationComboBx = new System.Windows.Forms.ComboBox();
            this.eventTableAdapter1 = new SportsGalaxy.SportsGalaxyDataSetTableAdapters.EventTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
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
            this.eventDGV.Location = new System.Drawing.Point(21, 244);
            this.eventDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eventDGV.Name = "eventDGV";
            this.eventDGV.RowHeadersWidth = 51;
            this.eventDGV.Size = new System.Drawing.Size(1004, 354);
            this.eventDGV.TabIndex = 1;
            this.eventDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventDGV_CellClick);
            // 
            // eventIdDataGridViewTextBoxColumn
            // 
            this.eventIdDataGridViewTextBoxColumn.DataPropertyName = "EventId";
            this.eventIdDataGridViewTextBoxColumn.HeaderText = "EventId";
            this.eventIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventIdDataGridViewTextBoxColumn.Name = "eventIdDataGridViewTextBoxColumn";
            this.eventIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "EventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "EventName";
            this.eventNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "EventDate";
            this.eventDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventTimeDataGridViewTextBoxColumn
            // 
            this.eventTimeDataGridViewTextBoxColumn.DataPropertyName = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.HeaderText = "EventTime";
            this.eventTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eventTimeDataGridViewTextBoxColumn.Name = "eventTimeDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // maxAttendeesDataGridViewTextBoxColumn
            // 
            this.maxAttendeesDataGridViewTextBoxColumn.DataPropertyName = "MaxAttendees";
            this.maxAttendeesDataGridViewTextBoxColumn.HeaderText = "MaxAttendees";
            this.maxAttendeesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxAttendeesDataGridViewTextBoxColumn.Name = "maxAttendeesDataGridViewTextBoxColumn";
            // 
            // matricnoDataGridViewTextBoxColumn
            // 
            this.matricnoDataGridViewTextBoxColumn.DataPropertyName = "matric_no";
            this.matricnoDataGridViewTextBoxColumn.HeaderText = "matric_no";
            this.matricnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matricnoDataGridViewTextBoxColumn.Name = "matricnoDataGridViewTextBoxColumn";
            // 
            // eventBindingSource2
            // 
            this.eventBindingSource2.DataMember = "Event";
            this.eventBindingSource2.DataSource = this.sportsGalaxyDataSet;
            // 
            // sportsGalaxyDataSet
            // 
            this.sportsGalaxyDataSet.DataSetName = "SportsGalaxyDataSet";
            this.sportsGalaxyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataMember = "Event";
            this.eventBindingSource1.DataSource = this.sportsGalaxyDataSet;
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
            this.parrotClock1.Location = new System.Drawing.Point(21, 63);
            this.parrotClock1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parrotClock1.Name = "parrotClock1";
            this.parrotClock1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotClock1.ShowAmPm = false;
            this.parrotClock1.ShowHexagon = true;
            this.parrotClock1.ShowMinutesCircle = true;
            this.parrotClock1.ShowSecondsCircle = true;
            this.parrotClock1.Size = new System.Drawing.Size(159, 160);
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
            // lblEventID
            // 
            this.lblEventID.AutoSize = true;
            this.lblEventID.Location = new System.Drawing.Point(17, 645);
            this.lblEventID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventID.Name = "lblEventID";
            this.lblEventID.Size = new System.Drawing.Size(57, 16);
            this.lblEventID.TabIndex = 5;
            this.lblEventID.Text = "Event ID";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(17, 687);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(81, 16);
            this.lblEventName.TabIndex = 6;
            this.lblEventName.Text = "Event Name";
            // 
            // IDTxtBox
            // 
            this.IDTxtBox.Location = new System.Drawing.Point(141, 641);
            this.IDTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDTxtBox.Name = "IDTxtBox";
            this.IDTxtBox.ReadOnly = true;
            this.IDTxtBox.Size = new System.Drawing.Size(211, 22);
            this.IDTxtBox.TabIndex = 7;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(141, 683);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.ReadOnly = true;
            this.nameTxtBox.Size = new System.Drawing.Size(211, 22);
            this.nameTxtBox.TabIndex = 8;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.delBtn.Location = new System.Drawing.Point(20, 865);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(160, 49);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "Delete";
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateBtn.Location = new System.Drawing.Point(652, 865);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(160, 49);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(19, 729);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(58, 16);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location";
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(141, 725);
            this.locationTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.ReadOnly = true;
            this.locationTxtBox.Size = new System.Drawing.Size(211, 22);
            this.locationTxtBox.TabIndex = 12;
            // 
            // lblEventTime
            // 
            this.lblEventTime.AutoSize = true;
            this.lblEventTime.Location = new System.Drawing.Point(19, 768);
            this.lblEventTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventTime.Name = "lblEventTime";
            this.lblEventTime.Size = new System.Drawing.Size(75, 16);
            this.lblEventTime.TabIndex = 13;
            this.lblEventTime.Text = "Event Time";
            // 
            // timeTxtBox
            // 
            this.timeTxtBox.Location = new System.Drawing.Point(141, 764);
            this.timeTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeTxtBox.Name = "timeTxtBox";
            this.timeTxtBox.ReadOnly = true;
            this.timeTxtBox.Size = new System.Drawing.Size(211, 22);
            this.timeTxtBox.TabIndex = 14;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(17, 809);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(73, 16);
            this.lblEventDate.TabIndex = 15;
            this.lblEventDate.Text = "Event Date";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Location = new System.Drawing.Point(141, 805);
            this.dateTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.ReadOnly = true;
            this.dateTxtBox.Size = new System.Drawing.Size(211, 22);
            this.dateTxtBox.TabIndex = 16;
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(759, 641);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(265, 22);
            this.startDate.TabIndex = 18;
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(648, 645);
            this.lblNewDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(66, 16);
            this.lblNewDate.TabIndex = 19;
            this.lblNewDate.Text = "New Date";
            // 
            // lblNewTime
            // 
            this.lblNewTime.AutoSize = true;
            this.lblNewTime.Location = new System.Drawing.Point(648, 692);
            this.lblNewTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewTime.Name = "lblNewTime";
            this.lblNewTime.Size = new System.Drawing.Size(68, 16);
            this.lblNewTime.TabIndex = 20;
            this.lblNewTime.Text = "New Time";
            // 
            // startTime
            // 
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.Location = new System.Drawing.Point(759, 687);
            this.startTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(265, 22);
            this.startTime.TabIndex = 21;
            // 
            // lblNewLocation
            // 
            this.lblNewLocation.AutoSize = true;
            this.lblNewLocation.Location = new System.Drawing.Point(648, 738);
            this.lblNewLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewLocation.Name = "lblNewLocation";
            this.lblNewLocation.Size = new System.Drawing.Size(88, 16);
            this.lblNewLocation.TabIndex = 22;
            this.lblNewLocation.Text = "New Location";
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
            this.locationComboBx.Location = new System.Drawing.Point(759, 735);
            this.locationComboBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.locationComboBx.Name = "locationComboBx";
            this.locationComboBx.Size = new System.Drawing.Size(265, 24);
            this.locationComboBx.TabIndex = 23;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // EventAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1041, 953);
            this.Controls.Add(this.locationComboBx);
            this.Controls.Add(this.lblNewLocation);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.lblNewTime);
            this.Controls.Add(this.lblNewDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.dateTxtBox);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.timeTxtBox);
            this.Controls.Add(this.lblEventTime);
            this.Controls.Add(this.locationTxtBox);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.IDTxtBox);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lblEventID);
            this.Controls.Add(this.parrotClock1);
            this.Controls.Add(this.eventDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EventAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsGalaxyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView eventDGV;
        private ReaLTaiizor.Controls.ParrotClock parrotClock1;
        private System.Windows.Forms.Label lblEventID;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox IDTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private ReaLTaiizor.Controls.ThunderButton delBtn;
        private ReaLTaiizor.Controls.ThunderButton updateBtn;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.Label lblEventTime;
        private System.Windows.Forms.TextBox timeTxtBox;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Label lblNewTime;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label lblNewLocation;
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