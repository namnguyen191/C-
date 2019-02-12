using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rent;

namespace Lab4_RentProperty_WithClasses
{
    public partial class N01185573 : Form
    {

        public N01185573()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Property prp = new Property(txtFName.Text, txtLName.Text);
            prp.Address = txtAddress.Text;
            prp.PropertyId = txtPropID.Text;
            if (rad1room.Checked) prp.NumOfBed = 1;
            if (rad2rooms.Checked) prp.NumOfBed = 2;
            if (rad3rooms.Checked) prp.NumOfBed = 3;
            if (rad1Bath.Checked) prp.NumOfBath = 1;
            if (rad1AndHalfBath.Checked) prp.NumOfBath = 1.5;
            if (rad2bath.Checked) prp.NumOfBath = 2;
            if (rad2andhalfbath.Checked) prp.NumOfBath = 2.5;
            lblDisplayRent.Text = prp.toString();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAddress.Clear();
            txtPropID.Clear();
            rad1Bath.Checked = true;
            rad1room.Checked = true;
            lblDisplayRent.ResetText();
            txtFName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
