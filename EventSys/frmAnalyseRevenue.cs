using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EventSys
{
    public partial class frmAnalyseRevenue : Form
    {
        frmMainMenu parent;
        public frmAnalyseRevenue()
        {
            InitializeComponent();
        }
        public frmAnalyseRevenue(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmAnalyseRevenue_Load(object sender, EventArgs e)
        {
            //Load list of years to system
            List<String> years = Booking.loadYear();
            cboYear.Items.AddRange(years.ToArray());

            chtRevenue.Titles.Add("Total Ticket Sales Revenue By Month");

            chtFees.Titles.Add("Yearly Revenue in Fees");
        }



        private void btnEmailAnalysis_Click(object sender, EventArgs e)
        {
            //Retrieve venue email and send above Analysis results 
            MessageBox.Show("Revenue Analysis has been emailed", "Analysis Emailed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            
            cboYear.Focus();
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (cboYear.SelectedIndex >= 0) {

                String Year = Convert.ToString(cboYear.Text[2]) + Convert.ToString(cboYear.Text[3]);

                String strSQL = "SELECT to_Char(BookingDate,'MM') AS MONTH, SUM (BookingTotal) AS TOTAL FROM Bookings WHERE BookingDate LIKE '%" + Year + "' GROUP BY to_Char(BookingDate, 'MM') ORDER BY MONTH";

                DataTable dt = new DataTable();
                

                OracleConnection conn = new OracleConnection(DBConnect.oradb);             
                OracleCommand cmd = new OracleCommand(strSQL, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                
                da.Fill(dt);

                conn.Close();

                string[] N = new string[dt.Rows.Count];
                decimal[] M = new decimal[dt.Rows.Count];

                decimal ticketTotal = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    N[i] = getMonth(Convert.ToInt32(dt.Rows[i][0]));
                    M[i] = Convert.ToDecimal(dt.Rows[i][1]);
                    ticketTotal += Convert.ToDecimal(dt.Rows[i][1]);
                }

                //order the arrays N and M 

                txtTicketRev.Text = "€ " + Convert.ToString(Math.Round(ticketTotal, 2));

                chtRevenue.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtRevenue.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtRevenue.Series[0].IsVisibleInLegend = false;
                chtRevenue.Series[0].Points.DataBindXY(N, M);
                chtRevenue.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
         
                chtRevenue.Series[0].Label = "€ " + "#VALY"; 

                
               

                String stringSQL = "SELECT SUM(BookingTotal*.05) AS SYSFEE,  COUNT(BookingID)*2.5 AS BOOKINGFEE FROM Bookings B JOIN Events E ON B.EventID = E.EventID JOIN Venues V ON E.VenueID = V.VenueID WHERE BookingDate LIKE '%" + Year + "'";

                DataTable dtable = new DataTable();
                
                OracleConnection connect = new OracleConnection(DBConnect.oradb);
                OracleCommand command = new OracleCommand(stringSQL, connect);
                OracleDataAdapter adapt = new OracleDataAdapter(command);

                adapt.Fill(dtable);

                conn.Close();

                string[] N2 = new string[2];
                decimal[] M2 = new decimal[dtable.Columns.Count];

                decimal sysTotal = 0;

                N2[0] = "System Fee";
                N2[1] = "Booking Fee";

                for (int i = 0; i < dtable.Columns.Count; i++)
                {
                    M2[i] = Convert.ToDecimal(dtable.Rows[0][i]);
                    sysTotal += Convert.ToDecimal(dtable.Rows[0][i]);
                }

                txtSysRev.Text = "€ " + Convert.ToString(Math.Round(sysTotal, 2));

                //order the arrays N and M 

                chtFees.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chtFees.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chtFees.Series[0].IsVisibleInLegend = false;
                chtFees.Series[0].Points.DataBindXY(N2, M2);
                chtFees.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

                chtFees.Series[0].Label = "€ " + "#VALY";


                pnlRevenue.Visible = true;

            }

            String getMonth(int month)
            {
                switch (month)
                {
                    case 1:
                        {
                            return "JAN";
                        }
                    case 2:
                        {
                            return "FEB";
                        }
                    case 3:
                        {
                            return "MAR";
                        }
                    case 4:
                        {
                            return "APR";
                        }
                    case 5:
                        {
                            return "MAY";
                        }
                    case 6:
                        {
                            return "JUN";
                        }
                    case 7:
                        {
                            return "JUL";
                        }
                    case 8:
                        {
                            return "AUG";
                        }
                    case 9:
                        {
                            return "SEP";
                        }
                    case 10:
                        {
                            return "OCT";
                        }
                    case 11:
                        {
                            return "NOV";
                        }
                    case 12:
                        {
                            return "DEC";
                        }
                    default: return "OTH";

                }


    

       
    }


        }

        }

    }

