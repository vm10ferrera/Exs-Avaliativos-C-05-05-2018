namespace WindowsFormsApplication1
{
    partial class frmExer2
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
            this.lblndiv = new System.Windows.Forms.Label();
            this.txbdiv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblresu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblndiv
            // 
            this.lblndiv.AutoSize = true;
            this.lblndiv.Location = new System.Drawing.Point(22, 29);
            this.lblndiv.Name = "lblndiv";
            this.lblndiv.Size = new System.Drawing.Size(89, 13);
            this.lblndiv.TabIndex = 0;
            this.lblndiv.Text = "Digite um número";
            // 
            // txbdiv
            // 
            this.txbdiv.Location = new System.Drawing.Point(25, 45);
            this.txbdiv.Name = "txbdiv";
            this.txbdiv.Size = new System.Drawing.Size(100, 20);
            this.txbdiv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblresu
            // 
            this.lblresu.AutoSize = true;
            this.lblresu.Location = new System.Drawing.Point(25, 152);
            this.lblresu.Name = "lblresu";
            this.lblresu.Size = new System.Drawing.Size(16, 13);
            this.lblresu.TabIndex = 3;
            this.lblresu.Text = "...";
            // 
            // frmExer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblresu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbdiv);
            this.Controls.Add(this.lblndiv);
            this.Name = "frmExer2";
            this.Text = "Ex 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblndiv;
        private System.Windows.Forms.TextBox txbdiv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblresu;
    }
}