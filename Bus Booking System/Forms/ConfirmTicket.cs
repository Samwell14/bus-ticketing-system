using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class ConfirmTicket : Form
    {
        Booking b;
        int price;
        int seat;

        public ConfirmTicket(Booking b)
        {
            InitializeComponent();
            this.b = b;
            string r = b.BookingTravellingToComboBox.SelectedItem.ToString();

            if (int.TryParse(b.BookingSeatsTextBox.Text, out seat))
            { }

            if (r == "Bisrate Gabriel")
            {
                price = 25;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Qera")
            {
                price = 30;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Haya Hule")
            {
                price = 35;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Gulele")
            {
                price = 25;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Akaky Kaliti")
            {
                price = 25;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Alemgena")
            {
                price = 40;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Ayer Tena")
            {
                price = 35;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Arada")
            {
                price = 20;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Mexico")
            {
                price = 25;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }
            else if (r == "Senga Tera")
            {
                price = 20;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }

            else if (r is string)
            {
                price = 25;
                price *= Convert.ToInt32(seat);
                Confirmtotalamounttxt.Text = price.ToString();
            }


        }




        //SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");


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
                try
                {
                    string filePath = @"C:\Tickets\Ticket.pdf";
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(filePath));

                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();
                    doc.Add(new Paragraph($"Name: {b.BookingNameTextbox.Text}"));
                    doc.Add(new Paragraph($"CNIC: {b.BookingCNICTextbox.Text}"));
                    doc.Add(new Paragraph($"Departure From: {b.BookingDepartureFromCombobox.Text}"));
                    doc.Add(new Paragraph($"Travelling To: {b.BookingTravellingToComboBox.Text}"));
                    doc.Add(new Paragraph($"Date: {b.BookingDatePicker.Value.ToString("yyyy-MM-dd")}"));
                    doc.Add(new Paragraph($"Seats: {b.BookingSeatsTextBox.Text}"));
                    doc.Add(new Paragraph($"Total Amount: {Confirmtotalamounttxt.Text}"));
                    doc.Add(new Paragraph($"Paid Amount: {ConfirmPaidAmounttextBox.Text}"));
                    doc.Add(new Paragraph($"Return Amount: {ConfirmReturnAmounttextBox.Text}"));
                    doc.Close();

                    MessageBox.Show("Ticket generated successfully at " + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while generating the ticket: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Confirmtotalamounttxt.Text) || string.IsNullOrEmpty(ConfirmPaidAmounttextBox.Text) || string.IsNullOrEmpty(ConfirmReturnAmounttextBox.Text))
            {
                SomethingMissing i = new SomethingMissing();
                i.ShowDialog();
            }
            else
            {
                //Payment p = new Payment(Convert.ToInt32(Confirmtotalamounttxt.Text), Convert.ToInt32(ConfirmPaidAmounttextBox.Text), Convert.ToInt32(ConfirmReturnAmounttextBox.Text));
                //if (Sql.State == ConnectionState.Closed)
                //{
                //    Sql.Open();
                //}

                try
                {
                    //DatabaseHelper dbhelper = new DatabaseHelper();
                    string connectionString = "server=localhost;database=bus_ticketing_system;user=root;password=Samii@122";

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        //string query = "INSERT INTO Users (Name, FatherName, CNIC, Gender, Password, City) VALUES (@Name, @FatherName, @CNIC, @Gender, @Password, @City)";
                        conn.Open();
                        string query = "INSERT INTO Ticket (TicketNo, Name, PhoneNo, CNIC, DepartureFrom, TravellingTo, Date, Seats, AmountPaid, ReturnAmount) VALUES (@TicketNo, @Name, @PhoneNo, @CNIC, @DepartureFrom, @TravellingTo, @Date, @Seats, @AmountPaid, @ReturnAmount)";
                        MySqlCommand s = new MySqlCommand(query, conn);
                        s.Parameters.AddWithValue("@TicketNo", b.BookingTicketNotextBox.Text);
                        s.Parameters.AddWithValue("@Name", b.BookingNameTextbox.Text);
                        s.Parameters.AddWithValue("@PhoneNo", b.BookingPhoneNoTextbox.Text);
                        s.Parameters.AddWithValue("@CNIC", b.BookingCNICTextbox.Text);
                        s.Parameters.AddWithValue("@DepartureFrom", b.BookingDepartureFromCombobox.SelectedItem.ToString());
                        s.Parameters.AddWithValue("@TravellingTo", b.BookingTravellingToComboBox.SelectedItem.ToString());
                        s.Parameters.AddWithValue("@Date", b.BookingDatePicker.Value);
                        s.Parameters.AddWithValue("@Seats", b.BookingSeatsTextBox.Text);
                        s.Parameters.AddWithValue("@AmountPaid", ConfirmPaidAmounttextBox.Text);
                        s.Parameters.AddWithValue("@ReturnAmount", ConfirmReturnAmounttextBox.Text);
                        if (s.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Ticket registered Succesfully");
                            return;
                        }
                    }

                    //SqlCommand s = new SqlCommand("INSERT INTO Ticket (TicketNo, Name, PhoneNo, CNIC, DepartureFrom, TravellingTo, Date, Seats, AmountPaid, ReturnAmount) VALUES (@TicketNo, @Name, @PhoneNo, @CNIC, @DepartureFrom, @TravellingTo, @Date, @Seats, @AmountPaid, @ReturnAmount)", Sql);


                    // Clear the booking form
                    b.BookingCNICTextbox.Text = "";
                    b.BookingDepartureFromCombobox.SelectedIndex = 0;
                    b.BookingNameTextbox.Text = "";
                    b.BookingPhoneNoTextbox.Text = "";
                    b.BookingSeatsTextBox.Text = "";
                    b.BookingTicketNotextBox.Text = "";
                    b.BookingTravellingToComboBox.SelectedIndex = 0;
                    b.BookingDatePicker.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                //finally
                //{
                //    Sql.Close();
                //}
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