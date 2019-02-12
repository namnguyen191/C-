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
        }

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            regularBurger = new RegularBurger();
        }
    }
}
