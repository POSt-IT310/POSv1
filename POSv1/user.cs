using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace POSv1
{
    class user
    {
        private static string SQL;
        private static SqlConnection conn;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataSet ds;
        /*private string uname;
        private string pword;
        private string alevel;
        private string uLN;
        private string uFN;
        private string uMN;*/


        //use PC name = Admin-PC or use loop back address=127.0.0.1
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

        }

        public static DataTable login(string usnam, string pawd)
        {
         
           SQL = "Select * From users where username = '"+ usnam +"' and password='"+ pawd +"'";
           cmd = new SqlCommand(SQL, conn);
           cmd.CommandType = CommandType.Text;
           da = new SqlDataAdapter(cmd);
           ds = new DataSet();
           da.Fill(ds);
           return ds.Tables[0];

        }
        public static DataTable getUsers()
        {

            SQL = "Select * From users";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }
        //search
        public static DataTable getUsers(string keyword)
        {

            SQL = "Select * From users where username like '%" + keyword + "%' or accesslevel like '%" + keyword + "%' or lastname like '%" + keyword + "%' or firstname like '%" + keyword + "%' ";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];

        }

        public static bool checkUser(string usnam) {

            //return true if username selected is already 
            bool userexist = false;
            SQL = "Select * From users where username = '" + usnam + "'";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            int n = ds.Tables[0].Rows.Count;
            if (n >= 1) {
                userexist = true;
            }
            
            
            return userexist;
        
        }
        public static bool checkUser(string ln,string fn, string mn)
        {

            //return true if username selected is already 
            bool userexist = false;
            SQL = "Select * From users where lastname = '" + ln + "' and firstname= '" + fn + "' and middlename= '" + mn + "'";
            cmd = new SqlCommand(SQL, conn);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            int n = ds.Tables[0].Rows.Count;
            if (n >= 1)
            {
                userexist = true;
            }


            return userexist;

        }
        public static bool adduser(string usnam, string pawd, string al, string ln, string fn, string mn, string cn)
        {

            bool success = false;
            string insertSQL = "INSERT INTO users (username,password,accesslevel,lastname,firstname,middlename,contactnum) VALUES ('" + usnam + "','" + pawd + "','" + al + "','" + ln + "','" + fn + "','" + mn + "','" + cn + "')";
            cmd = new SqlCommand(insertSQL, conn);
            cmd.CommandType = CommandType.Text;
            if (cmd.ExecuteNonQuery() == 1)
                success = true;

            return success;
        
        }
        public static bool updateuser(string oldusnam, string usnam, string pawd, string al, string ln, string fn, string mn, string cn) {
            bool success = false;
            string updateSQL = "UPDATE users SET username ='" + usnam + "', password ='" + pawd + "',accesslevel='" + al + "',lastname='" + ln + "', firstname='" + fn + "', middlename='" + mn + "', contactnum='" + cn + "' WHERE username='" + oldusnam + "'";
            cmd = new SqlCommand(updateSQL, conn);
            cmd.CommandType = CommandType.Text;
            if (cmd.ExecuteNonQuery() == 1)
                success = true;

            return success;
        
        
        }
        public static bool deleteuser(string usnam)
        {

            bool success = false;
            string delSQL = "DELETE from users where username='"+ usnam +"'";
            cmd = new SqlCommand(delSQL, conn);
            cmd.CommandType = CommandType.Text;
            if (cmd.ExecuteNonQuery() == 1)
                success = true;

            return success;

        }


        public static void Terminate()
        {
            conn.Close();
        }

        //setters and getters for username, password and user's details
        /*no need for now
       public string un
        {
            get { return uname; }
            set { uname = value; }
        }

        public string pw
        {
            get { return pword; }
            set { pword = value; }
        }
        public string al
        {
            get { return alevel; }
            set { alevel = value; }
        }
        public string uLast
        {
            get { return uLN; }
            set { uLN = value; }   
            
        }
        public string uFirst
        {
            get { return uFN; }
            set { uFN = value; }

        }
        public string uMiddle
        {
            get { return uMN; }
            set { uMN = value; }

        }*/
    }
}
