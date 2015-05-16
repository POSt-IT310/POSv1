using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POSv1
{
    public partial class frmLogin : Form
    {
        //user newUser = new user();
        public static string un;
        public static string pw;
        public static string accesslevel;
        public static string ln;
        public static string fn;
        public static string mn;

        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void resetForm(){
            txtun.Text = "";
            txtpw.Text = "";
            txtun.Focus();

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {

            if ((txtun.Text == "") || (txtpw.Text == ""))
            {
                MessageBox.Show("Please check your username and/or password \n and try again.","Check entry",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtun.Focus();

            }
            else
            {
                int nmatch = 0;
                user.Connection();
                DataTable usr = user.login(Convert.ToString(txtun.Text), Convert.ToString(txtpw.Text));
                //datatable has an object rows
                //rows has count
                //dguser.DataSource = usr;
                nmatch = usr.Rows.Count;
                if (nmatch == 1)
                {
                    //note: check on how to retrieve column by name
                    un = Convert.ToString(usr.Rows[0][0]);
                    pw = Convert.ToString(usr.Rows[0][1]);
                    accesslevel = Convert.ToString(usr.Rows[0][2]);
                    ln = Convert.ToString(usr.Rows[0][3]);
                    fn = Convert.ToString(usr.Rows[0][4]);
                    mn = Convert.ToString(usr.Rows[0][5]);
                    //use static variable instead
                    /*newUser.al = Convert.ToString(usr.Rows[0][2]);
                    newUser.uLast = Convert.ToString(usr.Rows[0][3]);
                    newUser.uFirst = Convert.ToString(usr.Rows[0][4]);
                    newUser.uMiddle = Convert.ToString(usr.Rows[0][5]);
                    */
                    this.Hide();
                    frmMain newMain = new frmMain();
                    newMain.Show();

                }
                else {
                    MessageBox.Show("The username and password you entered does not exists.\nPlease try again.", "Invalid User Account",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    resetForm();
                }

                user.Terminate();
            }


        }
    }
}
