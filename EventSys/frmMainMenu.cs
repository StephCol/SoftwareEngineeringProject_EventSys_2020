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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuRegVenue_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY USE THIS ON MAIN MENU
            this.Hide();

            //Display frmregVenue
            frmRegVenue nextForm =  new frmRegVenue(this);
            nextForm.Show();

        }

        private void mnuUpdVenue_Click(object sender, EventArgs e)
        {
            //Hide main menu ONLY USE THIS ON MAIN MENU
            this.Hide();

            frmUpdateVenue nextForm = new frmUpdateVenue(this);
            nextForm.Show();
        }

        private void mnuDelVenue_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeleteVenue nextForm = new frmDeleteVenue(this);
            nextForm.Show();
        }

        private void mnuAddEvent_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddEvent nextForm = new frmAddEvent(this);
            nextForm.Show();
        }

        private void mnuUpdEvent_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUpdateEvent nextForm = new frmUpdateEvent(this);
            nextForm.Show();
        }

        private void mnuCancelEvent_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmCancelEvent nextForm = new frmCancelEvent(this);
            nextForm.Show();
        }

        private void manageEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSignUpCustomer nextForm = new frmSignUpCustomer(this);
            nextForm.Show();
        }

        private void mnuTopUp_Click(object sender, EventArgs e)
        {
            frmTopUp nextForm = new frmTopUp(this);
            nextForm.Show();
        }

        private void manageVenuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuMakeBooking_Click(object sender, EventArgs e)
        {
            frmMakeBooking nextForm = new frmMakeBooking(this);
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking nextForm = new frmCancelBooking(this);
            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAnVenues_Click(object sender, EventArgs e)
        {
            frmAnalyseVenue nextForm = new frmAnalyseVenue(this);
            nextForm.Show();
        }

        private void mnuAnRev_Click(object sender, EventArgs e)
        {
            frmAnalyseRevenue nextForm = new frmAnalyseRevenue(this);
            nextForm.Show();
        }
    }
}
