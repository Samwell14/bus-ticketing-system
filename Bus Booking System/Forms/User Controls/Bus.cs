using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Booking_System
{
 public   class Bus
    {
        string BusType;
        string ConductorName;
        int seatsCapacity;
        int Noofseats;

        public Bus()
        {
            BusType = "Local";
            ConductorName = "Maaz";
            seatsCapacity = 30;
            Noofseats = 5;
        }
        public Bus(int Noofseats)
        {
            this.Noofseats = Noofseats;

        }
        public int NOOFSEATS { get { return Noofseats; } set { Noofseats = value; } }


    }
}
