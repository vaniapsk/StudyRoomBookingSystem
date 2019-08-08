namespace StudyRoomBooking.UserInterface.AdminForms
{
    partial class AdminBookingOptins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePickerAdm = new System.Windows.Forms.DateTimePicker();
            this.availableSlotsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyRoomBookingDataSet4 = new StudyRoomBooking.StudyRoomBookingDataSet4();
            this.availableSlotsTableAdapter = new StudyRoomBooking.StudyRoomBookingDataSet4TableAdapters.availableSlotsTableAdapter();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editBookingTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSlot = new System.Windows.Forms.Label();
            this.panelEditBooking = new System.Windows.Forms.Panel();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStNumber = new System.Windows.Forms.TextBox();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lstBoxBookings = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.availableSlotsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRoomBookingDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editBookingTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelEditBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerAdm
            // 
            this.dateTimePickerAdm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdm.Location = new System.Drawing.Point(408, 95);
            this.dateTimePickerAdm.Name = "dateTimePickerAdm";
            this.dateTimePickerAdm.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerAdm.TabIndex = 30;
            this.dateTimePickerAdm.ValueChanged += new System.EventHandler(this.DateTimePickerAdm_ValueChanged_1);
            // 
            // availableSlotsBindingSource
            // 
            this.availableSlotsBindingSource.DataMember = "availableSlots";
            this.availableSlotsBindingSource.DataSource = this.studyRoomBookingDataSet4;
            // 
            // studyRoomBookingDataSet4
            // 
            this.studyRoomBookingDataSet4.DataSetName = "StudyRoomBookingDataSet4";
            this.studyRoomBookingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // availableSlotsTableAdapter
            // 
            this.availableSlotsTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNumber.Location = new System.Drawing.Point(273, 95);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(92, 26);
            this.txtStudentNumber.TabIndex = 27;
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.AccessibleName = "labelOutput";
            this.btnBookRoom.BackColor = System.Drawing.Color.White;
            this.btnBookRoom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBookRoom.Location = new System.Drawing.Point(342, 291);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(100, 49);
            this.btnBookRoom.TabIndex = 26;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.BtnBookRoom_Click_1);
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(149, 98);
            this.lblStudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(120, 18);
            this.lblStudentNumber.TabIndex = 28;
            this.lblStudentNumber.Text = "Student Number:";
            // 
            // labelOutput
            // 
            this.labelOutput.AccessibleName = "labelOutput";
            this.labelOutput.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(149, 352);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(487, 23);
            this.labelOutput.TabIndex = 31;
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstructions.Location = new System.Drawing.Point(69, 35);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(620, 56);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Provide the student number, room, date and time slot of the booking.\r\n";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(688, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 32;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // t19
            // 
            this.t19.DataPropertyName = "t19";
            this.t19.HeaderText = "19:00";
            this.t19.Name = "t19";
            this.t19.ReadOnly = true;
            this.t19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t18
            // 
            this.t18.DataPropertyName = "t18";
            this.t18.HeaderText = "18:00";
            this.t18.Name = "t18";
            this.t18.ReadOnly = true;
            this.t18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t17
            // 
            this.t17.DataPropertyName = "t17";
            this.t17.HeaderText = "17:00";
            this.t17.Name = "t17";
            this.t17.ReadOnly = true;
            this.t17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t16
            // 
            this.t16.DataPropertyName = "t16";
            this.t16.HeaderText = "16:00";
            this.t16.Name = "t16";
            this.t16.ReadOnly = true;
            this.t16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t15
            // 
            this.t15.DataPropertyName = "t15";
            this.t15.HeaderText = "15:00";
            this.t15.Name = "t15";
            this.t15.ReadOnly = true;
            this.t15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t14
            // 
            this.t14.DataPropertyName = "t14";
            this.t14.HeaderText = "14:00";
            this.t14.Name = "t14";
            this.t14.ReadOnly = true;
            this.t14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t13
            // 
            this.t13.DataPropertyName = "t13";
            this.t13.HeaderText = "13:00";
            this.t13.Name = "t13";
            this.t13.ReadOnly = true;
            this.t13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t12
            // 
            this.t12.DataPropertyName = "t12";
            this.t12.HeaderText = "12:00";
            this.t12.Name = "t12";
            this.t12.ReadOnly = true;
            this.t12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t11
            // 
            this.t11.DataPropertyName = "t11";
            this.t11.HeaderText = "11:00";
            this.t11.Name = "t11";
            this.t11.ReadOnly = true;
            this.t11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t10
            // 
            this.t10.DataPropertyName = "t10";
            this.t10.HeaderText = "10:00";
            this.t10.Name = "t10";
            this.t10.ReadOnly = true;
            this.t10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t9
            // 
            this.t9.DataPropertyName = "t9";
            this.t9.HeaderText = "09:00";
            this.t9.Name = "t9";
            this.t9.ReadOnly = true;
            this.t9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // t8
            // 
            this.t8.DataPropertyName = "t8";
            this.t8.HeaderText = "08:00";
            this.t8.Name = "t8";
            this.t8.ReadOnly = true;
            this.t8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // roomNumber
            // 
            this.roomNumber.DataPropertyName = "roomNumber";
            this.roomNumber.Frozen = true;
            this.roomNumber.HeaderText = "Room Number";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            this.roomNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumber,
            this.t8,
            this.t9,
            this.t10,
            this.t11,
            this.t12,
            this.t13,
            this.t14,
            this.t15,
            this.t16,
            this.t17,
            this.t18,
            this.t19});
            this.dataGridView1.DataSource = this.availableSlotsBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Location = new System.Drawing.Point(57, 149);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 136);
            this.dataGridView1.TabIndex = 29;
            // 
            // editBookingTab
            // 
            this.editBookingTab.Controls.Add(this.tabPage1);
            this.editBookingTab.Controls.Add(this.tabPage2);
            this.editBookingTab.Location = new System.Drawing.Point(-1, -2);
            this.editBookingTab.Name = "editBookingTab";
            this.editBookingTab.SelectedIndex = 0;
            this.editBookingTab.Size = new System.Drawing.Size(784, 431);
            this.editBookingTab.TabIndex = 33;
            this.editBookingTab.Tag = "All Bookings";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::StudyRoomBooking.Properties.Resources.backgroungImg3;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.labelOutput);
            this.tabPage1.Controls.Add(this.lblInstructions);
            this.tabPage1.Controls.Add(this.dateTimePickerAdm);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnBookRoom);
            this.tabPage1.Controls.Add(this.lblStudentNumber);
            this.tabPage1.Controls.Add(this.txtStudentNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Booking";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::StudyRoomBooking.Properties.Resources.backgroungImg3;
            this.tabPage2.Controls.Add(this.buttonBack);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblSlot);
            this.tabPage2.Controls.Add(this.panelEditBooking);
            this.tabPage2.Controls.Add(this.lblDate);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblRoomNumber);
            this.tabPage2.Controls.Add(this.lstBoxBookings);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Bookings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.White;
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.Location = new System.Drawing.Point(688, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 28);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Logout";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Student ID";
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlot.Location = new System.Drawing.Point(351, 46);
            this.lblSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(77, 19);
            this.lblSlot.TabIndex = 35;
            this.lblSlot.Text = "Time Slot";
            // 
            // panelEditBooking
            // 
            this.panelEditBooking.Controls.Add(this.lblTimeSlot);
            this.panelEditBooking.Controls.Add(this.cmbTimeSlot);
            this.panelEditBooking.Controls.Add(this.label2);
            this.panelEditBooking.Controls.Add(this.txtBoxStNumber);
            this.panelEditBooking.Controls.Add(this.lblSelectDate);
            this.panelEditBooking.Controls.Add(this.btnUpdate);
            this.panelEditBooking.Controls.Add(this.btnDelete);
            this.panelEditBooking.Controls.Add(this.dtpSelectDate);
            this.panelEditBooking.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEditBooking.Location = new System.Drawing.Point(432, 67);
            this.panelEditBooking.Margin = new System.Windows.Forms.Padding(2);
            this.panelEditBooking.Name = "panelEditBooking";
            this.panelEditBooking.Size = new System.Drawing.Size(318, 205);
            this.panelEditBooking.TabIndex = 32;
            this.panelEditBooking.Visible = false;
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(15, 76);
            this.lblTimeSlot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(78, 19);
            this.lblTimeSlot.TabIndex = 26;
            this.lblTimeSlot.Text = "TimeSlot:";
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.cmbTimeSlot.Location = new System.Drawing.Point(150, 73);
            this.cmbTimeSlot.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(91, 27);
            this.cmbTimeSlot.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Student Number:";
            // 
            // txtBoxStNumber
            // 
            this.txtBoxStNumber.Location = new System.Drawing.Point(150, 17);
            this.txtBoxStNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxStNumber.Name = "txtBoxStNumber";
            this.txtBoxStNumber.ReadOnly = true;
            this.txtBoxStNumber.Size = new System.Drawing.Size(122, 27);
            this.txtBoxStNumber.TabIndex = 23;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(15, 50);
            this.lblSelectDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(47, 19);
            this.lblSelectDate.TabIndex = 11;
            this.lblSelectDate.Text = "Date:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(94, 130);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(181, 129);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 41);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelectDate.Location = new System.Drawing.Point(150, 44);
            this.dtpSelectDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(91, 27);
            this.dtpSelectDate.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(279, 46);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 19);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(270, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Select a booking to start editing";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(157, 46);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(51, 19);
            this.lblRoomNumber.TabIndex = 33;
            this.lblRoomNumber.Text = "Room";
            // 
            // lstBoxBookings
            // 
            this.lstBoxBookings.BackColor = System.Drawing.Color.White;
            this.lstBoxBookings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxBookings.FormattingEnabled = true;
            this.lstBoxBookings.ItemHeight = 16;
            this.lstBoxBookings.Location = new System.Drawing.Point(29, 67);
            this.lstBoxBookings.Margin = new System.Windows.Forms.Padding(2);
            this.lstBoxBookings.Name = "lstBoxBookings";
            this.lstBoxBookings.Size = new System.Drawing.Size(399, 276);
            this.lstBoxBookings.TabIndex = 30;
            this.lstBoxBookings.SelectedIndexChanged += new System.EventHandler(this.LstBoxBookings_SelectedIndexChanged);
            // 
            // AdminBookingOptins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyRoomBooking.Properties.Resources.backgroungImg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 423);
            this.Controls.Add(this.editBookingTab);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminBookingOptins";
            this.Text = "Study Room Booking - Administrator";
            this.Load += new System.EventHandler(this.CreateBookingForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.availableSlotsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRoomBookingDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editBookingTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelEditBooking.ResumeLayout(false);
            this.panelEditBooking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerAdm;
        private StudyRoomBookingDataSet4 studyRoomBookingDataSet4;
        private System.Windows.Forms.BindingSource availableSlotsBindingSource;
        private StudyRoomBookingDataSet4TableAdapters.availableSlotsTableAdapter availableSlotsTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t19;
        private System.Windows.Forms.DataGridViewTextBoxColumn t18;
        private System.Windows.Forms.DataGridViewTextBoxColumn t17;
        private System.Windows.Forms.DataGridViewTextBoxColumn t16;
        private System.Windows.Forms.DataGridViewTextBoxColumn t15;
        private System.Windows.Forms.DataGridViewTextBoxColumn t14;
        private System.Windows.Forms.DataGridViewTextBoxColumn t13;
        private System.Windows.Forms.DataGridViewTextBoxColumn t12;
        private System.Windows.Forms.DataGridViewTextBoxColumn t11;
        private System.Windows.Forms.DataGridViewTextBoxColumn t10;
        private System.Windows.Forms.DataGridViewTextBoxColumn t9;
        private System.Windows.Forms.DataGridViewTextBoxColumn t8;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl editBookingTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.Panel panelEditBooking;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStNumber;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.ListBox lstBoxBookings;
    }
}