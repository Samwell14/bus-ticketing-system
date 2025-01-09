using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
            string gender = comboBox1.SelectedItem.ToString();
            string password = RegistrationPasswordTextbox.Text;
            string city = RegistrationCityTextBox.Text;
            decimal cnic = 0;
            string pattern = @"^[a-zA-Z\s]+$";

            try
            {

                if ((string.IsNullOrEmpty(name) || string.IsNullOrEmpty(fatherName) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(password)
                   || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(cnic.ToString())) || ((string.IsNullOrEmpty(name) && string.IsNullOrEmpty(fatherName) && string.IsNullOrEmpty(gender) && string.IsNullOrEmpty(cnic.ToString()) && string.IsNullOrEmpty(password)
                   || string.IsNullOrEmpty(city))))
                {
                    MessageBox.Show("Please insert all neccesary fields!");
                    return;
                }


                else if (!Regex.IsMatch(name, pattern) || !Regex.IsMatch(fatherName, pattern))
                {
                    MessageBox.Show("Please insert valid name or father name");
                    return;
                }

                else if (!Regex.IsMatch(city, pattern))
                {

                    MessageBox.Show("Please insert valid city name");
                    return;
                }

                if (!decimal.TryParse(RegistrationCNICTextbox.Text, out cnic))
                {
                    MessageBox.Show("Invalid CNIC format. Please enter a valid CNIC number.");
                    return;
                }

            }

            catch (NullReferenceException k)
            {
                MessageBox.Show("Please fill out all the Forms! " + k.Message);
            }



            DatabaseHelper dbHelper = new DatabaseHelper();
            bool success = dbHelper.RegisterUser(name, fatherName, cnic, gender, password, city);

            if (success)
            {
                ErrorCancellationForm f = new ErrorCancellationForm();
                f.label1.Text = "Registration successful!";
                f.ShowDialog();
            }
            else
            {
                ErrorCancellationForm f = new ErrorCancellationForm();
                f.label1.Text = "Registration failed! Please try again";
                f.ShowDialog();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
