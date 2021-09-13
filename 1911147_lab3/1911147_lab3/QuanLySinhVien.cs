using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab3
{
    public delegate int SoSanh(object sv1, object sv2);
    public class QuanLySinhVien
    {
        public List<Sinhvien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach = new List<Sinhvien>();
        }
       public void Them(Sinhvien sv)
        {
            this.DanhSach.Add(sv);
        }
        public Sinhvien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
        public void Xoa(object obj,SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for (; i >= 0; i--)
                if (ss(obj, this[i]) == 0)
                    this.DanhSach.RemoveAt(i);
        }
        public Sinhvien Tim(object obj, SoSanh ss)
        {
            Sinhvien svresult = null;
            foreach (Sinhvien sv in DanhSach)
                if(ss(obj,sv)==0)
                {
                    svresult = sv;
                }
            return svresult;
        }
        public bool Sua(Sinhvien svsua,object obj,SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.DanhSach.Count - 1;
            for(i=0;i<count; i++)
                if(ss(obj,this[i])==0)
                {
                    _ = this[i] == svsua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void DocTuFile()
        {
            string filename = "danhsachsinhvien.txt", t;
            string[] s;
            Sinhvien sv;
            StreamReader sr = new StreamReader(new FileStream(filename,FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('*');
                sv = new Sinhvien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NgaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                sv.Gioitinh = false;
                if (s[6] == "1")
                    sv.Gioitinh = true;
                string[] cn = s[7].Split(',');
                foreach (string c in cn)
                    sv.ChuyenNganh.Add(c);
                this.Them(sv);
            }
        }
    }
}
