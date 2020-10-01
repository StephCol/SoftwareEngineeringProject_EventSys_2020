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
    public partial class frmDeleteVenue : Form
    {
        frmMainMenu parent;
        public frmDeleteVenue()
        {
            InitializeComponent();
        }

        public frmDeleteVenue(frmMainMenu Parent )
        {
            InitializeComponent();
            parent = Parent;
        }


        private void frmDeleteVenue_Load(object sender, EventArgs e)
        {
            //load room types to UI


            List<String> venues = Venue.fillComboBox();

            cboVenueNames.Items.AddRange(venues.ToArray());
        }



        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); //close the form       
            parent.Show();
        }

        private void cboVenueNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenueNames.SelectedIndex >= 0)
            {
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

                pnlDeleteVenue.Visible = true;
            }
        }

        private void btnDelVenue_Click(object sender, EventArgs e)
        {
            //Validation
            string selected = cboVenueNames.Text;

            Venue selectedVenue = new Venue();

            selectedVenue.setName(selected);

            selectedVenue.setVenueDetails();


            //Check that Venue has no events beyond todays date
            if (!selectedVenue.checkIfUpcomingEvents())
            {
                //if no upcoming events

                //Ask user to confirm
                DialogResult confirmation = MessageBox.Show("Are you sure you want to delete Venue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (confirmation == DialogResult.Yes)
                {
                    selectedVenue.deleteVenue();
                    //if yes set status of venue to "Unavailable" in the Venues File
                    MessageBox.Show("Venue has been removed from the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                //Display error message
                MessageBox.Show("Please cancel upcoming events before deregistering from the system.", "Cancel Events", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }

            txtVenueName.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCapacity.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            pnlDeleteVenue.Visible = false;
            cboVenueNames.SelectedIndex = -1;
            cboVenueNames.Focus();
           

        }
    }
}
