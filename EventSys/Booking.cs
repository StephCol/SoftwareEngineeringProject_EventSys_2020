using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace EventSys
{
    internal class Booking
    {
        private int id;
        private int custID;
        private int eventID;
        private string bookingDate;
        private int tickets;
        private double total;

        public Booking()
        {
            id = 0;
            custID = 0;
            eventID = 0;
            bookingDate = "";
            tickets = 0;
            total = 0;
        }

        //----------------------- SETTERS ----------------------
        public void setID(int id)
        {
            this.id = id;
        }
        public void setCustID(int custID)
        {
            this.custID = custID;
        }
        public void setEventID(int eventID)
        {
            this.eventID = eventID;
        }
        public void setTickets(int tickets)
        {
            this.tickets = tickets;

        }
        public void setTotal(double total)
        {
            this.total = total;

        }

        //----------------------- GETTERS ----------------------
        public int getID()
        {
            return id;
        }
        public int getCustID()
        {
            return custID;
        }
        public int getEventID()
        {
            return eventID;
        }
        public int getTickets()
        {
            return tickets;

        }
        public double getTotal()
        {
            return total;

        }


        //----------------------- ADD BOOKING -----------------------

        public void addBooking()
        {
            //---------------------INSERT BOOKING INTO BOOKINGS TABLE

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "INSERT INTO Bookings(BookingID, CustID, EventID, NoTickets, BookingTotal)" +
                         "VALUES( " + Booking.getNextID() + "," + this.custID + "," + this.eventID + "," + this.tickets + "," + this.total + ")";


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

            //---------------------REDUCE CUSTOMER BALANCE

            //Declare an Oracle Connection
            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);
            conn2.Open();


            Customer myCust = new Customer();
            myCust.setID(this.custID);
            myCust.setCustDetails();

            //define sql query
            String strSQL2 = "UPDATE Customers SET Balance = " + (myCust.getBal() - this.total) + " WHERE CustID = " + myCust.getID();


            //Declare an oracle command to execute
            OracleCommand cmd2 = new OracleCommand(strSQL2, conn2);

            //Execute Query
            cmd2.ExecuteNonQuery();

            conn2.Close();

            //---------------------DECREASE TICKETS AVAILABLE

            //Declare an Oracle Connection
            OracleConnection conn3 = new OracleConnection(DBConnect.oradb);
            conn3.Open();

            Event thisEvent = new Event();
            thisEvent.setID(this.eventID);
            thisEvent.setEventDetails();

            int newTickets = thisEvent.getTickets() - this.tickets;

            //define sql query
            String strSQL3 = "UPDATE Events SET TicketsAvailable = " + newTickets + " WHERE EventID = " + this.eventID;


            //Declare an oracle command to execute
            OracleCommand cmd3 = new OracleCommand(strSQL3, conn3);

            //Execute Query
            cmd3.ExecuteNonQuery();

            conn3.Close();

        }


        //--------------------------- GET NEXT ID -----------------------------

        public static int getNextID()
        {
            //define sql query
            String strSQL = "SELECT MAX(BookingID) From Bookings";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            //Declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            int nxt = 0;

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    nxt = reader.GetInt32(0) + 1;
                }
            }

            //Close database connection
            //Another transaction could be waiting to access table 
            conn.Close();

            return nxt;

        }

        //--------------------------- FILL GRID WITH CUST BOOKINGS -----------------------------

        public static DataSet getMyBookings(int custid)
        {
            //define sql query
            string strSQL = "SELECT BookingID AS REF, E.Title, EventDate, NoTickets, BookingTotal  FROM Bookings B JOIN Events E ON B.EventID = E.EventID " +
                            "WHERE CustID = " + custid + "AND EventDate >= TRUNC(sysdate)";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //Declare DataSet to return records to 
            DataSet ds = new DataSet();

            da.Fill(ds, "WS");

            //Close database connection
            //Another transaction could be waiting to access table 
            conn.Close();

            return ds;

        }

        public Boolean isMoreThan24()
        {

            //define sql query
            String strSQL = "SELECT EventDate - TRUNC(sysdate) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE BookingID = " + this.id;

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            //Declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            Boolean result = false;

            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int nxt = reader.GetInt32(0);

                    if (nxt > 1)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            conn.Close();

            return result;
        }

        //---------------------------------SET BOOKING DETAILS ----------------------------
        public void setBookingDetails()
        {
            //define sql query
            String strSQL = "SELECT * From Bookings WHERE BookingID = " + this.getID();

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();
            // reader is IDisposable and should be closed
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    this.setID(dr.GetInt32(0));
                    this.setCustID(dr.GetInt32(1));
                    this.setEventID(dr.GetInt32(2));
                    this.setTickets(dr.GetInt32(4));
                    this.setTotal(dr.GetDouble(5));
                }
            }

            conn.Close();

        }

        //-------------------------CANCEL WITH REFUND---------------------------


        public void cancelBooking(Boolean result)
        {
            //INCREASE TICKETS AVAILABLE

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            Event thisEvent = new Event();
            thisEvent.setID(this.eventID);
            thisEvent.setEventDetails();

            int newTickets = thisEvent.getTickets() + this.tickets;


            //define sql query
            String strSQL = "UPDATE Events SET TicketsAvailable = " + newTickets + " WHERE EventID = " + this.eventID;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();


            //UPDATE CUSTOMER BALANCE IF EVENT MORE THAN 24 HOURS AWAY


            if (result == true)
            {
                OracleConnection conn1 = new OracleConnection(DBConnect.oradb);
                conn1.Open();

                Customer cust = new Customer();
                cust.setID(this.custID);
                cust.setCustDetails();

                double newBal = this.total + cust.getBal();

                //define sql query
                strSQL = "UPDATE Customers SET Balance = " + newBal + " WHERE CustID = " + this.custID;


                //Declare an oracle command to execute
                OracleCommand cmd1 = new OracleCommand(strSQL, conn1);

                //Execute Query
                cmd1.ExecuteNonQuery();


                conn1.Close();

            }



            //DELETE BOOKING


            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);
            conn2.Open();


            //define sql query
            strSQL = "DELETE FROM BOOKINGS WHERE BookingID = " + this.id;


            //Declare an oracle command to execute
            OracleCommand cmd2 = new OracleCommand(strSQL, conn2);

            //Execute Query
            cmd2.ExecuteNonQuery();


            conn2.Close();


        }

        public static List<String> loadYear()
        {

            string strSQL = "SELECT to_Char (BookingDate,'YYYY') AS YEAR FROM Bookings GROUP BY to_Char(BookingDate, 'YYYY')";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            List<String> years = new List<String>();


            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    years.Add(dr.GetString(0));
                }
            }

            string strSQL2 = "SELECT to_Char(EventDate,'YYYY') AS YEAR FROM Events GROUP BY to_Char(EventDate, 'YYYY')";


            //Declare an Oracle Connection
            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd2 = new OracleCommand(strSQL2, conn2);

            conn2.Open();


            // reader is IDisposable and should be closed
            using (OracleDataReader dr = cmd2.ExecuteReader())
            {
                while (dr.Read())
                {
                    if (years.Count >= 1)
                    {
                        for (int i = 0; i < years.Count; i++)
                        {
                            if (!years.Contains(dr.GetString(0)))
                                years.Add(dr.GetString(0));

                        }
                    }
                    else
                        years.Add(dr.GetString(0));


                }
            }


            years.Sort();
            return years;

        }



    }

}





