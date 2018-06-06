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
    public partial class frmExer1 : Form
    {
        private Label label1;
        private Label label2;
        private TextBox txbn01;
        private TextBox txbn02;
        private Button button1;
        private TextBox txbresult;
        private Label label3;
    
        public frmExer1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbn01 = new System.Windows.Forms.TextBox();
            this.txbn02 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o 1º número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o 2º número";
            // 
            // txbn01
            // 
            this.txbn01.Location = new System.Drawing.Point(32, 43);
            this.txbn01.Name = "txbn01";
            this.txbn01.Size = new System.Drawing.Size(100, 20);
            this.txbn01.TabIndex = 2;
            this.txbn01.TextChanged += new System.EventHandler(this.txbn01_TextChanged);
            // 
            // txbn02
            // 
            this.txbn02.Location = new System.Drawing.Point(32, 93);
            this.txbn02.Name = "txbn02";
            this.txbn02.Size = new System.Drawing.Size(100, 20);
            this.txbn02.TabIndex = 3;
            this.txbn02.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado: ";
            // 
            // txbresult
            // 
            this.txbresult.Location = new System.Drawing.Point(88, 185);
            this.txbresult.Name = "txbresult";
            this.txbresult.Size = new System.Drawing.Size(100, 20);
            this.txbresult.TabIndex = 6;
            this.txbresult.TextChanged += new System.EventHandler(this.txbresult_TextChanged);
            // 
            // frmExer1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txbresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbn02);
            this.Controls.Add(this.txbn01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExer1";
            this.Text = "Ex 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double n1 = System.Convert.ToDouble(txbn01.Text);
            double n2 = System.Convert.ToDouble(txbn02.Text);
            double resultado = n1 + n2;

            if (resultado > 20)
            {
                double result = resultado + 8;
                txbresult.Text = result.ToString();
            }
            else
            {
                double result = resultado - 5;
                txbresult.Text = result.ToString();
            }
        }

        private void txbresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbn01_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
