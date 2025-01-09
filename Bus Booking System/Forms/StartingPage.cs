using System;
using System.Windows.Forms;

namespace Bus_Booking_System.Forms
{
    public partial class StartingPage : Form
    {
        public StartingPage()
        {
            InitializeComponent();
        }

        private void Registrationbutton_Click(object sender, EventArgs e)
        {
            Login d = new Login();
            d.ShowDialog();


        }

        private void RegisterStartButton_click(object sender, EventArgs e)
        {
            REGISTERFINALFORM r = new REGISTERFINALFORM();
            r.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            REGISTERFINALFORM r = new REGISTERFINALFORM();
            r.ShowDialog();
        }

        private void StartingPage_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
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

        }
    }
}
