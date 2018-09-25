namespace BankSample
{
    partial class BranchForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFIrstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAptNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStreetNum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bankFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.txtProvince = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1239, 581);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(171, 45);
            this.btnOpen.TabIndex = 13;
            this.btnOpen.Text = "Open Customer";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1082, 581);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 45);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(914, 581);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 45);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(755, 581);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 45);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(12, 54);
            this.lblBranchName.MinimumSize = new System.Drawing.Size(0, 5);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(142, 25);
            this.lblBranchName.TabIndex = 37;
            this.lblBranchName.Text = "Branch Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(750, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(958, 162);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(452, 31);
            this.txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name:";
            // 
            // txtFIrstName
            // 
            this.txtFIrstName.Location = new System.Drawing.Point(958, 204);
            this.txtFIrstName.Name = "txtFIrstName";
            this.txtFIrstName.Size = new System.Drawing.Size(452, 31);
            this.txtFIrstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customers";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 25;
            this.lstCustomers.Location = new System.Drawing.Point(12, 130);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(732, 504);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.bankFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1422, 40);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1038, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Phone Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Postal Code:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(958, 409);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(452, 31);
            this.txtCity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Street Name:";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(958, 285);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(452, 31);
            this.txtStreetName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(750, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Apartment Number:";
            // 
            // txtAptNum
            // 
            this.txtAptNum.Location = new System.Drawing.Point(958, 368);
            this.txtAptNum.Name = "txtAptNum";
            this.txtAptNum.Size = new System.Drawing.Size(452, 31);
            this.txtAptNum.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(750, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Street Number:";
            // 
            // txtStreetNum
            // 
            this.txtStreetNum.Location = new System.Drawing.Point(958, 327);
            this.txtStreetNum.Name = "txtStreetNum";
            this.txtStreetNum.Size = new System.Drawing.Size(452, 31);
            this.txtStreetNum.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1033, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Customer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(750, 454);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 58;
            this.label11.Text = "Province:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(750, 413);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 25);
            this.label12.TabIndex = 57;
            this.label12.Text = "City:";
            // 
            // bankFormToolStripMenuItem
            // 
            this.bankFormToolStripMenuItem.Name = "bankFormToolStripMenuItem";
            this.bankFormToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.bankFormToolStripMenuItem.Text = "Bank Form";
            this.bankFormToolStripMenuItem.Click += new System.EventHandler(this.bankFormToolStripMenuItem_Click_1);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(958, 532);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(452, 31);
            this.txtPhone.TabIndex = 9;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(958, 492);
            this.txtPostalCode.Mask = "L9L-9L9";
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(452, 31);
            this.txtPostalCode.TabIndex = 8;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(958, 451);
            this.txtProvince.Mask = "LL";
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(452, 31);
            this.txtProvince.TabIndex = 7;
            // 
            // BranchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 664);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAptNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStreetNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFIrstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCustomers);
            this.Name = "BranchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BranchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BranchForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFIrstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAptNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStreetNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripMenuItem bankFormToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtPostalCode;
        private System.Windows.Forms.MaskedTextBox txtProvince;
    }
}