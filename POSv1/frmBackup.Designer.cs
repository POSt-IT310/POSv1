namespace POSv1
{
    partial class frmBackup
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
            this.cmdBackup = new System.Windows.Forms.Button();
            this.cmdLoc = new System.Windows.Forms.Button();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBackup);
            this.groupBox1.Controls.Add(this.cmdLoc);
            this.groupBox1.Controls.Add(this.txtLoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Information";
            // 
            // cmdBackup
            // 
            this.cmdBackup.Location = new System.Drawing.Point(127, 97);
            this.cmdBackup.Name = "cmdBackup";
            this.cmdBackup.Size = new System.Drawing.Size(154, 23);
            this.cmdBackup.TabIndex = 30;
            this.cmdBackup.Text = "Back-up Database";
            this.cmdBackup.UseVisualStyleBackColor = true;
            // 
            // cmdLoc
            // 
            this.cmdLoc.Location = new System.Drawing.Point(287, 69);
            this.cmdLoc.Name = "cmdLoc";
            this.cmdLoc.Size = new System.Drawing.Size(32, 23);
            this.cmdLoc.TabIndex = 29;
            this.cmdLoc.Text = "...";
            this.cmdLoc.UseVisualStyleBackColor = true;
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(127, 71);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(154, 20);
            this.txtLoc.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Back-up Location";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(127, 45);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(154, 20);
            this.txtFN.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "File Size";
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(127, 19);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(154, 20);
            this.txtLN.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "FIle Name";
            // 
            // folderBD
            // 
            this.folderBD.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 169);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Back-up Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FolderBrowserDialog folderBD;
        private System.Windows.Forms.Button cmdBackup;
        private System.Windows.Forms.Button cmdLoc;
        private System.Windows.Forms.TextBox txtLoc;
    }
}