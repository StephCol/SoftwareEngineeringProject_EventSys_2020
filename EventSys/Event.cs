using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EventSys
{
    class Event
    {
        public int id;
        private int venueID;
        private String date;
        private String title;
        private String description;
        private int type;
        private String time;
        private int tickets;
        private double price ;
        private char status;

        //--------------------- NO ARGUMENT CONSTRUCTOR --------------

        public Event()
        {
            id = 0;
            venueID = 0;
            date = "";
            title = "";
            description = "";
            type = 0;
            time = "";
            tickets = 0;
            price = 0;
            status = 'S';
        }

        //-------------------------- GETTERS -----------------------------

        public int getID()
        {
            return id;
        }
        public int getVenueId()
        {
            return venueID;
        }
        public string getTitle()
        {
            return title;
        }
        public string getDate()
        {
            return date;
        }
        public string getDesc()
        {
            return description;
        }
        public int getType()
        {
            return type;
        }
        public string getTime()
        {
            return time;
        }
        public int getTickets()
        {
            return tickets;
        }
        public double getPrice()
        {
            return price;
        }
        public char getStatus()
        {
            return status;
        }


        //-------------------------- SETTERS -----------------------------

        public void setID(int id)
        {
            this.id = id;
        }
        public void setVenueID(int venueID)
        {
            this.venueID = venueID;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setDate(String date)
        {
            this.date = date;
        }
        public void setDesc(string description)
        {
            this.description = description;
        }
        public void setType(int type)
        {
            this.type = type;
        }
        public void setTime(string time)
        {
            this.time = time;
        }
        public void setTickets(int tickets)
        {
            this.tickets = tickets;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }


        //-------------------------- ADD EVENT -----------------------------

        public void addEvent()

        {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "INSERT INTO Events(EventID, VenueID, Title, Description, TypeID, EventDate, Time, TicketsAvailable, Price)" +
                         "VALUES( " + this.id + "," + this.venueID + ",'" + this.title + "','" + this.description + "'," + this.type + ", '" + this.date + "','" + this.time + "'," + this.tickets + "," + this.price + ")";


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        //-------------------------- UPDATE EVENT -----------------------------

        public void updateEvent()
        {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //String strSQL = "INSERT INTO Events(EventID, VenueID, Title, Description, Type, Date, Time, TicketsAvailable, Price)" +
            //             "VALUES( " + this.id + "," + this.venueID + ",'" + this.title + "','" + this.description + "'," +
            //         this.type + ",'" + this.date + "'," + this.tickets + "," + this.price;

            //define sql query
            String strSQL = "UPDATE Events SET Title = '" + this.title + "', Description = '" + this.description +
                            "', TypeID = " + this.type + ", EventDate = '" + this.date + "' , Time = '" +
                            this.time + "', TicketsAvailable = " + this.tickets + ", Price = " + this.price +
                            "WHERE EventID = " + this.id;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        //-------------------------- CANCEL EVENT -----------------------------

        public void cancelEvent()
        {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Events SET Status = 'C' WHERE EventID = " + this.id;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);


            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

            //--------------------------REFUND CUSTOMERS -------------------------

            //define sql query
            String strSQL2 = "SELECT CustID, SUM(BookingTotal)AS Total FROM Bookings WHERE EventID = " + this.id + " GROUP BY CustID";

            //Declare an Oracle Connection
            OracleConnection conn2 = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd2 = new OracleCommand(strSQL2, conn2);

            conn2.Open();

            //Declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd2);
            

            using (OracleDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    int custID = reader.GetInt32(0);
                    Double total = reader.GetDouble(1);

                    Customer cust = new Customer();
                    cust.setID(custID);
                    cust.setCustDetails();
                    double balance = cust.getBal();
                    double newBal = balance + total;

                    OracleConnection conn3 = new OracleConnection(DBConnect.oradb);
                    conn3.Open();

                    String strSQL3 = "UPDATE Customers SET Balance = " + newBal + " WHERE CustID = " + custID;
                    
                    //Declare an oracle command to execute
                    OracleCommand cmd3 = new OracleCommand(strSQL3, conn3);

                    //Execute Query
                    cmd3.ExecuteNonQuery();

                    conn3.Close();

                }
            }
            
            conn2.Close();

            //-------------------------DELETE BOOKING---------------------------------

            String strSQL4 = "DELETE FROM BOOKINGS WHERE EventID = " + this.id;

            //Declare an Oracle Connection
            OracleConnection conn4 = new OracleConnection(DBConnect.oradb);

            conn4.Open();

            //Declare an oracle command to execute
            OracleCommand cmd4 = new OracleCommand(strSQL4, conn4);

            //Execute Query
            cmd4.ExecuteNonQuery();

            conn4.Close();


        }

        //-------------------------- GET AVAILABLE EVENTS -----------------------------

        public static DataSet getAvailableEvents()
        {
            //define sql query
            String strSQL = "SELECT Title, Description, Time, EventDate, Price From Events WHERE Status = 'S' AND EventDate >= TRUNC(sysdate) ORDER BY Title";

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



        //-------------------------- GET AVAILABLE EVENTS -----------------------------

        public static DataSet getAvailableEventsFiltered(String condition, String value)
        {
            String strSQL = "";


            if (condition == "Town")
            {
                //define sql query
                strSQL = "SELECT Title, Description, Time, EventDate, Price From Events E JOIN Venues V ON E.VenueID = V.VenueID" +
                    " WHERE E.Status = 'S' AND " + condition + " = '" + value + "' AND EventDate >= TRUNC(sysdate) ORDER BY Title";
            }
            else if(condition == "TypeID" || condition == "VenueID")
            {
                //define sql query
                strSQL = "SELECT Title, Description, Time, EventDate, Price From Events WHERE Status = 'S' AND " + condition + " = " + value + " AND EventDate >= TRUNC(sysdate) ORDER BY Title";
            }
            else if(condition == "Price")
            {
                //define sql query
                strSQL = "SELECT Title, Description, Time, EventDate, Price From Events WHERE Status = 'S' AND " + condition + " " + value + " AND EventDate >= TRUNC(sysdate) ORDER BY Title";

            }

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


        //--------------------------- GET NEXT ID -----------------------------

        public static int getNextID()
        {
           //define sql query
            String strSQL = "SELECT MAX(EventID) From Events";

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


        //------------------------------ CHECK IF VENUE IS FREE -------------------------------

        public Boolean isVenueFree()
        {
            Venue newVenue = new Venue();
            newVenue.setID(this.venueID);
            newVenue.setVenueDetails();


            //define sql query
            String strSQL = "SELECT COUNT(E.VENUEID) From Events E Join Venues V ON E.VenueID = V.VenueID" +
                " WHERE EventDate = '" + this.date + "' AND E.VenueID = " + this.venueID + "AND E.EventID != " + this.id ;

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

                    if (nxt == 0)
                    {
                        result = true;
                    }
                    else if (nxt >= 1)
                    {
                        result = false;
                    }
                }
            }

            conn.Close();

            return result;
        }

        //------------------------------ CHECK IF CAPACITY IS BIGGER THAN TICKETSAVAILABLE ----------

        public Boolean isVenueBigEnough()
        {

            //define sql query
            String strSQL = "SELECT Capacity From Venues WHERE VenueID = " + this.venueID;

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
                    int cap = reader.GetInt32(0);

                    if (cap >= this.tickets)
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


        //--------------------------- FILL COMBO BOX WITH LIST OF EVENTS -----------------------------

        public static List<String> fillComboBoxEvents()
        {

            string strSQL = "SELECT Title FROM Events WHERE Status = 'S' AND EventDate >= sysdate ORDER BY Title";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            List<String> items = new List<String>();

            // reader is IDisposable and should be closed
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    items.Add(dr.GetString(0));
                }
            }

            return items;

        }

        //--------------------------- FILL COMBO BOX WITH LIST OF TOWNS -----------------------------

        public static List<String> fillComboBoxTowns()
        {

            string strSQL = "SELECT DISTINCT Town FROM Events E JOIN Venues V on E.VenueID = V.VenueID " + 
                                "WHERE E.Status = 'S' AND EventDate >= sysdate ORDER BY Town";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            List<String> items = new List<String>();

            // reader is IDisposable and should be closed
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    items.Add(dr.GetString(0));
                }
            }

            return items;

        }

        //--------------------------- SET AN EVENTS DETAILS ----------------------------

        public void setEventDetails()
        {
            //define sql query
            String strSQL = "SELECT * From Events WHERE Title = '" + this.getTitle() + "' OR EventID = " + this.getID();

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
                    this.setVenueID(dr.GetInt32(1));
                    this.setTitle(dr.GetString(2));

                    if (dr.IsDBNull(3))
                        this.setDesc("");
                    else
                        this.setDesc(dr.GetString(3));

                    this.setType(dr.GetInt32(4));
                    this.setDate(Convert.ToString(dr.GetDateTime(5)));
                    this.setTime(dr.GetString(6));
                    this.setTickets(dr.GetInt32(7));
                    this.setPrice(dr.GetDouble(8));

                }
            }

            conn.Close();

        }



        //-----------------------------To STRING ------------------------
        public string toString()
        {
            Type tName = new Type();
            tName.setID(this.getType());
            tName.setTypeDetails();

            return  "\nTitle: " + this.title +
                    "\nDescription: " + this.description +
                    "\nType: " + tName.getName() +
                    "\nDate: " + this.date +
                    "\nTime: " + this.time +
                    "\nTickets: " + this.tickets +
                    "\nPrice: €" + this.price;
           
        }

    }
}
