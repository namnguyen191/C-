using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Nam_N01185573 : Form
    {
        
        public Nam_N01185573()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumOfBedRoom_Click(object sender, EventArgs e)
        {

        }

        private void lblLName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (txtFName.Text != "" & txtLName.Text != "")
            {
                grbFinalMess.Visible = true;
                lblFullName.Text = "Thank you! " + txtLName.Text + " " + txtFName.Text;
                txtBedRent.Text = nudBed.Value + " bedroom(s) rented.";
                txtCost.Text = "Total cost: " + (nudBed.Value * 500).ToString("c");
                btnClear.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            nudBed.ResetText();
            txtFName.Focus();
            grbFinalMess.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
