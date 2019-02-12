using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSqrt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frm1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;

        }

        private void frm1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtSqrt.Text = Math.Sqrt((float)nudNumber.Value).ToString("n");
        }

      

        private void frm1_Load(object sender, EventArgs e)
        {

        }

        private void frm1_Enter(object sender, EventArgs e)
        {
            txtSqrt.Text = Math.Sqrt((float)nudNumber.Value).ToString("n");
        }
    }
}
