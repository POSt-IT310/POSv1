namespace POSv1
{
    partial class frmCustomers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDelete = new System.Windows.Forms.RadioButton();
            this.optUpdate = new System.Windows.Forms.RadioButton();
            this.optAdd = new System.Windows.Forms.RadioButton();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmdCloseSB = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.lblSCaption = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.cmdTask = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.gbCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDelete);
            this.groupBox1.Controls.Add(this.optUpdate);
            this.groupBox1.Controls.Add(this.optAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Task";
            // 
            // optDelete
            // 
            this.optDelete.AutoSize = true;
            this.optDelete.Location = new System.Drawing.Point(251, 17);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(103, 17);
            this.optDelete.TabIndex = 27;
            this.optDelete.TabStop = true;
            this.optDelete.Text = "Delete Customer";
            this.optDelete.UseVisualStyleBackColor = true;
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optUpdate
            // 
            this.optUpdate.AutoSize = true;
            this.optUpdate.Location = new System.Drawing.Point(115, 17);
            this.optUpdate.Name = "optUpdate";
            this.optUpdate.Size = new System.Drawing.Size(128, 17);
            this.optUpdate.TabIndex = 26;
            this.optUpdate.TabStop = true;
            this.optUpdate.Text = "Update Customer Info";
            this.optUpdate.UseVisualStyleBackColor = true;
            this.optUpdate.CheckedChanged += new System.EventHandler(this.optUpdate_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.AutoSize = true;
            this.optAdd.Location = new System.Drawing.Point(18, 19);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(91, 17);
            this.optAdd.TabIndex = 25;
            this.optAdd.TabStop = true;
            this.optAdd.Text = "Add Customer";
            this.optAdd.UseVisualStyleBackColor = true;
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSearch.Controls.Add(this.cmdCloseSB);
            this.gbSearch.Controls.Add(this.lblTask);
            this.gbSearch.Controls.Add(this.dgProducts);
            this.gbSearch.Controls.Add(this.lblSCaption);
            this.gbSearch.Controls.Add(this.cmdSearch);
            this.gbSearch.Controls.Add(this.txtsearch);
            this.gbSearch.Location = new System.Drawing.Point(9, 60);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(357, 309);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Visible = false;
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
            this.lblTask.Location = new System.Drawing.Point(-1, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(329, 26);
            this.lblTask.TabIndex = 4;
            this.lblTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(10, 76);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(340, 194);
            this.dgProducts.TabIndex = 3;
            // 
            // lblSCaption
            // 
            this.lblSCaption.AutoSize = true;
            this.lblSCaption.Location = new System.Drawing.Point(6, 49);
            this.lblSCaption.Name = "lblSCaption";
            this.lblSCaption.Size = new System.Drawing.Size(95, 13);
            this.lblSCaption.TabIndex = 2;
            this.lblSCaption.Text = "Search keyword(s)";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(261, 44);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(89, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(107, 47);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(149, 20);
            this.txtsearch.TabIndex = 0;
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.txtCN);
            this.gbCustomers.Controls.Add(this.label5);
            this.gbCustomers.Controls.Add(this.txtAddress);
            this.gbCustomers.Controls.Add(this.label4);
            this.gbCustomers.Controls.Add(this.txtMN);
            this.gbCustomers.Controls.Add(this.label11);
            this.gbCustomers.Controls.Add(this.txtFN);
            this.gbCustomers.Controls.Add(this.cmdTask);
            this.gbCustomers.Controls.Add(this.comboBox2);
            this.gbCustomers.Controls.Add(this.label10);
            this.gbCustomers.Controls.Add(this.label3);
            this.gbCustomers.Controls.Add(this.txtLN);
            this.gbCustomers.Controls.Add(this.label2);
            this.gbCustomers.Controls.Add(this.txtcusid);
            this.gbCustomers.Controls.Add(this.label1);
            this.gbCustomers.Location = new System.Drawing.Point(13, 60);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Size = new System.Drawing.Size(354, 278);
            this.gbCustomers.TabIndex = 5;
            this.gbCustomers.TabStop = false;
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(119, 173);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(154, 20);
            this.txtCN.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 125);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 42);
            this.txtAddress.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(119, 99);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(154, 20);
            this.txtMN.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Middle Name";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(119, 73);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(154, 20);
            this.txtFN.TabIndex = 22;
            // 
            // cmdTask
            // 
            this.cmdTask.Location = new System.Drawing.Point(119, 226);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(120, 27);
            this.cmdTask.TabIndex = 21;
            this.cmdTask.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Employer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(119, 47);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(154, 20);
            this.txtLN.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // txtcusid
            // 
            this.txtcusid.Location = new System.Drawing.Point(119, 21);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.Size = new System.Drawing.Size(101, 20);
            this.txtcusid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 411);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCustomers);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.gbCustomers.ResumeLayout(false);
            this.gbCustomers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDelete;
        private System.Windows.Forms.RadioButton optUpdate;
        private System.Windows.Forms.RadioButton optAdd;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button cmdCloseSB;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Label lblSCaption;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.TextBox txtMN;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
    }
}