namespace POSv1
{
    partial class frmTransactions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.tabUnpaid = new System.Windows.Forms.TabPage();
            this.gbSearchAcct = new System.Windows.Forms.GroupBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboUT = new System.Windows.Forms.ComboBox();
            this.cmdSearchUT = new System.Windows.Forms.Button();
            this.txtsearchUT = new System.Windows.Forms.TextBox();
            this.cmdPayAll = new System.Windows.Forms.Button();
            this.cmdPay = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabUnpaid.SuspendLayout();
            this.gbSearchAcct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAccounts);
            this.tabControl1.Controls.Add(this.tabUnpaid);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.cmdPrint);
            this.tabAccounts.Controls.Add(this.dgAccounts);
            this.tabAccounts.Controls.Add(this.gbSearchAcct);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(568, 276);
            this.tabAccounts.TabIndex = 0;
            this.tabAccounts.Text = "List of Transactions";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // tabUnpaid
            // 
            this.tabUnpaid.Controls.Add(this.cmdPay);
            this.tabUnpaid.Controls.Add(this.cmdPayAll);
            this.tabUnpaid.Controls.Add(this.button1);
            this.tabUnpaid.Controls.Add(this.dataGridView1);
            this.tabUnpaid.Controls.Add(this.groupBox1);
            this.tabUnpaid.Location = new System.Drawing.Point(4, 22);
            this.tabUnpaid.Name = "tabUnpaid";
            this.tabUnpaid.Padding = new System.Windows.Forms.Padding(3);
            this.tabUnpaid.Size = new System.Drawing.Size(568, 276);
            this.tabUnpaid.TabIndex = 1;
            this.tabUnpaid.Text = "List of Unpaid Transactions";
            this.tabUnpaid.UseVisualStyleBackColor = true;
            // 
            // gbSearchAcct
            // 
            this.gbSearchAcct.Controls.Add(this.label1);
            this.gbSearchAcct.Controls.Add(this.comboBox1);
            this.gbSearchAcct.Controls.Add(this.cmdSearch);
            this.gbSearchAcct.Controls.Add(this.txtsearch);
            this.gbSearchAcct.Location = new System.Drawing.Point(15, 6);
            this.gbSearchAcct.Name = "gbSearchAcct";
            this.gbSearchAcct.Size = new System.Drawing.Size(537, 42);
            this.gbSearchAcct.TabIndex = 0;
            this.gbSearchAcct.TabStop = false;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(442, 12);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(89, 23);
            this.cmdSearch.TabIndex = 4;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(267, 13);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(169, 20);
            this.txtsearch.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Individual",
            "Employer"});
            this.comboBox1.Location = new System.Drawing.Point(109, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Group by";
            // 
            // dgAccounts
            // 
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Location = new System.Drawing.Point(15, 54);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.Size = new System.Drawing.Size(537, 187);
            this.dgAccounts.TabIndex = 1;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(463, 247);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(89, 23);
            this.cmdPrint.TabIndex = 5;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 187);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboUT);
            this.groupBox1.Controls.Add(this.cmdSearchUT);
            this.groupBox1.Controls.Add(this.txtsearchUT);
            this.groupBox1.Location = new System.Drawing.Point(15, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 42);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Group by";
            // 
            // cboUT
            // 
            this.cboUT.FormattingEnabled = true;
            this.cboUT.Items.AddRange(new object[] {
            "Individual",
            "Employer"});
            this.cboUT.Location = new System.Drawing.Point(109, 12);
            this.cboUT.Name = "cboUT";
            this.cboUT.Size = new System.Drawing.Size(152, 21);
            this.cboUT.TabIndex = 5;
            // 
            // cmdSearchUT
            // 
            this.cmdSearchUT.Location = new System.Drawing.Point(442, 12);
            this.cmdSearchUT.Name = "cmdSearchUT";
            this.cmdSearchUT.Size = new System.Drawing.Size(89, 23);
            this.cmdSearchUT.TabIndex = 4;
            this.cmdSearchUT.Text = "Search";
            this.cmdSearchUT.UseVisualStyleBackColor = true;
            // 
            // txtsearchUT
            // 
            this.txtsearchUT.Location = new System.Drawing.Point(267, 13);
            this.txtsearchUT.Name = "txtsearchUT";
            this.txtsearchUT.Size = new System.Drawing.Size(169, 20);
            this.txtsearchUT.TabIndex = 3;
            // 
            // cmdPayAll
            // 
            this.cmdPayAll.Location = new System.Drawing.Point(368, 247);
            this.cmdPayAll.Name = "cmdPayAll";
            this.cmdPayAll.Size = new System.Drawing.Size(89, 23);
            this.cmdPayAll.TabIndex = 9;
            this.cmdPayAll.Text = "Pay All";
            this.cmdPayAll.UseVisualStyleBackColor = true;
            // 
            // cmdPay
            // 
            this.cmdPay.Location = new System.Drawing.Point(273, 247);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(89, 23);
            this.cmdPay.TabIndex = 10;
            this.cmdPay.Text = "Pay";
            this.cmdPay.UseVisualStyleBackColor = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 327);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTransactions";
            this.Text = "Customer Transactions";
            this.tabControl1.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.tabUnpaid.ResumeLayout(false);
            this.gbSearchAcct.ResumeLayout(false);
            this.gbSearchAcct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabUnpaid;
        private System.Windows.Forms.GroupBox gbSearchAcct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUT;
        private System.Windows.Forms.Button cmdSearchUT;
        private System.Windows.Forms.TextBox txtsearchUT;
        private System.Windows.Forms.Button cmdPayAll;
        private System.Windows.Forms.Button cmdPay;
    }
}