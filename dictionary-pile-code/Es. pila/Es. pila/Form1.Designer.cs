namespace Es.pila
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
            this.gpbContainer = new System.Windows.Forms.GroupBox();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupPeso = new System.Windows.Forms.NumericUpDown();
            this.nupTara = new System.Windows.Forms.NumericUpDown();
            this.btnInserisciContainer = new System.Windows.Forms.Button();
            this.btnVisualizzaDati = new System.Windows.Forms.Button();
            this.lblDati = new System.Windows.Forms.Label();
            this.gpbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTara)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbContainer
            // 
            this.gpbContainer.Controls.Add(this.nupTara);
            this.gpbContainer.Controls.Add(this.nupPeso);
            this.gpbContainer.Controls.Add(this.label3);
            this.gpbContainer.Controls.Add(this.label2);
            this.gpbContainer.Controls.Add(this.label1);
            this.gpbContainer.Controls.Add(this.txtCodice);
            this.gpbContainer.Location = new System.Drawing.Point(12, 12);
            this.gpbContainer.Name = "gpbContainer";
            this.gpbContainer.Size = new System.Drawing.Size(200, 111);
            this.gpbContainer.TabIndex = 0;
            this.gpbContainer.TabStop = false;
            this.gpbContainer.Text = "Container";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(67, 22);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(120, 22);
            this.txtCodice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tara:";
            // 
            // nupPeso
            // 
            this.nupPeso.DecimalPlaces = 1;
            this.nupPeso.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupPeso.Location = new System.Drawing.Point(67, 50);
            this.nupPeso.Name = "nupPeso";
            this.nupPeso.Size = new System.Drawing.Size(120, 22);
            this.nupPeso.TabIndex = 1;
            // 
            // nupTara
            // 
            this.nupTara.DecimalPlaces = 1;
            this.nupTara.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupTara.Location = new System.Drawing.Point(67, 78);
            this.nupTara.Name = "nupTara";
            this.nupTara.Size = new System.Drawing.Size(120, 22);
            this.nupTara.TabIndex = 5;
            // 
            // btnInserisciContainer
            // 
            this.btnInserisciContainer.Location = new System.Drawing.Point(12, 129);
            this.btnInserisciContainer.Name = "btnInserisciContainer";
            this.btnInserisciContainer.Size = new System.Drawing.Size(200, 48);
            this.btnInserisciContainer.TabIndex = 1;
            this.btnInserisciContainer.Text = "Inserisci container";
            this.btnInserisciContainer.UseVisualStyleBackColor = true;
            this.btnInserisciContainer.Click += new System.EventHandler(this.btnInserisciContainer_Click);
            // 
            // btnVisualizzaDati
            // 
            this.btnVisualizzaDati.Location = new System.Drawing.Point(12, 183);
            this.btnVisualizzaDati.Name = "btnVisualizzaDati";
            this.btnVisualizzaDati.Size = new System.Drawing.Size(200, 48);
            this.btnVisualizzaDati.TabIndex = 2;
            this.btnVisualizzaDati.Text = "Visualizza dati container";
            this.btnVisualizzaDati.UseVisualStyleBackColor = true;
            this.btnVisualizzaDati.Click += new System.EventHandler(this.btnVisualizzaDati_Click);
            // 
            // lblDati
            // 
            this.lblDati.AutoSize = true;
            this.lblDati.Location = new System.Drawing.Point(218, 199);
            this.lblDati.Name = "lblDati";
            this.lblDati.Size = new System.Drawing.Size(0, 17);
            this.lblDati.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDati);
            this.Controls.Add(this.btnVisualizzaDati);
            this.Controls.Add(this.btnInserisciContainer);
            this.Controls.Add(this.gpbContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbContainer.ResumeLayout(false);
            this.gpbContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContainer;
        private System.Windows.Forms.NumericUpDown nupTara;
        private System.Windows.Forms.NumericUpDown nupPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Button btnInserisciContainer;
        private System.Windows.Forms.Button btnVisualizzaDati;
        private System.Windows.Forms.Label lblDati;
    }
}

