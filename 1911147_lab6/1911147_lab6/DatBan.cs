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
    public partial class DatBan : Form
    {
        public DatBan()
        {
            InitializeComponent();
        }

        private void btnThemban_Click(object sender, EventArgs e)
        {
            var dialog = new ThemBan();
            if(dialog.ShowDialog()==DialogResult.OK)
            {

            }
        }

        private void DatBan_Load(object sender, EventArgs e)
        {
            LoadBan();
        }
        private void LoadBan()
        {   // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            // thiết lập truy vấn
            cmd.CommandText = "select ID,Name as[Tên bàn],Status as[Trạng thái],Capacity as[Sức Chứa]from [Table]";

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
            dgvBan.DataSource = dt;
        }
    }
}
