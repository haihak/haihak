using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.comboBox1.DataSource = data;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.comboBox1.SelectedItem.ToString());   
        }
      
    }
}
