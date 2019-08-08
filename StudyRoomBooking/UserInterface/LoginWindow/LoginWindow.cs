using StudyRoomBooking.UserInterface.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyRoomBooking
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();
                //get data from table Administrator
                DataTable dt_admin = databaseHelper.getData("Administrator");

                Boolean found = false;
                Boolean admin = false;
                
                //check for matching from the fields, to the info stored on the database
                foreach (DataRow dr in dt_admin.Rows)
                {
                    String username = dr.Field<int>("Username").ToString();
                    String password = dr.Field<string>("Password");
                    
                    if (username == txtUsername.Text && password == txtPassword.Text)
                    {
                        found = true;
                        admin = true;
                        break;
                    }

                }

                //If inputed info is not from admin, check if it is from a student
                if (!found)
                {
                    DataTable dt_student = databaseHelper.getData("Student");

                    foreach (DataRow dr in dt_student.Rows)
                    {
                        String username = dr.Field<int>("StudentNumber").ToString();
                        String password = dr.Field<string>("Password");

                        if (username == txtUsername.Text && password == txtPassword.Text)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                //grant access if info is from admin or student
                if (found && !admin)
                {
                    studentBookingOptionsForm stOptionsForm = new studentBookingOptionsForm();
                    stOptionsForm.username = txtUsername.Text;
                    this.Visible = false;
                    stOptionsForm.Show();
                }
                else if (found && admin)
                {
                    AdminBookingOptins adOptionForm = new AdminBookingOptins();
                    this.Visible = false;
                    adOptionForm.Show();
                }

                //if the login is not found, or incorrect, display a message
                else
                {
                    lblWarning.Show();
                    lblWarning.ForeColor = Color.Red;
                    lblWarning.Text = "Wrong username or password";
                }

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
