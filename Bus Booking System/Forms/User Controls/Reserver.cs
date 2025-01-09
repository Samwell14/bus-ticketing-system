namespace Bus_Booking_System
{
    public class Reserver
    {
        string name;
        decimal cnic;
        string phoneNo;

        public Reserver()
        {
            name = "salman";
            cnic = 42101 - 7141223 - 1;
            phoneNo = "0316-1019292";

        }

        public Reserver(string name, decimal cnic, string phoneNo)
        {
            this.name = name;
            this.cnic = cnic;
            this.phoneNo = phoneNo;

        }
        public string NAME { get { return name; } set { name = value; } }
        public decimal CNIC { get { return cnic; } set { cnic = value; } }
        public string PHONENO { get { return phoneNo; } set { phoneNo = value; } }
    }
}
