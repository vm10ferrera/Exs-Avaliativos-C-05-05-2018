using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmExer6 : Form
    {
        public frmExer6()
        {
            InitializeComponent();
        }

        private void txbin_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbBrasil.Text);
            double N = 1;
            do
            {
                rtbBrasil.Text += N.ToString() + "- Brasil\n";
                N++;
            }
            while (N <= num1);
        }
    }
}
