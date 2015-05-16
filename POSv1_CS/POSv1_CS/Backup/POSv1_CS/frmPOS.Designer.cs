namespace POSv1_CS
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsubT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPPU = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.gbCredit = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblcloseCus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbCash = new System.Windows.Forms.GroupBox();
            this.lblCloseCash = new System.Windows.Forms.Label();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.cmdViewLast = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.cmdRAll = new System.Windows.Forms.Button();
            this.cmdCredit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdCash = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.recbg = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.gbProduct.SuspendLayout();
            this.gbCart.SuspendLayout();
            this.gbCredit.SuspendLayout();
            this.gbCash.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.label6);
            this.gbProduct.Controls.Add(this.label5);
            this.gbProduct.Controls.Add(this.txtsubT);
            this.gbProduct.Controls.Add(this.label4);
            this.gbProduct.Controls.Add(this.txtqty);
            this.gbProduct.Controls.Add(this.label3);
            this.gbProduct.Controls.Add(this.txtPPU);
            this.gbProduct.Controls.Add(this.cmdAdd);
            this.gbProduct.Controls.Add(this.label2);
            this.gbProduct.Controls.Add(this.label1);
            this.gbProduct.Controls.Add(this.txtProduct);
            this.gbProduct.Location = new System.Drawing.Point(0, 79);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(1265, 96);
            this.gbProduct.TabIndex = 0;
            this.gbProduct.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(763, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            // 
            // txtsubT
            // 
            this.txtsubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubT.Location = new System.Drawing.Point(794, 43);
            this.txtsubT.Name = "txtsubT";
            this.txtsubT.Size = new System.Drawing.Size(269, 29);
            this.txtsubT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(790, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sub-Total (Php)";
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(601, 43);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(146, 29);
            this.txtqty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // txtPPU
            // 
            this.txtPPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPU.Location = new System.Drawing.Point(395, 43);
            this.txtPPU.Name = "txtPPU";
            this.txtPPU.Size = new System.Drawing.Size(147, 29);
            this.txtPPU.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(1082, 35);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(168, 46);
            this.cmdAdd.TabIndex = 9;
            this.cmdAdd.Text = "Add to Cart (F2)";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price/Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product";
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(6, 43);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(372, 29);
            this.txtProduct.TabIndex = 0;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProduct_MouseClick);
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.gbCredit);
            this.gbCart.Controls.Add(this.label10);
            this.gbCart.Controls.Add(this.label11);
            this.gbCart.Controls.Add(this.label8);
            this.gbCart.Controls.Add(this.label9);
            this.gbCart.Controls.Add(this.gbCash);
            this.gbCart.Controls.Add(this.cmdViewLast);
            this.gbCart.Controls.Add(this.gbSearch);
            this.gbCart.Controls.Add(this.cmdClose);
            this.gbCart.Controls.Add(this.lblTotal);
            this.gbCart.Controls.Add(this.cmdCancel);
            this.gbCart.Controls.Add(this.cmdRemove);
            this.gbCart.Controls.Add(this.cmdPrint);
            this.gbCart.Controls.Add(this.cmdRAll);
            this.gbCart.Controls.Add(this.cmdCredit);
            this.gbCart.Controls.Add(this.label7);
            this.gbCart.Controls.Add(this.cmdCash);
            this.gbCart.Controls.Add(this.dataGridView1);
            this.gbCart.Controls.Add(this.shapeContainer1);
            this.gbCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCart.Location = new System.Drawing.Point(0, 175);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(1265, 535);
            this.gbCart.TabIndex = 1;
            this.gbCart.TabStop = false;
            // 
            // gbCredit
            // 
            this.gbCredit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCredit.Controls.Add(this.label16);
            this.gbCredit.Controls.Add(this.textBox1);
            this.gbCredit.Controls.Add(this.lblcloseCus);
            this.gbCredit.Controls.Add(this.button1);
            this.gbCredit.Controls.Add(this.label15);
            this.gbCredit.Controls.Add(this.textBox2);
            this.gbCredit.Location = new System.Drawing.Point(411, 162);
            this.gbCredit.Name = "gbCredit";
            this.gbCredit.Size = new System.Drawing.Size(484, 268);
            this.gbCredit.TabIndex = 24;
            this.gbCredit.TabStop = false;
            this.gbCredit.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(28, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 24);
            this.label16.TabIndex = 9;
            this.label16.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(32, 140);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 49);
            this.textBox1.TabIndex = 8;
            // 
            // lblcloseCus
            // 
            this.lblcloseCus.AutoSize = true;
            this.lblcloseCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcloseCus.Location = new System.Drawing.Point(392, 0);
            this.lblcloseCus.Name = "lblcloseCus";
            this.lblcloseCus.Size = new System.Drawing.Size(92, 24);
            this.lblcloseCus.TabIndex = 7;
            this.lblcloseCus.Text = "Close(X)";
            this.lblcloseCus.Click += new System.EventHandler(this.lblcloseCus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Press Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(28, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Customer ID";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(32, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 49);
            this.textBox2.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(768, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 55);
            this.label10.TabIndex = 23;
            this.label10.Text = "0.00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(748, 55);
            this.label11.TabIndex = 22;
            this.label11.Text = "Change";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(768, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 55);
            this.label8.TabIndex = 21;
            this.label8.Text = "0.00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(748, 45);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cash Tendered";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCash
            // 
            this.gbCash.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCash.Controls.Add(this.lblCloseCash);
            this.gbCash.Controls.Add(this.cmdEnter);
            this.gbCash.Controls.Add(this.label12);
            this.gbCash.Controls.Add(this.txtcash);
            this.gbCash.Location = new System.Drawing.Point(479, 6);
            this.gbCash.Name = "gbCash";
            this.gbCash.Size = new System.Drawing.Size(442, 210);
            this.gbCash.TabIndex = 19;
            this.gbCash.TabStop = false;
            this.gbCash.Visible = false;
            // 
            // lblCloseCash
            // 
            this.lblCloseCash.AutoSize = true;
            this.lblCloseCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseCash.Location = new System.Drawing.Point(350, 0);
            this.lblCloseCash.Name = "lblCloseCash";
            this.lblCloseCash.Size = new System.Drawing.Size(92, 24);
            this.lblCloseCash.TabIndex = 7;
            this.lblCloseCash.Text = "Close(X)";
            this.lblCloseCash.Click += new System.EventHandler(this.lblCloseCash_Click);
            // 
            // cmdEnter
            // 
            this.cmdEnter.Location = new System.Drawing.Point(32, 152);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(384, 30);
            this.cmdEnter.TabIndex = 6;
            this.cmdEnter.Text = "Press Enter";
            this.cmdEnter.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "Enter Amount (Php)";
            // 
            // txtcash
            // 
            this.txtcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcash.Location = new System.Drawing.Point(32, 61);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(384, 80);
            this.txtcash.TabIndex = 4;
            // 
            // cmdViewLast
            // 
            this.cmdViewLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdViewLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdViewLast.Location = new System.Drawing.Point(1082, 403);
            this.cmdViewLast.Name = "cmdViewLast";
            this.cmdViewLast.Size = new System.Drawing.Size(168, 46);
            this.cmdViewLast.TabIndex = 14;
            this.cmdViewLast.Text = "View Last Txn";
            this.cmdViewLast.UseVisualStyleBackColor = true;
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbSearch.Controls.Add(this.dgProducts);
            this.gbSearch.Location = new System.Drawing.Point(105, 6);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(357, 245);
            this.gbSearch.TabIndex = 18;
            this.gbSearch.TabStop = false;
            this.gbSearch.Visible = false;
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(7, 20);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.Size = new System.Drawing.Size(340, 215);
            this.dgProducts.TabIndex = 3;
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(1082, 464);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(168, 46);
            this.cmdClose.TabIndex = 16;
            this.cmdClose.Text = "Close (F3)";
            this.cmdClose.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(444, 354);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(617, 76);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCancel
            // 
            this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Location = new System.Drawing.Point(1084, 344);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(168, 46);
            this.cmdCancel.TabIndex = 13;
            this.cmdCancel.Text = "Cancel Txn";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdRemove
            // 
            this.cmdRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemove.Location = new System.Drawing.Point(1084, 36);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(168, 46);
            this.cmdRemove.TabIndex = 14;
            this.cmdRemove.Text = "Remove Item";
            this.cmdRemove.UseVisualStyleBackColor = true;
            // 
            // cmdPrint
            // 
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrint.Location = new System.Drawing.Point(1082, 281);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(168, 46);
            this.cmdPrint.TabIndex = 12;
            this.cmdPrint.Text = "Print Receipt (F4)";
            this.cmdPrint.UseVisualStyleBackColor = true;
            // 
            // cmdRAll
            // 
            this.cmdRAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRAll.Location = new System.Drawing.Point(1084, 99);
            this.cmdRAll.Name = "cmdRAll";
            this.cmdRAll.Size = new System.Drawing.Size(168, 46);
            this.cmdRAll.TabIndex = 15;
            this.cmdRAll.Text = "Remove All";
            this.cmdRAll.UseVisualStyleBackColor = true;
            // 
            // cmdCredit
            // 
            this.cmdCredit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCredit.Location = new System.Drawing.Point(1082, 219);
            this.cmdCredit.Name = "cmdCredit";
            this.cmdCredit.Size = new System.Drawing.Size(168, 46);
            this.cmdCredit.TabIndex = 11;
            this.cmdCredit.Text = "Credit (F6)";
            this.cmdCredit.UseVisualStyleBackColor = true;
            this.cmdCredit.Click += new System.EventHandler(this.cmdCredit_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(443, 76);
            this.label7.TabIndex = 1;
            this.label7.Text = "TOTAL (Php)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdCash
            // 
            this.cmdCash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCash.Location = new System.Drawing.Point(1084, 158);
            this.cmdCash.Name = "cmdCash";
            this.cmdCash.Size = new System.Drawing.Size(168, 46);
            this.cmdCash.TabIndex = 10;
            this.cmdCash.Text = "Cash (F5)";
            this.cmdCash.UseVisualStyleBackColor = true;
            this.cmdCash.Click += new System.EventHandler(this.cmdCash_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 25);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.recbg});
            this.shapeContainer1.Size = new System.Drawing.Size(1259, 507);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // recbg
            // 
            this.recbg.BackColor = System.Drawing.Color.DarkBlue;
            this.recbg.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.recbg.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.recbg.FillColor = System.Drawing.Color.DarkBlue;
            this.recbg.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.recbg.Location = new System.Drawing.Point(1071, 3);
            this.recbg.Name = "recbg";
            this.recbg.Size = new System.Drawing.Size(182, 494);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 712);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.gbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            this.gbCart.ResumeLayout(false);
            this.gbCredit.ResumeLayout(false);
            this.gbCredit.PerformLayout();
            this.gbCash.ResumeLayout(false);
            this.gbCash.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsubT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdCash;
        private System.Windows.Forms.Button cmdCredit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.Button cmdRAll;
        private System.Windows.Forms.Button cmdClose;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape recbg;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button cmdViewLast;
        private System.Windows.Forms.GroupBox gbCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcash;
        private System.Windows.Forms.Label lblCloseCash;
        private System.Windows.Forms.GroupBox gbCredit;
        private System.Windows.Forms.Label lblcloseCus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
    }
}

