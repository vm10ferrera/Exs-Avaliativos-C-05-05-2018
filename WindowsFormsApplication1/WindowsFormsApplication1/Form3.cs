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
    public partial class frmExer2 : Form
    {
        public frmExer2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbdiv.Text);
            double rst1 = num1 % 2;
            double rst2 = num1 % 5;
            double rst3 = num1 % 10;

            if (rst1 == 0 && rst2 == 0 && rst3 == 0)
            {
                lblresu.Text = "O número é divisível pelos 3 números";
            }

            else if (rst1 == 0 && rst2 == 0)
            {
                lblresu.Text = "O número é divisível apenas por 5 e por 2";
            }

            else if (rst1 == 0 && rst3 == 0)
            {
                lblresu.Text = "O número é divisível apenas por 10 e por 2";
            }

            else if (rst2 == 0 && rst3 == 0)
            {
                lblresu.Text = "O número é divisível apenas por 10 e por 2";
            }

            else if (rst1 == 0)
            {
                lblresu.Text = "O número é divisível apenas por 2";
            }

            else if (rst2 == 0)
            {
                lblresu.Text = "O número é divisível apenas por 5";
            }

            else if (rst3 == 0)
            {
                lblresu.Text = "O número é divisível por apenas 10";
            }

            else
                lblresu.Text = "O número não é divisível por nenhum dos 3 números";
        }
    }
}
