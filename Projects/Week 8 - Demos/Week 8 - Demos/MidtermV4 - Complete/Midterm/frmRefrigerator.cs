﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FridgeClasses;

namespace Midterm
{
    public partial class frmRefrigerator : Form
    {
        Refrigerator fridge;
        List<Refrigerator> fridgeList;

        public frmRefrigerator()
        {
            InitializeComponent();
            radCompact.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtMakeModel.Focus();
            this.grpFull.Enabled = false;
            fridgeList = new List<Refrigerator>();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMakeModel.Text = "";
            lstFeatures.ClearSelected();
            radCompact.Checked = true;
            chkEnergy.Checked = false;
            nudCapacity.Value = 12;
            txtMakeModel.Focus();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            String print = "";
            for (int i = 0; i < fridgeList.Count; i++)
            {
                print += fridgeList[i].ToString() + "\n";

            }
            MessageBox.Show(print, "Details");  
        }

        private void radFullSize_CheckedChanged(object sender, EventArgs e)
        {
            grpCompact.Enabled = false;
            grpFull.Enabled = true;
        }

        private void radCompact_CheckedChanged(object sender, EventArgs e)
        {
            grpCompact.Enabled = true;
            grpFull.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //5 marks
            if (txtMakeModel.Text == "")
            {
                errorProvMake.SetError(txtMakeModel, "Please enter a make and model");
                txtMakeModel.Focus();
                return;
            }
            else
            {
                errorProvMake.Clear();

                if (radFull.Checked)
                {
                    errorProvMake.Clear();
                    // fridge = new FullSize(txtMakeModel.Text, Convert.ToDouble(nudCapacity.Value), chkEnergy.Checked, lstFeatures.Text);
                    fridge = new FullSize(txtMakeModel.Text, Convert.ToDouble(nudCapacity.Value), chkEnergy.Checked, lstFeatures);
                    //for (int i = 0; i < lstFeatures.SelectedItems.Count; i++)
                    //{
                    //    ((FullSize)fridge).AddFeature(lstFeatures.SelectedItems[i].ToString());
                    //}

                }
                else //single
                {
                    fridge = new Compact(txtMakeModel.Text, Convert.ToDouble(nudCapacity.Value), chkEnergy.Checked, Convert.ToInt32(nudShelves.Value));
                    //sample of how to set a property that belongs to the derived class only
                    //((Compact)maker).NumberOfShelves = Convert.ToInt32(nudShelves.Value);
                }
            }
            fridgeList.Add(fridge);
            txtMakeModel.Clear();
        }

       

    }
}
