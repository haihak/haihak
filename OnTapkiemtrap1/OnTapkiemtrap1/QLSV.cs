using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OnTapkiemtrap1.Properties;

namespace OnTapkiemtrap1
{
    public delegate int SoSanh(object sv1, object sv2);

    public class QLSV
    {
        public List<SinhVien> DanhSach;
        
        public QLSV()
        {
            DanhSach = new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            this.DanhSach.Add(sv);          
        }
        public void Xoa(object obj, SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public SinhVien Tim(object obj, SoSanh ss)
        {
            SinhVien svresult = null;
            foreach (SinhVien sv in DanhSach)
                if (ss(obj, sv) == 0)
                {
                    svresult = sv;
                }
            return svresult;
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
            while((t = sr.ReadLine()) != null)
            {
                s = t.Split('\t');
                sv = new SinhVien();
                sv.MSSV = s[0];
                sv.HoVaTenLot = s[1];
                sv.Ten = s[2];
                sv.GioiTinh = true;
                sv.NgaySinh = DateTime.MinValue;
                sv.SDT = "";
                sv.Lop = s[3];
                sv.Khoa = s[4];
                sv.DiaChi = "";
                this.Them(sv);
            }
        }
    }
}
