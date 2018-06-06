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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }

        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer1 exer1 = new frmExer1();
            exer1.MdiParent = this;
            exer1.Show();
        }

        private void teste2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer2 exer2 = new frmExer2();
            exer2.MdiParent = this;
            exer2.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer3 exer3 = new frmExer3();
            exer3.MdiParent = this;
            exer3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer4 exer4 = new frmExer4();
            exer4.MdiParent = this;
            exer4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer5 exer5 = new frmExer5();
            exer5.MdiParent = this;
            exer5.Show();
        }

        private void exercício6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer6 exer6 = new frmExer6();
            exer6.MdiParent = this;
            exer6.Show();
        }

        private void exercício7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExer7 exer7 = new frmExer7();
            exer7.MdiParent = this;
            exer7.Show();
        }
    }
}
