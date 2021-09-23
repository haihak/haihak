using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab4_controls
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HovaTen { get; set; }
        public bool Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Hinh { get; set; }
        public SinhVien()
        {
            
        }
        public SinhVien(string mssv,string hvt,bool p,DateTime ns,string lop,string sdt, string email, string diachi, string hinh)
        {
            this.MSSV = mssv;
            this.HovaTen = hvt;
            this.Phai = p;
            this.NgaySinh = ns;
            this.Lop = lop;
            this.SDT = sdt;
            this.Email = email;
            this.DiaChi = diachi;
            this.Hinh = hinh;
        }
    }
}
