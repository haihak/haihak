
namespace login
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
            this.IbIUser = new System.Windows.Forms.Label();
            this.IbIPassword = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IbIUser
            // 
            this.IbIUser.AutoSize = true;
            this.IbIUser.Location = new System.Drawing.Point(27, 20);
            this.IbIUser.Name = "IbIUser";
            this.IbIUser.Size = new System.Drawing.Size(38, 20);
            this.IbIUser.TabIndex = 0;
            this.IbIUser.Text = "User";
            // 
            // IbIPassword
            // 
            this.IbIPassword.AutoSize = true;
            this.IbIPassword.Location = new System.Drawing.Point(27, 65);
            this.IbIPassword.Name = "IbIPassword";
            this.IbIPassword.Size = new System.Drawing.Size(70, 20);
            this.IbIPassword.TabIndex = 1;
            this.IbIPassword.Text = "Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(44, 110);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(103, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(103, 20);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(142, 27);
            this.txtUser.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 301);
            this.Controls.Add(this.IbIUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.IbIPassword);
            this.Name = "Form1";
            this.Text = "Ok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbIUser;
        private System.Windows.Forms.Label IbIPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
    }
}

