using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoomBooking
{
    public class DatabaseHelper
    {
        //get all the data of given table
        public DataTable getData(String tableName)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                // Build connection string - - Vania 6/24/2018
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "master";

                // Connect to SQL 

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to StudyRoomBooking.");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE StudyRoomBooking; ");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    sql = "SELECT * from " + tableName;

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dataTable.Load(dr);
                        }
                    }
                    connection.Close();

                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            return dataTable;
        }

        //create new booking
        public bool createBooking(int roomNumber, int studentNumber, string date, string slotTime)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                // Build connection string - - Vania 6/24/2018
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "master";

                // Connect to SQL 

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to StudyRoomBooking.");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE StudyRoomBooking; ");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    sql = "INSERT INTO Booking (RoomNumber, StudentNumber, Date, slotTime) values  (" + roomNumber + "," + studentNumber + ",'" + date + "','" + slotTime + "')";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }

                    
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        //Get the booking for a given student.
        public DataTable getBookings(String username = null)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "StudyRoomBooking";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    string sql;
                    if(username != null)
                    {
                        sql = "SELECT * FROM Booking WHERE StudentNumber = " + username;
                    }
                    else
                    {
                        sql = "SELECT * FROM Booking";
                    }

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dataTable.Load(dr);
                        }
                    }

                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            return dataTable;
        }

        //Update availableSlots table
        public void bookTimeSlot(string colum, string value, int roomN)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                // Build connection string - - Vania 6/24/2018
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "master";

                // Connect to SQL 

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to StudyRoomBooking.");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("USE StudyRoomBooking; ");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    sql = " update availableSlots set " + colum + " = '" + value + "' where roomNumber =" + roomN;

                    using (var command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            dataTable.Load(dr);
                        }
                    }
                    connection.Close();

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        //to update a booking
        public void updateBooking(int bookingID, string date, string slot)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "StudyRoomBooking";

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
                string sql = "UPDATE Booking SET date = '"+date+"', slotTime = '"+slot+"' WHERE BookingID = "+bookingID;
                //string sql = "UPDATE Booking SET date = '8/1/2019', slotTime = '13:00' WHERE BookingID = 2";
                var command = new SqlCommand(sql, connection);
                int output = command.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        //to delete booking
        public void deleteBooking(int bookingID)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            DataTable dataTable = new DataTable();

            try
            {
                builder.DataSource = "localhost";
                builder.UserID = "project3300";
                builder.Password = "csis3300";
                builder.InitialCatalog = "StudyRoomBooking";

                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                connection.Open();
                string sql = "DELETE FROM Booking WHERE BookingID = " + bookingID;
                var command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
