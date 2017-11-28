using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPORTGMRM
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ventana1 v = new ventana1();
            v.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ventana2 v = new ventana2();
            v.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ventana3 v = new ventana3();
            v.Show();
        }

    }
}
