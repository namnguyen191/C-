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
            decimal decPrice = 0;
            decimal decTotal = 0;

            //change numeric updown to textbox to demo Double.TryParse
            double dblPrice = 0;

            /*
             * Double.TryParse() takes a string and a double as parameters and returns a boolean.
             * The boolean is true if the string contains a valid double, and false if not.
             * Also note the out parameter here, we haven't seen this before: 
             * the variable must be declared above, and the method puts a value into the variable as it executes.
             * When the method is done, if the string contained a valid double,
             * the out variable contains the value as a double. 
             * If false is returned, put out an error message and don't use dblPrice
             */
            if (Double.TryParse(txtPrice.Text, out dblPrice))
            {
                decPrice = (decimal)dblPrice;
            }
            else
            {
                MessageBox.Show("Invalid Value" + Environment.NewLine + "Please enter a valid decimal value");
                //select the text and put focus there so it's easy for the user to fix it
                txtPrice.SelectAll();
                txtPrice.Focus();
                //don't try to do more processing in this method, 
                //return skips the rest of the code. 
                //Could use a nested if instead but this is cleaner
                return;
            }

            decPrice = (1 - decAdjustment) * decPrice;
            decTotal = nudQty.Value * decPrice;
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
            this.txtPrice.Text = "1.50";
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
