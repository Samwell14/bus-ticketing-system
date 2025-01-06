using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Bus_Booking_System
{
    public partial class ConfirmTicket : Form
    {
        Booking b;
        int price;
        public ConfirmTicket(string city, string seat, Booking b)
        {
            this.b = b;
            InitializeComponent();


            if (city == "Islamabad")
            {
                price = 3000;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Multan")
            {
                price = 2000;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Lahore")
            {
                price = 2500;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Sukkur")
            {
                price = 1500;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Hyderabad")
            {
                price = 500;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Peshawar")
            {
                price = 2000;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Nawabshah")
            {
                price = 1800;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Larkana")
            {
                price = 1700;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Faisalabad")
            {
                price = 3000;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (city == "Thatta")
            {
                price = 500;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }


        }

        SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Confirmtotalamounttxt.Text) || string.IsNullOrEmpty(ConfirmPaidAmounttextBox.Text) || string.IsNullOrEmpty(ConfirmReturnAmounttextBox.Text))
            {
                SomethingMissing i = new SomethingMissing();
                i.ShowDialog();
            }
            else
            {
                ReportParameter[] param = { new ReportParameter("Name", b.BookingNameTextbox.Text), new ReportParameter("CNIC", b.BookingCNICTextbox.Text), new ReportParameter("DepartureFrom", b.BookingDepartureFromCombobox.Text), new ReportParameter("TicketNo", b.BookingTicketNotextBox.Text), new ReportParameter("Seats", b.BookingSeatsTextBox.Text), new ReportParameter("TravellingTo", b.BookingTravellingToComboBox.Text), new ReportParameter("Date", b.BookingDatePicker.Text), new ReportParameter("ReturnAmount", ConfirmReturnAmounttextBox.Text), new ReportParameter("PaidAmount", ConfirmPaidAmounttextBox.Text), new ReportParameter("TotalAmount", Confirmtotalamounttxt.Text), new ReportParameter("PhoneNo", b.BookingPhoneNoTextbox.Text), new ReportParameter("Time", b.BookingDatePicker.Value.ToShortTimeString()) };
                Receipt r = new Receipt();
                r.reportViewer1.LocalReport.SetParameters(param);
                r.reportViewer1.RefreshReport();
                r.ShowDialog();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Confirmtotalamounttxt.Text) || string.IsNullOrEmpty(ConfirmPaidAmounttextBox.Text) || string.IsNullOrEmpty(ConfirmReturnAmounttextBox.Text))
            {
                SomethingMissing i = new SomethingMissing();
                i.ShowDialog();
                //MessageBox.Show("SomeThing Missing");
            }

            
            else
            { 
                Payment p = new Payment(Convert.ToInt32(Confirmtotalamounttxt.Text), Convert.ToInt32(ConfirmPaidAmounttextBox.Text), Convert.ToInt32(ConfirmReturnAmounttextBox.Text));
                if (Sql.State == ConnectionState.Closed)
                {
                    Sql.Open();
                }
                SqlCommand s = new SqlCommand("Insert into Booking values('" + Booking.s.TICKETNO + "','" + Booking.r.NAME + "','" + Booking.r.PHONENO + "','" + Booking.r.CNIC + "','" + Booking.s.TREVELLINGTO + "','" + Booking.s.DEPARTUREFROM + "','" + Booking.s.DateTime + "','" + Booking.B.NOOFSEATS + "','" + p.TOTALAMOUNT + "','" + p.PAIDAMOUNT + "','" + p.RETURNAMOUNT + "')", Sql);
                s.ExecuteNonQuery();
                b.BookingCNICTextbox.Text = "";
                b.BookingDepartureFromCombobox.SelectedIndex = 0;
                b.BookingNameTextbox.Text = "";
                b.BookingPhoneNoTextbox.Text = "";
                b.BookingSeatsTextBox.Text = "";
                b.BookingTicketNotextBox.Text = "";
                b.BookingTravellingToComboBox.SelectedIndex = 0;
                b.BookingDatePicker.Text = "";
                //Booking.s.TICKETNO = 0;

            }
        
            
        }
    



        

        private void ConfirmTicket_Load(object sender, EventArgs e)
        {

        }

        private void totalamounttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmTicket_Load_1(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int a;
            //a = Convert.ToInt32(ConfirmPaidAmounttextBox.Text) -Convert.ToInt32(Confirmtotalamounttxt.Text);
            //ConfirmChangeAmountlabel.Text = a.ToString();
            //int PaidAmount = Convert.ToInt32(ConfirmPaidAmounttextBox.Text);
            //ConfirmChangeAmounttextBox.Text = ""+(PaidAmount - price).ToString();
        }

        private void ConfirmTicket_Load_2(object sender, EventArgs e)
        {
            
        }

        private void ConfirmChangeAmountlabel_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Confirmtotalamounttxt.Text) || string.IsNullOrEmpty(ConfirmPaidAmounttextBox.Text))
            {
                SomethingMissing i = new SomethingMissing();
                i.ShowDialog();

            }
            else
            {
                int PaidAmount = Convert.ToInt32(ConfirmPaidAmounttextBox.Text);
                ConfirmReturnAmounttextBox.Text = (PaidAmount - price).ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}