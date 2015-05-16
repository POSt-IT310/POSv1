using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POSv1_CS
{
    public partial class frmPOS : Form
    {
       
        public frmPOS()
        {
            
            InitializeComponent();
        }

        private void lblCloseCash_Click(object sender, EventArgs e)
        {
            gbCash.Visible = false;
        }

        private void lblcloseCus_Click(object sender, EventArgs e)
        {
            gbCredit.Visible = false;
        }

        private void cmdCash_Click(object sender, EventArgs e)
        {
            gbCash.Visible = true;
        }

        private void cmdCredit_Click(object sender, EventArgs e)
        {
            gbCredit.Visible = true;
        }

        private void txtProduct_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            gbSearch.Visible = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



 

  
    }
}
