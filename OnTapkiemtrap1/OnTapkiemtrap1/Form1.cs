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
    public partial class FormQLSV : Form
    {   
        QLSV qlsv;
        private const string placeholdertext = "Nhập thông tin cần tìm";
        public FormQLSV()
        {
            InitializeComponent();
        }
        
        private void FormQLSV_Load(object sender, EventArgs e)
        {
            qlsv = new QLSV();
            qlsv.DocTuFile();
            LoadListView();
            AnHienTimKiem();
            HienTreeView(qlsv.DanhSach);
        }

        
        private void ThemSinhVien(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoVaTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.GioiTinh == true ? "Nam" : "Nữ");
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.Khoa);
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


        /*void HienTreeView(SinhVien sv)
        {
            TreeNode CNTT = new TreeNode();
            TreeNode NN = new TreeNode();
            TreeNode TT = new TreeNode();
            CNTT.Text = "Công Nghệ Thông Tin";
            TreeNode CTK = new TreeNode() { Text = "CTK40"};
            TreeNode CTK1 = new TreeNode() { Text = "CTK41" };
            TreeNode CTK2 = new TreeNode() { Text = "CTK42" };
            TreeNode CTK3 = new TreeNode() { Text = "CTK43" };
            TreeNode CTK4 = new TreeNode() { Text = "CTK44A" };
            TreeNode CTK5 = new TreeNode() { Text = "CTK44B" };
            CNTT.Nodes.Add(CTK);
            CNTT.Nodes.Add(CTK1);
            CNTT.Nodes.Add(CTK2);
            CNTT.Nodes.Add(CTK3);
            CNTT.Nodes.Add(CTK4);
            CNTT.Nodes.Add(CTK5);
            NN.Text = "Khoa Ngoại ngữ";
            TreeNode AVK = new TreeNode() { Text = "AVK41A" };
            TreeNode AVK1 = new TreeNode() { Text = "AVK41D" };
            TreeNode AVK2 = new TreeNode() { Text = "AVK42A" };
            TreeNode AVK3 = new TreeNode() { Text = "AVK42B" };
            TreeNode AVK4 = new TreeNode() { Text = "AVK42C" };
            TreeNode AVK5 = new TreeNode() { Text = "AVK42D" };
            TreeNode AVK6 = new TreeNode() { Text = "AVK43A" };
            TreeNode AVK7 = new TreeNode() { Text = "AVK43C" };
            TreeNode AVK8 = new TreeNode() { Text = "AVK43D" };
            TreeNode AVK9 = new TreeNode() { Text = "AVK43E" };
            TreeNode AVK10 = new TreeNode() { Text = "AVK43F" };
            TreeNode AVK11 = new TreeNode() { Text = "AVK44C" };
            NN.Nodes.Add(AVK);
            NN.Nodes.Add(AVK1);
            NN.Nodes.Add(AVK2);
            NN.Nodes.Add(AVK3);
            NN.Nodes.Add(AVK4);
            NN.Nodes.Add(AVK5);
            NN.Nodes.Add(AVK6);
            NN.Nodes.Add(AVK7);
            NN.Nodes.Add(AVK8);
            NN.Nodes.Add(AVK9);
            NN.Nodes.Add(AVK10);
            NN.Nodes.Add(AVK11);
            TT.Text = "Khoa Toán - Tin học";
            TreeNode TNK = new TreeNode() { Text = "TNK44" };
            TT.Nodes.Add(TNK);
            tvKhoa.Nodes.Add(CNTT);
            tvKhoa.Nodes.Add(NN);
            tvKhoa.Nodes.Add(TT);
        }*/
        private void ThemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dialog = new formTTSV();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
               
            }    
        }
        private void xoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvDSSV.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvDSSV.Items[i];
                if (lvitem.Selected) qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMSSV);
            }
            this.LoadListView();
        }
        private int SoSanhTheoMSSV(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);
        }
        public List<string> GetDSKhoa(List<SinhVien> ds)
        {
            List<string> khoa = new List<string>();
            foreach (var sv in ds)
            {
                if (!khoa.Contains(sv.Khoa))
                {
                    khoa.Add(sv.Khoa);
                }
            }
            return khoa;
        }
        public List<string> GetDSLop(String Khoa)
        {
            List<string> lop = new List<string>();
            foreach (var l in qlsv.DanhSach)
            {     
                if(l.Khoa.CompareTo(Khoa)==0)
                    if(!lop.Contains(l.Lop))
                    {
                        lop.Add(l.Lop);
                    }
            }
            return lop;
        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level==1)
            {
                this.lvDSSV.Items.Clear();
                foreach (var sv in qlsv.DanhSach)
                {
                    if(e.Node.Text == sv.Lop.ToString())
                    {
                        ThemSinhVien(sv);
                    }
                }
            }
        }
        private void HienTreeView(List<SinhVien> ds)
        {
            tvKhoa.Nodes.Clear();
            foreach (var khoa in GetDSKhoa(ds))
            {
                var nutkhoa = tvKhoa.Nodes.Add(khoa);
                foreach (var lop in GetDSLop(khoa.ToString()))
                {
                    nutkhoa.Nodes.Add(lop);
                }
            }
            tvKhoa.ExpandAll();
        }
        private void AnHienTimKiem()
        {
            txtNhaptt.Text = placeholdertext;
            txtNhaptt.GotFocus += Removeholdertext;
            txtNhaptt.LostFocus += show;
        }

        private void show(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNhaptt.Text))
                txtNhaptt.Text = placeholdertext;
        }

        private void Removeholdertext(object sender, EventArgs e)
        {
            if (txtNhaptt.Text == placeholdertext)
                txtNhaptt.Text = "";
        }
    }
}
