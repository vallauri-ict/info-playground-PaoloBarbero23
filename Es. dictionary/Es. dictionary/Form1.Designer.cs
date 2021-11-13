namespace Es.dictionary
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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInserisciArticolo = new System.Windows.Forms.Button();
            this.btnNumeroInserimenti = new System.Windows.Forms.Button();
            this.lblNumeroInserimenti = new System.Windows.Forms.Label();
            this.btnCercaValue = new System.Windows.Forms.Button();
            this.lblAbbigliamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 38);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chiave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valore";
            // 
            // btnInserisciArticolo
            // 
            this.btnInserisciArticolo.Location = new System.Drawing.Point(12, 64);
            this.btnInserisciArticolo.Name = "btnInserisciArticolo";
            this.btnInserisciArticolo.Size = new System.Drawing.Size(143, 23);
            this.btnInserisciArticolo.TabIndex = 4;
            this.btnInserisciArticolo.Text = "Inserisci articolo";
            this.btnInserisciArticolo.UseVisualStyleBackColor = true;
            this.btnInserisciArticolo.Click += new System.EventHandler(this.btnInserisciArticolo_Click);
            // 
            // btnNumeroInserimenti
            // 
            this.btnNumeroInserimenti.Location = new System.Drawing.Point(164, 12);
            this.btnNumeroInserimenti.Name = "btnNumeroInserimenti";
            this.btnNumeroInserimenti.Size = new System.Drawing.Size(171, 23);
            this.btnNumeroInserimenti.TabIndex = 5;
            this.btnNumeroInserimenti.Text = "Visualizza il numero di inserimenti";
            this.btnNumeroInserimenti.UseVisualStyleBackColor = true;
            this.btnNumeroInserimenti.Click += new System.EventHandler(this.btnNumeroInserimenti_Click);
            // 
            // lblNumeroInserimenti
            // 
            this.lblNumeroInserimenti.AutoSize = true;
            this.lblNumeroInserimenti.Location = new System.Drawing.Point(161, 41);
            this.lblNumeroInserimenti.Name = "lblNumeroInserimenti";
            this.lblNumeroInserimenti.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroInserimenti.TabIndex = 6;
            this.lblNumeroInserimenti.Text = "Numero inserimenti: ";
            // 
            // btnCercaValue
            // 
            this.btnCercaValue.Location = new System.Drawing.Point(164, 64);
            this.btnCercaValue.Name = "btnCercaValue";
            this.btnCercaValue.Size = new System.Drawing.Size(171, 23);
            this.btnCercaValue.TabIndex = 7;
            this.btnCercaValue.Text = "Cerca un abbigliamento";
            this.btnCercaValue.UseVisualStyleBackColor = true;
            this.btnCercaValue.Click += new System.EventHandler(this.btnCercaValue_Click);
            // 
            // lblAbbigliamento
            // 
            this.lblAbbigliamento.AutoSize = true;
            this.lblAbbigliamento.Location = new System.Drawing.Point(161, 90);
            this.lblAbbigliamento.Name = "lblAbbigliamento";
            this.lblAbbigliamento.Size = new System.Drawing.Size(0, 13);
            this.lblAbbigliamento.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 306);
            this.Controls.Add(this.lblAbbigliamento);
            this.Controls.Add(this.btnCercaValue);
            this.Controls.Add(this.lblNumeroInserimenti);
            this.Controls.Add(this.btnNumeroInserimenti);
            this.Controls.Add(this.btnInserisciArticolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInserisciArticolo;
        private System.Windows.Forms.Button btnNumeroInserimenti;
        private System.Windows.Forms.Label lblNumeroInserimenti;
        private System.Windows.Forms.Button btnCercaValue;
        private System.Windows.Forms.Label lblAbbigliamento;
    }
}

