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
    public partial class frmExer4 : Form
    {
        public frmExer4()
        {
            InitializeComponent();
        }

        private void btnveri_Click(object sender, EventArgs e)
        {
            double num1 = System.Convert.ToDouble(txbm.Text);

            if (num1 == 1)
            {
                lblmês.Text = "O número representa o mês de Janeiro";
            }

            else if (num1 == 2)
            {
                lblmês.Text = "O número representa o mês de Fevereiro";
            }

            else if (num1 == 3)
            {
                lblmês.Text = "O número representa o mês de Março";
            }

            else if (num1 == 4)
            {
                lblmês.Text = "O número representa o mês de Abril";
            }

            else if (num1 == 5)
            {
                lblmês.Text = "O número representa o mês de Maio";
            }

            else if (num1 == 6)
            {
                lblmês.Text = "O número representa o mês de Junho";
            }

            else if (num1 == 7)
            {
                lblmês.Text = "O número representa o mês de Julho";
            }

            else if (num1 == 8)
            {
                lblmês.Text = "O número representa o mês de Agosto";
            }

            else if (num1 == 9)
            {
                lblmês.Text = "O número representa o mês de Setembro";
            }

            else if (num1 == 10)
            {
                lblmês.Text = "O número representa o mês de Outubro";
            }

            else if (num1 == 11)
            {
                lblmês.Text = "O número representa o mês de Novembro";
            }

            else if (num1 == 12)
            {
                lblmês.Text = "O número representa o mês de Dezembro";
            }

            else
            {
                lblmês.Text = "O número digitado não representa nenhum mês conhecido";
            }
        }
    }
}
