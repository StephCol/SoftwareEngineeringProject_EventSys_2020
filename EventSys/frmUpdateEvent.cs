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
    public partial class frmUpdateEvent : Form
    {
        frmMainMenu parent;

        public frmUpdateEvent()
        {
            InitializeComponent();
        }

        public frmUpdateEvent(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void frmUpdateEvent_Load(object sender, EventArgs e)
        {
            List<String> events = Event.fillComboBoxEvents();
            cboEventTitles.Items.AddRange(events.ToArray());

            List<String> types = Type.fillComboBoxTypes();
            cboTypes.Items.AddRange(types.ToArray());

            cboAmPm.SelectedIndex = 1;
        }

     
        private void btnUpdateEvent_Click_1(object sender, EventArgs e)
        {
            //validate Data

            if (txtTitle.Text != "" && cboTypes.SelectedIndex != -1 && txtDate.Text != ""
                && txtHour.Text != "" && txtMin.Text != ""  && txtTickets.Text != "" && txtPrice.Text != "")
            {

                //if there are other events on same date with same venueID
                //Error- Clashing Events
                Event newEvent = new Event();
                newEvent.setTitle(cboEventTitles.Text);
                newEvent.setEventDetails();

                Venue eventVenue = new Venue();
                eventVenue.setID(newEvent.getVenueId());
                eventVenue.setVenueDetails();

                newEvent.setTickets(Convert.ToInt32(txtTickets.Text));

                //Tickets Available cannot be more than Capacity
                //Error - Capacity Exceeded
                if (newEvent.isVenueBigEnough())
                {
                    Type eventType = new Type();
                    eventType.setName(cboTypes.Text);
                    eventType.setTypeDetails();

                    newEvent.setType(eventType.getID());
                    newEvent.setDate(txtDate.Text);

                    string time;
                    int hour = Convert.ToInt32(txtHour.Text);
                    int mins = Convert.ToInt32(txtMin.Text);

                    if((hour > 0 && hour < 13) && (mins >= 0 && mins < 60))
                    {
                        //If pm add 12 hours to make 24 hr format
                        if (cboAmPm.Text.Equals("pm") && hour < 12)
                        {
                            hour += 12;
                        }

                        time = hour + ":" + txtMin.Text;

                        newEvent.setTime(time);
                        newEvent.setPrice(Convert.ToDouble(txtPrice.Text));


                        //check if event is on the same date in the same venue
                        if (newEvent.isVenueFree())
                        {
                            newEvent.setTitle(txtTitle.Text);
                            newEvent.setDesc(txtDescription.Text);


                            //Ask user to confirm
                            DialogResult confirmation = MessageBox.Show("The new Event details you have entered are: \n" +
                                                                        newEvent.toString() + "\n\nWould you like to update the event?,",
                                                                         "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (confirmation == DialogResult.Yes)
                            {
                                //if yes System save data to Events File
                                newEvent.updateEvent();

                                //Email Customers with Updates

                                MessageBox.Show("Event has been updated - Customers with existing tickets will be contacted and updated", "New Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Reset UI
                                cboEventTitles.SelectedIndex = -1;
                                pnlUpdateEvent.Visible = false;
                                txtTitle.Clear();
                                txtDescription.Clear();
                                cboTypes.SelectedIndex = -1;
                                txtDate.Refresh();
                                txtHour.Clear();
                                txtMin.Clear();
                                txtTickets.Clear();
                                txtPrice.Clear();
                              

                            }

                        }
                        else
                        {
                            MessageBox.Show("Your Venue already has an event scheduled for " + newEvent.getDate(), "Existing Event!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtDate.Focus();
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
                return;
            }

        
        }

        private void mnuBack_Click_1(object sender, EventArgs e)
        {

            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void cboEventTitles_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEventTitles.SelectedIndex >= 0)
            {
                pnlUpdateEvent.Visible = true;

                //Load Event information to text boxes
                string selected = cboEventTitles.Text;

                //Create an event with the title selected
                Event selectedEvent = new Event();
                selectedEvent.setTitle(selected);

                //Assign the event details to the event object
                selectedEvent.setEventDetails();

                //Get type name from its ID
                Type type = new Type();
                type.setID(selectedEvent.getType());
                type.setTypeDetails();


                //Get time in hours and minutes
                string time = selectedEvent.getTime();
                string hours = time[0] + "" + time[1]; //index out of bounds
                string mins = time[3] + "" + time[4];


                //Fill text boxes with the selected event details
                txtTitle.Text = selectedEvent.getTitle();
                txtDescription.Text = selectedEvent.getDesc();
                txtDate.Text = selectedEvent.getDate();
                txtHour.Text = hours;
                txtMin.Text = mins;
                cboTypes.Text = type.getName();
                txtTickets.Text = Convert.ToString(selectedEvent.getTickets());
                txtPrice.Text = Convert.ToString(selectedEvent.getPrice());
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
    }

