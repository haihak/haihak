using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_lab4_controls
{
    public partial class FormQLSV : Form
    {
        QLSV qlsv;
        public FormQLSV()
        {
            InitializeComponent();
        }

        private void FormQLSV_Load(object sender, EventArgs e)
        {
            qlsv = new QLSV();
            qlsv.DocTufile();
            LoadListView();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChonhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Picture";
            dlg.Filter = "Image File (JPEG, GIF, BMP, etc.)|"
                            + "*.jpg;*.jpeg;*.gif;*.bmp"
                            + "*.tif;*.tiff;*.png|"
                        + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                        + "GIF files (*.gif)|*.gif|"
                        + "BMP files (*.bmp)|*.bmp|"
                        + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                        + "PNG files (*.png)|*.png|"
                        + "ALL files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filename = dlg.FileName;
                txtHinh.Text = filename;
                ptbhinh.Load(filename);
            }
        }

        private void btnMacdinh_Click(object sender, EventArgs e)
        {
            this.mtbMSSV.Text = "";
            this.txtEmail.Text = "";
            this.txtDiachi.Text = "";
            this.txtHinh.Text = "";
            this.txtName.Text = "";
            this.dttdate.Value = DateTime.Now;
            this.ptbhinh.ImageLocation = "";
            this.cbbLop.Text = this.cbbLop.Items[0].ToString();
            this.rbtNam.Checked = true;
            this.mtbSĐT.Text = "";
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool p = true;
            List<string> cn = new List<string>();
            sv.MSSV = this.mtbMSSV.Text;
            sv.HovaTen = this.txtName.Text;
            if (rbtNu.Checked)
                p = false;
            sv.Phai = p;
            sv.NgaySinh = this.dttdate.Value;
            sv.Lop = this.cbbLop.Text;
            sv.SDT = this.mtbSĐT.Text;
            sv.Email = this.txtEmail.Text;
            sv.DiaChi = this.txtDiachi.Text;
            sv.Hinh = this.txtHinh.Text;
            return sv;
        }
       private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HovaTen = lvitem.SubItems[1].Text;
            sv.Phai = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.Phai = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtbMSSV.Text = sv.MSSV;
            this.txtName.Text = sv.HovaTen;
            if (sv.Phai)
                this.rbtNam.Checked = true;
            else
                this.rbtNu.Checked = true;
            this.dttdate.Value = sv.NgaySinh;
            this.cbbLop.Text = sv.Lop;
            this.mtbSĐT.Text = sv.SDT;
            this.txtEmail.Text = sv.Email;
            this.txtDiachi.Text = sv.DiaChi;
            this.txtHinh.Text = sv.Hinh;
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HovaTen);
            string p= "Nữ";
            if (sv.Phai)
                p = "Nam";
            lvitem.SubItems.Add(p);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Email);
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Hinh);
            this.lvDSSV.Items.Add(lvitem);
        }
        private void LoadListView()
        {
            this.lvDSSV.Items.Clear();
            foreach(SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if(count >0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool sua;

            SinhVien kq = qlsv.Tim(sv.MSSV, delegate (object obj1, object obj2)
                {
                    return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("MSSV đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }
        /*private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }*/
    }
}
