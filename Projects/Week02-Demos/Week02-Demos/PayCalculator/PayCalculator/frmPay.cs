using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class frmPay : Form
    {
        public frmPay()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //end the application by closing the form
            this.Close();
        }

        private void btnCalcGrossPay_Click(object sender, EventArgs e)
        {
            //calculate gross pay as hours worked * pay rate
            txtPay.Text = (Convert.ToDouble(txtHours.Text) 
                * Convert.ToDouble(txtRate.Text)).ToString();
        }
    }
}
