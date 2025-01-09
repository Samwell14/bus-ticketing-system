using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bus_Booking_System.Forms.User_Controls
{
    public partial class ChangeDestination : Form
    {
        public ChangeDestination()
        {
            InitializeComponent();
        }

        MySqlConnection Sql = new MySqlConnection("Server=localhost;Database=bus_booking_system;Uid=root;Pwd=Samii@122;");
        MySqlDataAdapter apt = new MySqlDataAdapter();
        DataTable table = new DataTable();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sql.State == ConnectionState.Closed)
                {
                    Sql.Open();
                }

                MySqlCommand a = new MySqlCommand("Select * from Ticket where TicketNo = @TicketNo and CNIC = @CNIC", Sql);
                a.Parameters.AddWithValue("@TicketNo", ChangeDesTicketNtextBox.Text);
                a.Parameters.AddWithValue("@CNIC", ChangeDesCNICtextBox.Text);

                table.Clear();
                apt.SelectCommand = a;
                apt.Fill(table);

                if (table.Rows.Count == 0)
                {
                    ErrorCancellationForm E = new ErrorCancellationForm();
                    E.ShowDialog();
                }
                else
                {
                    MySqlCommand s = new MySqlCommand("Update Ticket SET TravellingTo = @TravellingTo WHERE TicketNo = @TicketNo and CNIC = @CNIC", Sql);
                    s.Parameters.AddWithValue("@TravellingTo", ChangeDesTravellingToComboBox.Text);
                    s.Parameters.AddWithValue("@TicketNo", ChangeDesTicketNtextBox.Text);
                    s.Parameters.AddWithValue("@CNIC", ChangeDesCNICtextBox.Text);
                    s.ExecuteNonQuery();
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while updating the destination. Please try again later. Error: " + ex.Message);
            }
            finally
            {
                if (Sql.State == ConnectionState.Open)
                {
                    Sql.Close();
                }
            }
        }
    }
}