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
    public partial class frmCancelEvent : Form
    {
        frmMainMenu parent;

        public frmCancelEvent()
        {
            InitializeComponent();
        }


        public frmCancelEvent(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmCancelEvent_Load(object sender, EventArgs e)
        {
            List<String> events = Event.fillComboBoxEvents();
            cboEventTitles.Items.AddRange(events.ToArray());

            cboCancellation.Items.Add("Artist Unavailable");
            cboCancellation.Items.Add("Venue Unavailable");
            cboCancellation.Items.Add("Unforseen Circumstances");
            cboCancellation.Items.Add("Other");

            grpDetails.Visible = false;

        }
    

        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void btnCancelEvent_Click_1(object sender, EventArgs e)
        {
           
            //Ask user to confirm
            DialogResult confirmation = MessageBox.Show("Are you sure you want to cancel this Event?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (confirmation == DialogResult.Yes)
            {
                //if yes set status of event to "Cancelled" in the Events File
                //Increase the balance of the customers that had a booking for the event
                //Send an email to notify customers of cancellation

                Event cancelledEvent = new Event();
                cancelledEvent.setTitle(txtTitle.Text);
                cancelledEvent.setEventDetails();

                cancelledEvent.cancelEvent();



                MessageBox.Show("Event has been cancelled! Customers have been refunded and notified that the event was cancelled due to:\n\n" +
                   cboCancellation.Text , "Event Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Reset UI 
            grpDetails.Visible = false;
            cboCancellation.SelectedIndex = -1;
            cboEventTitles.SelectedIndex = -1;



        }

            private void cboCancellation_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCancellation.SelectedIndex >= 0)
            {
                grpDetails.Visible = true;
            }
        }

        private void cboEventTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEventTitles.SelectedIndex >= 0)
            {

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

    }
}
