using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_lab5
{
    public partial class formSV : Form
    {
        QuanLySinhVien qlsv;
        public formSV()
        {
            InitializeComponent();
        }
        private void formSV_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool a = true;
            List<string> b = new List<string>();
            sv.MSSV = this.mktbMSSV.Text;
            sv.HovTen = this.txtHovTen.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            if (rdbNu.Checked)
                a = false;
            sv.GioiTinh = a;
            sv.Lop = this.cbbLop.Text;
            sv.CMND = this.mktbCMND.Text;
            sv.SDT = this.mktbSDT.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            return sv;
        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HovTen = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.GioiTinh = false;
            if (lvitem.SubItems[4].Text == "Nam")
                sv.GioiTinh = true;
            sv.Lop = lvitem.SubItems[5].Text;
            sv.CMND = lvitem.SubItems[6].Text;
            sv.SDT = lvitem.SubItems[7].Text;
            sv.DiaChi = lvitem.SubItems[8].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mktbMSSV.Text = sv.MSSV;
            this.txtHovTen.Text = sv.HovTen;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            if (sv.GioiTinh)
                this.rdbNam.Checked = true;
            else
                this.rdbNu.Checked = true;
            this.cbbLop.Text = sv.Lop;
            this.mktbCMND.Text = sv.CMND;
            this.mktbSDT.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;
        }
        private void ThemSinhVien(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HovTen);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            string a = "Nữ";
            if (sv.GioiTinh)
                a = "Nam";
            lvitem.SubItems.Add(a);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.CMND);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChi);
            this.lvDSSV.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSinhVien(sv);
            }
        }
        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool sua;
            SinhVien kq = qlsv.ThemSV(sv.MSSV, delegate (object obj01, object obj02)
                {
                    return (obj02 as SinhVien).MSSV.CompareTo(obj01.ToString());
                });
            if (kq != null)
                MessageBox.Show("MSSV đã xuất hiện ràu!", "Lỗi siêu to", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
    }
}

