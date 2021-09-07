using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class formLinklabei : Form
    {
        public formLinklabei()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Link1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURL = Convert.ToString(e.Link.LinkData);
            if (strURL.StartsWith("mailto:"))
                Process.Start(strURL +"?subject=hello");
        }

        private void Link2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void formLinklabei_Load(object sender, EventArgs e)
        {
            string strURL = "mailto:ctk43@gmail.com";
            this.Linklabei1.Links.Add(0, strURL.Length, strURL);
            strURL = "http://www.cnttk43.net";
            this.Linklabel2.Links.Add(0, strURL.Length, strURL);
        }
    }
}
