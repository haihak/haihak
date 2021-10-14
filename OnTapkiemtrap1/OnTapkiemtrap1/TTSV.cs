using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapkiemtrap1
{
    public partial class formTTSV : Form
    {
        private QLSV qlsv;
        public formTTSV()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            /* SinhVien sv = GetSinhvien();
             SinhVien kq = qlsv.Tim(sv.MSSV,delegate(object obj,object obj1)
             {
                 return (obj1 as SinhVien).MSSV.CompareTo(obj.ToString());
             });
             if(kq == null)
             {

             }
             else
             {
                 qlsv.Them(GetSinhvien());

                 Close();
             }   */
            DialogResult = DialogResult.OK;
        }
        private void formTTSV_Load(object sender, EventArgs e)
        {

        }
       /* private SinhVien GetSinhvien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MSSV = this.mktbMSSV.Text;
            sv.HoVaTenLot = this.txtHovaTenLot.Text;
            sv.Ten = this.txtTen.Text;
            if (rdbtnNu.Checked)
                gt = false;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.SDT = this.mktbSDT.Text;
            sv.Lop = this.cbbLop.Text;
            sv.Khoa = this.cbbKhoa.Text;
            sv.DiaChi = this.txtDiaChi.Text;
            return sv;
        }*/
        
    }
}
