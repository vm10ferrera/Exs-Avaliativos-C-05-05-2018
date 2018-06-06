namespace WindowsFormsApplication1
{
    partial class frmExer5
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
            this.lbln = new System.Windows.Forms.Label();
            this.btnv = new System.Windows.Forms.Button();
            this.txbvr = new System.Windows.Forms.TextBox();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(83, 39);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(89, 13);
            this.lbln.TabIndex = 0;
            this.lbln.Text = "Digite um número";
            this.lbln.Click += new System.EventHandler(this.lbln_Click);
            // 
            // btnv
            // 
            this.btnv.Location = new System.Drawing.Point(86, 87);
            this.btnv.Name = "btnv";
            this.btnv.Size = new System.Drawing.Size(75, 23);
            this.btnv.TabIndex = 1;
            this.btnv.Text = "Verificar";
            this.btnv.UseVisualStyleBackColor = true;
            this.btnv.Click += new System.EventHandler(this.btnv_Click);
            // 
            // txbvr
            // 
            this.txbvr.Location = new System.Drawing.Point(86, 55);
            this.txbvr.Name = "txbvr";
            this.txbvr.Size = new System.Drawing.Size(100, 20);
            this.txbvr.TabIndex = 3;
            // 
            // rTB
            // 
            this.rTB.Location = new System.Drawing.Point(72, 125);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(100, 96);
            this.rTB.TabIndex = 4;
            this.rTB.Text = "";
            // 
            // frmExer5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.txbvr);
            this.Controls.Add(this.btnv);
            this.Controls.Add(this.lbln);
            this.Name = "frmExer5";
            this.Text = "Ex 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Button btnv;
        private System.Windows.Forms.TextBox txbvr;
        private System.Windows.Forms.RichTextBox rTB;
    }
}