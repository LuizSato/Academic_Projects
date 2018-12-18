namespace Lab_22
{
    partial class Search
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblResultNumber = new System.Windows.Forms.Label();
            this.lblResultName = new System.Windows.Forms.Label();
            this.lblResultSymbol = new System.Windows.Forms.Label();
            this.lblResultDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(30, 56);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(112, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(222, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblResult
            // 
            this.lblResultNumber.AutoSize = true;
            this.lblResultNumber.Location = new System.Drawing.Point(30, 86);
            this.lblResultNumber.Name = "lblResultName";
            this.lblResultNumber.Size = new System.Drawing.Size(62, 17);
            this.lblResultNumber.TabIndex = 4;
            this.lblResultNumber.Text = "Number:";
            // 
            // lblResultName
            // 
            this.lblResultName.AutoSize = true;
            this.lblResultName.Location = new System.Drawing.Point(30, 115);
            this.lblResultName.Name = "lblResultName";
            this.lblResultName.Size = new System.Drawing.Size(49, 17);
            this.lblResultName.TabIndex = 5;
            this.lblResultName.Text = "Name:";
            // 
            // lblResultSymbol
            // 
            this.lblResultSymbol.AutoSize = true;
            this.lblResultSymbol.Location = new System.Drawing.Point(119, 86);
            this.lblResultSymbol.Name = "lblResultSymbol";
            this.lblResultSymbol.Size = new System.Drawing.Size(54, 17);
            this.lblResultSymbol.TabIndex = 6;
            this.lblResultSymbol.Text = "Symbol";
            // 
            // lblResultDescription
            // 
            this.lblResultDescription.AutoSize = true;
            this.lblResultDescription.Location = new System.Drawing.Point(119, 115);
            this.lblResultDescription.Name = "lblResultDescription";
            this.lblResultDescription.Size = new System.Drawing.Size(83, 17);
            this.lblResultDescription.TabIndex = 7;
            this.lblResultDescription.Text = "Description:";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 187);
            this.Controls.Add(this.lblResultNumber);
            this.Controls.Add(this.lblResultName);
            this.Controls.Add(this.lblResultSymbol);
            this.Controls.Add(this.lblResultDescription);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClose);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblResultNumber;
        private System.Windows.Forms.Label lblResultName;
        private System.Windows.Forms.Label lblResultSymbol;
        private System.Windows.Forms.Label lblResultDescription;
    }
}