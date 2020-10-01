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
    public partial class frmMakeBooking : Form
    {
        frmMainMenu parent;

        public frmMakeBooking()
        {
            InitializeComponent();
        }

        public frmMakeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            //System loads list of Events including, name, venue, price 
            //where event is "Available" 

            grdEvents.DataSource = Event.getAvailableEvents().Tables["WS"];

            //Utility.formatEventGrid(grdEvents);


            //Load VenueIDs from Venues File WHERE Status = "Available" 
            List<String> venues = Venue.fillComboBox();
            cboVenue.Items.AddRange(venues.ToArray());

            //Load Types from EventTypes File  
            List<String> types = Type.fillComboBoxTypes();
            cboType.Items.AddRange(types.ToArray());

            List<String> towns = Event.fillComboBoxTowns();
            cboTown.Items.AddRange(towns.ToArray());

            pnlLogin.Visible = false;
            pnlBook.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();

        }


        private void btnBook_Click(object sender, EventArgs e)
        {


            Event myEvent = new Event();

            //gets the selected rows id
            myEvent.setTitle(grdEvents.Rows[grdEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
            myEvent.setEventDetails();

            if (Convert.ToInt32(txtNoTickets.Value) >= 1 && Convert.ToInt32(txtNoTickets.Value) <= 4)
            {

                if (Convert.ToInt32(txtNoTickets.Value) <= myEvent.getTickets())
                {


                    //Validate data
                    //Customers Balance must be more than No Tickets * price
                    if (Convert.ToDouble(txtPrice.Text) <= Convert.ToDouble(txtBal.Text))
                    {
                        Customer cust = new Customer();
                        cust.setEmail(txtEmail.Text);
                        cust.setPassword(txtPassword.Text);
                        cust.setCustDetails();

                        Booking newBooking = new Booking();
                        newBooking.setCustID(cust.getID());
                        newBooking.setEventID(myEvent.getID());
                        int tickets = Convert.ToInt32(txtNoTickets.Value);
                        newBooking.setTickets(tickets);
                        newBooking.setTotal(Convert.ToDouble(txtPrice.Text) + 2.5);

                        string evDate = myEvent.getDate();
                        string formatDate = evDate[0] + "" + evDate[1] + "" + evDate[2] + "" + evDate[3] + "" + evDate[4] + "" + evDate[5] + "" + evDate[6] + "" + evDate[7] + "" + evDate[8] + "" + evDate[9] + "" + evDate[10];

                        DialogResult confirmation = MessageBox.Show("Booking Details: \n\nEvent: " + myEvent.getTitle() + "\nDate: " + formatDate + "\nTime: " + myEvent.getTime() +
                                                                    "\n\nTickets: " + newBooking.getTickets() + "\nTotal (inc €2.50 Booking Fee): €" + newBooking.getTotal() + "\nNew Balance: €" + (cust.getBal() - newBooking.getTotal()) +
                                                                      "\n\nWould you like to continue with ths booking?,",
                                                                     "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                        if (confirmation == DialogResult.Yes)
                        {
                            MessageBox.Show("Thank you for booking, you will receive your tickets via email\n\nYour Booking Reference is : " + Booking.getNextID(), "Event Booked!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            newBooking.addBooking();


                            txtEmail.Enabled = true;
                            txtEmail.Clear();
                            txtPassword.Enabled = true;
                            txtPassword.Clear();
                            txtBal.Clear();
                            txtNoTickets.ResetText();
                            txtPrice.Clear();

                            grdEvents.Enabled = true;
                            btnLogin.Visible = true;
                            pnlBook.Visible = false;
                            pnlLogin.Visible = false;



                        }

                    }
                    else
                        MessageBox.Show("Insufficient funds - Please Top Up", "Insufficient Funds!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Sorry there are " + Convert.ToString(myEvent.getTickets()) + " tickets avaialable for this Event", "Tickets Unavailable!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Please select between 1 and 4 tickets for your selected event" , "Tickets Amount Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboType.SelectedIndex >= 0)
            {
                Type myType = new Type();
                myType.setName(cboType.Text);
                myType.setTypeDetails();

                grdEvents.DataSource = Event.getAvailableEventsFiltered("TypeID", Convert.ToString(myType.getID())).Tables["WS"];


                cboTown.SelectedIndex = -1;
                cboVenue.SelectedIndex = -1;
                cboPrice.SelectedIndex = -1;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grdEvents.DataSource = Event.getAvailableEvents().Tables["WS"];

            cboTown.SelectedIndex = -1;
            cboVenue.SelectedIndex = -1;
            cboPrice.SelectedIndex = -1;
            cboType.SelectedIndex = -1;
        }

        private void cboTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTown.SelectedIndex >= 0)
            {
                grdEvents.DataSource = Event.getAvailableEventsFiltered("Town", cboTown.Text).Tables["WS"];

                cboType.SelectedIndex = -1;
                cboVenue.SelectedIndex = -1;
                cboPrice.SelectedIndex = -1;
            }
        }

        private void cboVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenue.SelectedIndex >= 0)
            {
                Venue newVen = new Venue();
                newVen.setName(cboVenue.Text);
                newVen.setVenueDetails();

                grdEvents.DataSource = Event.getAvailableEventsFiltered("VenueID", Convert.ToString(newVen.getID())).Tables["WS"];

                cboType.SelectedIndex = -1;
                cboTown.SelectedIndex = -1;
                cboPrice.SelectedIndex = -1;
            }
        }

        private void cboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPrice.SelectedIndex >= 0)
            {
                cboType.SelectedIndex = -1;
                cboTown.SelectedIndex = -1;
                cboVenue.SelectedIndex = -1;

                if (cboPrice.SelectedIndex == 0)
                {
                    grdEvents.DataSource = Event.getAvailableEventsFiltered("Price", "= 0").Tables["WS"];
                }
                else
                {
                    grdEvents.DataSource = Event.getAvailableEventsFiltered("Price", cboPrice.Text).Tables["WS"];
                }
            }
        }

        private void grdEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlLogin.Visible = true;

            Event myEvent = new Event();

            //gets the selected rows id
            myEvent.setTitle(grdEvents.Rows[grdEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
            myEvent.setEventDetails();

            Venue venue = new Venue();
            venue.setID(myEvent.getVenueId());
            venue.setVenueDetails();

           
            lblSelectedEvent.Text = myEvent.getTitle() + " at " + venue.getName();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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

                    pnlBook.Visible = true;
                    txtBal.Text = Convert.ToString(cust.getBal());
                    txtEmail.Enabled = false;
                    txtPassword.Enabled = false;
                    grdEvents.Enabled = false;
                    btnLogin.Visible = false;

                    Event myEvent = new Event();

                    //gets the selected rows id
                    myEvent.setTitle(grdEvents.Rows[grdEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    myEvent.setEventDetails();

                    Venue venue = new Venue();
                    venue.setID(myEvent.getVenueId());
                    venue.setVenueDetails();

                    lblSelectedEvent.Text = myEvent.getTitle() + " at " + venue.getName();
                    


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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtEmail.Enabled = true;
            txtEmail.Clear();
            txtPassword.Enabled = true;
            txtPassword.Clear();
            txtBal.Clear();
            txtNoTickets.ResetText();
            txtPrice.Clear();

            grdEvents.Enabled = true;
            btnLogin.Visible = true;
            pnlBook.Visible = false;
            pnlLogin.Visible = false;
           
        }

        private void txtNoTickets_ValueChanged(object sender, EventArgs e)
        {
            Event myEvent = new Event();

            //gets the selected rows id
            myEvent.setTitle(grdEvents.Rows[grdEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());          
            myEvent.setEventDetails();

            double price = Convert.ToDouble(txtNoTickets.Value) * myEvent.getPrice();

            txtPrice.Text = Convert.ToString(price);
            
        }

        private void grdEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
