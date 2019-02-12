using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleClasses;

namespace Midterm
{
    public partial class frmVehicles : Form
    {
        Vehicles veh;
        public frmVehicles()
        {
            InitializeComponent();
            txtName.Focus();
            radCar.Checked = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.Text = "";
            lstMail.SelectedIndex = -1;
            radCar.Checked = true;
            radTruch.Checked = false;
            chkHatchback.Checked = false;
            nudCargo.Value = 5.00M;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            String chk = "";
            if (lstMail.SelectedIndex == 1 | lstMail.SelectedIndex == 0 | lstMail.SelectedIndex == 2 )
            {
                chk = "aaa";
            }
            
            if (radCar.Checked == true)
            {
                veh = new Car(txtName.Text,chk,chkHatchback.Checked);
                MessageBox.Show(veh.ToString(), "Vehcle Information");
            }
            else
            {
                veh = new Truck(txtName.Text, chk, nudCargo.Value);
                MessageBox.Show(veh.ToString(), "Vehcle Information");
            }

        }

        private void radCar_CheckedChanged(object sender, EventArgs e)
        {
            chkHatchback.Enabled = true;
            nudCargo.Enabled = false;
        }

        private void radTruch_CheckedChanged(object sender, EventArgs e)
        {
            chkHatchback.Enabled = false;
            nudCargo.Enabled = true;
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {

        }
    }
}
