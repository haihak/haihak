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
    public partial class frmFood : Form
    {
        //private DataTable foodTable;
        public frmFood()
        {
            InitializeComponent();
        }
        private void frmFood_Load(object sender, EventArgs e)
        {
        }  
        public void LoadFood(int categoryID)
        {
           
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            // Tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // tạo dối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // thiết lập truy vấn đối tượng command
            sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;
            // mở kết nối tới csdl
            sqlConnection.Open();
            // gán tên nhóm sản phẩm cho tiêu đề
            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm:" + catName;
            sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;
            // tạo đối tượng DatAdapter
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            // tạo DâtTeble để chứa dữ liệu
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            //hiển thị danh sách món ăn lên form
            dgvFood.DataSource = dt;
            // Đóng kết nối và giải phóng bộ nhớ
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
        // hiển thị thông tin 
        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            // biến i
            int i;
            // gán i là dữ liệu hàng ngang hiện tại trong dgvFood 
            i = dgvFood.CurrentRow.Index;
            txtID.Text = dgvFood.Rows[i].Cells[0].Value.ToString();
            txtTenMonAn.Text = dgvFood.Rows[i].Cells[1].Value.ToString();
            txtDoDung.Text = dgvFood.Rows[i].Cells[2].Value.ToString();
            txtLoaiMonAn.Text = dgvFood.Rows[i].Cells[3].Value.ToString();
            txtGia.Text = dgvFood.Rows[i].Cells[4].Value.ToString();
            txtGhiChu.Text = dgvFood.Rows[i].Cells[5].Value.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // thiết lập lệnh truy vấn cho đối tượng command
            sqlCommand.CommandText = "UPDATE Food SET Name = N'" + txtTenMonAn.Text + "', Unit = N'" + txtDoDung.Text + "', FoodCategoryID = " + txtLoaiMonAn.Text + ", Price = " + txtGia.Text + ", Notes = N'" + txtGhiChu.Text + "'" + " WHERE ID = " + txtID.Text;
            // mở kết nối tới csdl
            sqlConnection.Open();
            // thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            // đóng kết nối
            sqlConnection.Close();
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("ngon, lưu(cập nhật) thành công");
                //Tải lại dữ liệu
                LoadFood(Convert.ToInt32(txtLoaiMonAn.Text));
                // xoá các ô đã nhập
                txtTenMonAn.Text = "";
                txtDoDung.Text = "";
                txtLoaiMonAn.Text = "";
                txtGia.Text = "";
                txtGhiChu.Text = "";
            }
            else
            {
                MessageBox.Show("Lỗi rồi :< thử lại xem");
            }          
        }         

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFood.SelectedRows.Count == 0) return;
            var selectedRow = dgvFood.SelectedRows[0];
            string foodID = selectedRow.Cells[0].Value.ToString();
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            //Tạo đối tượng thực thi lệnh
            SqlCommand command;
            command = conn.CreateCommand();
            // Tạo truy vấn
            string query = "DELETE FROM Food WHERE ID =" + foodID;
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
            dgvFood.Rows.Remove(selectedRow);
            // Đóng kết nối
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // thiết lập lệnh truy vấn cho đối tượng command
            sqlCommand.CommandText = "INSERT INTO Food (Name,Unit,FoodCategoryID,Price,Notes)" + "VALUES (N'"+txtTenMonAn.Text+"','"+txtDoDung.Text+"','"+txtLoaiMonAn.Text+"','"+txtGia.Text+"','"+txtGhiChu.Text+"')";
            // mở kết nối tới csdl
            sqlConnection.Open();
            // thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
            
            if (numOfRowsEffected == 1)
            {
                MessageBox.Show("ngon, thêm thành công");
                //Tải lại dữ liệu
                btnSave.PerformClick();
                // xoá các ô đã nhập
                txtTenMonAn.Text = "";
                txtDoDung.Text = "";
                txtLoaiMonAn.Text = "";
                txtGia.Text = "";
                txtGhiChu.Text = "";
            }
            else
            {
                MessageBox.Show("Lỗi rồi :< thử lại xem");
            }
            // đóng kết nối
            sqlConnection.Close();
        }
    }
}
