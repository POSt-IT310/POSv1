namespace POSv1
{
    partial class frmStocks
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
            this.lblSCaption = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gbSearchBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdRecall = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtprodcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUR = new System.Windows.Forms.TabControl();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.gbStockStatus = new System.Windows.Forms.GroupBox();
            this.cmdDiscard = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.dgStocks = new System.Windows.Forms.DataGridView();
            this.optCritical = new System.Windows.Forms.RadioButton();
            this.optExpired = new System.Windows.Forms.RadioButton();
            this.opt60 = new System.Windows.Forms.RadioButton();
            this.opt30 = new System.Windows.Forms.RadioButton();
            this.tabManage = new System.Windows.Forms.TabPage();
            this.optOnHand = new System.Windows.Forms.RadioButton();
            this.gbSearchBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabUR.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.gbStockStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).BeginInit();
            this.tabManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSCaption
            // 
            this.lblSCaption.AutoSize = true;
            this.lblSCaption.Location = new System.Drawing.Point(12, 14);
            this.lblSCaption.Name = "lblSCaption";
            this.lblSCaption.Size = new System.Drawing.Size(95, 13);
            this.lblSCaption.TabIndex = 2;
            this.lblSCaption.Text = "Search keyword(s)";
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(268, 10);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(89, 23);
            this.cmdSearch.TabIndex = 1;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(113, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(149, 20);
            this.txtsearch.TabIndex = 0;
            // 
            // gbSearchBox
            // 
            this.gbSearchBox.Controls.Add(this.cmdSearch);
            this.gbSearchBox.Controls.Add(this.txtsearch);
            this.gbSearchBox.Controls.Add(this.lblSCaption);
            this.gbSearchBox.Location = new System.Drawing.Point(6, 6);
            this.gbSearchBox.Name = "gbSearchBox";
            this.gbSearchBox.Size = new System.Drawing.Size(375, 43);
            this.gbSearchBox.TabIndex = 3;
            this.gbSearchBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdRecall);
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtProdDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProdName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtprodcode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmdRecall
            // 
            this.cmdRecall.Location = new System.Drawing.Point(179, 234);
            this.cmdRecall.Name = "cmdRecall";
            this.cmdRecall.Size = new System.Drawing.Size(90, 23);
            this.cmdRecall.TabIndex = 28;
            this.cmdRecall.Text = "Recall";
            this.cmdRecall.UseVisualStyleBackColor = true;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(88, 234);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(85, 23);
            this.cmdUpdate.TabIndex = 27;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(88, 208);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "On-Hand";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(90, 68);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(206, 55);
            this.txtProdDesc.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Expiry Date";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(90, 42);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(154, 20);
            this.txtProdName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date Acquired";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // txtprodcode
            // 
            this.txtprodcode.Location = new System.Drawing.Point(90, 16);
            this.txtprodcode.Name = "txtprodcode";
            this.txtprodcode.Size = new System.Drawing.Size(101, 20);
            this.txtprodcode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Code";
            // 
            // tabUR
            // 
            this.tabUR.Controls.Add(this.tabManage);
            this.tabUR.Controls.Add(this.tabStatus);
            this.tabUR.Location = new System.Drawing.Point(12, 12);
            this.tabUR.Name = "tabUR";
            this.tabUR.SelectedIndex = 0;
            this.tabUR.Size = new System.Drawing.Size(638, 368);
            this.tabUR.TabIndex = 5;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.gbStockStatus);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(630, 342);
            this.tabStatus.TabIndex = 1;
            this.tabStatus.Text = "Stock Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // gbStockStatus
            // 
            this.gbStockStatus.Controls.Add(this.optOnHand);
            this.gbStockStatus.Controls.Add(this.cmdDiscard);
            this.gbStockStatus.Controls.Add(this.cmdPrint);
            this.gbStockStatus.Controls.Add(this.dgStocks);
            this.gbStockStatus.Controls.Add(this.optCritical);
            this.gbStockStatus.Controls.Add(this.optExpired);
            this.gbStockStatus.Controls.Add(this.opt60);
            this.gbStockStatus.Controls.Add(this.opt30);
            this.gbStockStatus.Location = new System.Drawing.Point(17, 18);
            this.gbStockStatus.Name = "gbStockStatus";
            this.gbStockStatus.Size = new System.Drawing.Size(596, 308);
            this.gbStockStatus.TabIndex = 0;
            this.gbStockStatus.TabStop = false;
            // 
            // cmdDiscard
            // 
            this.cmdDiscard.Location = new System.Drawing.Point(422, 265);
            this.cmdDiscard.Name = "cmdDiscard";
            this.cmdDiscard.Size = new System.Drawing.Size(75, 23);
            this.cmdDiscard.TabIndex = 6;
            this.cmdDiscard.Text = "Discard";
            this.cmdDiscard.UseVisualStyleBackColor = true;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(503, 265);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(75, 23);
            this.cmdPrint.TabIndex = 5;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // dgStocks
            // 
            this.dgStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStocks.Location = new System.Drawing.Point(11, 46);
            this.dgStocks.Name = "dgStocks";
            this.dgStocks.Size = new System.Drawing.Size(566, 213);
            this.dgStocks.TabIndex = 4;
            // 
            // optCritical
            // 
            this.optCritical.AutoSize = true;
            this.optCritical.Location = new System.Drawing.Point(110, 19);
            this.optCritical.Name = "optCritical";
            this.optCritical.Size = new System.Drawing.Size(56, 17);
            this.optCritical.TabIndex = 3;
            this.optCritical.TabStop = true;
            this.optCritical.Text = "Critical";
            this.optCritical.UseVisualStyleBackColor = true;
            // 
            // optExpired
            // 
            this.optExpired.AutoSize = true;
            this.optExpired.Location = new System.Drawing.Point(473, 19);
            this.optExpired.Name = "optExpired";
            this.optExpired.Size = new System.Drawing.Size(105, 17);
            this.optExpired.TabIndex = 2;
            this.optExpired.TabStop = true;
            this.optExpired.Text = "Expired Products";
            this.optExpired.UseVisualStyleBackColor = true;
            // 
            // opt60
            // 
            this.opt60.AutoSize = true;
            this.opt60.Location = new System.Drawing.Point(328, 19);
            this.opt60.Name = "opt60";
            this.opt60.Size = new System.Drawing.Size(139, 17);
            this.opt60.TabIndex = 1;
            this.opt60.TabStop = true;
            this.opt60.Text = "To expire within 60 days";
            this.opt60.UseVisualStyleBackColor = true;
            // 
            // opt30
            // 
            this.opt30.AutoSize = true;
            this.opt30.Location = new System.Drawing.Point(183, 19);
            this.opt30.Name = "opt30";
            this.opt30.Size = new System.Drawing.Size(139, 17);
            this.opt30.TabIndex = 0;
            this.opt30.TabStop = true;
            this.opt30.Text = "To expire within 30 days";
            this.opt30.UseVisualStyleBackColor = true;
            // 
            // tabManage
            // 
            this.tabManage.Controls.Add(this.gbSearchBox);
            this.tabManage.Controls.Add(this.groupBox1);
            this.tabManage.Location = new System.Drawing.Point(4, 22);
            this.tabManage.Name = "tabManage";
            this.tabManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabManage.Size = new System.Drawing.Size(630, 342);
            this.tabManage.TabIndex = 0;
            this.tabManage.Text = "Manage Stocks";
            this.tabManage.UseVisualStyleBackColor = true;
            // 
            // optOnHand
            // 
            this.optOnHand.AutoSize = true;
            this.optOnHand.Location = new System.Drawing.Point(11, 19);
            this.optOnHand.Name = "optOnHand";
            this.optOnHand.Size = new System.Drawing.Size(68, 17);
            this.optOnHand.TabIndex = 7;
            this.optOnHand.TabStop = true;
            this.optOnHand.Text = "On-Hand";
            this.optOnHand.UseVisualStyleBackColor = true;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 417);
            this.Controls.Add(this.tabUR);
            this.Name = "frmStocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stocks";
            this.gbSearchBox.ResumeLayout(false);
            this.gbSearchBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabUR.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.gbStockStatus.ResumeLayout(false);
            this.gbStockStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStocks)).EndInit();
            this.tabManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSCaption;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.GroupBox gbSearchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprodcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdRecall;
        private System.Windows.Forms.TabControl tabUR;
        private System.Windows.Forms.TabPage tabManage;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.GroupBox gbStockStatus;
        private System.Windows.Forms.RadioButton optExpired;
        private System.Windows.Forms.RadioButton opt60;
        private System.Windows.Forms.RadioButton opt30;
        private System.Windows.Forms.RadioButton optCritical;
        private System.Windows.Forms.Button cmdDiscard;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.DataGridView dgStocks;
        private System.Windows.Forms.RadioButton optOnHand;
    }
}