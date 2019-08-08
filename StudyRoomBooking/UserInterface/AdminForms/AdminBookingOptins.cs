using StudyRoomBooking.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomBooking.UserInterface.AdminForms
{
    public partial class AdminBookingOptins : Form
    {
        private List<Booking> bookings = new List<Booking>();
        public AdminBookingOptins()
        {
            InitializeComponent();
        }


        private void CreateBookingForm_Load_1(object sender, EventArgs e)
        {
            // This line of code loads data into the 'studyRoomBookingDataSet5.Booking' table. You can move, or remove it, as needed.
            this.availableSlotsTableAdapter.Fill(this.studyRoomBookingDataSet4.availableSlots);
            //get the availability and passes it to dataGridView with the right colors setted ut
            getSlotAvailability();
            //shows all bookings from database in the list
            this.onFormLoad();
            //get changes of tab
            editBookingTab.SelectedIndexChanged += new EventHandler(editBookingTab_SelectedIndexChanged);

        }
        //reload colors on dataGridView and booking list
        private void editBookingTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSlotAvailability();
            this.onFormLoad();
        }
        private void getSlotAvailability()
        {
            refreshColors();
            DatabaseHelper db = new DatabaseHelper();
            DataTable dataTable = db.getData("Booking");
            string selectedDate = dateTimePickerAdm.Value.ToShortDateString();


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        string dbDate = dr.Field<string>("date").ToString();
                        
                        if (dbDate.Equals(selectedDate))
                        {
                            if (dataGridView1.Columns[i].HeaderText.Equals(dr.Field<string>("slotTime")) &
                                (int)row.Cells[0].Value == dr.Field<int>("RoomNumber"))
                            {
                                row.Cells[i].Style.BackColor = Color.Red;
                            }

                        }

                    }

                }
            }
        }

        private void refreshColors()
        {
            //set dataGrid cells background colors to green

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (row.Cells[i].ColumnIndex != 0)
                        row.Cells[i].Style.BackColor = Color.Green;
                }
            }

        }

        private void DateTimePickerAdm_ValueChanged_1(object sender, EventArgs e)
        {
            getSlotAvailability();
            labelOutput.Text = "";
        }

        private void BtnBookRoom_Click_1(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            int selectCellIndex = dataGridView1.CurrentCell.ColumnIndex;
            string slotTime = dataGridView1.Columns[selectCellIndex].HeaderCell.Value.ToString(); ;
            int roomNumber = (int)dataGridView1.CurrentRow.Cells[0].Value;
            string selectedDate = dateTimePickerAdm.Value.ToShortDateString();
            int stID;

            if (dataGridView1.CurrentCell.Style.BackColor == Color.Green)
            {
                if (int.TryParse(txtStudentNumber.Text, out stID))
                {
                    if (db.createBooking(roomNumber, stID, selectedDate, slotTime))
                    {
                        labelOutput.ForeColor = Color.Green;
                        labelOutput.Text = "Success";
                    }
                    else
                    {
                        labelOutput.ForeColor = Color.Red;
                        labelOutput.Text = "Room not booked. Please check the student id";
                    }

                }
                else
                {
                    labelOutput.ForeColor = Color.Red;
                    labelOutput.Text = "Room not booked. Please check the student id";
                }

            }
            else
            {
                labelOutput.ForeColor = Color.Red;
                labelOutput.Text = "The selected slot is already booked";
            }

            getSlotAvailability();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            AdminBookingOptins createBooking = new AdminBookingOptins();

            this.Close();
            createBooking.Close();
            loginWindow.Show();

        }
        private void onFormLoad()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable dt = databaseHelper.getBookings();
            lstBoxBookings.Items.Clear();
            bookings.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int bookingID = dr.Field<int>("bookingID");
                int studentNumber = dr.Field<int>("StudentNumber");
                int roomNumber = dr.Field<int>("RoomNumber");
                string date = dr.Field<string>("date");
                string slot = dr.Field<string>("slotTime");
                lstBoxBookings.Items.Add(studentNumber + "                          "
                                       + roomNumber + "                        "
                                       + date + "      "
                                       + slot);

                Booking booking = new Booking();
                booking.bookingID = bookingID;
                booking.roomNumber = roomNumber;
                booking.studentNumber = studentNumber;
                booking.date = date;
                booking.slot = slot;
                bookings.Add(booking);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int i = lstBoxBookings.SelectedIndex;
            if (i != -1)
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                databaseHelper.updateBooking(bookings[i].bookingID,
                                             dtpSelectDate.Text.ToString(),
                                             cmbTimeSlot.Text.ToString());
                this.onFormLoad();
                getSlotAvailability();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int i = lstBoxBookings.SelectedIndex;
            if (i != -1)
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                databaseHelper.deleteBooking(bookings[i].bookingID);
                this.onFormLoad();
                getSlotAvailability();
            }
        }

        private void LstBoxBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstBoxBookings.SelectedIndex;
            if (i != -1)
            {
                txtBoxStNumber.Text = bookings[i].studentNumber.ToString();
                dtpSelectDate.Value = DateTime.Parse(bookings[i].date);
                cmbTimeSlot.SelectedItem = bookings[i].slot;
                panelEditBooking.Show();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            AdminBookingOptins createBooking = new AdminBookingOptins();

            this.Close();
            createBooking.Close();
            loginWindow.Show();
        }

    }
}
