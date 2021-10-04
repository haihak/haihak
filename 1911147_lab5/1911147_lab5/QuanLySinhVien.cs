using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1911147_lab5
{
    public delegate int SoSanh(object sv0, object sv1);
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public void DocTuFile()
        {
            string filename = "haihak.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
            while((t = sr.ReadLine())!= null)
            {
                s = t.Split('*');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HovTen = s[1];
                sv.Ten = s[2];
                sv.NgaySinh = DateTime.Parse(s[3]);
                sv.GioiTinh = false;
                if (s[4] == "1")
                    sv.GioiTinh = true;
                sv.Lop = s[5];
                sv.CMND = s[6];
                sv.SDT = s[7];
                sv.DiaChi = s[8];
                this.Them(sv);
            }
        }
        public SinhVien ThemSV(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                    break;
                }
            return svresult;
        }
    }
}
