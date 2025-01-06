using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bus_Booking_System.Forms;
using Bus_Booking_System.Forms.User_Controls;

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

            if (string.IsNullOrEmpty(BookingTicketNotextBox.Text) || string.IsNullOrEmpty(BookingNameTextbox.Text) || string.IsNullOrEmpty(BookingCNICTextbox.Text) ||
                  string.IsNullOrEmpty(BookingDepartureFromCombobox.Text) || string.IsNullOrEmpty(BookingPhoneNoTextbox.Text) || string.IsNullOrEmpty(BookingSeatsTextBox.Text) ||
                      string.IsNullOrEmpty(BookingTravellingToComboBox.Text))
            {
                SomethingMissing s = new SomethingMissing();
                s.ShowDialog();
            }
            else
            {
                r = new Reserver(BookingNameTextbox.Text, Convert.ToDecimal(BookingCNICTextbox.Text), BookingPhoneNoTextbox.Text);
                s = new Ticket(Convert.ToInt32(BookingTicketNotextBox.Text), BookingDepartureFromCombobox.SelectedItem.ToString(), BookingTravellingToComboBox.SelectedItem.ToString(), BookingDatePicker.Value = new DateTime(BookingDatePicker.Value.Year, BookingDatePicker.Value.Month, BookingDatePicker.Value.Day, (int)BookingnumericUpdown1.Value, (int)BookingNumericUpdown2.Value, (int)BookingNumericUpdown3.Value));
                B = new Bus(Convert.ToInt32(BookingSeatsTextBox.Text));

                //using (ConfirmTicket a = new ConfirmTicket("asd", "sad"))
                //{
                //    a.ShowDialog();
                //}
                ConfirmTicket ct = new ConfirmTicket(BookingTravellingToComboBox.Text, BookingSeatsTextBox.Text,this);

                ct.ShowDialog();



            }

            

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
    }
}