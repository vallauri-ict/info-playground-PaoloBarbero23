namespace OOP_03
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreaMannaro = new System.Windows.Forms.Button();
            this.btnCreaMostro = new System.Windows.Forms.Button();
            this.btnCreaMannaro2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaMannaro
            // 
            this.btnCreaMannaro.Location = new System.Drawing.Point(16, 15);
            this.btnCreaMannaro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreaMannaro.Name = "btnCreaMannaro";
            this.btnCreaMannaro.Size = new System.Drawing.Size(144, 58);
            this.btnCreaMannaro.TabIndex = 0;
            this.btnCreaMannaro.Text = "Crea mannaro";
            this.btnCreaMannaro.UseVisualStyleBackColor = true;
            this.btnCreaMannaro.Click += new System.EventHandler(this.btnCreaMannaro_Click);
            // 
            // btnCreaMostro
            // 
            this.btnCreaMostro.Location = new System.Drawing.Point(168, 15);
            this.btnCreaMostro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreaMostro.Name = "btnCreaMostro";
            this.btnCreaMostro.Size = new System.Drawing.Size(144, 58);
            this.btnCreaMostro.TabIndex = 1;
            this.btnCreaMostro.Text = "Crea mostro";
            this.btnCreaMostro.UseVisualStyleBackColor = true;
            this.btnCreaMostro.Click += new System.EventHandler(this.btnCreaMostro_Click);
            // 
            // btnCreaMannaro2
            // 
            this.btnCreaMannaro2.Location = new System.Drawing.Point(16, 81);
            this.btnCreaMannaro2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreaMannaro2.Name = "btnCreaMannaro2";
            this.btnCreaMannaro2.Size = new System.Drawing.Size(144, 58);
            this.btnCreaMannaro2.TabIndex = 2;
            this.btnCreaMannaro2.Text = "Crea mannaro 2";
            this.btnCreaMannaro2.UseVisualStyleBackColor = true;
            this.btnCreaMannaro2.Click += new System.EventHandler(this.btnCreaMannaro2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnCreaMannaro2);
            this.Controls.Add(this.btnCreaMostro);
            this.Controls.Add(this.btnCreaMannaro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaMannaro;
        private System.Windows.Forms.Button btnCreaMostro;
        private System.Windows.Forms.Button btnCreaMannaro2;
    }
}

