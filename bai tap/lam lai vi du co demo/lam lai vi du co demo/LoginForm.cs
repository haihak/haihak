using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lam_lai_vi_du_co_demo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginName = txtLoginName.Text;
            var password = txtPassword.Text;

            if(loginName.CompareTo("a")==0 && password.CompareTo("1")==0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
