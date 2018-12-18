namespace Lab_19
{
    partial class Form1
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
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblFraction1 = new System.Windows.Forms.Label();
            this.lblFraction2 = new System.Windows.Forms.Label();
            this.lblFraction3 = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoSub = new System.Windows.Forms.RadioButton();
            this.rdoMulti = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.txtFirstNume = new System.Windows.Forms.TextBox();
            this.txtFirstDeno = new System.Windows.Forms.TextBox();
            this.txtSecondNume = new System.Windows.Forms.TextBox();
            this.txtSecondDeno = new System.Windows.Forms.TextBox();
            this.txtResultNume = new System.Windows.Forms.TextBox();
            this.txtResultDeno = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(22, 57);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(89, 17);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(219, 57);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(110, 17);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Second Number";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(354, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // lblFraction1
            // 
            this.lblFraction1.AutoSize = true;
            this.lblFraction1.Location = new System.Drawing.Point(62, 115);
            this.lblFraction1.Name = "lblFraction1";
            this.lblFraction1.Size = new System.Drawing.Size(12, 17);
            this.lblFraction1.TabIndex = 3;
            this.lblFraction1.Text = "/";
            // 
            // lblFraction2
            // 
            this.lblFraction2.AutoSize = true;
            this.lblFraction2.Location = new System.Drawing.Point(259, 115);
            this.lblFraction2.Name = "lblFraction2";
            this.lblFraction2.Size = new System.Drawing.Size(12, 17);
            this.lblFraction2.TabIndex = 4;
            this.lblFraction2.Text = "/";
            // 
            // lblFraction3
            // 
            this.lblFraction3.AutoSize = true;
            this.lblFraction3.Location = new System.Drawing.Point(394, 115);
            this.lblFraction3.Name = "lblFraction3";
            this.lblFraction3.Size = new System.Drawing.Size(12, 17);
            this.lblFraction3.TabIndex = 5;
            this.lblFraction3.Text = "/";
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(325, 115);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(16, 17);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "=";
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(148, 52);
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
            this.rdoSub.Location = new System.Drawing.Point(148, 80);
            this.rdoSub.Name = "rdoSub";
            this.rdoSub.Size = new System.Drawing.Size(34, 21);
            this.rdoSub.TabIndex = 4;
            this.rdoSub.TabStop = true;
            this.rdoSub.Text = "-";
            this.rdoSub.UseVisualStyleBackColor = true;
            // 
            // rdoMulti
            // 
            this.rdoMulti.AutoSize = true;
            this.rdoMulti.Location = new System.Drawing.Point(148, 108);
            this.rdoMulti.Name = "rdoMulti";
            this.rdoMulti.Size = new System.Drawing.Size(34, 21);
            this.rdoMulti.TabIndex = 5;
            this.rdoMulti.TabStop = true;
            this.rdoMulti.Text = "*";
            this.rdoMulti.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(148, 136);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(33, 21);
            this.rdoDiv.TabIndex = 6;
            this.rdoDiv.TabStop = true;
            this.rdoDiv.Text = "/";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // txtFirstNume
            // 
            this.txtFirstNume.Location = new System.Drawing.Point(25, 113);
            this.txtFirstNume.Name = "txtFirstNume";
            this.txtFirstNume.Size = new System.Drawing.Size(30, 22);
            this.txtFirstNume.TabIndex = 0;
            this.txtFirstNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoDigit);
            // 
            // txtFirstDeno
            // 
            this.txtFirstDeno.Location = new System.Drawing.Point(81, 113);
            this.txtFirstDeno.Name = "txtFirstDeno";
            this.txtFirstDeno.Size = new System.Drawing.Size(30, 22);
            this.txtFirstDeno.TabIndex = 1;
            this.txtFirstDeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoDigit);
            // 
            // txtSecondNume
            // 
            this.txtSecondNume.Location = new System.Drawing.Point(222, 113);
            this.txtSecondNume.Name = "txtSecondNume";
            this.txtSecondNume.Size = new System.Drawing.Size(30, 22);
            this.txtSecondNume.TabIndex = 7;
            this.txtSecondNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoDigit);
            // 
            // txtSecondDeno
            // 
            this.txtSecondDeno.Location = new System.Drawing.Point(278, 113);
            this.txtSecondDeno.Name = "txtSecondDeno";
            this.txtSecondDeno.Size = new System.Drawing.Size(30, 22);
            this.txtSecondDeno.TabIndex = 8;
            this.txtSecondDeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoDigit);
            // 
            // txtResultNume
            // 
            this.txtResultNume.Location = new System.Drawing.Point(357, 113);
            this.txtResultNume.Name = "txtResultNume";
            this.txtResultNume.ReadOnly = true;
            this.txtResultNume.Size = new System.Drawing.Size(30, 22);
            this.txtResultNume.TabIndex = 9;
            // 
            // txtResultDeno
            // 
            this.txtResultDeno.Location = new System.Drawing.Point(413, 113);
            this.txtResultDeno.Name = "txtResultDeno";
            this.txtResultDeno.ReadOnly = true;
            this.txtResultDeno.Size = new System.Drawing.Size(30, 22);
            this.txtResultDeno.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(65, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(337, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Perform Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCalculate_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 229);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblFraction1);
            this.Controls.Add(this.lblFraction2);
            this.Controls.Add(this.lblFraction3);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.rdoSub);
            this.Controls.Add(this.rdoMulti);
            this.Controls.Add(this.rdoDiv);
            this.Controls.Add(this.txtFirstNume);
            this.Controls.Add(this.txtFirstDeno);
            this.Controls.Add(this.txtSecondNume);
            this.Controls.Add(this.txtSecondDeno);
            this.Controls.Add(this.txtResultNume);
            this.Controls.Add(this.txtResultDeno);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Fraction Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFraction1;
        private System.Windows.Forms.Label lblFraction2;
        private System.Windows.Forms.Label lblFraction3;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoSub;
        private System.Windows.Forms.RadioButton rdoMulti;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.TextBox txtFirstNume;
        private System.Windows.Forms.TextBox txtFirstDeno;
        private System.Windows.Forms.TextBox txtSecondNume;
        private System.Windows.Forms.TextBox txtSecondDeno;
        private System.Windows.Forms.TextBox txtResultNume;
        private System.Windows.Forms.TextBox txtResultDeno;
        private System.Windows.Forms.Button btnCalculate;
    }
}

