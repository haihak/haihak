using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listbox
{
    public partial class formlistbox : Form
    {
        public formlistbox()
        {
            InitializeComponent();
        }

        private void formlistbox_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int itemsslelect = lbDanhsach.SelectedItems.Count - 1;
            for(int i= itemsslelect; i>= 0; i--)
            {
                lbDanhsach.Items.Add(lbDanhsachChon.SelectedItems[i]);
                lbDanhsachChon.Items.Remove(lbDanhsachChon.SelectedItems[i]);
            }

        }
        private void lbDanhsachChon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = lbDanhsach.SelectedItems.Count - 1;
            while(i>=0)
            {
                lbDanhsach.Items.RemoveAt(lbDanhsach.SelectedIndices[i]);
                i--;
            }
        }
    }
}
