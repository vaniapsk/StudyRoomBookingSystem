using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoomBooking.Entity
{
    class Room
    {
        private int roomNumber { get; set; }
        private int capacity { get; set; }
        private Building building { get; set; }

        public Room(int roomNumber, int capacity, Building building)
        {
            this.roomNumber = roomNumber;
            this.capacity = capacity;
            this.building = building;
        }
    }
}
