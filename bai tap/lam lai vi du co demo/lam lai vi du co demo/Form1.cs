using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lam_lai_vi_du_co_demo
{
    public partial class txt : Form
    {
        private List<DaringTable> tableList;

        public txt()
        {
            InitializeComponent();
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            tableList = new List<DaringTable>();
            Random r = new Random();
            for (int i = 1; i < 30; i++)
            {
                DaringTable table = new DaringTable();
                table.TableName = $"Bàn {i}" ;
                table.TableId = i;
                table.Status = r.Next(0, 2);//0 bàn trống , là bàn có ng
                table.Floor = r.Next(1, 4);

                tableList.Add(table);

            }

            LoadTableListFlp();
            //LoadTableListView();
            LoadTableToLVDetail();
        }  
        private void LoadTableListFlp()
        {
            var floors = new[] { flbFloserOne, flbFloserTwo, fblFloserthree };
            foreach (var table in tableList)
            {
                Button btn = new Button();
                btn.Text = table.TableName + "\r \n" + (table.Status == 1 ? "Có người" : "Trống");
                btn.BackColor = table.Status == 1 ? Color.DarkCyan : Color.DarkGray;
                btn.Height = 80;
                btn.Width = 80;
                ttFlow.SetToolTip(btn, $"Tầng{table.Floor}");
                flbFloserOne.Controls.Add(btn);

                floors[table.Floor - 1].Controls.Add(btn);
            }
        }
        private void LoadTableListView()
        {
            ListViewGroup floorOne = new ListViewGroup("Tầng 1", HorizontalAlignment.Center);
            ListViewGroup floorTwo = new ListViewGroup("Tầng 2", HorizontalAlignment.Center);
            ListViewGroup floorThree = new ListViewGroup("Tầng 3", HorizontalAlignment.Center);
            lvTableList.Groups.Add(floorOne);
            lvTableList.Groups.Add(floorTwo);
            lvTableList.Groups.Add(floorThree);
            var floorGroups = new[] { floorOne, floorTwo, floorThree };
            foreach (var table in tableList)
            {
                ListViewItem item = new ListViewItem(table.TableName,table.Status);
                item.Group = floorGroups[table.Floor - 1];
                lvTableList.Items.Add(item);
            }
        }
       private void LoadTableToLVDetail()
        {
            foreach (var table in tableList)
            {
                ListViewItem item = new ListViewItem(table.TableId.ToString());
                item.SubItems.Add(table.TableName);
                item.SubItems.Add(table.Status==1? "có người": "Trống");
                item.SubItems.Add(table.Floor.ToString());
                lvTableList.Items.Add(item);
            }
        }
    }
}
