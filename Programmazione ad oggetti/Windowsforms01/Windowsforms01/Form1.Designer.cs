namespace Windowsforms01
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAprif2 = new System.Windows.Forms.Button();
            this.btnAprif2b = new System.Windows.Forms.Button();
            this.txtPassare = new System.Windows.Forms.TextBox();
            this.btnF2controllo = new System.Windows.Forms.Button();
            this.btnFormModale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAprif2
            // 
            this.btnAprif2.Location = new System.Drawing.Point(12, 12);
            this.btnAprif2.Name = "btnAprif2";
            this.btnAprif2.Size = new System.Drawing.Size(79, 30);
            this.btnAprif2.TabIndex = 0;
            this.btnAprif2.Text = "Apri form f2";
            this.btnAprif2.UseVisualStyleBackColor = true;
            this.btnAprif2.Click += new System.EventHandler(this.btnAprif2_Click);
            // 
            // btnAprif2b
            // 
            this.btnAprif2b.Location = new System.Drawing.Point(97, 12);
            this.btnAprif2b.Name = "btnAprif2b";
            this.btnAprif2b.Size = new System.Drawing.Size(79, 30);
            this.btnAprif2b.TabIndex = 1;
            this.btnAprif2b.Text = "Apri f2b";
            this.btnAprif2b.UseVisualStyleBackColor = true;
            // 
            // txtPassare
            // 
            this.txtPassare.Location = new System.Drawing.Point(12, 48);
            this.txtPassare.Name = "txtPassare";
            this.txtPassare.Size = new System.Drawing.Size(164, 20);
            this.txtPassare.TabIndex = 2;
            // 
            // btnF2controllo
            // 
            this.btnF2controllo.Location = new System.Drawing.Point(12, 74);
            this.btnF2controllo.Name = "btnF2controllo";
            this.btnF2controllo.Size = new System.Drawing.Size(164, 30);
            this.btnF2controllo.TabIndex = 3;
            this.btnF2controllo.Text = "Passa textbox a f2";
            this.btnF2controllo.UseVisualStyleBackColor = true;
            this.btnF2controllo.Click += new System.EventHandler(this.btnF2controllo_Click);
            // 
            // btnFormModale
            // 
            this.btnFormModale.Location = new System.Drawing.Point(12, 110);
            this.btnFormModale.Name = "btnFormModale";
            this.btnFormModale.Size = new System.Drawing.Size(164, 30);
            this.btnFormModale.TabIndex = 4;
            this.btnFormModale.Text = "Apri form modale";
            this.btnFormModale.UseVisualStyleBackColor = true;
            this.btnFormModale.Click += new System.EventHandler(this.btnFormModale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFormModale);
            this.Controls.Add(this.btnF2controllo);
            this.Controls.Add(this.txtPassare);
            this.Controls.Add(this.btnAprif2b);
            this.Controls.Add(this.btnAprif2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAprif2;
        private System.Windows.Forms.Button btnAprif2b;
        private System.Windows.Forms.TextBox txtPassare;
        private System.Windows.Forms.Button btnF2controllo;
        private System.Windows.Forms.Button btnFormModale;
    }
}

