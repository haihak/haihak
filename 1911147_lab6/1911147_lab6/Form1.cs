using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _1911147_lab6
{
    public partial class formMonan : Form
    {
        public formMonan()
        {
            InitializeComponent();
        }
        private void DisplayCategory(SqlDataReader reader)
        {
            // xóa tất cả các dòng hiện tại
            //lvCategory.Items.Clear();
            // Đọc một dòng dữ liệu
            while (reader.Read())
            {
                // tạo một dòng mới trong listview
                ListViewItem item = new ListViewItem(reader["ID"].ToString());
                // thêm dòng mói vào listview
                lvCategory.Items.Add(item);
                // bổ sung các thông tin khác cho listviewitem
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Type"].ToString());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // tạo chuỗi kết nối với csdl RetaurantManagement
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            // tạo đối tượng kết nối
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // thiết lập lệnh truy vấn cho đối tượng Command
            string query = "SELECT ID, Name, Type FROM Category";
            sqlCommand.CommandText = query;
            // mở kết nối tới cơ sở dữ liệu
            sqlConnection.Open();
            // thực thi lệnh bằng phương thức excutereader
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            // gọi hàm hiển thị dữ liệu trên màn hình
            this.DisplayCategory(sqlDataReader);
            // đóng kết nối
            sqlConnection.Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // tạo đối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // thiết lập truy vấn cho đố tượng command
            sqlCommand.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'" + txtName.Text + "'," + txtType.Text + ")";
            // mở kết nối tới csdl
            sqlConnection.Open();
            //thực thi lệnh băng phương thức ExcuteReader            
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            //Đóng kết nối
            sqlConnection.Close();
            if(numOfRowEffected == 1)
            {
                MessageBox.Show("Thêm món thành công rồi");
                // tải lại dữ liệu
                btnLoad.PerformClick();
                // xóa các ô nhập
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("xuất hiện lỗi rồi thử lại xem nào :V");
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // tạo dối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // Thiết lập lệnh truy vấn cho đối tượng command
            sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtName.Text + "',[Type] =" + txtType.Text + "WHERE ID = " + txtID.Text;
            // mở kết nối tới csdl
            sqlConnection.Open();
            // thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            // đóng kết nối
            sqlConnection.Close();
            if (numOfRowEffected == 1)
            {
                // cập nhật lại dữ liệu trên listview
                ListViewItem item = lvCategory.SelectedItems[0];
                item.SubItems[1].Text = txtName.Text;
                item.SubItems[2].Text = txtType.Text;
                // Xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                // Disable ccác nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show(" ý Cập nhật nhóm món ăn thành công");
            }
            else
            {
                MessageBox.Show("lỗi ràu. thử lại nào");
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            // lấy dòng được chọn trong Listview
            ListViewItem item = lvCategory.SelectedItems[0];
            //hiển thị dữ liệu lên Textbox
            txtID.Text = item.Text;
            txtName.Text = item.SubItems[1].Text;
            txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";
            // hiển thị nút cập nhật và xóa
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            // tạo dối tượng thực thi lệnh
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            // Thiết lập lệnh truy vấn cho đối tượng Command
            sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID =" + txtID.Text;
            // mở kết nối tới csdl
            sqlConnection.Open();
            // thực thi lệnh bằng phương thức ExcuteReader
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            // đóng kết nối
            sqlConnection.Close();
            if(numOfRowEffected == 1)
            {
                // cập nhật lại dữ liệu trên listview
                ListViewItem item = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(item);
                // xóa các ô nhập
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                // Disable các nút xóa và cập nhật
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show(" ế xóa được rồi");
            }
            else
            {
                MessageBox.Show("hmm lỗi rồi thử lại nào");
            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text !="")
            {
                frmFood foodform = new frmFood();
                foodform.Show(this);
                foodform.LoadFood(Convert.ToInt32(txtID.Text));
            }
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
