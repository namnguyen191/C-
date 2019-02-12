using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2_MouseMove
{
    public partial class frmMouseMove : Form
    {
        public frmMouseMove()
        {
            InitializeComponent();
        }

        private void textBox2_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void frmMouseMove_Load(object sender, EventArgs e)
        {

        }
    }
}
