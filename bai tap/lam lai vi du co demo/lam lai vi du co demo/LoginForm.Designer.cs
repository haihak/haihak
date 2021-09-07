
namespace lam_lai_vi_du_co_demo
{
    partial class LoginForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(114, 136);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 30);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(185, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "1";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(139, 51);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(185, 27);
            this.txtLoginName.TabIndex = 6;
            this.txtLoginName.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(14, 118);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(12, 20);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chi nhánh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Items.AddRange(new object[] {
            "Garena",
            "EPic",
            "CyberHunter"});
            this.cbbChiNhanh.Location = new System.Drawing.Point(139, 16);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(185, 28);
            this.cbbChiNhanh.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 193);
            this.Controls.Add(this.cbbChiNhanh);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label lblMessage;
    }
}