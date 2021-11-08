using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_lab6
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            this.LoadTaiKhoan();
        }
        private void LoadTaiKhoan()
        {   // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            // thiết lập truy vấn
            cmd.CommandText = "SELECT AccountName as[Tài Khoản],Password as[Mật Khẩu],FullName as[Họ và Tên],Email,Tell as[Số Điện Thoại],DateCreated as[Ngày Tạo] FROM Account";
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // mở kết nối
            conn.Open();
            // Lấy dữ liệu từ csdl đưa vào database
            adapter.Fill(dt);
            // đóng kêt nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
            // nhập dữ liệu vào DatagridView
            dgvTK.DataSource = dt;
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTK.CurrentRow.Index;
            txtTaiKhoan.Text = dgvTK.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTK.Rows[i].Cells[1].Value.ToString();
            txtHovaTen.Text = dgvTK.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvTK.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text =   dgvTK.Rows[i].Cells[4].Value.ToString();
            dtpTGDK.Text = dgvTK.Rows[i].Cells[5].Value.ToString();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.txtHovaTen.Text= "";
            this.txtMatKhau.Text = "";
            this.txtHovaTen.Text = "";
            this.txtEmail.Text = "";
            this.txtSDT.Text = "";
            this.dtpTGDK.Value = DateTime.Now;
        }
    }
}
