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
    public partial class frmSignUpCustomer : Form
    {
        frmMainMenu parent;
    
        public frmSignUpCustomer()
        {
            InitializeComponent();
        }

        public frmSignUpCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }


        private void frmSignUpCustomer_Load(object sender, EventArgs e)
        {
            //Assign next Cust ID
           txtCustID.Text = Convert.ToString(Customer.getNextID());
        }


        private void btnSignUp_Click_1(object sender, EventArgs e)
        {

            //Validation

            if (!txtFName.Text.Equals("") && !txtSName.Text.Equals("") && !txtEmail.Text.Equals("") && !txtPassword.Text.Equals("") && !txtContactNo.Text.Equals(""))
            {
                //customer email must not already exist
                //Error Message "Account already exists"

                Customer newCust = new Customer();
                newCust.setID(Convert.ToInt32(txtCustID.Text));
                newCust.setEmail(txtEmail.Text);

                if (!newCust.isCustomerRegistered())
                {
                    newCust.setForename(txtFName.Text);
                    newCust.setSurname(txtSName.Text);
                    newCust.setPassword(txtPassword.Text);

                    string contact = txtContactNo.Text;

                    if(contact.Substring(0,2) == "08" || contact.Substring(0, 3) == "066")
                    {
                        newCust.setContactNo(txtContactNo.Text);

                        newCust.addCustomer();


                        //Display Confirmation Message
                        MessageBox.Show("Customer Registered - You may now book events on the system", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Ask user to top up
                        DialogResult confirmation = MessageBox.Show("Would you like to top up your account?", "TopUp", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (confirmation == DialogResult.Yes)
                        {
                            this.Hide();
                            frmTopUp next = new frmTopUp(this);
                            next.Show();

                            //Load Top Up form
                            //frmTopUp nextForm = new frmTopUp(this);
                            //nextForm.Show();
                        }

                        //if no
                        //Reset UI
                        txtFName.Clear();
                        txtSName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtContactNo.Clear();
                        txtFName.Focus();
                        //Assign next Cust ID
                        txtCustID.Text = Convert.ToString(Customer.getNextID());


                    }
                    else
                    {
                        MessageBox.Show("Contact number must start with '08' or '066'", "Invalid Number Format", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



                }
                else
                {
                    //Display Confirmation Message
                    MessageBox.Show("Email Address is already registered to another account, please use a differnet email or contact support to retrieve password.", "Account already registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                    txtEmail.Focus();

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

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
