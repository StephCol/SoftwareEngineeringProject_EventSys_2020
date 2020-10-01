using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSys
{
   

    public partial class frmCancelBooking : Form
    {
        private frmMainMenu parent;

        public frmCancelBooking()
        {
            InitializeComponent();
        }

        public frmCancelBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void btnLoadBookings_Click(object sender, EventArgs e)
        {
            //Validate Email & password combination
            if (!txtEmail.Text.Equals("") || !txtPassword.Text.Equals(""))
            {

                Customer cust = new Customer();
                cust.setEmail((txtEmail.Text).ToLower());
                cust.setPassword(txtPassword.Text);
                

                if (cust.isValidLogin())
                {
                    cust.setCustDetails();

                    if (cust.hasBookings())
                    {

                        pnlBookings.Visible = true;
                        txtEmail.Enabled = false;
                        txtPassword.Enabled = false;
                        btnLoadBookings.Enabled = false;


                        grdBookings.DataSource = Booking.getMyBookings(cust.getID()).Tables["WS"];

                    }
                    else
                    {
                        MessageBox.Show("There are no upcoming bookings associated with your account! ", "No Bookings Available!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtEmail.Focus();
                    }
                }
                else
                    MessageBox.Show("Your Email or Password is incorrect", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter a valid Email or Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();

            }
            
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            Booking myBooking = new Booking();

            string condition ="";

            //gets the selected rows id
            myBooking.setID(Convert.ToInt32(grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells[0].Value.ToString()));
            myBooking.setBookingDetails();

            string refund = "";

            if (myBooking.isMoreThan24())
            {
                condition = "Your booking is now cancelled and your tickets have been refunded";
                refund = "Your account will be refunded immeadiatly";
            }
            else
            {
                condition = "Your booking is now cancelled however you will NOT be refunded";
                refund = "Your account will NOT be refunded";
            }


            DialogResult confirmation = MessageBox.Show("Are you sure you want to cancel the selected booking? \n " + refund,
                                                             "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            

            if (confirmation == DialogResult.Yes)
            {
                
                myBooking.cancelBooking(myBooking.isMoreThan24());

                pnlBookings.Visible = false;
                txtEmail.Enabled = true;
                txtPassword.Enabled = true;
                txtEmail.Clear();
                txtPassword.Clear();
                btnLoadBookings.Enabled = true;
                txtEmail.Focus();

                MessageBox.Show(condition, "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            grdBookings.DataSource = Booking.getMyBookings(myBooking.getCustID()).Tables["WS"];


        }

    

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelBooking.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }
    }
}
