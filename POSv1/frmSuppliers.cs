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
    public partial class frmSuppliers : Form
    {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void optAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtsupid.Text=supplier.generateID();
            cmdTask.Text = "Save Record";
            //change caption when user has selected a record
          
            //gbSearch.Visible = false;
        }

        private void optUpdate_CheckedChanged(object sender, EventArgs e)
        {
            cmdTask.Text = "";
            //change caption when user has selected a record
            lblTask.Text = "SEARCH A RECORD TO UPDATE";
            gbSearch.Visible = true;
        }

        private void optDelete_CheckedChanged(object sender, EventArgs e)
        {
            cmdTask.Text = "";
            //change caption when user has selected a record
            lblTask.Text = "SEARCH A RECORD TO DELETE";
            gbSearch.Visible = true;
        }

        private void cmdCloseSB_Click(object sender, EventArgs e)
        {
            gbSearch.Visible = false;
        }

        private void getSup() { 
            DataTable gs= supplier.getSuppliers();
            dgSuppliers.DataSource = gs;

           
            
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            string strConn = supplier.Connection();
            getSup();
        }
       




    }
}
