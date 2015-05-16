using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace POSv1
{
    class supplier
    {
        private static string SQL;
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataSet ds;

        public static string Connection()
        {
            try
            {
                string name = System.Environment.MachineName;//get pc name
                string sqldb = "Data Source=" + name + "\\SQLEXPRESS ;Initial Catalog=posv1;Persist Security Info=True;User ID=patski;Password=jan1927;TrustServerCertificate=False;User Instance=False";


                conn = new SqlConnection(sqldb);
                conn.Open();

            }
            catch (SqlException e)
            {
                return e.Message;
            }
            return conn.State.ToString();


        }//end of connection

        public static DataTable getSuppliers()
        {

            SQL = "Select * From suppliers order by supplierid ASC";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }

        public static string generateID() {
            string newID;
            int rcount;
            string lastid;
            SQL = "Select * From suppliers order by supplierid ASC";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            rcount = ds.Tables[0].Rows.Count;
            if (rcount == 0)
            {
                newID = "SUP001";
            }
            else {

                DataRow lastrow = (DataRow)ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1];
                lastid = Convert.ToString(lastrow[0]);

                newID = "SUP"+ (Convert.ToInt32(lastid.Substring(3,3))+1).ToString("D3");

            }

                return newID;
        
        }
        public static void Terminate()
        {
            conn.Close();
        }
    }//end of class
}//end of namespace
