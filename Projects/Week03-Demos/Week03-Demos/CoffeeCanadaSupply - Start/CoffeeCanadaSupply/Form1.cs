using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeCanadaSupply
{
    public partial class frmCoffeeSupply : Form
    {
        private decimal decAdjustment = 0;
        private const decimal decNEW = 0.04M;
        private const decimal decSTANDARD = 0.0M;
        private const decimal decPREFERRED = 0.03M;

        public frmCoffeeSupply()
        {
            InitializeComponent();
            radNew.Checked = true;
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            //if (radNew.Checked)
            //{
            //    decAdjustment = decNEW;
            //}
            //if (radStandard.Checked)
            //{
            //    decAdjustment = decSTANDARD;
            //}
            //if (radPreferred.Checked)
            //{
            //    decAdjustment = decPREFERRED;
            //}
            decimal decNewPrice = 0;
            decNewPrice = nudPrice.Value - nudPrice.Value * decAdjustment;

            //txtTotal.Text = (nudQty.Value * decNewPrice).ToString("C3");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            radNew.Checked = true;
            //nudQty.Value = 0;
            nudPrice.Value = 1.50m;
            txtTotal.Text = "0.00";
        }

        private void nudQty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decSTANDARD;
        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decNEW;
        }

        private void radPreferred_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decPREFERRED;
        }
    }
}
