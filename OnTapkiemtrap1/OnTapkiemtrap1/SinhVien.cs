using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapkiemtrap1
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoVaTenLot { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }
        public string DiaChi { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string mssv, string hvtl, string ten, bool gt, DateTime ns,string sdt, string lop,string khoa,string diachi)
        {
            this.MSSV = mssv;
            this.HoVaTenLot = hvtl;
            this.Ten = ten;
            this.GioiTinh = gt;
            this.NgaySinh = ns;
            this.SDT = sdt;
            this.Lop = lop;
            this.Khoa = khoa;
            this.DiaChi = diachi;
        }
    }
}
