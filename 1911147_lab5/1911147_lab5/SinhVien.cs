using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab5
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HovTen { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Lop { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string mssv,string hovten, string ten, DateTime ngaysinh,bool gioitinh, string lop, string cmnd, string sdt, string diachi)
        {
            this.MSSV = mssv;
            this.HovTen = hovten;
            this.Ten = ten;
            this.NgaySinh = ngaysinh;
            this.GioiTinh = gioitinh;
            this.Lop = lop;
            this.CMND = cmnd;
            this.SDT = sdt;
            this.DiaChi = diachi;
        }

    }
}
