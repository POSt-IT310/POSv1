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
    public partial class frmUsers : Form
    {
        //open connection when the form loads
        //close connection if it will be unloaded


        static int match = 0;
        static int errors = 0;
        static string msg = "";
      
        static string oldun="";
        static string oldln="";
        static string oldfn="";
        static string oldmn="";

       

        public frmUsers()
        {
            InitializeComponent();
            
        }

        private void optAdd_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            txtun.Focus();
            cmdTask.Text = "Save Record";
            //change caption when user has selected a record
      
            gbSearch.Visible = false;

        }

        private void optUpdate_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            cmdTask.Text = "";
            //change caption when user has selected a record
            lblTask.Text = "SEARCH A RECORD TO UPDATE";
            getUsers();
            gbSearch.Visible = true;
            


        }

        private void optDelete_CheckedChanged(object sender, EventArgs e)
        {
            clearForm();
            cmdTask.Text = "";
            //change caption when user has selected a record
            lblTask.Text = "SEARCH A RECORD TO DELETE";
            getUsers();
            gbSearch.Visible = true;

        }

        private void cmdCloseSB_Click(object sender, EventArgs e)
        {
            gbSearch.Visible = false;
        }

        private void txtun_KeyUp(object sender, KeyEventArgs e)
        {

            if (optAdd.Checked == true)
            {
                if (txtun.TextLength == 0)
                {
                    lblcheck.Text = "Please enter a username.";
                    cmdTask.Text = "";
                }
                else
                {
                    if (user.checkUser(txtun.Text))
                    {
                        lblcheck.Text = "Username is already taken.";
                        cmdTask.Text = "";

                    }
                    else
                    {
                        lblcheck.Text = "Username is available.";
                        cmdTask.Enabled = true;
                        cmdTask.Text = "Save Record";

                    }
                }
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            string strConn = user.Connection();
            cboAL.SelectedIndex = 0;
            
        }

       
        //add user account
        private string checkentries() {

            errors = 0;
            msg = "";
            if (txtun.Text == "") {
                errors = errors + 1;
                msg = "Username cannot be blank.";
            }
            if (txtpw.Text == "")
            {
                errors = errors + 1;
                msg = msg + "\nPassword cannot be blank.";
            }
            if (txtLN.Text == "")
            {
                errors = errors + 1;
                msg = msg +"\nLastname cannot be blank.";
            }
            if (txtFN.Text == "")
            {
                errors = errors + 1;
                msg = msg+"\nFirst name cannot be blank.";
            }




            return msg;
        }
        //add user
        private void addrecord() {


            if (user.adduser(txtun.Text, txtpw.Text, cboAL.Text, txtLN.Text, txtFN.Text, txtMN.Text, txtCN.Text))
            { 
                MessageBox.Show("User Account successfully added.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insertion failed.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //update user
        private void updaterecord() { 
        //check if supplied username already exists with the assumption that user supplied a new username/change occured
            string errmsg = "";
            bool cun;
            bool cname;
            int cFlag = 0;//value will be greater than zero if username or name exists
            cun = ocUN();
            cname = ocName();
            if (cun == true)
            {
                if (user.checkUser(txtun.Text))
                {
                    cFlag = cFlag + 1;
                    errmsg = "Username belongs to someone else.";
                }
                else {
                    cFlag = cFlag + 0;
                }
            }

            if (cname ==true){
                if (user.checkUser(txtLN.Text, txtFN.Text, txtMN.Text))
                {
                    cFlag = cFlag + 1;
                    errmsg = "\nName belongs to someone else.";
                }
                else {
                    cFlag = cFlag + 0;
                }
                
            }

            if (cFlag == 0)
            {
                if (user.updateuser(oldun, txtun.Text, txtpw.Text, cboAL.Text, txtLN.Text, txtFN.Text, txtMN.Text, txtCN.Text))
                {
                    MessageBox.Show("User Account successfully updated.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else {

                MessageBox.Show(errmsg, "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        
        
        
        }

        //delete user
        private void delrecord() {
            if (frmLogin.un == txtun.Text)
            {
                MessageBox.Show("Action not allowed.\nThis account is currently in use.\nIf you want to delete this account,\nlog out first and log-in with another account \nthat has administrator priveleges.","User Account",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clearForm();
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete \n this user from the list?", "User Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (user.deleteuser(txtun.Text))
                    {
                        MessageBox.Show("User Account successfully deleted.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }


        }
        //display users list
        private void getUsers() {
            DataTable users = user.getUsers();
            dgUsers.DataSource = users;
            
        
        
        }
        private void searchUser()
        {
            DataTable userRS = user.getUsers(txtkw.Text);
            dgUsers.DataSource = userRS;
            match = userRS.Rows.Count;



        }

        private void cmdTask_Click(object sender, EventArgs e)
        {
            string Task;
            Task = cmdTask.Text;
            switch (Task) { 
                case "Save Record":
                    checkentries();
                    if (errors != 0)
                    {
                        MessageBox.Show(msg, "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        if (user.checkUser(txtLN.Text, txtFN.Text, txtMN.Text))
                        {
                            MessageBox.Show("Only one account per user is allowed.\nTry again.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else {
                            addrecord();
                            clearForm();
                        }
                    }

                    break;
                case "Update Record":
                    checkentries();
                    if (errors != 0)
                    {
                        MessageBox.Show(msg, "User Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        updaterecord();
                        clearForm();
                    
                    
                    }
                    break;


                case "Delete Record":
                    if (cmdTask.Text != "") {
                        delrecord();
                        clearForm();
                    }
                    break;
              
            
            
            }
        }

        //clear form
        private void clearForm() {

            foreach (Control ctl in gbUsers.Controls)
            {

                if (ctl is TextBox)
                    ctl.Text = "";
            }
            cboAL.SelectedIndex = 0;
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            user.Terminate();

        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            searchUser();
            lblresult.Text = "Result: "+ Convert.ToString(match) + " match(es) found.";

        }

        private void txtkw_KeyUp(object sender, KeyEventArgs e)
        {
            searchUser();
            lblresult.Text = "Result: " + Convert.ToString(match) + " match(es) found.";
        }

        //display users list
        private void displayuser() {
            int i;
            i = dgUsers.SelectedCells[0].RowIndex;

            txtun.Text = dgUsers.CurrentRow.Cells[0].Value.ToString();
            txtpw.Text = dgUsers.CurrentRow.Cells[1].Value.ToString();
            cboAL.Text = dgUsers.CurrentRow.Cells[2].Value.ToString();
            txtLN.Text = dgUsers.CurrentRow.Cells[3].Value.ToString();
            txtFN.Text = dgUsers.CurrentRow.Cells[4].Value.ToString();
            txtMN.Text = dgUsers.CurrentRow.Cells[5].Value.ToString();
            txtCN.Text = dgUsers.CurrentRow.Cells[6].Value.ToString();
        
        }
        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displayuser();
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            displayuser();
            gbSearch.Visible = false;
            if (optUpdate.Checked == true)
            {
                if (txtun.Text == "")
                {
                    cmdTask.Text = "";

                }
                else
                {
                    oldun = dgUsers.CurrentRow.Cells[0].Value.ToString();
                    oldln = dgUsers.CurrentRow.Cells[3].Value.ToString();
                    oldfn = dgUsers.CurrentRow.Cells[4].Value.ToString();
                    oldmn = dgUsers.CurrentRow.Cells[5].Value.ToString();
                    cmdTask.Text = "Update Record";
                }
            }
            if (optDelete.Checked == true)
            {
                if (txtun.Text == "")
                {
                    cmdTask.Text = "";

                }
                else
                {
                    cmdTask.Text = "Delete Record";
                }
            }
        }

        private bool ocUN() {
            bool oc = false;
            if (oldun != txtun.Text)
            {
                oc = true;
            }
            return oc;
        
        }
        private bool ocName() {
            bool ocLN = false;
            bool ocFN = false;
            bool ocMN = false;
            bool ocN = false;

            if (oldln!=txtLN.Text){
                ocLN = true;
            
            }
            if (oldfn != txtFN.Text)
            {
                ocFN = true;

            }
            if (oldmn != txtMN.Text) {

                ocMN = true;
            }

            ocN = ocLN || ocFN || ocMN;
            return ocN;

        }






    
       
        





  





      
        


    }
}
