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
    public partial class frmMain : Form
    {
        //load all forms

        public static DateTime timeNow = new DateTime();
        
        
        
        
        
        


        public frmMain()
        {
            InitializeComponent();
            
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            //status settings
            this.stripAL.Text=Convert.ToString(frmLogin.accesslevel);
            this.stripName.Text=Convert.ToString(frmLogin.ln +","+frmLogin.fn +" "+frmLogin.mn);
            


        }


        private void productTS_Click(object sender, EventArgs e)
        {
            frmProducts newP = new frmProducts();
            newP.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
       
            newP.Show();
            
            
        }

        private void prodStMS_Click(object sender, EventArgs e)
        {
            frmStocks newS = new frmStocks();
            newS.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newS.Show();
        }

        private void manageCUSMS_Click(object sender, EventArgs e)
        {
            frmCustomers newC = new frmCustomers();
            newC.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newC.Show();
        }

        private void supTS_Click(object sender, EventArgs e)
        {
            frmSuppliers newSup = new frmSuppliers();
            newSup.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newSup.Show();
        }

 

        private void reportsTS_Click(object sender, EventArgs e)
        {
            frmSalesReport newSales = new frmSalesReport();
            newSales.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newSales.Show();
        }

        private void userAcctMS_Click(object sender, EventArgs e)
        {
            frmUsers newU = new frmUsers();
            newU.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newU.Show();
        }

        private void BudbMS_Click(object sender, EventArgs e)
        {
            frmBackup newBU = new frmBackup();
            newBU.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newBU.Show();
        }

        private void transMS_Click(object sender, EventArgs e)
        {
            frmTransactions newT = new frmTransactions();
            newT.MdiParent = this;
            //  newP.Dock = DockStyle.Fill;//optional for now
            newT.Show();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {

            timeNow = DateTime.Now;
            this.stripTime.Text = Convert.ToString(timeNow);
            
        }







 
       




 

  


    }
}
