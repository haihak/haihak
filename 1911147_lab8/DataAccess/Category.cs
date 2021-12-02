using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    /// lớp ánh xạ bảng Category
    public class Category
    {
        // id của bảng, tự tăng trong csdl
        public int ID { get; set; }
        // tên của loại thức ăn
        public string Name { get; set; }
        // kiểu:0 là dồ uống; 1  là thức ăn...
        public int Type { get; set; }
    }
}
