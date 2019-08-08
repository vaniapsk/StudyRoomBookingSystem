using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoomBooking.Entity
{
    class Building
    {
        private string buildingName { get; set; }

        public Building(string buildingName)
        {
            this.buildingName = buildingName;
        }
    }
}
