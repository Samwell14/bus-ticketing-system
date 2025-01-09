namespace Bus_Booking_System
{
    class Payment
    {
        double totalAmount;
        double paidAmount;
        double ReturnAmount;
        public Payment()
        {
            totalAmount = 4000;
            paidAmount = 5000;
            ReturnAmount = 1000;
        }
        public Payment(double totalAmount, double paidAmount, double ReturnAmount)
        {
            this.totalAmount = totalAmount;
            this.paidAmount = paidAmount;
            this.ReturnAmount = ReturnAmount;
        }
        public double TOTALAMOUNT { get { return totalAmount; } set { totalAmount = value; } }
        public double PAIDAMOUNT { get { return paidAmount; } set { paidAmount = value; } }
        public double RETURNAMOUNT { get { return ReturnAmount; } set { ReturnAmount = value; } }
    }
}
