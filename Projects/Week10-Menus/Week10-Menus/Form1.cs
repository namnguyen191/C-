using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOptionsChange_Click(object sender, EventArgs e)
        {
            codBackColors.AllowFullOpen = false;
            codBackColors.ShowDialog();
            this.BackColor = codBackColors.Color;
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            opdPictures.FileName = "";
            opdPictures.Title = "Select your picture";
            opdPictures.Filter = "All Files|*.*";
            opdPictures.FilterIndex = 1;
            opdPictures.InitialDirectory = System.IO.Path.Combine(Application.StartupPath, @"Images");
            opdPictures.ShowDialog();
            if(opdPictures.ShowDialog() == DialogResult.OK)
                picBackImage.Image = Image.FromFile(opdPictures.FileName);
        }
    }
}
