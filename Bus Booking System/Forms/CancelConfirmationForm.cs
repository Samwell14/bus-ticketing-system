using MySql.Data.MySqlClient;
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
            string connectionString = "server=localhost;uid=root;pwd=Samii@122;database=bus_ticketing_system";
            string cnic = c.CancellationCNICtextBox.Text;
            string ticketId = c.CancellationTicketNotextBox.Text;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Ticket WHERE CNIC = @CNIC AND TicketNo = @TicketID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CNIC", cnic);
                        cmd.Parameters.AddWithValue("@TicketID", ticketId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            ErrorCancellationForm err = new ErrorCancellationForm();
                            err.label1.Text = "Ticket Cancelled Successfully";
                            err.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No ticket found with the provided CNIC and Ticket ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}

