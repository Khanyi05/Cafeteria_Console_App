using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiumCafeteria
{
    internal class Residential:Student
    {
        private string dormName;
        private int roomNumber;
        public Residential(int id, string fullName, bool isResStudent, int yearsOnCampus, int yearsAtRes, decimal allowance, double avgMark,string dormName, int roomNumber, int yearsAtResidence):base(id, fullName, isResStudent,yearsOnCampus,yearsAtResidence, allowance, avgMark)
        {
            this.DormName = dormName;
            this.RoomNumber = roomNumber;
        }

        public string DormName { get => dormName; set => dormName = value; }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public override string GetStudentType() => "Residential Student";
        public override string ToString()
        {
            return base.ToString() + $", Dormitory: {dormName}, RoomNumber: {roomNumber}";
        }
    }
}
