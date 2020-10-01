using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventSys
{
    public partial class frmAddEvent : Form
    {

        frmMainMenu parent;

        public frmAddEvent()
        {
            InitializeComponent();
        }

        public frmAddEvent(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            //Assign next Event ID
            txtEventID.Text = Convert.ToString(Event.getNextID());

            //Load VenueIDs from Venues File WHERE Status = "Available" 
            List<String> venues = Venue.fillComboBox();
            cboVenueName.Items.AddRange(venues.ToArray());

            //Load Types from EventTypes File  
            List<String> types = Type.fillComboBoxTypes();
            cboTypes.Items.AddRange(types.ToArray());

            cboAmPm.SelectedIndex = 1;
            pnlEvDetails.Visible = false;
        }

        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            //validate Data

           
                if (cboVenueName.SelectedIndex != -1 && txtTitle.Text != "" && cboTypes.SelectedIndex != -1 && txtHour.Text != "" && txtMin.Text != "" && txtTickets.Text != "" && txtPrice.Text != "")
            {

                //Set venue details to get access to ID
                Venue eventVenue = new Venue();
                eventVenue.setName(cboVenueName.Text);
                eventVenue.setVenueDetails();

                //Set new event no tickets and venue id
                Event newEvent = new Event();
                newEvent.setTickets(Convert.ToInt32(txtTickets.Text));
                newEvent.setVenueID(eventVenue.getID());

                //Check the venues capacity
                if (newEvent.isVenueBigEnough())
                {
                    //Access the Type ID through it's description
                    Type eventType = new Type();
                    eventType.setName(cboTypes.Text);
                    eventType.setTypeDetails();

                    //Correct the format of the time 
                    string time;
                    int hour = Convert.ToInt32(txtHour.Text);
                    int mins = Convert.ToInt32(txtMin.Text);

                    if ((hour > 0 && hour < 13) && (mins >= 0 && mins < 60))
                    {

                        //If pm add 12 hours to make 24 hr format
                        if (cboAmPm.Text.Equals("pm") && hour < 12)
                        {
                            hour += 12;
                        }

                        time = hour + ":" + txtMin.Text;

                        //get the new event details
                        newEvent.setID(Convert.ToInt32(txtEventID.Text));
                        newEvent.setTitle(txtTitle.Text);
                        newEvent.setDesc(txtDescription.Text);
                        newEvent.setType(eventType.getID());
                        newEvent.setDate(txtDate.Text);
                        newEvent.setTime(time);
                        newEvent.setTickets(Convert.ToInt32(txtTickets.Text));
                        newEvent.setPrice(Convert.ToDouble(txtPrice.Text));


                        //Ask user to confirm
                        DialogResult confirmation = MessageBox.Show("The new Event details you have entered are: \n" +
                                                                    newEvent.toString() + "\n\nWould you like to add this event?,",
                                                                     "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (confirmation == DialogResult.Yes)
                        {

                            //Add the new event to the events file
                            newEvent.addEvent();

                            MessageBox.Show("Event has been added - Customers can now purchase Tickets", "New Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Reset UI
                            txtTitle.Clear();
                            txtDescription.Clear();
                            cboVenueName.SelectedIndex = -1;
                            cboTypes.SelectedIndex = -1;
                            txtTickets.Clear();
                            txtPrice.Clear();
                            txtHour.Clear();
                            txtMin.Clear();
                            cboVenueName.Focus();
                            txtDate.Value = DateTime.Now;
                            txtEventID.Text = Convert.ToString(Event.getNextID());
                            pnlEvDetails.Visible = false;
                            


                        }


                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid time", "Invalid Time!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHour.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("For Health & Safety reasons you may NOT sell more tickets than the capacity of your Venue!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTickets.Clear();
                    txtTickets.Focus();
                }               
            }
            else
            {
                MessageBox.Show("Information Missing", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }   
        }


        private void txtDate_ValueChanged(object sender, EventArgs e)
        {
            if (cboVenueName.SelectedIndex >= 0)
            {
                Venue checkVenue = new Venue();
                //Assign rest of attributes to the venue object
                checkVenue.setName(cboVenueName.Text);
                checkVenue.setVenueDetails();

                Event newEvent = new Event();
                //Assign venueID and date to Event
                newEvent.setVenueID(checkVenue.getID());
                newEvent.setDate(txtDate.Text);

                //check if event is on the same date in the same venue
                if (newEvent.isVenueFree())
                {
                    pnlEvDetails.Visible = true;
                }
                else
                {
                    MessageBox.Show("Your Venue already has an event scheduled for " + newEvent.getDate(), "Existing Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlEvDetails.Visible = false;
                }

            }

        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTickets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

