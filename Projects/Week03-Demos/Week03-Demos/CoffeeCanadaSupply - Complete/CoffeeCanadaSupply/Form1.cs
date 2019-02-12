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
            this.radStandard.Checked = true;
            decAdjustment = decSTANDARD;
        }

        private void btnCalcTotal_Click(object sender, EventArgs e)
        {
            //decimal decAdjustment = 0;
            //if (this.radNew.Checked == true)
            //{
            //    decAdjustment = decNEW;
            //}

            //if (this.radStandard.Checked == true)
            //{
            //    decAdjustment = decSTANDARD;
            //}

            //if (this.radPreferred.Checked == true)
            //{
            //    decAdjustment = decPREFERRED;
            //}

            //decimal decPrice = nudPrice.Value - (nudPrice.Value * decAdjustment);
            decimal decPrice = (1 - decAdjustment) * nudPrice.Value;
            decimal decTotal = nudQty.Value* decPrice;
           // this.txtTotal.Text = String.Format("{0:.00}",decTotal);
            this.txtTotal.Text = string.Format("{0:c}", decTotal);
           // this.txtTotal.Text = decTotal.ToString("C");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTotal.Text = "$0.00";
            this.radStandard.Checked = true;
            this.nudQty.Value = 0;
            //this.nudPrice.Value = 1.5M;
           //this.nudPrice.Value = Convert.ToDecimal(1.5);
            this.nudPrice.Value = (decimal)1.5;
        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decNEW;
        }

        private void radStandard_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decSTANDARD;
        }

        private void radPreferred_CheckedChanged(object sender, EventArgs e)
        {
            decAdjustment = decPREFERRED;
        }


    }
}
