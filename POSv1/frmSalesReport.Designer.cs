namespace POSv1
{
    partial class frmSalesReport
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
            this.tabSReport = new System.Windows.Forms.TabControl();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cmdViewD = new System.Windows.Forms.Button();
            this.dtDaily = new System.Windows.Forms.DateTimePicker();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.cmdViewM = new System.Windows.Forms.Button();
            this.cboYearM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabYearly = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabInBetween = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.dgSales = new System.Windows.Forms.DataGridView();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSReport.SuspendLayout();
            this.tabDaily.SuspendLayout();
            this.tabMonthly.SuspendLayout();
            this.tabYearly.SuspendLayout();
            this.tabInBetween.SuspendLayout();
            this.gbSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSReport
            // 
            this.tabSReport.Controls.Add(this.tabDaily);
            this.tabSReport.Controls.Add(this.tabMonthly);
            this.tabSReport.Controls.Add(this.tabYearly);
            this.tabSReport.Controls.Add(this.tabInBetween);
            this.tabSReport.Location = new System.Drawing.Point(16, 18);
            this.tabSReport.Name = "tabSReport";
            this.tabSReport.SelectedIndex = 0;
            this.tabSReport.Size = new System.Drawing.Size(447, 60);
            this.tabSReport.TabIndex = 0;
            // 
            // tabDaily
            // 
            this.tabDaily.Controls.Add(this.lblSelect);
            this.tabDaily.Controls.Add(this.cmdViewD);
            this.tabDaily.Controls.Add(this.dtDaily);
            this.tabDaily.Location = new System.Drawing.Point(4, 22);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(439, 34);
            this.tabDaily.TabIndex = 0;
            this.tabDaily.Text = "Daily";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(7, 8);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(63, 13);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select Date";
            // 
            // cmdViewD
            // 
            this.cmdViewD.Location = new System.Drawing.Point(268, 6);
            this.cmdViewD.Name = "cmdViewD";
            this.cmdViewD.Size = new System.Drawing.Size(75, 23);
            this.cmdViewD.TabIndex = 1;
            this.cmdViewD.Text = "View";
            this.cmdViewD.UseVisualStyleBackColor = true;
            // 
            // dtDaily
            // 
            this.dtDaily.Location = new System.Drawing.Point(76, 8);
            this.dtDaily.Name = "dtDaily";
            this.dtDaily.Size = new System.Drawing.Size(186, 20);
            this.dtDaily.TabIndex = 0;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Controls.Add(this.cmdViewM);
            this.tabMonthly.Controls.Add(this.cboYearM);
            this.tabMonthly.Controls.Add(this.label8);
            this.tabMonthly.Controls.Add(this.cboMonth);
            this.tabMonthly.Controls.Add(this.label7);
            this.tabMonthly.Location = new System.Drawing.Point(4, 22);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(439, 34);
            this.tabMonthly.TabIndex = 1;
            this.tabMonthly.Text = "Monthly";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // cmdViewM
            // 
            this.cmdViewM.Location = new System.Drawing.Point(317, 8);
            this.cmdViewM.Name = "cmdViewM";
            this.cmdViewM.Size = new System.Drawing.Size(75, 23);
            this.cmdViewM.TabIndex = 6;
            this.cmdViewM.Text = "View";
            this.cmdViewM.UseVisualStyleBackColor = true;
            // 
            // cboYearM
            // 
            this.cboYearM.FormattingEnabled = true;
            this.cboYearM.Location = new System.Drawing.Point(218, 8);
            this.cboYearM.Name = "cboYearM";
            this.cboYearM.Size = new System.Drawing.Size(93, 21);
            this.cboYearM.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Year";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Septermber",
            "October",
            "November",
            "December"});
            this.cboMonth.Location = new System.Drawing.Point(56, 7);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(121, 21);
            this.cboMonth.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Month";
            // 
            // tabYearly
            // 
            this.tabYearly.Controls.Add(this.button2);
            this.tabYearly.Controls.Add(this.cboYear);
            this.tabYearly.Controls.Add(this.label9);
            this.tabYearly.Location = new System.Drawing.Point(4, 22);
            this.tabYearly.Name = "tabYearly";
            this.tabYearly.Size = new System.Drawing.Size(439, 34);
            this.tabYearly.TabIndex = 2;
            this.tabYearly.Text = "Yearly";
            this.tabYearly.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(42, 6);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(93, 21);
            this.cboYear.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Year";
            // 
            // tabInBetween
            // 
            this.tabInBetween.Controls.Add(this.label11);
            this.tabInBetween.Controls.Add(this.dtTo);
            this.tabInBetween.Controls.Add(this.label10);
            this.tabInBetween.Controls.Add(this.button3);
            this.tabInBetween.Controls.Add(this.dtFrom);
            this.tabInBetween.Location = new System.Drawing.Point(4, 22);
            this.tabInBetween.Name = "tabInBetween";
            this.tabInBetween.Size = new System.Drawing.Size(439, 34);
            this.tabInBetween.TabIndex = 3;
            this.tabInBetween.Text = "In-Between Dates";
            this.tabInBetween.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(210, 6);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(121, 20);
            this.dtTo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "From";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(43, 6);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(121, 20);
            this.dtFrom.TabIndex = 2;
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.cmdPrint);
            this.gbSummary.Controls.Add(this.dgSales);
            this.gbSummary.Controls.Add(this.txtProfit);
            this.gbSummary.Controls.Add(this.label6);
            this.gbSummary.Controls.Add(this.txtCapital);
            this.gbSummary.Controls.Add(this.label5);
            this.gbSummary.Controls.Add(this.textBox1);
            this.gbSummary.Controls.Add(this.label4);
            this.gbSummary.Controls.Add(this.txtTotal);
            this.gbSummary.Controls.Add(this.label3);
            this.gbSummary.Controls.Add(this.txtCredit);
            this.gbSummary.Controls.Add(this.txtCash);
            this.gbSummary.Controls.Add(this.label2);
            this.gbSummary.Controls.Add(this.label1);
            this.gbSummary.Location = new System.Drawing.Point(12, 84);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(451, 409);
            this.gbSummary.TabIndex = 4;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Sales Summary";
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(14, 370);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(423, 23);
            this.cmdPrint.TabIndex = 13;
            this.cmdPrint.Text = "Print Report";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // dgSales
            // 
            this.dgSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSales.Location = new System.Drawing.Point(14, 103);
            this.dgSales.Name = "dgSales";
            this.dgSales.Size = new System.Drawing.Size(421, 261);
            this.dgSales.TabIndex = 12;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(321, 77);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(114, 20);
            this.txtProfit.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Net Profit";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(321, 49);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(114, 20);
            this.txtCapital.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Capital";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(321, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gross Sales";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(92, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(114, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Sales";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(92, 51);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(114, 20);
            this.txtCredit.TabIndex = 3;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(92, 23);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(114, 20);
            this.txtCash.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales on Credit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales on Cash";
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 522);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.tabSReport);
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sales Report";
            this.tabSReport.ResumeLayout(false);
            this.tabDaily.ResumeLayout(false);
            this.tabDaily.PerformLayout();
            this.tabMonthly.ResumeLayout(false);
            this.tabMonthly.PerformLayout();
            this.tabYearly.ResumeLayout(false);
            this.tabYearly.PerformLayout();
            this.tabInBetween.ResumeLayout(false);
            this.tabInBetween.PerformLayout();
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSReport;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabYearly;
        private System.Windows.Forms.TabPage tabInBetween;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button cmdViewD;
        private System.Windows.Forms.DateTimePicker dtDaily;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSales;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Button cmdViewM;
        private System.Windows.Forms.ComboBox cboYearM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtTo;

    }
}