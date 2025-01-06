using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bus_Booking_System.Forms;

namespace Bus_Booking_System
{
    public partial class Cancellation : UserControl
    {
        public Cancellation()
        {
            InitializeComponent();
        }
        //public static string ticketNo;
        //public static string CnIC;


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CancellationTicketNotextBox.Text) || string.IsNullOrEmpty(CancellationCNICtextBox.Text))

            {
                SomethingMissing s = new SomethingMissing();
                s.ShowDialog();
            }
            else
            {
                //ticketNo = CancellationTicketNotextBox.Text;
                //CnIC = CancellationCNICtextBox.Text;
                using (CancelConfirmationForm f = new CancelConfirmationForm(this))
                {
                    f.ShowDialog();
                    //CancellationCNICtextBox.Text = "";
                    //CancellationTicketNotextBox.Text = "";
                }
               
            }
        }
    }
}
