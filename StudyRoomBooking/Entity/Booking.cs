using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoomBooking.Entity
{
    class Booking
    {
        public int bookingID { get; set; }
        public int roomNumber { get; set; }
        public int studentNumber { get; set; }
        public string date { get; set; }
        public string slot { get; set; }
        /*private Room room { get; set; }
        private Student student { get; set; }
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }*/
    }
}
