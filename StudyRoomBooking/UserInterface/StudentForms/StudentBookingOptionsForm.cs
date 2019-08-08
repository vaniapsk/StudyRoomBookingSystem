using StudyRoomBooking.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomBooking
{
    public partial class studentBookingOptionsForm : Form
    {
        public String username { get; set; }
        private List<Booking> bookings = new List<Booking>();
        public studentBookingOptionsForm()
        {
            InitializeComponent();
        }

  
    private void MakeBookingForm_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'studyRoomBookingDataSet6.availableSlots' table. You can move, or remove it, as needed.
            this.availableSlotsTableAdapter2.Fill(this.studyRoomBookingDataSet6.availableSlots);
            //get the availability and passes it to dataGridView with the right colors setted ut
            getSlotAvailability();
            //shows all bookings from database in the list
            this.onFormLoad();
            //get changes of tab and call the envent handler
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);

        }
        //reload colors on dataGridView and booking list
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSlotAvailability();
            this.onFormLoad();
        }

        private void onFormLoad()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();
            DataTable dt = databaseHelper.getBookings(username);
            lstBoxYourBookings.Items.Clear();
            bookings.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int bookingID = dr.Field<int>("bookingID");
                int roomNumber = dr.Field<int>("RoomNumber");
                string date = dr.Field<string>("date");
                string slot = dr.Field<string>("slotTime");
                lstBoxYourBookings.Items.Add(roomNumber + "                                 "
                                           + date + "                   "
                                           + slot);

                Booking booking = new Booking();
                booking.bookingID = bookingID;
                booking.roomNumber = roomNumber;
                booking.studentNumber = int.Parse(username);
                booking.date = date;
                booking.slot = slot;
                bookings.Add(booking);
            }
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            int selectCellIndex = dataGridView2.CurrentCell.ColumnIndex;
            string slotTime = dataGridView2.Columns[selectCellIndex].HeaderCell.Value.ToString(); ;
            int roomNumber = (int)dataGridView2.CurrentRow.Cells[0].Value;
            string selectedDate = dateTimePicker.Value.ToShortDateString();

            //create a booking (1234 is there for thesting. It ts
            //is the student number to the current user st numb)

            if (dataGridView2.CurrentCell.Style.BackColor == Color.Green)
            {

                if (db.createBooking(roomNumber, int.Parse(this.username), selectedDate, slotTime))
                {
                    lblWarning.ForeColor = Color.Green;
                    lblWarning.Text = "Success";
                }
                else
                {
                    lblWarning.ForeColor = Color.Red;
                    lblWarning.Text = "Room not booked. Please check the student id";
                }

            }
            else
            {
                lblWarning.ForeColor = Color.Red;
                lblWarning.Text = "The selected slot is already booked";
            }

            getSlotAvailability();
        }

        //check database and match correct collors to available/unavailable time
        private void getSlotAvailability()
        {
            refreshColors();
            DatabaseHelper db = new DatabaseHelper();
            DataTable dataTable = db.getData("Booking");
            string selectedDate = dateTimePicker.Value.ToShortDateString();


            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        string dbDate = dr.Field<string>("date").ToString();

                        if (dbDate.Equals(selectedDate))
                        {
                            if (dataGridView2.Columns[i].HeaderText.Equals(dr.Field<string>("slotTime")) &
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
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    if (row.Cells[i].ColumnIndex != 0)
                        row.Cells[i].Style.BackColor = Color.Green;
                }
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lblWarning.Text = "";
            getSlotAvailability();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();

        }

        private void LstBoxYourBookings_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lstBoxYourBookings.SelectedIndex;
            if (i != -1)
            {
                dtpSelectDate.Value = DateTime.Parse(bookings[i].date);
                cmbTimeSlot.SelectedItem = bookings[i].slot;
                panelEditBooking.Show();
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();

        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            int i = lstBoxYourBookings.SelectedIndex;
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
            int i = lstBoxYourBookings.SelectedIndex;
            if (i != -1)
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                databaseHelper.deleteBooking(bookings[i].bookingID);
                this.onFormLoad();
                getSlotAvailability();
            }
        }
        
    }
}
