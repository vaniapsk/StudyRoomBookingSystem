using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyRoomBooking.Entity
{
    class Student
    {
        private int studentNumber { get; set; }
        private string name { get; set; }

        public Student(int studentNumber, string name)
        {
            this.studentNumber = studentNumber;
            this.name = name;
        }
    }
}
