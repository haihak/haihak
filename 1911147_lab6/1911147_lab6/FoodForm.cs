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
        private DataTable foodTable;
        public frmFood()
        {
            InitializeComponent();
        }
        private void frmFood_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }
        private void LoadCategory()
        {   // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // mở kết nối
            conn.Open();
            // Lấy dữ liệu từ csdl đưa vào database
            adapter.Fill(dt);
            // đóng kêt nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
            // đưa dữ liệu vào combobox
            cbbLoaiMonAn.DataSource = dt;
            // hiển thị tên nhóm sản phẩm
            cbbLoaiMonAn.DisplayMember = "Name";
            // nhưng khi lấy giá trị thì lấy id của nhóm
            cbbLoaiMonAn.ValueMember = "ID";
        }
        //1911147
        public void LoadFood(int categoryID)
        {
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
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
        //1911147
        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // hiển thị thông tin 
            // biến i
            int i;
            // gán i là dữ liệu hàng ngang hiện tại trong dgvFood 
            i = dgvFood.CurrentRow.Index;
            txtID.Text = dgvFood.Rows[i].Cells[0].Value.ToString();
            txtTenMonAn.Text = dgvFood.Rows[i].Cells[1].Value.ToString();
            txtDoDung.Text = dgvFood.Rows[i].Cells[2].Value.ToString();
            cbbLoaiMonAn.Text = dgvFood.Rows[i].Cells[3].Value.ToString();
            nudGia.Text = dgvFood.Rows[i].Cells[4].Value.ToString();
            txtGhiChu.Text = dgvFood.Rows[i].Cells[5].Value.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        //1911147
        private void cbbLoaiMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiMonAn.SelectedIndex == -1) return;
            // tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

            // Truyền tham số
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbLoaiMonAn.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbLoaiMonAn.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbLoaiMonAn.SelectedValue;
            }
            //tạo bộ điểu phiếu dữ liệu
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();
            // mở kết nối
            conn.Open();
            // Lấy dữ liệu từ csdl đưa vào datatable
            adapter.Fill(foodTable);
            // đóng kêt nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
            // đưa dữ liệu vào dât gridview
            dgvFood.DataSource = foodTable;
            // tính số lượng mẫu tin
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbLoaiMonAn.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            
        }
    }
}
