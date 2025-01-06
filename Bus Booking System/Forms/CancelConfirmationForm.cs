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
            if (Sql.State == ConnectionState.Closed)
            {
                Sql.Open();
            }
            
            SqlCommand a = new SqlCommand("Select * from Booking where TicketNo = " + "'" + c.CancellationTicketNotextBox.Text/*Cancellation.ticketNo*/ + "'" + " and CNIC = " + "'" + c.CancellationCNICtextBox.Text/*Cancellation.CnIC*/ + "'", Sql);
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
                
                SqlCommand s = new SqlCommand("Delete from Booking where TicketNo= '" + c.CancellationTicketNotextBox.Text/*Cancellation.ticketNo*/ + "'" + " and CNIC = '" + c.CancellationCNICtextBox.Text/*Cancellation.CnIC*/ + "'", Sql);
                s.ExecuteNonQuery();
                this.Close();
                c.CancellationCNICtextBox.Text = "";
                c.CancellationTicketNotextBox.Text = "";


            }
            

        }
    }
}

