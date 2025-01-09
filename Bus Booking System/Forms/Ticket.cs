using System;

namespace Bus_Booking_System
{
    public class Ticket
    {
        String DepartureFrom;
        String TravellingTo;

        public DateTime DateTime;
        double TicketNo;





        public Ticket()
        {
            DepartureFrom = "Karachi";
            TravellingTo = "Larkana";

            TicketNo = 42323;

        }
        public Ticket(double TicketNo, String DepartureFrom, String TravellingTo, DateTime DateTime)
        {
            this.TicketNo = TicketNo;
            this.DepartureFrom = DepartureFrom;
            this.TravellingTo = TravellingTo;
            this.DateTime = DateTime;



        }
        public string DEPARTUREFROM { get { return DepartureFrom; } set { DepartureFrom = value; } }
        public string TREVELLINGTO { get { return TravellingTo; } set { TravellingTo = value; } }
        public double TICKETNO { get { return TicketNo; } set { TicketNo = value; } }




    }
}
