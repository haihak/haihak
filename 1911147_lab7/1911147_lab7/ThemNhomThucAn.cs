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
    public partial class ThemNhomThucAn : Form
    {
        public ThemNhomThucAn()
        {
            InitializeComponent();
        }
        private void ThemNhomThucAn_Load(object sender, EventArgs e)
        {

        }      
        private void btnAddNhom_Click(object sender, EventArgs e)
        {//1911147
            try
            {
                // tao doi tuong ket noi
                string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                // tao doi tuong thuc thi lenh
                SqlCommand cmd = conn.CreateCommand();
                //thiet lap truy van
                cmd.CommandText = "INSERT INTO Category(Name, [Type])" + "VALUES (N'"+ txtTennhom.Text +"',"+txtLoai.Text+")";
                // mở kết nối
                conn.Open();
                // thực thi lệnh bằng phương thức ExecuteNonQuery
                int numRowAffected = cmd.ExecuteNonQuery();
                // thong bao ket qua
                if (numRowAffected == 1)
                {
                    MessageBox.Show("Đã thêm thành công nhóm món ăn mới ràu");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm không được :<");
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
        
        private void ResetText()
        {           
            txtTennhom.ResetText();
            txtLoai.ResetText();
        }


    }
}
