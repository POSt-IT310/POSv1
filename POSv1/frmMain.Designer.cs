namespace POSv1
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuMS = new System.Windows.Forms.MenuStrip();
            this.productTS = new System.Windows.Forms.ToolStripMenuItem();
            this.prodStMS = new System.Windows.Forms.ToolStripMenuItem();
            this.cusTS = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCUSMS = new System.Windows.Forms.ToolStripMenuItem();
            this.transMS = new System.Windows.Forms.ToolStripMenuItem();
            this.supTS = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.utilTS = new System.Windows.Forms.ToolStripMenuItem();
            this.userAcctMS = new System.Windows.Forms.ToolStripMenuItem();
            this.BudbMS = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTS = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.stripAL = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.mnuMS.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMS
            // 
            this.mnuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productTS,
            this.prodStMS,
            this.cusTS,
            this.supTS,
            this.reportsTS,
            this.utilTS,
            this.helpTS,
            this.logoutTS});
            this.mnuMS.Location = new System.Drawing.Point(0, 0);
            this.mnuMS.Name = "mnuMS";
            this.mnuMS.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnuMS.Size = new System.Drawing.Size(646, 24);
            this.mnuMS.TabIndex = 1;
            this.mnuMS.Text = "Products";
            // 
            // productTS
            // 
            this.productTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTS.Name = "productTS";
            this.productTS.Size = new System.Drawing.Size(68, 20);
            this.productTS.Text = "&Products";
            this.productTS.Click += new System.EventHandler(this.productTS_Click);
            // 
            // prodStMS
            // 
            this.prodStMS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodStMS.Name = "prodStMS";
            this.prodStMS.Size = new System.Drawing.Size(56, 20);
            this.prodStMS.Text = "&Stocks";
            this.prodStMS.Click += new System.EventHandler(this.prodStMS_Click);
            // 
            // cusTS
            // 
            this.cusTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCUSMS,
            this.transMS});
            this.cusTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusTS.Name = "cusTS";
            this.cusTS.Size = new System.Drawing.Size(81, 20);
            this.cusTS.Text = "&Customers";
            // 
            // manageCUSMS
            // 
            this.manageCUSMS.Name = "manageCUSMS";
            this.manageCUSMS.Size = new System.Drawing.Size(146, 22);
            this.manageCUSMS.Text = "Manage List";
            this.manageCUSMS.Click += new System.EventHandler(this.manageCUSMS_Click);
            // 
            // transMS
            // 
            this.transMS.Name = "transMS";
            this.transMS.Size = new System.Drawing.Size(146, 22);
            this.transMS.Text = "Transactions";
            this.transMS.Click += new System.EventHandler(this.transMS_Click);
            // 
            // supTS
            // 
            this.supTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supTS.Name = "supTS";
            this.supTS.Size = new System.Drawing.Size(72, 20);
            this.supTS.Text = "S&uppliers";
            this.supTS.Click += new System.EventHandler(this.supTS_Click);
            // 
            // reportsTS
            // 
            this.reportsTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsTS.Name = "reportsTS";
            this.reportsTS.Size = new System.Drawing.Size(98, 20);
            this.reportsTS.Text = "Sales &Reports";
            this.reportsTS.Click += new System.EventHandler(this.reportsTS_Click);
            // 
            // utilTS
            // 
            this.utilTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAcctMS,
            this.BudbMS});
            this.utilTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilTS.Name = "utilTS";
            this.utilTS.Size = new System.Drawing.Size(60, 20);
            this.utilTS.Text = "U&tilities";
            // 
            // userAcctMS
            // 
            this.userAcctMS.Name = "userAcctMS";
            this.userAcctMS.Size = new System.Drawing.Size(172, 22);
            this.userAcctMS.Text = "User Accounts";
            this.userAcctMS.Click += new System.EventHandler(this.userAcctMS_Click);
            // 
            // BudbMS
            // 
            this.BudbMS.Name = "BudbMS";
            this.BudbMS.Size = new System.Drawing.Size(172, 22);
            this.BudbMS.Text = "Backup Database";
            this.BudbMS.Click += new System.EventHandler(this.BudbMS_Click);
            // 
            // helpTS
            // 
            this.helpTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTS.Name = "helpTS";
            this.helpTS.Size = new System.Drawing.Size(45, 20);
            this.helpTS.Text = "&Help";
            // 
            // logoutTS
            // 
            this.logoutTS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutTS.Name = "logoutTS";
            this.logoutTS.Size = new System.Drawing.Size(57, 20);
            this.logoutTS.Text = "&Logout";
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // stripAL
            // 
            this.stripAL.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stripAL.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.stripAL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripAL.Name = "stripAL";
            this.stripAL.Size = new System.Drawing.Size(4, 17);
            this.stripAL.ToolTipText = "Access Level";
            // 
            // stripName
            // 
            this.stripName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stripName.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.stripName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripName.Name = "stripName";
            this.stripName.Size = new System.Drawing.Size(4, 17);
            this.stripName.ToolTipText = "Current User";
            // 
            // stripTime
            // 
            this.stripTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stripTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.stripTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripTime.Name = "stripTime";
            this.stripTime.Size = new System.Drawing.Size(4, 17);
            this.stripTime.ToolTipText = "Time";
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripAL,
            this.stripName,
            this.stripTime});
            this.statStrip.Location = new System.Drawing.Point(0, 594);
            this.statStrip.Name = "statStrip";
            this.statStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statStrip.ShowItemToolTips = true;
            this.statStrip.Size = new System.Drawing.Size(646, 22);
            this.statStrip.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 616);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.mnuMS);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMS;
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMS.ResumeLayout(false);
            this.mnuMS.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMS;
        private System.Windows.Forms.ToolStripMenuItem productTS;
        private System.Windows.Forms.ToolStripMenuItem reportsTS;
        private System.Windows.Forms.ToolStripMenuItem utilTS;
        private System.Windows.Forms.ToolStripMenuItem userAcctMS;
        private System.Windows.Forms.ToolStripMenuItem BudbMS;
        private System.Windows.Forms.ToolStripMenuItem helpTS;
        private System.Windows.Forms.ToolStripMenuItem cusTS;
        private System.Windows.Forms.ToolStripMenuItem manageCUSMS;
        private System.Windows.Forms.ToolStripMenuItem logoutTS;
        private System.Windows.Forms.ToolStripMenuItem supTS;
        private System.Windows.Forms.ToolStripMenuItem prodStMS;
        private System.Windows.Forms.ToolStripMenuItem transMS;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.ToolStripStatusLabel stripAL;
        private System.Windows.Forms.ToolStripStatusLabel stripName;
        private System.Windows.Forms.ToolStripStatusLabel stripTime;
        private System.Windows.Forms.StatusStrip statStrip;
    }
}

