using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundedInterest
{
    public partial class txtInterestRate : Form
    {
        public txtInterestRate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double  principal= 0.00,
                interestRate = 0.00,
                interestEarned = 0.00;
            double futureValue = 0.00,
                ratePerPeriod = 0.00,
                periods = 0;
            int compoundType = 0;

            principal = double.Parse(txtPrincipal.Text);

            interestRate = double.Parse(txt.Text) / 100;

            if (rdoMonthly.Checked)
                compoundType = 12;
            else if (rdoQuarterly.Checked)
                compoundType = 4;
            else if (rdoSemiannually.Checked)
                compoundType = 2;
            else
                compoundType = 1;

            periods = double.Parse(txtPeriods.Text);

            double i = interestRate / compoundType;
            double n = compoundType * periods;

            ratePerPeriod = interestRate / periods;
            futureValue = principal * Math.Pow(1 + i, n);
            interestEarned = futureValue - principal;

            txtInterestEarned.Text = interestEarned.ToString("C");
            txtFutureValue.Text = futureValue.ToString("C");
        }
    }
}
