using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace j.Tab_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.Clear();
            TabPage tabSV = new TabPage();
            TabPage tabGV = new TabPage();
            TabPage tabMH = new TabPage();
            tabSV.Text = "Sinh viên";
            tabGV.Text = "Giáo Viên";
            tabMH.Text = "Môn học";
            this.tabControl1.TabPages.Add(tabSV);
            this.tabControl1.TabPages.Add(tabGV);
            this.tabControl1.TabPages.Add(tabMH);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
