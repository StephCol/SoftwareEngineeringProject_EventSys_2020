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
    public partial class frmAnalyseVenue : Form
    {
        frmMainMenu parent;

        public frmAnalyseVenue()
        {
            InitializeComponent();
        }

        public frmAnalyseVenue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void frmAnalyseVenue_Load(object sender, EventArgs e)
        {
            List<String> venues = Venue.fillComboBox();
            cboVenueNames.Items.AddRange(venues.ToArray());
        }

        private void btnAnalyseVenue_Click(object sender, EventArgs e)
        {
          
            string venue = cboVenueNames.Text;
            Venue ven = new Venue();
            ven.setName(venue);
            ven.setVenueDetails();

            string condition;

            string year = cboYear.Text;

            

            if (cboMonth.SelectedIndex >= 0 && cboMonth.Text != "All") {

                string month = cboMonth.Text;
                condition = month.ToUpper() + "-" + year.Substring(2, 2);

                lblDate.Text = "Analysis for " + month + " " + year;
                
            }
            else
            {
                condition = year.Substring(2, 2);
                lblDate.Text = "Analysis for " + year;

            }
                    

                 

            List<String> analysis = ven.getAnalysis(condition);

            txtEvents.Text = analysis[0];
            txtCancelledEvents.Text = analysis[1];
            txtTicketsSold.Text = analysis[2];
            txtRevenue.Text = analysis[3];
            txtSysFee.Text = analysis[4];
            txtRevFee.Text = analysis[5];

            pnlAnalysis.Visible = true;

        }

        private void btnEmailAnalysis_Click(object sender, EventArgs e)
        {
            string venue = cboVenueNames.Text;
            Venue ven = new Venue();
            ven.setName(venue);
            ven.setVenueDetails();

            //Retrieve venue email and send above Analysis results 
            MessageBox.Show("Venue Analysis has been emailed to " + ven.getEmail(), "Analysis Emailed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI

            txtEvents.Clear();
            txtCancelledEvents.Clear();
            txtTicketsSold.Clear();
            txtRevenue.Clear();
            txtSysFee.Clear();
            txtRevFee.Clear();
            cboVenueNames.Focus();

        }

        private void cboVenueNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboYear.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.Items.Clear();
            pnlAnalysis.Visible = false;
            pnlMonth.Visible = false;
            pnlYear.Visible = false;
            btnAnalyseVenue.Visible = false;
            btnReset.Visible = false;


            if(cboVenueNames.SelectedIndex >= 0)
            {
                Venue ven = new Venue();
                ven.setName(cboVenueNames.Text);
                ven.setVenueDetails();

                List<String> years = ven.getYears();

                if (years.Count > 0)
                {
                    cboYear.Items.AddRange(years.ToArray());
                    pnlYear.Visible = true;
                }
                else
                {
                    MessageBox.Show("There is no analysis available for " + cboVenueNames.Text, "Analysis Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboVenueNames.SelectedIndex = -1;
                }

            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVenueNames.SelectedIndex >= 0)
            {
                Venue ven = new Venue();
                ven.setName(cboVenueNames.Text);
                ven.setVenueDetails();

               
                pnlMonth.Visible = true;
                btnAnalyseVenue.Visible = true;
                btnReset.Visible = true;



            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlAnalysis.Visible = false;
            pnlYear.Visible = false;
            pnlMonth.Visible = false;
            cboVenueNames.SelectedIndex = -1;
            btnReset.Visible = false;
            btnAnalyseVenue.Visible = false;
            cboYear.SelectedIndex = -1;
            cboMonth.SelectedIndex = -1;
            cboYear.Items.Clear();
            
        }
    }
}
