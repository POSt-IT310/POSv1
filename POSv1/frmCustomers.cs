using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSv1
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void optAdd_CheckedChanged(object sender, EventArgs e)
        {
            cmdTask.Text = "SAVE RECORD";
            //change caption when user has selected a record
            gbSearch.Visible = false;
        }

        private void optUpdate_CheckedChanged(object sender, EventArgs e)
        {
            cmdTask.Text = "";
            //change caption when user has selected a record
            lblTask.Text = "SEARCH A RECORD TO UPDATE";
            gbSearch.Visible=true;
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

    }
}
