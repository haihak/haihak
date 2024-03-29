﻿using System;
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

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvTK.SelectedRows.Count == 0) return;
            var selectedRow = dgvTK.SelectedRows[0];
            string AccountName = selectedRow.Cells[0].Value.ToString();
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            //Tạo đối tượng thực thi lệnh
            SqlCommand command;
            command = conn.CreateCommand();
            // Tạo truy vấn
            string query = "DELETE DROM Account WHERE AccountName" + AccountName;
            command.CommandText = query;
            // Mở kết nối
            conn.Open();
            int numOfRowsEffected = command.ExecuteNonQuery();
            if (numOfRowsEffected != 1)
            {
                MessageBox.Show("không được rồi", "bèm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("ế xóa được rồi", "Tèn Ten", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvTK.Rows.Remove(selectedRow);
            // Đóng kết nối
            conn.Close();
        }
    }
}
