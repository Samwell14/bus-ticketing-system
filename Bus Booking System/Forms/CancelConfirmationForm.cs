using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class CancelConfirmationForm : Form
    {
        Cancellation c;
        public CancelConfirmationForm(Cancellation c)
        {
            this.c = c;
            InitializeComponent();

        }
        SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");
        SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ErrorCancellationForm err = new ErrorCancellationForm();
            err.label1.Text = "Ticket Cancelled Succesfully";
            err.ShowDialog();
        }
    }
}

