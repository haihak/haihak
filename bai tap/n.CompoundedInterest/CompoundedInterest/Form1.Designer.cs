
namespace CompoundedInterest
{
    partial class txtInterestRate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoAnnually = new System.Windows.Forms.RadioButton();
            this.rdoSemiannually = new System.Windows.Forms.RadioButton();
            this.rdoQuarterly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFutureValue = new System.Windows.Forms.TextBox();
            this.txtInterestEarned = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPeriods);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.txtPrincipal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loan Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(118, 129);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(89, 27);
            this.txtPeriods.TabIndex = 5;
            this.txtPeriods.Text = "1";
            this.txtPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(118, 81);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(89, 27);
            this.txt.TabIndex = 4;
            this.txt.Text = "8.25";
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(118, 37);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(89, 27);
            this.txtPrincipal.TabIndex = 3;
            this.txtPrincipal.Text = "0.00";
            this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Periods:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoAnnually);
            this.groupBox2.Controls.Add(this.rdoSemiannually);
            this.groupBox2.Controls.Add(this.rdoQuarterly);
            this.groupBox2.Controls.Add(this.rdoMonthly);
            this.groupBox2.Location = new System.Drawing.Point(352, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compound Frequency";
            // 
            // rdoAnnually
            // 
            this.rdoAnnually.AutoSize = true;
            this.rdoAnnually.Location = new System.Drawing.Point(21, 165);
            this.rdoAnnually.Name = "rdoAnnually";
            this.rdoAnnually.Size = new System.Drawing.Size(87, 24);
            this.rdoAnnually.TabIndex = 3;
            this.rdoAnnually.TabStop = true;
            this.rdoAnnually.Text = "Annually";
            this.rdoAnnually.UseVisualStyleBackColor = true;
            this.rdoAnnually.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rdoSemiannually
            // 
            this.rdoSemiannually.AutoSize = true;
            this.rdoSemiannually.Location = new System.Drawing.Point(21, 119);
            this.rdoSemiannually.Name = "rdoSemiannually";
            this.rdoSemiannually.Size = new System.Drawing.Size(118, 24);
            this.rdoSemiannually.TabIndex = 2;
            this.rdoSemiannually.TabStop = true;
            this.rdoSemiannually.Text = "Semiannually";
            this.rdoSemiannually.UseVisualStyleBackColor = true;
            this.rdoSemiannually.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdoQuarterly
            // 
            this.rdoQuarterly.AutoSize = true;
            this.rdoQuarterly.Location = new System.Drawing.Point(21, 80);
            this.rdoQuarterly.Name = "rdoQuarterly";
            this.rdoQuarterly.Size = new System.Drawing.Size(91, 24);
            this.rdoQuarterly.TabIndex = 1;
            this.rdoQuarterly.TabStop = true;
            this.rdoQuarterly.Text = "Quarterly";
            this.rdoQuarterly.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Location = new System.Drawing.Point(21, 36);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(84, 24);
            this.rdoMonthly.TabIndex = 0;
            this.rdoMonthly.TabStop = true;
            this.rdoMonthly.Text = "Monthly";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            this.rdoMonthly.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(554, 40);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 29);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(554, 75);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFutureValue);
            this.groupBox3.Controls.Add(this.txtInterestEarned);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(21, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 96);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // txtFutureValue
            // 
            this.txtFutureValue.Location = new System.Drawing.Point(368, 46);
            this.txtFutureValue.Name = "txtFutureValue";
            this.txtFutureValue.ReadOnly = true;
            this.txtFutureValue.Size = new System.Drawing.Size(89, 27);
            this.txtFutureValue.TabIndex = 11;
            this.txtFutureValue.Text = "0.00";
            this.txtFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterestEarned
            // 
            this.txtInterestEarned.Location = new System.Drawing.Point(132, 46);
            this.txtInterestEarned.Name = "txtInterestEarned";
            this.txtInterestEarned.ReadOnly = true;
            this.txtInterestEarned.Size = new System.Drawing.Size(89, 27);
            this.txtInterestEarned.TabIndex = 10;
            this.txtInterestEarned.Text = "0.00";
            this.txtInterestEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Amount Earned:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Interest Eamed:";
            // 
            // txtInterestRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 358);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "txtInterestRate";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoAnnually;
        private System.Windows.Forms.RadioButton rdoSemiannually;
        private System.Windows.Forms.RadioButton rdoQuarterly;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.TextBox txtFutureValue;
        private System.Windows.Forms.TextBox txtInterestEarned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

