using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Booking_System.Forms.User_Controls
{
    public partial class BusManagement : UserControl
    {
        public static string connectionString = @"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True";
        public BusManagement()
        {
            InitializeComponent();
        }
        SqlConnection Sql = new SqlConnection(connectionString);
        SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeDestination cd = new ChangeDestination();
            cd.ShowDialog();
            
            
            
        }

        private void BusManagementdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
               
            }
        }

        private void BusManagement_Load(object sender, EventArgs e)
        {
            if (Sql.State == ConnectionState.Closed)
            {
                Sql.Open();
            }

            SqlCommand s = new SqlCommand("Select * from Booking", Sql);
            table.Clear();
            apt.SelectCommand = s;
            apt.Fill(table);
            //SqlDataReader dataread = s.ExecuteReader();
            //dataread.Read();
            BusManagementdataGridView.DataSource = table;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Name")
            {
                (BusManagementdataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", textBox1.Text);
            }
            else if(comboBox1.Text=="CNIC")
            {
                (BusManagementdataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CNIC LIKE '{0}%'", textBox1.Text);
            }
        }
    }
 }
    


 