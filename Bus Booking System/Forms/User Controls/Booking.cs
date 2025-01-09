using System;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class Booking : UserControl
    {
        public Booking()
        {
            InitializeComponent();
        }

        public static Reserver r;
        public static Ticket s;
        public static Bus B;


        private void button1_Click(object sender, EventArgs e)

        {

            new ConfirmTicket(this).ShowDialog();

        }


        private void Booking_Load(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookingTicketNotextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void BookingTravellingToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BookingTicketNotextBox_MouseHover(object sender, EventArgs e)
        {
            Random generator = new Random();

            int randomValue;

            randomValue = generator.Next(10000, 900000);

            int x = randomValue;

            BookingTicketNotextBox.Text = x.ToString();
        }

        private void BookingSeatsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BookingSeatsTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}