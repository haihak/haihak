using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // lớp quản lý category: DA = DataAccess
    public class CategoryDA
    {
        // phương thức lấy dư liệu trong Category_GetAll
        public List<Category> GetAll()
        {
            // khai báo đối tượng SqlConnection và mở kết nối
            // Đối tượng SqlConnection truyền vào chuỗi kết nối trong App.Config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            // khai báo đối tượng sqlcommand có kiểu xử lý là storedprocedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_GetAll;
            // đọc dữ liệu, trả về danh sách các đối tượng category
            SqlDataReader reader = command.ExecuteReader();
            List<Category> list = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                list.Add(category);
            }
            // đóng kết nối và trả về danh sách
            sqlConn.Close();
            return list;
        }
        // phương thức thêm, xóa, sửa theo thủ tục category_insertudatedelete
        public int Insert_Update_Delete(Category category, int action)
        {
            // khai báo đối tượng sqlconnection và mở kết nối
            // đối tượng sqlconnection truyền vào chuỗi kết nối trong app.config
            SqlConnection sqlConn = new SqlConnection(Ultilities.ConnectionString);
            sqlConn.Open();
            // khai báo đối tượng SqlCommand có kiểu xử lý là storedprocedure
            SqlCommand command = sqlConn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = Ultilities.Category_InsertUpdateDelete;
            // thêm các tham số cho thủ tục; các tham số này chính là các tham số trong thủ tục;
            // id là tham số có giá trị lấy ra khi thêm và truyền vào khi xóa, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra 
            command.Parameters.Add(IDPara).Value = category.ID;
            command.Parameters.Add("@Name", SqlDbType.NVarChar, 200)
            .Value = category.Name;
            command.Parameters.Add("@Type", SqlDbType.Int)
            .Value = category.Type;
            command.Parameters.Add("@Action", SqlDbType.Int)
            .Value = action;
            // thực thi lệnh 
            int result = command.ExecuteNonQuery();
            if (result > 0) // nếu thành công thì trả về ID đã thêm 
                return (int)command.Parameters["@ID"].Value;
            return 0;
        }
    }
}
