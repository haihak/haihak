using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911147_lab8
{
    // lớp FoodBL có các phương thức xử lý bảng Food
    public class FoodBL
    {
        //đối tượng CategoryDA từ DataAccess
        FoodDA foodDA = new FoodDA();
        //Phương thức lấy hết dữ liệu 
        public List<Food> GetAll()
        {
            return foodDA.GetAll();
        }
        // phương thức lấy về đối tượng Food theo khoá chính 
        public Food GetByID(int ID)
        {
            // lấy hết 
            List<Food> list = GetAll();
            // duyệt để tìm kiếm 
            foreach (var item in list)
            {
                if (item.ID == ID) // nếu gặp khoá chính 
                    return item; // thì trả về kết quả
            }
            return null;
        }
        //phương thức tìm kiếm theo khoá 
        public List<Food> Find(string key)
        {
            List<Food> list = GetAll(); // lấy hết 
            List<Food> result = new List<Food>();
            // duyệt theo danh sách 
            foreach (var item in list)
            {
                // nếu từng trường chứa từ khoá 
                if (item.ID.ToString().Contains(key)
                || item.Name.Contains(key)
                || item.Unit.Contains(key)
                || item.Price.ToString().Contains(key)
                || item.Notes.Contains(key))
                    result.Add(item); // thì thêm vào danh sách kết quả
            }
            return result;
        }
        //phương thức thêm dữ liệu
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }
        //phương thức cập nhật dữ liệu
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }
        //phương thức xoá dữ liệu với ID cho trước
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }
    }
}
