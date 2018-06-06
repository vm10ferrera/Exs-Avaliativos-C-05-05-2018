namespace WindowsFormsApplication1
{
    partial class frmExer7
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnver = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manoel será maior que Arlindo em quantos anos?";
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(88, 63);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(75, 23);
            this.btnver.TabIndex = 1;
            this.btnver.Text = "Verificar";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(85, 105);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(16, 13);
            this.lblres.TabIndex = 2;
            this.lblres.Text = "...";
            // 
            // frmExer7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.label1);
            this.Name = "frmExer7";
            this.Text = "Ex 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Label lblres;
    }
}