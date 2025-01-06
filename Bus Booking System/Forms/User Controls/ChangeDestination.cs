using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bus_Booking_System.Forms.User_Controls
{
    public partial class ChangeDestination : Form
    {
        public ChangeDestination()
        {
            InitializeComponent();
        }
        SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");
        SqlDataAdapter apt = new SqlDataAdapter();
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


            if (Sql.State == ConnectionState.Closed)
            {
                Sql.Open();
            }

            SqlCommand a = new SqlCommand("Select * from Booking where TicketNo = " + "'" + ChangeDesTicketNtextBox.Text + "'" + " and CNIC = " + "'" + ChangeDesCNICtextBox.Text + "'", Sql);
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
                SqlCommand s = new SqlCommand("Update Booking SET TravellingTo= '" + ChangeDesTravellingToComboBox.Text + "'" + "WHERE TicketNo='" + ChangeDesTicketNtextBox.Text + "'" + "and CNIC='" + ChangeDesCNICtextBox.Text + "'", Sql);
                s.ExecuteNonQuery();
                this.Close();

            }
            
        }
    }
}
