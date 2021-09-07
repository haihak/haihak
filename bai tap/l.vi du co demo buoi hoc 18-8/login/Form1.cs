using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        string Taikhoan = "haihak";
        string Matkhau = "haihak";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(kiemtradangnhap(txtUser.Text,txtPassword.Text))
            {
                dangnhap f = new dangnhap();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "error");
                txtPassword.Focus();
            }
        }
        bool kiemtradangnhap(string taikhoan,string matkhau)
        {
            if(taikhoan == this.Taikhoan && matkhau==this.Matkhau)
            {
                return true;
            }
            return false;
        }
    }
}
