namespace Lab_18
{
    partial class FormCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMulti = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 37);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(89, 17);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First Number";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(195, 37);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(110, 17);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(329, 37);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(310, 77);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(16, 17);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(136, 33);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(37, 21);
            this.rdoAdd.TabIndex = 3;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "+";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoSub
            // 
            this.rdoSub.AutoSize = true;
            this.rdoSub.Location = new System.Drawing.Point(136, 60);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(34, 21);
            this.rdoSub.TabIndex = 5;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "-";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMulti
            // 
            this.rdoMulti.AutoSize = true;
            this.rdoMulti.Location = new System.Drawing.Point(136, 87);
            this.rdoMulti.Name = "rdoMulti";
            this.rdoMulti.Size = new System.Drawing.Size(34, 21);
            this.rdoMulti.TabIndex = 7;
            this.rdoMulti.TabStop = true;
            this.rdoMulti.Text = "*";
            this.rdoMulti.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(136, 114);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(33, 21);
            this.rdoDiv.TabIndex = 9;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "/";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(15, 72);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(50, 22);
            this.txtFirst.TabIndex = 1;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(198, 72);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(50, 22);
            this.txtSecond.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(332, 72);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(50, 22);
            this.txtResult.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(51, 171);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(300, 23);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Perform Operation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalculate_KeyPress);
            this.btnCalculate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalculate_MouseClick);
            // 
            // FormCalculator
            // 
            this.ClientSize = new System.Drawing.Size(411, 206);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.rdoMulti);
            this.Controls.Add(this.rdoDiv);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FormCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoMulti;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}

