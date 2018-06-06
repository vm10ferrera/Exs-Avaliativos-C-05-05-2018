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
    public partial class frmExer7 : Form
    {
        public frmExer7()
        {
            InitializeComponent();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            double alt1 = 1.50;
            double alt2 = 1.10;
            double i = 1;
           while(alt2 <= alt1)
            {
                alt1 += 0.02;
                alt2 += 0.03;
                i++;
           }
           lblres.Text = "Manoel passou Arlindo em: " + i + " anos.";

        }
    }
}
