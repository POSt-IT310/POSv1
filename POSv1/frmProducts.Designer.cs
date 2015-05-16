namespace POSv1
{
    partial class frmProducts
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cmdCloseSB = new System.Windows.Forms.Button();
            this.lblTask = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.lblSCaption = new System.Windows.Forms.Label();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.cmdTask = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboROLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboDiscount = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPPU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProdType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprodcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDelete = new System.Windows.Forms.RadioButton();
            this.optUpdate = new System.Windows.Forms.RadioButton();
            this.optAdd = new System.Windows.Forms.RadioButton();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.gbSearch.Location = new System.Drawing.Point(391, 69);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(357, 360);
            this.gbSearch.TabIndex = 0;
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
            this.dgProducts.Size = new System.Drawing.Size(340, 248);
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
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.cmdTask);
            this.gbProducts.Controls.Add(this.comboBox2);
            this.gbProducts.Controls.Add(this.label10);
            this.gbProducts.Controls.Add(this.comboBox1);
            this.gbProducts.Controls.Add(this.label9);
            this.gbProducts.Controls.Add(this.cboROLevel);
            this.gbProducts.Controls.Add(this.label8);
            this.gbProducts.Controls.Add(this.cboDiscount);
            this.gbProducts.Controls.Add(this.label7);
            this.gbProducts.Controls.Add(this.txtRPrice);
            this.gbProducts.Controls.Add(this.label6);
            this.gbProducts.Controls.Add(this.txtPPU);
            this.gbProducts.Controls.Add(this.label5);
            this.gbProducts.Controls.Add(this.cboProdType);
            this.gbProducts.Controls.Add(this.label4);
            this.gbProducts.Controls.Add(this.txtProdDesc);
            this.gbProducts.Controls.Add(this.label3);
            this.gbProducts.Controls.Add(this.txtProdName);
            this.gbProducts.Controls.Add(this.label2);
            this.gbProducts.Controls.Add(this.txtprodcode);
            this.gbProducts.Controls.Add(this.label1);
            this.gbProducts.Location = new System.Drawing.Point(22, 69);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(354, 360);
            this.gbProducts.TabIndex = 1;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Product Details";
            // 
            // cmdTask
            // 
            this.cmdTask.Location = new System.Drawing.Point(119, 321);
            this.cmdTask.Name = "cmdTask";
            this.cmdTask.Size = new System.Drawing.Size(120, 27);
            this.cmdTask.TabIndex = 21;
            this.cmdTask.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(206, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Supplier";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Re-Order Count";
            // 
            // cboROLevel
            // 
            this.cboROLevel.FormattingEnabled = true;
            this.cboROLevel.Location = new System.Drawing.Point(119, 240);
            this.cboROLevel.Name = "cboROLevel";
            this.cboROLevel.Size = new System.Drawing.Size(68, 21);
            this.cboROLevel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Re-Order Level";
            // 
            // cboDiscount
            // 
            this.cboDiscount.FormattingEnabled = true;
            this.cboDiscount.Location = new System.Drawing.Point(119, 213);
            this.cboDiscount.Name = "cboDiscount";
            this.cboDiscount.Size = new System.Drawing.Size(68, 21);
            this.cboDiscount.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Discount (%)";
            // 
            // txtRPrice
            // 
            this.txtRPrice.Location = new System.Drawing.Point(119, 187);
            this.txtRPrice.Name = "txtRPrice";
            this.txtRPrice.Size = new System.Drawing.Size(68, 20);
            this.txtRPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Retail Price (Php)";
            // 
            // txtPPU
            // 
            this.txtPPU.Location = new System.Drawing.Point(119, 161);
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.Size = new System.Drawing.Size(68, 20);
            this.txtPPU.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cost/Unit (Php)";
            // 
            // cboProdType
            // 
            this.cboProdType.FormattingEnabled = true;
            this.cboProdType.Location = new System.Drawing.Point(119, 134);
            this.cboProdType.Name = "cboProdType";
            this.cboProdType.Size = new System.Drawing.Size(120, 21);
            this.cboProdType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(119, 73);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(206, 55);
            this.txtProdDesc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(119, 47);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(154, 20);
            this.txtProdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // txtprodcode
            // 
            this.txtprodcode.Location = new System.Drawing.Point(119, 21);
            this.txtprodcode.Name = "txtprodcode";
            this.txtprodcode.Size = new System.Drawing.Size(101, 20);
            this.txtprodcode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDelete);
            this.groupBox1.Controls.Add(this.optUpdate);
            this.groupBox1.Controls.Add(this.optAdd);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Task";
            // 
            // optDelete
            // 
            this.optDelete.AutoSize = true;
            this.optDelete.Location = new System.Drawing.Point(251, 17);
            this.optDelete.Name = "optDelete";
            this.optDelete.Size = new System.Drawing.Size(96, 17);
            this.optDelete.TabIndex = 27;
            this.optDelete.TabStop = true;
            this.optDelete.Text = "Delete Product";
            this.optDelete.UseVisualStyleBackColor = true;
            this.optDelete.CheckedChanged += new System.EventHandler(this.optDelete_CheckedChanged);
            // 
            // optUpdate
            // 
            this.optUpdate.AutoSize = true;
            this.optUpdate.Location = new System.Drawing.Point(115, 17);
            this.optUpdate.Name = "optUpdate";
            this.optUpdate.Size = new System.Drawing.Size(121, 17);
            this.optUpdate.TabIndex = 26;
            this.optUpdate.TabStop = true;
            this.optUpdate.Text = "Update Product Info";
            this.optUpdate.UseVisualStyleBackColor = true;
            this.optUpdate.CheckedChanged += new System.EventHandler(this.optUpdate_CheckedChanged);
            // 
            // optAdd
            // 
            this.optAdd.AutoSize = true;
            this.optAdd.Location = new System.Drawing.Point(18, 19);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(84, 17);
            this.optAdd.TabIndex = 25;
            this.optAdd.TabStop = true;
            this.optAdd.Text = "Add Product";
            this.optAdd.UseVisualStyleBackColor = true;
            this.optAdd.CheckedChanged += new System.EventHandler(this.optAdd_CheckedChanged);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbProducts);
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.Label lblSCaption;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.TextBox txtprodcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPPU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProdType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboROLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button cmdTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optDelete;
        private System.Windows.Forms.RadioButton optUpdate;
        private System.Windows.Forms.RadioButton optAdd;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button cmdCloseSB;
    }
}