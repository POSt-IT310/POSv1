namespace POSv1
{
    partial class frmUsers
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
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtkw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.lblcheck = new System.Windows.Forms.Label();
            this.cboAL = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdTask = new System.Windows.Forms.Button();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDelete = new System.Windows.Forms.RadioButton();
            this.optUpdate = new System.Windows.Forms.RadioButton();
            this.optAdd = new System.Windows.Forms.RadioButton();
            this.lblSCaption = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.cmdCloseSB = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.gbUsers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(119, 211);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(154, 20);
            this.txtCN.TabIndex = 10;
            // 
            // txtkw
            // 
            this.txtkw.Location = new System.Drawing.Point(11, 62);
            this.txtkw.Name = "txtkw";
            this.txtkw.Size = new System.Drawing.Size(229, 20);
            this.txtkw.TabIndex = 0;
            this.txtkw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtkw_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Contact Number";
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lblcheck);
            this.gbUsers.Controls.Add(this.cboAL);
            this.gbUsers.Controls.Add(this.label10);
            this.gbUsers.Controls.Add(this.txtMN);
            this.gbUsers.Controls.Add(this.label11);
            this.gbUsers.Controls.Add(this.txtFN);
            this.gbUsers.Controls.Add(this.label7);
            this.gbUsers.Controls.Add(this.txtLN);
            this.gbUsers.Controls.Add(this.label8);
            this.gbUsers.Controls.Add(this.txtCN);
            this.gbUsers.Controls.Add(this.label6);
            this.gbUsers.Controls.Add(this.cmdTask);
            this.gbUsers.Controls.Add(this.txtpw);
            this.gbUsers.Controls.Add(this.label2);
            this.gbUsers.Controls.Add(this.txtun);
            this.gbUsers.Controls.Add(this.label1);
            this.gbUsers.Location = new System.Drawing.Point(374, 55);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(298, 361);
            this.gbUsers.TabIndex = 9;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "User Account Details";
            // 
            // lblcheck
            // 
            this.lblcheck.BackColor = System.Drawing.SystemColors.Control;
            this.lblcheck.Location = new System.Drawing.Point(119, 44);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(154, 30);
            this.lblcheck.TabIndex = 41;
            // 
            // cboAL
            // 
            this.cboAL.FormattingEnabled = true;
            this.cboAL.Items.AddRange(new object[] {
            "Administrator",
            "Staff",
            "Cashier"});
            this.cboAL.Location = new System.Drawing.Point(119, 103);
            this.cboAL.Name = "cboAL";
            this.cboAL.Size = new System.Drawing.Size(154, 21);
            this.cboAL.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Access Level";
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(119, 182);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(154, 20);
            this.txtMN.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Middle Name";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(119, 156);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(154, 20);
            this.txtFN.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "First Name";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(119, 130);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(154, 20);
            this.txtLN.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Last Name";
            // 
            // cmdTask
            // 
            this.cmdTask.Location = new System.Drawing.Point(153, 237);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(120, 27);
            this.cmdTask.TabIndex = 11;
            this.cmdTask.UseVisualStyleBackColor = true;
            this.cmdTask.Click += new System.EventHandler(this.cmdTask_Click);
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(119, 77);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(154, 20);
            this.txtpw.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(119, 21);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(154, 20);
            this.txtun.TabIndex = 4;
            this.txtun.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtun_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(262, 59);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(89, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDelete);
            this.groupBox1.Controls.Add(this.optUpdate);
            this.groupBox1.Controls.Add(this.optAdd);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 42);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Task";
            // 
            // optDelete
            // 
            this.optDelete.AutoSize = true;
            this.optDelete.Location = new System.Drawing.Point(251, 17);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(81, 17);
            this.optDelete.TabIndex = 3;
            this.optDelete.TabStop = true;
            this.optDelete.Text = "Delete User";
            this.optDelete.UseVisualStyleBackColor = true;
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optUpdate
            // 
            this.optUpdate.AutoSize = true;
            this.optUpdate.Location = new System.Drawing.Point(115, 17);
            this.optUpdate.Name = "optUpdate";
            this.optUpdate.Size = new System.Drawing.Size(106, 17);
            this.optUpdate.TabIndex = 2;
            this.optUpdate.TabStop = true;
            this.optUpdate.Text = "Update User Info";
            this.optUpdate.UseVisualStyleBackColor = true;
            this.optUpdate.CheckedChanged += new System.EventHandler(this.optUpdate_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.AutoSize = true;
            this.optAdd.Location = new System.Drawing.Point(18, 19);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(69, 17);
            this.optAdd.TabIndex = 1;
            this.optAdd.TabStop = true;
            this.optAdd.Text = "Add User";
            this.optAdd.UseVisualStyleBackColor = true;
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // lblSCaption
            // 
            this.lblSCaption.AutoSize = true;
            this.lblSCaption.Location = new System.Drawing.Point(8, 45);
            this.lblSCaption.Name = "lblSCaption";
            this.lblSCaption.Size = new System.Drawing.Size(290, 13);
            this.lblSCaption.TabIndex = 2;
            this.lblSCaption.Text = "Search (Username, AccessLevel, Last Name. or First Name)";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSearch.Controls.Add(this.lblresult);
            this.gbSearch.Controls.Add(this.cmdCloseSB);
            this.gbSearch.Controls.Add(this.lblTask);
            this.gbSearch.Controls.Add(this.dgUsers);
            this.gbSearch.Controls.Add(this.lblSCaption);
            this.gbSearch.Controls.Add(this.cmdSearch);
            this.gbSearch.Controls.Add(this.txtkw);
            this.gbSearch.Location = new System.Drawing.Point(11, 60);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(357, 356);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            this.gbSearch.Visible = false;
            // 
            // lblresult
            // 
            this.lblresult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblresult.Location = new System.Drawing.Point(8, 325);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(343, 20);
            this.lblresult.TabIndex = 42;
            // 
            // cmdCloseSB
            // 
            this.cmdCloseSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseSB.Location = new System.Drawing.Point(327, 0);
            this.cmdCloseSB.Name = "cmdCloseSB";
            this.cmdCloseSB.Size = new System.Drawing.Size(30, 26);
            this.cmdCloseSB.TabIndex = 5;
            this.cmdCloseSB.Text = "X";
            this.cmdCloseSB.UseVisualStyleBackColor = true;
            this.cmdCloseSB.Click += new System.EventHandler(this.cmdCloseSB_Click);
            // 
            // lblTask
            // 
            this.lblTask.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.Color.White;
            this.lblTask.Location = new System.Drawing.Point(1, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(329, 26);
            this.lblTask.TabIndex = 4;
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgUsers
            // 
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(11, 89);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.Size = new System.Drawing.Size(340, 233);
            this.dgUsers.TabIndex = 3;
            this.dgUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellContentClick);
            this.dgUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsers_CellDoubleClick);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 419);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUsers_FormClosed);
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtkw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDelete;
        private System.Windows.Forms.RadioButton optUpdate;
        private System.Windows.Forms.RadioButton optAdd;
        private System.Windows.Forms.Label lblSCaption;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button cmdCloseSB;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Label lblresult;
    }
}