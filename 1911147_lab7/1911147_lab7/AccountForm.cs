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

namespace _1911147_lab7
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btnReSet_Click(object sender, EventArgs e)
        {
            this.txtTaiKhoan.Text = "";
            this.txtMatKhau.Text = "";
            this.txtHovaTen.Text = "";
            this.txtEmail.Text = "";
            this.txtSDT.Text = "";
            this.dtpTGDK.Value = DateTime.Now;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
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
        private void ResetText()
        {
            txtTaiKhoan.ResetText();
            txtMatKhau.ResetText();
            txtHovaTen.ResetText();
            txtEmail.ResetText();
            txtSDT.ResetText();
            dtpTGDK.ResetText();
        }
        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTK.CurrentRow.Index;
            txtTaiKhoan.Text = dgvTK.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTK.Rows[i].Cells[1].Value.ToString();
            txtHovaTen.Text = dgvTK.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvTK.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgvTK.Rows[i].Cells[4].Value.ToString();
            dtpTGDK.Text = dgvTK.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // tao doi tuong ket noi
                string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                // tao doi tuong thuc thi lenh
                SqlCommand cmd = conn.CreateCommand();
                //thiet lap truy van
                cmd.CommandText = string.Format("insert into Account(AccountName,Password, FullName, Email, Tell, DateCreated) values ('{0}', '{1}', N'{2}', '{3}', '{4}', '{5}')", txtTaiKhoan.Text, txtMatKhau.Text, txtHovaTen.Text, txtEmail.Text, txtSDT.Text, DateTime.Now);
                // mở kết nối
                conn.Open();
                // thực thi lệnh bằng phương thức ExecuteNonQuery
                int numRowAffected = cmd.ExecuteNonQuery();
                // thong bao ket qua
                if (numRowAffected == 1)
                {
                    MessageBox.Show("Đã thêm thành công tài khoản :Đ");
                    //tai lai du lieu
                    LoadTaiKhoan();
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại :<");
                }
                // dong ket noi
                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL lỗi ~~");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Lỗi ~~");
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
