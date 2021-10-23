namespace Preparazione_verifica
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPadre = new System.Windows.Forms.Button();
            this.btnZio = new System.Windows.Forms.Button();
            this.btnNonno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPadre
            // 
            this.btnPadre.Location = new System.Drawing.Point(118, 12);
            this.btnPadre.Name = "btnPadre";
            this.btnPadre.Size = new System.Drawing.Size(114, 23);
            this.btnPadre.TabIndex = 1;
            this.btnPadre.Text = "Invia al padre";
            this.btnPadre.UseVisualStyleBackColor = true;
            this.btnPadre.Click += new System.EventHandler(this.btnPadre_Click);
            // 
            // btnZio
            // 
            this.btnZio.Location = new System.Drawing.Point(118, 41);
            this.btnZio.Name = "btnZio";
            this.btnZio.Size = new System.Drawing.Size(114, 23);
            this.btnZio.TabIndex = 2;
            this.btnZio.Text = "Invia allo zio";
            this.btnZio.UseVisualStyleBackColor = true;
            this.btnZio.Click += new System.EventHandler(this.btnZio_Click);
            // 
            // btnNonno
            // 
            this.btnNonno.Location = new System.Drawing.Point(118, 70);
            this.btnNonno.Name = "btnNonno";
            this.btnNonno.Size = new System.Drawing.Size(114, 23);
            this.btnNonno.TabIndex = 3;
            this.btnNonno.Text = "Invia al nonno";
            this.btnNonno.UseVisualStyleBackColor = true;
            this.btnNonno.Click += new System.EventHandler(this.btnNonno_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 245);
            this.Controls.Add(this.btnNonno);
            this.Controls.Add(this.btnZio);
            this.Controls.Add(this.btnPadre);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPadre;
        private System.Windows.Forms.Button btnZio;
        private System.Windows.Forms.Button btnNonno;
    }
}