using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EventSys
{
    class Customer
    {
        public int id;
        private String forename;
        private String surname;
        private String email;
        private String password;
        private String contactNo;
        private double balance;

        //--------------------- NO ARGUMENT CONSTRUCTOR --------------

        public Customer()
        {
            id = 0;
            forename = "";
            surname = "";
            email = "";
            contactNo = "";
            balance = 0;
        }

        //-------------------------- GETTERS -----------------------------

        public int getID()
        {
            return id;
        }
        public string getForename()
        {
            return forename;
        }
        public string getSurname()
        {
            return surname;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
        }
        public string getContactNo()
        {
            return contactNo;
        }
        public double getBal()
        {
            return balance;
        }

        //-------------------------- SETTERS -----------------------------

        public void setID(int id)
        {
            this.id = id;
        }
        public void setForename(string forename)
        {
            this.forename = forename;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public void setContactNo(string contactNo)
        {
            this.contactNo = contactNo;
        }
        public void setBal(double balance)
        {
            this.balance = balance;
        }


        //-------------------------- ADD CUSTOMER -----------------------------

        public void addCustomer()

        {
            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "INSERT INTO Customers(CustID, Fname, Sname, Email, Password, ContactNo)" +
                         "VALUES( " + this.id + ",'" + this.forename + "','" + this.surname + "','" + this.email + "','" + this.password + "','" + this.contactNo + "')";


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();
        }



        //-------------------------- UPDATE BALANCE -----------------------------

        public void topUp()
        {

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();


            //define sql query
            String strSQL = "UPDATE Customers SET Balance = " + this.balance + " WHERE CustID = " + this.id;


            //Declare an oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            cmd.ExecuteNonQuery();

            conn.Close();

        }
        

        //------------------------------ CHECK IF CUSTOMER EXISTS -------------------------------

        public Boolean isCustomerRegistered()
        {
           
            //define sql query
            String strSQL = "SELECT COUNT(Email) From Customers" +
                " WHERE Email = '" + this.email + "'";

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

        //------------------------------ GET NEXT ID -------------------------------

        public static int getNextID()
        {
            //define sql query
            String strSQL = "SELECT MAX(CustID) From Customers";

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

        //--------------------------- SET CUSTOMER DETAILS ----------------------------

        public void setCustDetails()
        {
            //define sql query
            String strSQL = "SELECT * From Customers WHERE (Email = '" + this.getEmail() + "' AND Password = '" + this.getPassword() + "') OR CustID = " + this.id;

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
                    this.setForename(dr.GetString(1));
                    this.setSurname(dr.GetString(2));
                    this.setBal(dr.GetDouble(6));

                }
            }

            conn.Close();

        }

        //------------------------------ CHECK IF VALID LOGIN ---------------------------

        public Boolean isValidLogin()
        {

            //define sql query
            String strSQL = "SELECT COUNT(*) From Customers WHERE Email = '" + this.email + "' AND Password = '" + this.password + "'" ;

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



        //------------------CHECK IF CUSTOMER HAS ANY BOOKINGS--------------

        public Boolean hasBookings()
        {
            //define sql query
            String strSQL = "SELECT COUNT(CustID)  FROM Bookings B JOIN Events E ON B.EventID = E.EventID " +
                            "WHERE CustID = " + this.id + "AND EventDate >= TRUNC(sysdate)";

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







    }
}
