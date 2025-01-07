using Bus_Booking_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class REGISTERFINALFORM : Form
    {
        public REGISTERFINALFORM()
        {
            InitializeComponent();
        }
        SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationSuccessfulbutton_Click(object sender, EventArgs e)
        {
            string name = RegistrationNameTextbox.Text;
            string fatherName = RegistrationFathersNameTextbox.Text;
            //decimal cnic = decimal.Parse(RegistrationCNICTextbox.Text);
            string gender = RegistrationGenderTextbox.Text;
            string password = RegistrationPasswordTextbox.Text;
            string city = RegistrationCityTextBox.Text;
            decimal cnic;

            
            if (!decimal.TryParse(RegistrationCNICTextbox.Text, out cnic))
            {
                MessageBox.Show("Invalid CNIC format. Please enter a valid CNIC number.");
                return;
            }

            DatabaseHelper dbHelper = new DatabaseHelper();
            bool success = dbHelper.RegisterUser(name, fatherName, cnic, gender, password, city);

            if (success)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void REGISTERFINALFORM_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.055;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }
    }
}
