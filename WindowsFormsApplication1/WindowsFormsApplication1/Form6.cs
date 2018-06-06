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
    public partial class frmExer5 : Form
    {
        public frmExer5()
        {
            InitializeComponent();
        }

        private void lbln_Click(object sender, EventArgs e)
        {

        }

        private void btnv_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbvr.Text);
            if (num1 <= 50)
            {
                double N = 1;
                do
                {
                    rTB.Text += N.ToString()+ "\n";
                    N++;
                }
                while (N <= num1);
            }
            else
                rTB.Text = "Seu número é maior que 50";
            }
        }
    }

