using System;
using System.Collections.Generic;
using System.Text;

namespace login
{
    public class taikhoan
    {
        private string Taikhoan;
        private string Matkhau;

        public string Taikhoan1 
        { 
            get => Taikhoan; 
            set => Taikhoan = value; 
        }
        public string Matkhau1 
        { 
            get => Matkhau; 
            set => Matkhau = value; 
        }
        taikhoan(string taikhoan,string matkhau)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
        }
    }
}
