
namespace lb_tb_btn
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(58, 311);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(24, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(139, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(125, 27);
            this.txtUser.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(24, 136);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(85, 20);
            this.lbDescription.TabIndex = 6;
            this.lbDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 159);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 130);
            this.txtDescription.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 352);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

