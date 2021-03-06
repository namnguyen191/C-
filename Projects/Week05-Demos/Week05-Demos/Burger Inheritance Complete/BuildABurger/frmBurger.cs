﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Burgers;

namespace BuildABurger
{
    public partial class frmBurger : Form
    {
        RegularBurger objBurger;
        internal frmBurger()
        {
            InitializeComponent();
        }

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            if(radRegular.Checked)
            {
                objBurger = new RegularBurger();
            }
            if (radSpecial.Checked)
            {
                objBurger = new SpecialBurger((int)nudCheeseSlices.Value, (int)nudBaconSlices.Value);
            }
            objBurger.Ketchup = chkKetchup.Checked;
            objBurger.Onions = chkOnions.Checked;
            objBurger.Mustard = chkMustard.Checked;
            objBurger.Pickels = chkPickels.Checked;
            objBurger.Lettuce = chkLettuce.Checked;
            //get just the list of condiments
            MessageBox.Show(objBurger.CondimentList, "Condiment List");
            //get the whole description, including condiments
            MessageBox.Show(objBurger.ToString(), "Burger Details");

            //create objects using overloaded constructors of two classes
            /*if (radRegular.Checked)
            {
               objBurger = new RegularBurger(chkKetchup.Checked, chkLettuce.Checked, chkMustard.Checked,
                    chkOnions.Checked, chkPickels.Checked);
            }
            if (radSpecial.Checked)
            {
               objBurger = new SpecialBurger(chkKetchup.Checked, chkLettuce.Checked, chkMustard.Checked,
                    chkOnions.Checked, chkPickels.Checked, (int)nudCheeseSlices.Value, (int)nudBaconSlices.Value);
            }
            
            //get just the list of condiments
            MessageBox.Show(objBurger.CondimentList, "Condiment List");
            //get the whole description, including condiments
            MessageBox.Show(objBurger.ToString(), "Burger Details");*/
        }

        private void radRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (radRegular.Checked)
            {
                nudBaconSlices.Enabled = false;
                nudCheeseSlices.Enabled = false;
            }

            else
            {
                nudBaconSlices.Enabled = true;
                nudCheeseSlices.Enabled = true;
            }
        }
    }
}
