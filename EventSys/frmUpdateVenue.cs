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
    public partial class frmUpdateVenue : Form
    {
        frmMainMenu parent;

        public frmUpdateVenue()
        {
            InitializeComponent();
        }

        public frmUpdateVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void frmUpdateVenue_Load(object sender, EventArgs e)
        {
            //load venue names to UI
            
            List<String> venues = Venue.fillComboBox();
            cboVenueNames.Items.AddRange(venues.ToArray());
        }



        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboVenueNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlUpdateVenue.Visible = true;

            string selected = cboVenueNames.Text;

            Venue selectedVenue = new Venue();

            selectedVenue.setName(selected);

            selectedVenue.setVenueDetails();

            txtVenueName.Text = selectedVenue.getName();
            txtStreet.Text = selectedVenue.getStreet();
            txtTown.Text = selectedVenue.getTown();
            txtCapacity.Text = Convert.ToString(selectedVenue.getCapacity());
            txtContactNo.Text = selectedVenue.getContactNo();
            txtEmail.Text = selectedVenue.getEmail();
            txtPassword.Text = selectedVenue.getPassword();

        }

        private void btnUpdateVenue_Click(object sender, EventArgs e)
        {
            //Validate data entered 

            if (!txtVenueName.Text.Equals("") && !txtStreet.Text.Equals("") && !txtTown.Text.Equals("") && !txtEmail.Text.Equals("") &&
                !txtCapacity.Text.Equals("") && !txtContactNo.Text.Equals("") && !txtPassword.Text.Equals(""))
            {

                Venue myVenue = new Venue();


                myVenue.setName(txtVenueName.Text);
                myVenue.setVenueDetails();
                myVenue.setStreet(txtStreet.Text);
                myVenue.setTown(txtTown.Text);
                myVenue.setCapacity(Convert.ToInt32(txtCapacity.Text));
                myVenue.setContactNo(txtContactNo.Text);
                myVenue.setEmail(txtEmail.Text);
                myVenue.setPassword(txtPassword.Text);

               

                if (!myVenue.isRegisteredWithID())
                {

                    //Ask user to confirm
                    DialogResult confirmation = MessageBox.Show("The new Venue details you have entered are: \n" +
                                                                myVenue.toString() + "\n\nWould you like to update this venue?,",
                                                                 "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (confirmation == DialogResult.Yes)
                    {

                        myVenue.updateVenue();

                        MessageBox.Show("Your venue details have been updated.", "Venue Updated!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Reset UI
                        //Reset Combo Box

                        txtVenueName.Clear();
                        txtStreet.Clear();
                        txtTown.Clear();
                        txtCapacity.Clear();
                        txtContactNo.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        cboVenueNames.SelectedIndex = -1;
                        cboVenueNames.Focus();
                        pnlUpdateVenue.Visible = false;
                    }

                   
                }
                else
                {
                    MessageBox.Show("Venue Name already exists" , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVenueName.Clear();
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
