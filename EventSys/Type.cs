using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EventSys
{
    class Type
    {

        private int id;
        private string description;


        public Type()
        {
            id = 0;
            description = "";

        }

        public string getName()
        {
            return description;
        }

        public int getID()
        {
            return id;
        }

        public void setName(string name)
        {
            description = name;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        //------------ASSIGN TYPE DETAILS---------------

        public void setTypeDetails()
        {
            //define sql query
            String strSQL = "SELECT * From EventType WHERE Description = '" + this.getName() +
                "' OR TypeID = " + this.getID();

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
                }
            }

            conn.Close();

        }

        //--------------------------- FILL COMBO BOX WITH LIST OF TYPES -----------------------------

        public static List<String> fillComboBoxTypes()
        {

            string strSQL = "SELECT Description FROM EventType ORDER BY Description";


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




    }
}
