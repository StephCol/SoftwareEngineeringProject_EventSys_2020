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
    public partial class frmTopUp : Form
    {
        Form parent;
        public frmTopUp(frmSignUpCustomer frmSignUpCustomer)
        {
            InitializeComponent();
            parent = frmSignUpCustomer;
        }
        public frmTopUp(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
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

                    btnTopUp.Visible = true;
                    txtFName.Text = cust.getForename();
                    txtSName.Text = cust.getSurname();
                    txtBal.Text = Convert.ToString(cust.getBal());
                    txtCardNo.Focus();

                    pnlTopUp.Visible = true;
                
                    
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

        private void btnTopUp_Click_1(object sender, EventArgs e)
        {
            //The Card Number must be 16 digits
            //Error - Invalid Card Number
            if (txtCardNo.TextLength == 16)
            {
                //The CVV must be 3 digits
                //Error - Invalid CVV
                if (txtCVV.TextLength == 3)
                {

                    if(cboMonth.SelectedIndex != -1 && cboYear.SelectedIndex != -1) { 


                    string date = "01-" + cboMonth.Text + "-" + cboYear.Text;

                    if(DateTime.Parse(date) > DateTime.Now)
                    {
                        Customer cust = new Customer();
                        cust.setEmail(txtEmail.Text);
                        cust.setPassword(txtPassword.Text);
                        cust.setCustDetails();

                            if (Convert.ToDouble(txtAmount.Text) > 0)
                            {
                                double balance = Double.Parse(txtBal.Text) + Double.Parse(txtAmount.Text);

                                cust.setBal(balance);
                                cust.topUp();

                                MessageBox.Show("Thank you for topping up your account your new balance is €" + balance + "! - You can now book Events.", "Account topped up!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                //Reset UI
                                txtEmail.Clear();
                                txtPassword.Clear();
                                txtFName.Clear();
                                txtSName.Clear();
                                txtAmount.Text = "000.00";
                                txtBal.Clear();
                                txtCardNo.Clear();
                                txtCVV.Clear();
                                cboMonth.SelectedIndex = -1;
                                cboYear.SelectedIndex = -1;
                                txtEmail.Focus();
                                btnTopUp.Visible = false;
                                pnlTopUp.Visible = false;
                            
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid Top Up Amount ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Your Card is expired please use another card", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCVV.Clear();
                        txtCardNo.Clear();
                        cboMonth.SelectedIndex = -1;
                        cboYear.SelectedIndex = -1;
                        txtCardNo.Focus();
                    }
                    }
                    else
                        MessageBox.Show("Please enter a valid Expiry Date ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    //The Expiry Date must be beyond todays date.
                    //Error - Your card appears to be expired, try a different card



                }
                else
                {
                    MessageBox.Show("Invalid CVV", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCVV.Clear();
                    txtCVV.Focus();
                }

            }

            else
            {
                MessageBox.Show("Invalid Card No", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Clear();
                txtCardNo.Focus();
            }

        }

        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Close Form
            parent.Show(); // Show the main menu again
        }

        private void frmTopUp_Load(object sender, EventArgs e)
        {
            btnTopUp.Visible = false;
        }

        private void txtFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
