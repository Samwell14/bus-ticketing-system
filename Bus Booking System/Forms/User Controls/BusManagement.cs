using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bus_Booking_System.Forms.User_Controls
{
    public partial class BusManagement : UserControl
    {
        public static string connectionString = "server=localhost;database=bus_ticketing_system;user=root;password=Samii@122";


        public BusManagement()
        {
            InitializeComponent();
        }

        MySqlConnection Sql = new MySqlConnection(connectionString);
        MySqlDataAdapter apt = new MySqlDataAdapter();
        DataTable table = new DataTable();

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeDestination cd = new ChangeDestination();
            cd.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            try
            {
                MySqlCommand s = new MySqlCommand("SELECT * FROM Ticket", Sql);
                table.Clear();
                apt.SelectCommand = s;
                apt.Fill(table);
                BusManagementdataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Sql.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Name")
            {
                (BusManagementdataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '{0}%'", textBox1.Text);
            }
            else if (comboBox1.Text == "CNIC")
            {
                (BusManagementdataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("CNIC LIKE '{0}%'", textBox1.Text);
            }
        }
    }
}