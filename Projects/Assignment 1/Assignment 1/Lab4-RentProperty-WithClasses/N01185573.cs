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
            if (radCondominium.Checked) grpHouse.Enabled = false;
            cbCondominium.SelectedIndex = 0;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Buyer prs = new Buyer(txtFName.Text, txtLName.Text);
            int rent;
            if (radCondominium.Checked)
            {
                Condominium condo = new Condominium(txtAddress.Text, txtPropID.Text);
                if (cbCondominium.SelectedIndex == 0)
                {
                    condo.Amenities = false;
                    rent = condo.CalRent();
                }
                else { condo.Amenities = true;  rent = condo.CalRent(); }
                MessageBox.Show("Thank you: " + prs.FName + " " + prs.LName +
                                condo, "Message");
            }
            else
            {
                House hs = new House(txtAddress.Text, txtPropID.Text);
                if (rad1room.Checked) hs.NumOfBed = 1;
                if (rad3rooms.Checked) hs.NumOfBed = 3;
                if (rad2rooms.Checked) hs.NumOfBed = 2;
                if (rad1Bath.Checked) hs.NumOfBath = 1;
                if (rad1AndHalfBath.Checked) hs.NumOfBath = 1.5;
                if (rad2bath.Checked) hs.NumOfBath = 2;
                if (rad2andhalfbath.Checked) hs.NumOfBath = 2.5;
                MessageBox.Show("Thank you: " + prs.FName + " " + prs.LName +
                                hs, "Message");
               
            }
            
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

        private void radCondominium_CheckedChanged(object sender, EventArgs e)
        {
            grpHouse.Enabled = false;
            cbCondominium.Enabled = true;
        }

        private void radHouse_CheckedChanged(object sender, EventArgs e)
        {
            grpHouse.Enabled = true;
            cbCondominium.Enabled = false;
        }

    }
}
