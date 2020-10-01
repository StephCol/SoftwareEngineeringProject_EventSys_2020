using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace EventSys
{
    class Venue
    {
        public int id;
        private String name;
        private String street;
        private String town;
        private int capacity;
        private String contactNo;
        private String email;
        private String password;
        private char status;

        //--------------------- NO ARGUMENT CONSTRUCTOR --------------

        public Venue()
        {
            id = 0;
            name = "";
            street = "";
            town = "";
            capacity = 0;
            contactNo = "";
            email = "";
            password = "";
            status = 'Y';
        }


       
        //-------------------------- GETTERS -----------------------------

        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public string getStreet()
        {
            return street;
        }
        public string getTown()
        {
            return town;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public string getContactNo()
        {
            return contactNo;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
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
        public void setName( string name)
        {
            this.name = name;
        }
        public void setStreet(string street)
        {
            this.street = street;
        }
        public void setTown(string town)
        {
            this.town = town;
        }
        public void setCapacity(int capacity)
        {
            this.capacity =  capacity;
        }
        public void setContactNo(string contactNo)
        {
            this.contactNo = contactNo;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }


        //-------------------------- REGISTER VENUE -----------------------------

        public void registerVenue()

        {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "INSERT INTO Venues(VenueID, VenueName, Street, Town, Capacity, ContactNo, Email, Password)" +
                            "VALUES( " + this.id + ",'" + this.name + "','" + this.street + "','" + this.town + "'," +
                             this.capacity + ",'" + this.contactNo + "','" + this.email + "','" + this.password + "')";


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //-------------------------- UPDATE VENUE -----------------------------

        public void updateVenue() {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "UPDATE Venues SET VenueName = '" + this.name + 
                                           "', Street = '" + this.street +
                                           "', Town = '" + this.town + 
                                           "', Capacity = " + this.capacity + 
                                           " , ContactNo = '" + this.contactNo + 
                                           "', Email = '" + this.email + 
                                           "', Password = '" + this.password + 
                                           "' WHERE VenueID = " + this.id;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        //-------------------------- DELETE VENUE -----------------------------

        public void deleteVenue() {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            String strSQL = "UPDATE Venues SET Status = 'N' WHERE VenueID = " + this.id; ;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //-------------------------- CHECK IF VENUE HAS UPCOMING EVENTS -----------------------------

        public Boolean checkIfUpcomingEvents()
        {

            //define sql query
            String strSQL = "SELECT COUNT(VENUEID) From Events " +
                " WHERE EventDate >  sysdate AND VenueID = " + this.id;

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
                        result = false;
                    }
                    else if (nxt >= 1)
                    {
                        result = true;
                    }
                }
            }

            conn.Close();

            return result;



        }



        //--------------------------- GET NEXT ID -----------------------------

        public static int getNextID()
        {


            //define sql query
            String strSQL = "SELECT MAX(VenueID) From Venues";

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


        //--------------------------- CHECK IF VENUE NAME IS ALREADY REGISTERED -----------------------------

        public Boolean isRegistered()
        {

            //define sql query
            String strSQL = "SELECT COUNT(*) From Venues WHERE VenueName = '" + this.name + "'";

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
                        result = false;
                    }
                    else
                    {

                        result = true;
                    }

                }

            }

            conn.Close();

            return result;
           

        }

        //--------------------------- CHECK IF VENUE NAME IS ALREADY REGISTERED -----------------------------
        //-------------------------------- EXCLUDING CURRENT FOR UPDATE -----------------------------
        public Boolean isRegisteredWithID()
        {

            //define sql query
            String strSQL = "SELECT COUNT(*) From Venues WHERE VenueName = '" + this.name + "' AND VenueID != " + this.id;

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
                        result = false;
                    }
                    else if (nxt >= 1)
                    {
                        result = true;
                    }
                }
            }

            conn.Close();

            return result;
        }


        //--------------------------- FILL COMBO BOX WITH LIST OF VENUE NAMES -----------------------------

        public static List<String> fillComboBox()
        {

            string strSQL = "SELECT VenueName FROM Venues WHERE Status = 'Y' ORDER BY VenueName";


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

       

        //--------------------------- SET A VENUES DETAILS ----------------------------

        public void setVenueDetails()
        {
            //define sql query
            String strSQL = "SELECT * From Venues WHERE VenueName = '" + this.getName() +"' OR VenueID = " + this.getID();

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
                    this.setName(dr.GetString(1));
                    this.setStreet(dr.GetString(2));
                    this.setTown(dr.GetString(3));
                    this.setCapacity(dr.GetInt32(4));
                    this.setContactNo(dr.GetString(5));
                    this.setEmail(dr.GetString(6));
                    this.setPassword(dr.GetString(8));

                }
            }

            conn.Close();

        }

        //-----------------------------To STRING ------------------------
        public string toString()
        {
            return "\nVenue Name: " + this.name +
                    "\nStreet: " + this.street +
                    "\nTown: " + this.town +
                    "\nCapacity: " + this.capacity +
                    "\nContact No: " + this.contactNo +
                    "\nEmail: " + this.email ;

        }

        //----------------------GET VENUE ANALYSIS---------------------
        public List<String> getAnalysis(String condition)
        {


            string strSQL = "SELECT (SELECT COUNT(EventID) FROM Events WHERE Status = 'S' AND VenueID = " + this.id + " AND EVENTDATE LIKE '%" + condition + "') AS NOEVENTS, " +
                            "(SELECT COUNT(EventID) FROM Events WHERE Status = 'C' AND VenueID = " + this.id + "  AND EVENTDATE LIKE '%" + condition + "') AS NoCancelledEvents, " +
                            "(SELECT SUM(NoTickets) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE VenueID = " + this.id + "  AND BOOKINGDATE LIKE '%" + condition + "') AS NOTickets, " +
                            "(SELECT SUM(BookingTotal) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE  Status = 'S' AND VenueID = " + this.id + "  AND BOOKINGDATE LIKE '%" + condition + "') AS TotalRevenue, " +
                            "(SELECT SUM(BookingTotal * .05) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE Status = 'S' AND VenueID = " + this.id + "  AND BOOKINGDATE LIKE '%" + condition + "') AS SysFee, " +
                            "(SELECT COUNT(BookingID) FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE Status = 'S' AND VenueID = " + this.id + "  AND BOOKINGDATE LIKE '%" + condition + "') AS NoBookings " +
                            "FROM Bookings B JOIN Events E ON B.EventID = E.EventID GROUP BY E.VenueID";


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
                    for (int i = 0; i <= 5; i++)
                    {
                        if (i <= 4)
                        {

                            if (!dr.IsDBNull(i))
                            {

                                items.Add(Convert.ToString(dr.GetInt32(i)));

                            }
                            else
                                items.Add("0");
                        }
                        else
                        {

                            if (!dr.IsDBNull(5))
                            {

                                items.Add(Convert.ToString((Convert.ToDouble(items[3]) - Convert.ToDouble(items[4])) - (dr.GetInt32(5) * 2.5)));

                            }
                            else
                            {
                                items.Add(Convert.ToString(Convert.ToDouble(items[3]) - Convert.ToDouble(items[4])));
                            }
                        }


                    }
                }

                return items;

            }
        }


        public List<String> getYears()
        {
            string strSQL = "  SELECT to_Char(BookingDate,'YYYY') AS YEAR FROM Bookings B JOIN Events E ON B.EventID = E.EventID WHERE VenueID = " + this.id + " GROUP BY to_Char(BookingDate, 'YYYY')";


            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            conn.Open();

            List<String> years = new List<String>();

            // reader is IDisposable and should be closed
            using (OracleDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {

                    years.Add(dr.GetString(0));
                    
                }
            }
            
            string strSQL2 = "SELECT to_Char(EventDate,'YYYY') AS YEAR FROM Events WHERE VenueID = " + this.id + " GROUP BY to_Char(EventDate, 'YYYY')";


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
