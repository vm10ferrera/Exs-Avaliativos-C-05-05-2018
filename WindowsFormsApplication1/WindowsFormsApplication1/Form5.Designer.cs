namespace WindowsFormsApplication1
{
    partial class frmExer4
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
            this.lblm = new System.Windows.Forms.Label();
            this.txbm = new System.Windows.Forms.TextBox();
            this.lblmê = new System.Windows.Forms.Label();
            this.lblmês = new System.Windows.Forms.Label();
            this.btnveri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblm
            // 
            this.lblm.AutoSize = true;
            this.lblm.Location = new System.Drawing.Point(13, 26);
            this.lblm.Name = "lblm";
            this.lblm.Size = new System.Drawing.Size(89, 13);
            this.lblm.TabIndex = 0;
            this.lblm.Text = "Digite um número";
            // 
            // txbm
            // 
            this.txbm.Location = new System.Drawing.Point(13, 43);
            this.txbm.Name = "txbm";
            this.txbm.Size = new System.Drawing.Size(100, 20);
            this.txbm.TabIndex = 1;
            // 
            // lblmê
            // 
            this.lblmê.AutoSize = true;
            this.lblmê.Location = new System.Drawing.Point(13, 99);
            this.lblmê.Name = "lblmê";
            this.lblmê.Size = new System.Drawing.Size(170, 13);
            this.lblmê.TabIndex = 2;
            this.lblmê.Text = "O número corresponde ao mês de:";
            // 
            // lblmês
            // 
            this.lblmês.AutoSize = true;
            this.lblmês.Location = new System.Drawing.Point(13, 112);
            this.lblmês.Name = "lblmês";
            this.lblmês.Size = new System.Drawing.Size(16, 13);
            this.lblmês.TabIndex = 3;
            this.lblmês.Text = "...";
            // 
            // btnveri
            // 
            this.btnveri.Location = new System.Drawing.Point(13, 69);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(75, 23);
            this.btnveri.TabIndex = 4;
            this.btnveri.Text = "Verificar";
            this.btnveri.UseVisualStyleBackColor = true;
            this.btnveri.Click += new System.EventHandler(this.btnveri_Click);
            // 
            // frmExer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.lblmês);
            this.Controls.Add(this.lblmê);
            this.Controls.Add(this.txbm);
            this.Controls.Add(this.lblm);
            this.Name = "frmExer4";
            this.Text = "Ex 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblm;
        private System.Windows.Forms.TextBox txbm;
        private System.Windows.Forms.Label lblmê;
        private System.Windows.Forms.Label lblmês;
        private System.Windows.Forms.Button btnveri;
    }
}