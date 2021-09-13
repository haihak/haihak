using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab3
{
    public class Sinhvien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool Gioitinh { get; set; }
        public List<string> ChuyenNganh { get; set; }

        public Sinhvien()
        {
            ChuyenNganh = new List<string>();
        }
        public Sinhvien(string ms, string ht, DateTime ngay, string dc, string lop,string hinh, bool gt, List<string>cn)
        {
            this.MaSo = ms;
            this.HoTen = ht;
            this.NgaySinh = ngay;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.Gioitinh = gt;
            this.ChuyenNganh = cn;
        }
    }
}
