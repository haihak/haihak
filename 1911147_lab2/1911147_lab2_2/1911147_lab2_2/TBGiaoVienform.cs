using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_lab2_2
{
    public partial class TBGiaoVienform : Form
    {       

        public TBGiaoVienform()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }
        private void TBGiaoVienform_Load(object sender, EventArgs e)
        {          
        }
    }
}
