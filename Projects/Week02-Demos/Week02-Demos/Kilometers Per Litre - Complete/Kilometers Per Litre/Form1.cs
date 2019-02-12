using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kilometers_Per_Litre
{
    public partial class frmKPL : Form
    {
        public frmKPL()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //this.txtKPL.Text = ((Convert.ToDouble(txtKL.Text) / Convert.ToDouble(nudLitres.Value))).ToString();
            this.txtKPL.Text = ((Convert.ToDouble(txtKL.Text) / (double)(nudLitres.Value))).ToString();
           // txtKPL.Text = (Decimal.Round(Convert.ToDecimal(txtKL.Text) / (nudLitres.Value),2)).ToString();
        }
    }
}
