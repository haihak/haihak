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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        private void LoadHoaDon()
        {   // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            // tạo đối tượng thực thi lệnh
            SqlCommand cmd = conn.CreateCommand();
            // thiết lập truy vấn
            cmd.CommandText = "SELECT ID,Name as[Tên Hóa Đơn],TableID as [ID Bàn],Amount as[Số Tiền],Discount as[Chiết khấu],Tax as[Thuế],Status as[Trạng Thái],CheckoutDate as[Ngày Trả],Account as[Tài Khoản] FROM Bills";
            // chạy lệnh truy vấn
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
            dgvHoaDon.DataSource = dt;
        }
    }
}
