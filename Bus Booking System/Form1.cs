using Bus_Booking_System.Forms.User_Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(BusManagement.connectionString); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand q = new SqlCommand("SELECT * FROM Booking", conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = q;
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            ReportDataSource source = new ReportDataSource("DataSet",table);



        
            this.reportViewer1.LocalReport.DataSources.Add(source);
            // TODO: This line of code loads data into the 'BusBookingSystemDataSet.Booking' table. You can move, or remove it, as needed.
            this.BookingTableAdapter.Fill(this.BusBookingSystemDataSet.Booking);

            this.reportViewer1.RefreshReport();
        }
    }
}
