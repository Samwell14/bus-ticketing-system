namespace Bus_Booking_System
{
    class Registration
    {
        string Name;
        string FatherName;
        decimal CNIC;
        string Gender;
        string Password;
        string City;
        public Registration()
        {
            Name = "Salman";
            FatherName = "Aqeel Uddin";
            CNIC = 4210171412231;
            Gender = "Male";
            Password = "Hello";
            City = "Karachi";
        }
        public Registration(string Name, string FatherName, decimal CNIC, string Gender, string Password, string City)
        {
            this.City = City;
            this.Name = Name;
            this.Password = Password;
            this.FatherName = FatherName;
            this.CNIC = CNIC;
            this.Gender = Gender;

        }
        public string NAME { get { return Name; } set { Name = value; } }
        public string FATHERNAME { get { return FatherName; } set { FatherName = value; } }
        public decimal Cnic { get { return CNIC; } set { CNIC = value; } }
        public string GENDER { get { return Gender; } set { Gender = value; } }
        public string PASSWORD { get { return Password; } set { Password = value; } }
        public string CITY { get { return City; } set { City = value; } }




    }

}
