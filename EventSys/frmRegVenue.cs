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
    public partial class frmRegVenue : Form
    {

        frmMainMenu parent;

        public frmRegVenue()
        {
            InitializeComponent();
        }

        public frmRegVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Assign next venue ID
            txtVenueID.Text = Convert.ToString(Venue.getNextID());
        }


        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void btnRegVenue_Click_1(object sender, EventArgs e)
        {

            //Validate data entered 



            if (!txtStreet.Text.Equals("") || !txtTown.Text.Equals("") || !txtEmail.Text.Equals("") ||
                !txtCapacity.Text.Equals("") || !txtContactNo.Text.Equals("") || !txtEmail.Text.Equals("") || !txtPassword.Text.Equals(""))
            {
                Venue myVenue = new Venue();

                myVenue.setID(Convert.ToInt32(txtVenueID.Text));
                myVenue.setName(txtVenueName.Text);
                myVenue.setStreet(txtStreet.Text);
                myVenue.setTown(txtTown.Text);
                myVenue.setCapacity(Convert.ToInt32(txtCapacity.Text));
                myVenue.setContactNo(txtContactNo.Text);
                myVenue.setEmail(txtEmail.Text);
                myVenue.setPassword(txtPassword.Text);
                myVenue.setStatus('y');

                if (!myVenue.isRegistered())
                {

                    //Ask user to confirm
                    DialogResult confirmation = MessageBox.Show("The new Venue details you have entered are: \n" +
                                                                myVenue.toString() + "\n\nWould you like to add this venue?,",
                                                                 "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                    if (confirmation == DialogResult.Yes)
                    {
                        //Save data to Venues File
                        myVenue.registerVenue();

                        //Display Confirmation Message
                        MessageBox.Show("Venue Registered - You may now add events to the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Reset UI
                        txtVenueName.Clear();
                        txtStreet.Clear();
                        txtTown.Clear();
                        txtCapacity.Clear();
                        txtContactNo.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtVenueName.Focus();
                        txtVenueID.Text = Convert.ToString(Venue.getNextID());

                    }
                }
                else
                {
                    MessageBox.Show("Venue Name already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVenueName.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Information Missing", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;

            }


        }

        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        


    }
}
