using Bus_Booking_System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Sql = new SqlConnection(@"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True");
        SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if(Sql.State==ConnectionState.Closed)
            {
                Sql.Open();
            }
           
            SqlCommand s = new SqlCommand("Select * from Registration where UserName = " + "'" + LoginUserNametextBox.Text + "'" +" and Password = "+ "'" + LoginPasswordtextBox.Text + "'",Sql);
            table.Clear();
            apt.SelectCommand = s;
            apt.Fill(table);
            
            if(table.Rows.Count==1)
            {
               
                Form_Dashboard f = new Form_Dashboard();
                f.ShowDialog();
              
                //LoginPasswordtextBox.Text = "";
                //LoginUserNametextBox.Text = "";
              

            }
            else
            {
                IncorrectNamePassword n = new IncorrectNamePassword();
                n.ShowDialog();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void button8_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
    

