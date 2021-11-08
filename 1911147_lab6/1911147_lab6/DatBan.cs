using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911147_lab6
{
    public partial class DatBan : Form
    {
        public DatBan()
        {
            InitializeComponent();
        }

        private void btnThemban_Click(object sender, EventArgs e)
        {
            var dialog = new ThemBan();
            if(dialog.ShowDialog()==DialogResult.OK)
            {

            }
        }
    }
}
