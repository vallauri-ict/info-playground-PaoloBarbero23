namespace Es.coda
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
            this.cmbCodice = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nupEta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnVisualizzaPaziente = new System.Windows.Forms.Button();
            this.lblDatiPaziente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupEta)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCodice
            // 
            this.cmbCodice.FormattingEnabled = true;
            this.cmbCodice.Items.AddRange(new object[] {
            "Rosso",
            "Giallo",
            "Verde",
            "Bianco"});
            this.cmbCodice.Location = new System.Drawing.Point(13, 86);
            this.cmbCodice.Name = "cmbCodice";
            this.cmbCodice.Size = new System.Drawing.Size(120, 21);
            this.cmbCodice.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(13, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(120, 20);
            this.txtNome.TabIndex = 1;
            // 
            // nupEta
            // 
            this.nupEta.Location = new System.Drawing.Point(13, 60);
            this.nupEta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupEta.Name = "nupEta";
            this.nupEta.Size = new System.Drawing.Size(120, 20);
            this.nupEta.TabIndex = 2;
            this.nupEta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Età";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codice";
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(13, 113);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(166, 27);
            this.btnRegistra.TabIndex = 6;
            this.btnRegistra.Text = "Registra paziente";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnVisualizzaPaziente
            // 
            this.btnVisualizzaPaziente.Location = new System.Drawing.Point(13, 146);
            this.btnVisualizzaPaziente.Name = "btnVisualizzaPaziente";
            this.btnVisualizzaPaziente.Size = new System.Drawing.Size(166, 23);
            this.btnVisualizzaPaziente.TabIndex = 7;
            this.btnVisualizzaPaziente.Text = "Visualizza prossimo paziente";
            this.btnVisualizzaPaziente.UseVisualStyleBackColor = true;
            this.btnVisualizzaPaziente.Click += new System.EventHandler(this.btnVisualizzaPaziente_Click);
            // 
            // lblDatiPaziente
            // 
            this.lblDatiPaziente.AutoSize = true;
            this.lblDatiPaziente.Location = new System.Drawing.Point(12, 172);
            this.lblDatiPaziente.Name = "lblDatiPaziente";
            this.lblDatiPaziente.Size = new System.Drawing.Size(0, 13);
            this.lblDatiPaziente.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDatiPaziente);
            this.Controls.Add(this.btnVisualizzaPaziente);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbCodice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupEta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCodice;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nupEta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnVisualizzaPaziente;
        private System.Windows.Forms.Label lblDatiPaziente;
    }
}

