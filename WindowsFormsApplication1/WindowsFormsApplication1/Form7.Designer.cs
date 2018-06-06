namespace WindowsFormsApplication1
{
    partial class frmExer6
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
            this.lblBrasil = new System.Windows.Forms.Label();
            this.txbBrasil = new System.Windows.Forms.TextBox();
            this.rtbBrasil = new System.Windows.Forms.RichTextBox();
            this.txbin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrasil
            // 
            this.lblBrasil.AutoSize = true;
            this.lblBrasil.Location = new System.Drawing.Point(21, 48);
            this.lblBrasil.Name = "lblBrasil";
            this.lblBrasil.Size = new System.Drawing.Size(286, 13);
            this.lblBrasil.TabIndex = 0;
            this.lblBrasil.Text = "Digite o número de vezes que a palavara Brasil sera escrita";
            // 
            // txbBrasil
            // 
            this.txbBrasil.Location = new System.Drawing.Point(97, 73);
            this.txbBrasil.Name = "txbBrasil";
            this.txbBrasil.Size = new System.Drawing.Size(100, 20);
            this.txbBrasil.TabIndex = 1;
            // 
            // rtbBrasil
            // 
            this.rtbBrasil.Location = new System.Drawing.Point(97, 154);
            this.rtbBrasil.Name = "rtbBrasil";
            this.rtbBrasil.Size = new System.Drawing.Size(100, 96);
            this.rtbBrasil.TabIndex = 2;
            this.rtbBrasil.Text = "";
            // 
            // txbin
            // 
            this.txbin.Location = new System.Drawing.Point(107, 109);
            this.txbin.Name = "txbin";
            this.txbin.Size = new System.Drawing.Size(75, 23);
            this.txbin.TabIndex = 3;
            this.txbin.Text = "Inserir";
            this.txbin.UseVisualStyleBackColor = true;
            this.txbin.Click += new System.EventHandler(this.txbin_Click);
            // 
            // frmExer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 262);
            this.Controls.Add(this.txbin);
            this.Controls.Add(this.rtbBrasil);
            this.Controls.Add(this.txbBrasil);
            this.Controls.Add(this.lblBrasil);
            this.Name = "frmExer6";
            this.Text = "Ex 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrasil;
        private System.Windows.Forms.TextBox txbBrasil;
        private System.Windows.Forms.RichTextBox rtbBrasil;
        private System.Windows.Forms.Button txbin;
    }
}