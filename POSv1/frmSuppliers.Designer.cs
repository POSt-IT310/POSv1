namespace POSv1
{
    partial class frmSuppliers
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
            this.dgSuppliers = new System.Windows.Forms.DataGridView();
            this.lblSCaption = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gbSuppliers = new System.Windows.Forms.GroupBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdTask = new System.Windows.Forms.Button();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsupid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).BeginInit();
            this.gbSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDelete);
            this.groupBox1.Controls.Add(this.optUpdate);
            this.groupBox1.Controls.Add(this.optAdd);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Task";
            // 
            // optDelete
            // 
            this.optDelete.AutoSize = true;
            this.optDelete.Location = new System.Drawing.Point(251, 17);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(97, 17);
            this.optDelete.TabIndex = 27;
            this.optDelete.TabStop = true;
            this.optDelete.Text = "Delete Supplier";
            this.optDelete.UseVisualStyleBackColor = true;
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optUpdate
            // 
            this.optUpdate.AutoSize = true;
            this.optUpdate.Location = new System.Drawing.Point(115, 17);
            this.optUpdate.Name = "optUpdate";
            this.optUpdate.Size = new System.Drawing.Size(122, 17);
            this.optUpdate.TabIndex = 26;
            this.optUpdate.TabStop = true;
            this.optUpdate.Text = "Update Supplier Info";
            this.optUpdate.UseVisualStyleBackColor = true;
            this.optUpdate.CheckedChanged += new System.EventHandler(this.optUpdate_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.AutoSize = true;
            this.optAdd.Location = new System.Drawing.Point(18, 19);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(85, 17);
            this.optAdd.TabIndex = 25;
            this.optAdd.TabStop = true;
            this.optAdd.Text = "Add Supplier";
            this.optAdd.UseVisualStyleBackColor = true;
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSearch.Controls.Add(this.cmdCloseSB);
            this.gbSearch.Controls.Add(this.lblTask);
            this.gbSearch.Controls.Add(this.dgSuppliers);
            this.gbSearch.Controls.Add(this.lblSCaption);
            this.gbSearch.Controls.Add(this.cmdSearch);
            this.gbSearch.Controls.Add(this.txtsearch);
            this.gbSearch.Location = new System.Drawing.Point(378, 60);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(357, 309);
            this.gbSearch.TabIndex = 5;
            this.gbSearch.TabStop = false;
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
            // dgSuppliers
            // 
            this.dgSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSuppliers.Location = new System.Drawing.Point(10, 76);
            this.dgSuppliers.Name = "dgSuppliers";
            this.dgSuppliers.Size = new System.Drawing.Size(340, 194);
            this.dgSuppliers.TabIndex = 3;
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
            // gbSuppliers
            // 
            this.gbSuppliers.Controls.Add(this.txtCN);
            this.gbSuppliers.Controls.Add(this.label6);
            this.gbSuppliers.Controls.Add(this.txtCP);
            this.gbSuppliers.Controls.Add(this.label3);
            this.gbSuppliers.Controls.Add(this.txtPN);
            this.gbSuppliers.Controls.Add(this.label5);
            this.gbSuppliers.Controls.Add(this.txtAddress);
            this.gbSuppliers.Controls.Add(this.label4);
            this.gbSuppliers.Controls.Add(this.cmdTask);
            this.gbSuppliers.Controls.Add(this.txtBName);
            this.gbSuppliers.Controls.Add(this.label2);
            this.gbSuppliers.Controls.Add(this.txtsupid);
            this.gbSuppliers.Controls.Add(this.label1);
            this.gbSuppliers.Location = new System.Drawing.Point(18, 60);
            this.gbSuppliers.Name = "gbSuppliers";
            this.gbSuppliers.Size = new System.Drawing.Size(354, 253);
            this.gbSuppliers.TabIndex = 6;
            this.gbSuppliers.TabStop = false;
            this.gbSuppliers.Text = "Supplier Details";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(119, 174);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(154, 20);
            this.txtCN.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Contact Number";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(119, 148);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(214, 20);
            this.txtCP.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact Person";
            // 
            // txtPN
            // 
            this.txtPN.Location = new System.Drawing.Point(119, 122);
            this.txtPN.Name = "txtPN";
            this.txtPN.Size = new System.Drawing.Size(154, 20);
            this.txtPN.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Phone Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 74);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 42);
            this.txtAddress.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // cmdTask
            // 
            this.cmdTask.Location = new System.Drawing.Point(119, 200);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(120, 27);
            this.cmdTask.TabIndex = 21;
            this.cmdTask.UseVisualStyleBackColor = true;
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(119, 47);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(214, 20);
            this.txtBName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Business Name";
            // 
            // txtsupid
            // 
            this.txtsupid.Location = new System.Drawing.Point(119, 21);
            this.txtsupid.Name = "txtsupid";
            this.txtsupid.Size = new System.Drawing.Size(101, 20);
            this.txtsupid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier ID";
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 381);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbSuppliers);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSuppliers)).EndInit();
            this.gbSuppliers.ResumeLayout(false);
            this.gbSuppliers.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgSuppliers;
        private System.Windows.Forms.Label lblSCaption;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox gbSuppliers;
        private System.Windows.Forms.TextBox txtPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsupid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label6;
    }
}