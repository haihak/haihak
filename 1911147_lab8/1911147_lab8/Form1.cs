using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic1;
using DataAccess;

namespace _1911147_lab8
{
    public partial class formFood : Form
    {
        // danh sách toàn cục bảng Category
        List<Category> listCategory = new List<Category>();
        // danh sách toàn cục bảng Food 
        List<Food> listFood = new List<Food>();
        // đối tượng Food đang chọn hiện hành
        Food foodCurrent = new Food();
        public formFood()
        {
            InitializeComponent();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //1911147
        private void cmdClear_Click(object sender, EventArgs e)
        {
            //Gán các ô bằng giá trị mặc định 
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";
            // Thiết lập index = 0 cho ComboBox
            if (cbbCategory.Items.Count > 0)
                cbbCategory.SelectedIndex = 0;
        }

        private void formFood_Load(object sender, EventArgs e)
        {
            //đổ dữ liệu vào ComboBox
            LoadCategory();
            // đổ dữ liệu vào ListView
            LoadFoodDataToListView();
        }//1911147
        private void LoadCategory()
        {
            //gọi đối tượng CategoryBL từ tầng BusinessLogic 
            CategoryBL categoryBL = new CategoryBL();
            // Lấy dữ liệu gán cho biến toàn cục listCategory
            listCategory = categoryBL.GetAll();
            // chuyển vào Combobox với dữ liệu là ID, hiển thị là Name
            cbbCategory.DataSource = listCategory;
            cbbCategory.ValueMember = "ID";
            cbbCategory.DisplayMember = "Name";
        }
        //1911147
        public void LoadFoodDataToListView()
        {
            //gọi đối tượng FoodBL từ tầng BusinessLogic 
            FoodBL foodBL = new FoodBL();
            // lấy dữ liệu 
            listFood = foodBL.GetAll();
            int count = 1; // Biến số thứ tự
                           // Xoá dữ liệu trong ListView 
            lsvFood.Items.Clear();
            // duyệt mảng dữ liệu để đưa vào ListView 
            foreach (var food in listFood)
            {
                // số thứ tự
                ListViewItem item = lsvFood.Items.Add(count.ToString());
                // Đưa dữ liệu Name, Unit, price vào cột tiếp theo 
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                // rheo dữ liệu của bảng Category ID, lấy Name để hiển thị
                string foodName = listCategory
                .Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                // đưa dữ liệu Notes vào cột cuối
                item.SubItems.Add(food.Notes);
                count++;
            }
        }//1911147

        private void lsvFood_Click(object sender, EventArgs e)
        {
            // duyệt toàn bộ dữ liệu trong ListView
            for (int i = 0; i < lsvFood.Items.Count; i++)
            {
                // nếu có dòng được chọn thì lấy dòng đó 
                if (lsvFood.Items[i].Selected)
                {
                    // lấy các tham số và gán dữ liệu vào các ô 
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    // lấy index của Combobox theo FoodCategoryID
                    cbbCategory.SelectedIndex = listCategory
                   .FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }//1911147 
        // phương thức thêm dữ liệu cho bảng Food 
        // trả về số dương nếu thành công, ngược lại trả về số âm
        public int InsertFood()
        {//1911147
            //khai báo đối tượng Food từ tầng DataAccess 
            Food food = new Food();
            food.ID = 0;
            // kiểm tra nếu các ô nhập khác rỗng 
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("phải nhập dữ liệu chỗ các ô đã, nhập lại lào");
            else
            {
                //nhận giá trị Name, Unit, và Notes từ người dùng nhập vào 
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                // giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai 
                int price = 0;
                try
                {
                    // cố gắng lấy giá trị
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    // nếu sai, gán giá = 0 
                    price = 0;
                }
                food.Price = price;
                // giá trị FoodCategoryID được lấy từ ComboBox 
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // khao báo đối tượng FoodBL từ tầng Business 
                FoodBL foodBL = new FoodBL();
                // chèn dữ liệu vào bảng 
                return foodBL.Insert(food);
            }
            return -1;
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            //gọi phương thức thêm dữ liệu
            int result = InsertFood();
            if (result > 0) // Nếu thêm thành công 
            {
                //thông báo kết quả
                MessageBox.Show("ú ù thêm được dữ liệu ràu :Đ");
                //tải lại dữ liệu cho ListView 
                LoadFoodDataToListView();
            }
            //nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("không được ràu :<, kiểm tra lại xem sai chỗ nào v");
        }//1911147

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            // Gọi phương thức cập nhật dữ liệu
            int result = UpdateFood();
            if (result > 0) // Nếu cập nhật thành công 
            {
                // Thông báo kết quả
                MessageBox.Show("wèo cập nhật được rồi");
                // Tải lại dữ liệu cho ListView 
                LoadFoodDataToListView();
            }
            // Nếu thêm không thành công thì thông báo cho người dùng
            else MessageBox.Show("không cập nhật đc :< kiểm tra lại nào");
        }//1911147

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //hỏi người dùng có chắc chắn xoá hay không? Nếu đồng ý thì 
            if (MessageBox.Show("có chắc xóa không đấy", "hú hú",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //khai báo đối tượng FoodBL từ BusinessLogic
                FoodBL foodBL = new FoodBL();
                if (foodBL.Delete(foodCurrent) > 0)// Nếu xoá thành công
                {
                    MessageBox.Show("ú xóa thực phẩm thành công yearrrr");
                    //tải tữ liệu lên ListView
                    LoadFoodDataToListView();
                }
                else MessageBox.Show("Không xóa được :<");
            }
        }//1911147
        // phương thức cập nhật dữ liệu cho bảng Food
        //trả về dương nếu cập nhật thành công, ngược lại là số âm
        public int UpdateFood()
        {//1911147
            //khai báo đối tượng Food và lấy đối tượng hiện hành 
            Food food = foodCurrent;
            // kiểm tra nếu các ô nhập khác rỗng 
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập lại");
            else
            {
                //nhận giá trị Name, Unit, và Notes khi người dùng sửa 
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                //giá trị price là giá trị số nên cần bắt lỗi khi người dùng nhập sai 
                int price = 0;
                try
                {
                    // chuyển giá trị từ kiểu văn bản qua kiểu int 
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    // nếu sai, gán giá = 0 
                    price = 0;
                }
                food.Price = price;
                // giá trị FoodCategoryID được lấy từ ComboBox 
                food.FoodCategoryID = int.Parse(cbbCategory.SelectedValue.ToString());
                // khai báo đối tượng FoodBL từ tầng Business 
                FoodBL foodBL = new FoodBL();
                // cập nhật dữ liệu trong bảng
                return foodBL.Update(food);
            }
            return -1;
        }
    }
}
