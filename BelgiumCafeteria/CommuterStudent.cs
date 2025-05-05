using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelgiumCafeteria
{
    internal class CommuterStudent:Student
    {
        private string homeAddress;
        private string transportationMode;

        public CommuterStudent(int id, string fullName, int yearsOnCampus,int yearsAtRes, decimal allowance, double avgMark,string homeAddress, string transportationMode): base(id, fullName, false, yearsOnCampus, yearsAtRes, allowance, avgMark)
        {
            HomeAddress = homeAddress;
            TransportationMode = transportationMode;
        }

        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public string TransportationMode { get => transportationMode; set => transportationMode = value; }

        public override string GetStudentType() => "Commuter Student";

        public override string ToString()
        {
            return base.ToString() + $"\nAddress: {HomeAddress}\nTransport: {TransportationMode}";
        }
    }
}
