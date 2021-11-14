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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            this.InitValues();
        }
        private void InitValues()
        {
            // tao doi tuong ket noi
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            //tao doi tuong thuc thi lenh
            SqlCommand cmd = conn.CreateCommand();
            //thiet lap truy van
            cmd.CommandText = "SELECT ID, Name FROM Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            // mo ket noi
            conn.Open();

            // lay du lieu tu csdl dua vao datatable
            adapter.Fill(ds, "Category");

            // hien thi nhom mon an
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";

            // đóng  kết nối và giải phóng bộ nhớ
            conn.Close();
            conn.Dispose();
        }
        private void ResetText()
        {
            txtID.ResetText();
            txtName.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();
            txtNotes.ResetText();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            { 
            // tao doi tuong ket noi
            string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            // tao doi tuong thuc thi lenh
            SqlCommand cmd = conn.CreateCommand();
            //thiet lap truy van
            cmd.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryId, @price, @notes";
            // thêm tham số vào đối tượng command
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
            cmd.Parameters.Add("@price", SqlDbType.Int);
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

            cmd.Parameters["@id"].Direction = ParameterDirection.Output;

            // Truyền giá trị vào thủ tục qua tham số
            cmd.Parameters["@name"].Value = txtName.Text;
            cmd.Parameters["@unit"].Value = txtUnit.Text;
            cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
            cmd.Parameters["@price"].Value = nudPrice.Value;
            cmd.Parameters["@notes"].Value = txtNotes.Text;
            // mở kết nối
            conn.Open();

            int numRowAffected = cmd.ExecuteNonQuery();
            // thông báo kết quả
            if (numRowAffected > 0)
            {
                string foodID = cmd.Parameters["@id"].Value.ToString();
                MessageBox.Show("ế! thêm được món ăn rồi id là = " + foodID, "hen sịt");
                this.ResetText();
            }
            else
            {
                MessageBox.Show("thêm thức ăn được mới lạ");
            }
            // đóng kết nối
            conn.Close();
            conn.Dispose();
        }
        // bắt lỗi sql và các lỗi khác
        catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL lỗi ~~");
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "lỗi ~~");
            }
        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();

                cbbCatName.SelectedIndex = -1;
                for(int index = 0; index < cbbCatName.Items.Count; index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if(cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Lỗi ~~");
                this.Close();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // tao doi tuong ket noi
                string connectionString = @"Data Source=DESKTOP-MK7TMGN\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                // tao doi tuong thuc thi lenh
                SqlCommand cmd = conn.CreateCommand();
                //thiet lap truy van
                cmd.CommandText = "EXECUTE UpdateFood @id , @name, @unit, @foodCategoryId, @price, @notes";
                // thêm tham số vào đối tượng command
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

                // truyền giá trị vào thủ tục qua tham số
                cmd.Parameters["@id"].Value = int.Parse(txtID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryId"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                // mo ket noi
                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();
                // thông báo kết quả
                if( numRowAffected > 0)
                {
                    MessageBox.Show("cập nhật thành công rồi", "Yeah boyyyyyy");
                    this.ResetText();

                }
                else
                {
                    MessageBox.Show("cập nhật thất bại :<");
                }
                // đóng kết nối
                conn.Close();
                conn.Dispose();
            }
            // bắt lỗi sql và các lỗi khác
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL lỗi ~~!");

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "lỗi ~~");
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ThemNhomThucAn themnhomthucan = new ThemNhomThucAn();
            themnhomthucan.FormClosed += new FormClosedEventHandler(FoodInfoForm_FormClosed);
            themnhomthucan.Show();
        }

        private void FoodInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCatName.SelectedIndex;
            cbbCatName.SelectedIndex = -1;
            cbbCatName.SelectedIndex = index;
        }
    }
}
