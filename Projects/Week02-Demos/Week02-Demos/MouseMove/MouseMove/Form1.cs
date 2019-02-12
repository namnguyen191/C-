using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseMove
{
    public partial class frmMouseMove : Form
    {
        public frmMouseMove()
        {
            InitializeComponent();
            this.txtYCoord.Text = "";
        }

        private void frmMouseMove_MouseMove(object sender, MouseEventArgs e)
        {
            this.txtXCoord.Text = e.X.ToString();
            this.txtYCoord.Text = e.Y.ToString();
            this.txtXCoord.Focus();
        }
    }
}
