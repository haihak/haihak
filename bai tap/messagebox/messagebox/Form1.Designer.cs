
namespace messagebox
{
    partial class Form1
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
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(17, 15);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(95, 35);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(118, 15);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(95, 35);
            this.btnError.TabIndex = 1;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(17, 56);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(95, 35);
            this.btnWarning.TabIndex = 2;
            this.btnWarning.Text = "Warning";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnQuestion
            // 
            this.btnQuestion.Location = new System.Drawing.Point(118, 56);
            this.btnQuestion.Name = "btnQuestion";
            this.btnQuestion.Size = new System.Drawing.Size(95, 35);
            this.btnQuestion.TabIndex = 3;
            this.btnQuestion.Text = "Question";
            this.btnQuestion.UseVisualStyleBackColor = true;
            this.btnQuestion.Click += new System.EventHandler(this.btnQuestion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 115);
            this.Controls.Add(this.btnQuestion);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnInformation);
            this.Name = "Form1";
            this.Text = "messagebox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnQuestion;
    }
}

