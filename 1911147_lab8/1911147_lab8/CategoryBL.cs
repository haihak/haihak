using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab8
{
    public class CategoryBL
    {
        //đối tượng CategoryDA từ DataAccess
        CategoryDA categoryDA = new CategoryDA();
        //phương thức lấy hết dữ liệu 
        public List<Category> GetAll()
        {
            return categoryDA.GetAll();
        }
        //phương thức thêm dữ liệu 
        public int Insert(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 0);
        }
        //phương thức cập nhật dữ liệu 
        public int Update(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 1);
        }
        //phương thức xoá dữ liệu truyền vào ID 
        public int Delete(Category category)
        {
            return categoryDA.Insert_Update_Delete(category, 2);
        }
    }
}
