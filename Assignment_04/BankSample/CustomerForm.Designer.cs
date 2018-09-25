namespace BankSample
{
    partial class CustomerForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branchFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFIrstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.lblAccountProperties = new System.Windows.Forms.Label();
            this.grpAccountType = new System.Windows.Forms.GroupBox();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnSaving = new System.Windows.Forms.RadioButton();
            this.lstTransactions = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnDebit = new System.Windows.Forms.RadioButton();
            this.rbtnDeposit = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.txtAccountProperties = new System.Windows.Forms.MaskedTextBox();
            this.txtAmount = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 84;
            this.label10.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 81;
            this.label5.Text = "AccountNumber:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(495, 228);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(286, 31);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Balance:";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(495, 270);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(286, 31);
            this.txtBalance.TabIndex = 62;
            this.txtBalance.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Account";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.branchFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1530, 40);
            this.menuStrip1.TabIndex = 77;
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(164, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // branchFormToolStripMenuItem
            // 
            this.branchFormToolStripMenuItem.Name = "branchFormToolStripMenuItem";
            this.branchFormToolStripMenuItem.Size = new System.Drawing.Size(141, 36);
            this.branchFormToolStripMenuItem.Text = "Bank Form";
            this.branchFormToolStripMenuItem.Click += new System.EventHandler(this.branchFormToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(636, 448);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 45);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(468, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 45);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(309, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(12, 12);
            this.lblBranchName.MinimumSize = new System.Drawing.Size(0, 5);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(142, 25);
            this.lblBranchName.TabIndex = 76;
            this.lblBranchName.Text = "Branch Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 75;
            this.label3.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(495, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(286, 31);
            this.txtLastName.TabIndex = 59;
            this.txtLastName.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "First Name:";
            // 
            // txtFIrstName
            // 
            this.txtFIrstName.Location = new System.Drawing.Point(495, 96);
            this.txtFIrstName.Name = "txtFIrstName";
            this.txtFIrstName.ReadOnly = true;
            this.txtFIrstName.Size = new System.Drawing.Size(286, 31);
            this.txtFIrstName.TabIndex = 60;
            this.txtFIrstName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Accounts";
            // 
            // lstAccounts
            // 
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.ItemHeight = 25;
            this.lstAccounts.Location = new System.Drawing.Point(12, 169);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(258, 329);
            this.lstAccounts.TabIndex = 1;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.lstAccounts_SelectedIndexChanged);
            // 
            // lblAccountProperties
            // 
            this.lblAccountProperties.AutoSize = true;
            this.lblAccountProperties.Location = new System.Drawing.Point(287, 389);
            this.lblAccountProperties.Name = "lblAccountProperties";
            this.lblAccountProperties.Size = new System.Drawing.Size(63, 25);
            this.lblAccountProperties.TabIndex = 86;
            this.lblAccountProperties.Text = "Rate:";
            // 
            // grpAccountType
            // 
            this.grpAccountType.Controls.Add(this.rbtnChecking);
            this.grpAccountType.Controls.Add(this.rbtnSaving);
            this.grpAccountType.Location = new System.Drawing.Point(338, 307);
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.Size = new System.Drawing.Size(443, 73);
            this.grpAccountType.TabIndex = 3;
            this.grpAccountType.TabStop = false;
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(281, 31);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(133, 29);
            this.rbtnChecking.TabIndex = 1;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // rbtnSaving
            // 
            this.rbtnSaving.AutoSize = true;
            this.rbtnSaving.Checked = true;
            this.rbtnSaving.Location = new System.Drawing.Point(57, 31);
            this.rbtnSaving.Name = "rbtnSaving";
            this.rbtnSaving.Size = new System.Drawing.Size(109, 29);
            this.rbtnSaving.TabIndex = 3;
            this.rbtnSaving.TabStop = true;
            this.rbtnSaving.Text = "Saving";
            this.rbtnSaving.UseVisualStyleBackColor = true;
            this.rbtnSaving.CheckedChanged += new System.EventHandler(this.rbtnSaving_CheckedChanged);
            // 
            // lstTransactions
            // 
            this.lstTransactions.FormattingEnabled = true;
            this.lstTransactions.ItemHeight = 25;
            this.lstTransactions.Location = new System.Drawing.Point(828, 169);
            this.lstTransactions.Name = "lstTransactions";
            this.lstTransactions.Size = new System.Drawing.Size(258, 329);
            this.lstTransactions.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(823, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 25);
            this.label6.TabIndex = 89;
            this.label6.Text = "Transactions";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDebit);
            this.groupBox1.Controls.Add(this.rbtnDeposit);
            this.groupBox1.Location = new System.Drawing.Point(1153, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 98);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // rbtnDebit
            // 
            this.rbtnDebit.AutoSize = true;
            this.rbtnDebit.Location = new System.Drawing.Point(198, 41);
            this.rbtnDebit.Name = "rbtnDebit";
            this.rbtnDebit.Size = new System.Drawing.Size(93, 29);
            this.rbtnDebit.TabIndex = 1;
            this.rbtnDebit.Text = "Debit";
            this.rbtnDebit.UseVisualStyleBackColor = true;
            // 
            // rbtnDeposit
            // 
            this.rbtnDeposit.AutoSize = true;
            this.rbtnDeposit.Checked = true;
            this.rbtnDeposit.Location = new System.Drawing.Point(20, 41);
            this.rbtnDeposit.Name = "rbtnDeposit";
            this.rbtnDeposit.Size = new System.Drawing.Size(116, 29);
            this.rbtnDeposit.TabIndex = 9;
            this.rbtnDeposit.TabStop = true;
            this.rbtnDeposit.Text = "Deposit";
            this.rbtnDeposit.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1103, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "Amount:";
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(1258, 369);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(111, 45);
            this.btnTransaction.TabIndex = 11;
            this.btnTransaction.Text = "OK";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // txtAccountProperties
            // 
            this.txtAccountProperties.Location = new System.Drawing.Point(495, 389);
            this.txtAccountProperties.Mask = "00000";
            this.txtAccountProperties.Name = "txtAccountProperties";
            this.txtAccountProperties.Size = new System.Drawing.Size(286, 31);
            this.txtAccountProperties.TabIndex = 4;
            this.txtAccountProperties.ValidatingType = typeof(int);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1200, 286);
            this.txtAmount.Mask = "99999999";
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(318, 31);
            this.txtAmount.TabIndex = 10;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 518);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccountProperties);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstTransactions);
            this.Controls.Add(this.grpAccountType);
            this.Controls.Add(this.lblAccountProperties);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFIrstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAccounts);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccountType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchFormToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFIrstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.Label lblAccountProperties;
        private System.Windows.Forms.GroupBox grpAccountType;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.RadioButton rbtnSaving;
        private System.Windows.Forms.ListBox lstTransactions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDebit;
        private System.Windows.Forms.RadioButton rbtnDeposit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.MaskedTextBox txtAccountProperties;
        private System.Windows.Forms.MaskedTextBox txtAmount;
    }
}