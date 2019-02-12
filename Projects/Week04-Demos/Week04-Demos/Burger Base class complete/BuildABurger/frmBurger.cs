using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerClasses;

namespace BuildABurger
{
    public partial class frmBurger : Form
    {
        RegularBurger regularBurger;
        internal frmBurger()
        {
            InitializeComponent();
           // regularBurger = new RegularBurger();
        }

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            //regularBurger.Ketchup = chkKetchup.Checked;
            //regularBurger.Lettuce = chkLettuce.Checked;
            //regularBurger.Mustard = chkMustard.Checked;
            //regularBurger.Onions = chkOnions.Checked;
            //regularBurger.Pickles = chkPickles.Checked;

            //create object using overloaded constructor
            regularBurger = new RegularBurger(chkKetchup.Checked, chkLettuce.Checked, chkMustard.Checked,
                chkOnions.Checked, chkPickles.Checked);
            //get just the list of condiments
            MessageBox.Show(regularBurger.CondimentList, "Condiment List");
            //get the whole description, including condiments
            MessageBox.Show(regularBurger.ToString(), "Burger Details");
        }

        private void grpBurgerType_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
