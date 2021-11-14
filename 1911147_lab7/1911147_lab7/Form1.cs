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
    public partial class formChonMon : Form
    {
        private DataTable foodTable;
        public formChonMon()
        {
            InitializeComponent();
        }

        private void formMonAn_Load(object sender, EventArgs e)
        {
            this.LoadCategory();
        }
        private void LoadCategory()
        {   // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            //tao doi tuong thuc thi lenh
            SqlCommand cmd = conn.CreateCommand();
            //thiet lap truy van
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
            cbbCategory.DataSource = dt;
            // hiển thị tên nhóm sản phẩm
            cbbCategory.DisplayMember = "Name";
            // nhưng khi lấy giá trị thì lấy id của nhóm
            cbbCategory.ValueMember = "ID";
        }
        //1911147
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1) return;
            // tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            //tao doi tuong thuc thi lenh
            SqlCommand cmd = conn.CreateCommand();
            //thiet lap truy van
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";
            
            // Truyền tham số
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
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
            dgvFoodList.DataSource = foodTable;
            // tính số lượng mẫu tin
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory.Text;
        }//1911147
        // Tính số lượng đã bán

        private void tsmAddFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += new FormClosedEventHandler(formChonMon_FormClosed);
            foodForm.Show(this);
        }
        
        private void tsmYdateFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(formChonMon_FormClosed);

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        private void formChonMon_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
             // tạo bộ lọc và xắp xếp biểu thức
             string BoLoc = "Name like '%" + txtSearchByName.Text + "%'";
            string XapXepBieuThuc = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
            // tạo chế độ xem dữ liệu để xem dữ liệu trong bảng thức ăn
            // lọc theo Name(contain 'ng') và sắp xếp giảm dần theo Price(giá)
            DataView foodView = new DataView(foodTable, BoLoc, XapXepBieuThuc, rowStateFilter);
            // chỉ định foodTable làm nguồn dữ liệu của data grid view
            dgvFoodList.DataSource = foodView;
        }//1911147

        private void xemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm orders = new OrdersForm();
            orders.Show();
        }

        private void xemTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.Show();
        }

        private void tínhSốLượngĐãBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng kết nối
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            // tao doi tuong thuc thi lenh
            SqlCommand cmd = conn.CreateCommand();
            //thiet lap truy van
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";
            // Lấy thông tin sản phẩm được chọn
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                // truyền tham số
                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                // mở kết nối csdl
                conn.Open();
                // thực thi truy vấ nvaf lấy dữ liệu từ tham số
                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("túm số lượng món lại " + rowView["Name"] + " đã bén là: " + result + " " + rowView["Unit"]);
                // đóng kết nối 
                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }//1911147
    }
}
