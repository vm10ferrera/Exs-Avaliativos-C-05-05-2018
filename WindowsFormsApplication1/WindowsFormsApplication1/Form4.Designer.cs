namespace WindowsFormsApplication1
{
    partial class frmExer3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblL1 = new System.Windows.Forms.Label();
            this.txbl1 = new System.Windows.Forms.TextBox();
            this.lblL2 = new System.Windows.Forms.Label();
            this.txbl2 = new System.Windows.Forms.TextBox();
            this.lblL3 = new System.Windows.Forms.Label();
            this.txbl3 = new System.Windows.Forms.TextBox();
            this.btntri = new System.Windows.Forms.Button();
            this.lbltri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblL1
            // 
            this.lblL1.AutoSize = true;
            this.lblL1.Location = new System.Drawing.Point(23, 25);
            this.lblL1.Name = "lblL1";
            this.lblL1.Size = new System.Drawing.Size(204, 13);
            this.lblL1.TabIndex = 0;
            this.lblL1.Text = "Digite o valor do primeiro lado do triângulo";
            this.lblL1.Click += new System.EventHandler(this.lblL1_Click);
            // 
            // txbl1
            // 
            this.txbl1.Location = new System.Drawing.Point(26, 41);
            this.txbl1.Name = "txbl1";
            this.txbl1.Size = new System.Drawing.Size(100, 20);
            this.txbl1.TabIndex = 1;
            // 
            // lblL2
            // 
            this.lblL2.AutoSize = true;
            this.lblL2.Location = new System.Drawing.Point(23, 74);
            this.lblL2.Name = "lblL2";
            this.lblL2.Size = new System.Drawing.Size(209, 13);
            this.lblL2.TabIndex = 2;
            this.lblL2.Text = "Digite o valor do segundo lado do triângulo";
            // 
            // txbl2
            // 
            this.txbl2.Location = new System.Drawing.Point(26, 90);
            this.txbl2.Name = "txbl2";
            this.txbl2.Size = new System.Drawing.Size(100, 20);
            this.txbl2.TabIndex = 3;
            // 
            // lblL3
            // 
            this.lblL3.AutoSize = true;
            this.lblL3.Location = new System.Drawing.Point(23, 126);
            this.lblL3.Name = "lblL3";
            this.lblL3.Size = new System.Drawing.Size(203, 13);
            this.lblL3.TabIndex = 4;
            this.lblL3.Text = "Digite o valor do terceiro lado do triângulo";
            // 
            // txbl3
            // 
            this.txbl3.Location = new System.Drawing.Point(26, 142);
            this.txbl3.Name = "txbl3";
            this.txbl3.Size = new System.Drawing.Size(100, 20);
            this.txbl3.TabIndex = 5;
            this.txbl3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btntri
            // 
            this.btntri.Location = new System.Drawing.Point(26, 179);
            this.btntri.Name = "btntri";
            this.btntri.Size = new System.Drawing.Size(125, 23);
            this.btntri.TabIndex = 6;
            this.btntri.Text = "Gerar tipo de triângulo";
            this.btntri.UseVisualStyleBackColor = true;
            this.btntri.Click += new System.EventHandler(this.btntri_Click);
            // 
            // lbltri
            // 
            this.lbltri.AutoSize = true;
            this.lbltri.Location = new System.Drawing.Point(26, 218);
            this.lbltri.Name = "lbltri";
            this.lbltri.Size = new System.Drawing.Size(16, 13);
            this.lbltri.TabIndex = 7;
            this.lbltri.Text = "...";
            // 
            // frmExer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbltri);
            this.Controls.Add(this.btntri);
            this.Controls.Add(this.txbl3);
            this.Controls.Add(this.lblL3);
            this.Controls.Add(this.txbl2);
            this.Controls.Add(this.lblL2);
            this.Controls.Add(this.txbl1);
            this.Controls.Add(this.lblL1);
            this.Name = "frmExer3";
            this.Text = " Ex 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblL1;
        private System.Windows.Forms.TextBox txbl1;
        private System.Windows.Forms.Label lblL2;
        private System.Windows.Forms.TextBox txbl2;
        private System.Windows.Forms.Label lblL3;
        private System.Windows.Forms.TextBox txbl3;
        private System.Windows.Forms.Button btntri;
        private System.Windows.Forms.Label lbltri;
    }
}