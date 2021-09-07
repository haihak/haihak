using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messagebox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imformation box with an OK button", "Information Icon", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error box with Abort,Ertry, and Ignore buttons", "Error Icon",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waring box with Ok and cancel buttons","Warning Icon",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A question box with Yes anh No buttons,and No as the default","Question Icon",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
        }
    }
}
