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
    public partial class frmExer3 : Form
    {
        public frmExer3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntri_Click(object sender, EventArgs e)
        {
            double n1 = System.Convert.ToDouble(txbl1.Text);
            double n2 = System.Convert.ToDouble(txbl2.Text);
            double n3 = System.Convert.ToDouble(txbl3.Text);

            if (n1 == n2 && n1 == n3) 
            {
                lbltri.Text = "O triângulo é equilatero";
            }
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                lbltri.Text = "O triângulo é isósceles";
            }
            else
            {
                lbltri.Text = "O triângulo é escaleno";
            }
        }

        private void lblL1_Click(object sender, EventArgs e)
        {

        }
    }
}

