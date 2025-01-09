using Bus_Booking_System.Forms;
using Bus_Booking_System.Forms.User_Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bus_Booking_System
{
    public partial class Form_Dashboard : Form
    {
        //public static string connectionString = @"Data Source=HAIER-PC;Initial Catalog=BusBookingSystem;Integrated Security=True";
        int PanelWidth;
        bool isCollapsed;
        //SqlConnection Sql = new SqlConnection(connectionString);
        //SqlDataAdapter apt = new SqlDataAdapter();
        DataTable table = new DataTable();

        public Form_Dashboard()
        {
            InitializeComponent();
            timer2Time.Start();

            isCollapsed = false;
            PanelWidth = PanelLeft.Width;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MoveSidePanel(BookingDetailsButton);
            Booking b = new Booking();
            AddControlstoPanel(b);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                if (panelControls1.Controls.Count > 0 && panelControls1.Controls[0] is BusManagement)
                {
                    BusManagement b = (BusManagement)panelControls1.Controls[0];
                    b.Visible = false;
                }
                PanelLeft.Width = PanelLeft.Width + 10;
                if (PanelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                    if (panelControls1.Controls.Count > 0 && panelControls1.Controls[0] is BusManagement)
                    {
                        BusManagement b = (BusManagement)panelControls1.Controls[0];
                        b.Visible = true;
                    }
                }
            }
            else
            {
                if (panelControls1.Controls.Count > 0 && panelControls1.Controls[0] is BusManagement)
                {
                    BusManagement b = (BusManagement)panelControls1.Controls[0];
                    b.Visible = false;
                }
                PanelLeft.Width = PanelLeft.Width - 10;
                {
                    if (PanelLeft.Width <= 60)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                        this.Refresh();
                        if (panelControls1.Controls.Count > 0 && panelControls1.Controls[0] is BusManagement)
                        {
                            BusManagement b = (BusManagement)panelControls1.Controls[0];
                            b.Visible = true;
                        }
                    }

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void MoveSidePanel(Control btn)
        {
            PanelSide.Top = btn.Top;
            PanelSide.Height = btn.Height;

        }

        private void AddControlstoPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls1.Controls.Clear();
            panelControls1.Controls.Add(c);
        }

        private void BusMangbtn_Click(object sender, EventArgs e)
        {
            MoveSidePanel(BusMangbtn);
            BusManagement bs = new BusManagement();
            AddControlstoPanel(bs);
        }

        private void RouteDetailsButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(RouteDetailsButton);
            RouteDetails r = new RouteDetails();
            AddControlstoPanel(r);
        }

        private void CancellationButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(CancellationButton);
            Cancellation c = new Cancellation();
            AddControlstoPanel(c);
        }


        private void timer2Time_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void HelpInstrurctions_Click(object sender, EventArgs e)
        {
            MoveSidePanel(HelpInstrurctions);
            HelpInstruct g = new HelpInstruct();
            AddControlstoPanel(g);



        }

        private void panelControls1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
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

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (WindowState.ToString() == "Normal")
            //{
            //    this.WindowState = FormWindowState.Maximized;
            //}
            //else
            //{
            //    this.WindowState = FormWindowState.Normal;
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
