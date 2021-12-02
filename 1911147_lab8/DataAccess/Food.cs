using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Food
    {
        //id của bảng food
        public int ID { get; set; }
        // tên loại dồ ăn, thức uống
        public string Name { get; set; }
        // đơn vị tính 
        public string Unit { get; set; }
        // loại thức ăn, ứng với bảng ở trên 
        public int FoodCategoryID { get; set; }
        // giá
        public int Price { get; set; }
        //ghi chú
        public string Notes { get; set; }
    }
}
