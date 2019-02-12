using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyClasses;
namespace Lab3
{
    public partial class Nam_N01185573 : Form
    {
        RentHouse rent;
        public Nam_N01185573()
        {
            InitializeComponent();
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

        private void btnBuy_Click(object sender, EventArgs e)
        {
            rent = new RentHouse(txtFName.Text, txtLName.Text);
            rent.NumOfRooms = (int)nudBed.Value;
            MessageBox.Show(rent.ToString(), "Rent Detail");
            
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
