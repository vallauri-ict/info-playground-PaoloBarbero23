namespace OOP_05
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnAddLibro = new System.Windows.Forms.Button();
            this.btnVisualizzaLibri = new System.Windows.Forms.Button();
            this.nupLibro = new System.Windows.Forms.NumericUpDown();
            this.btnIndiceLibro = new System.Windows.Forms.Button();
            this.btnAggiungiCoda = new System.Windows.Forms.Button();
            this.btnAggiungiPila = new System.Windows.Forms.Button();
            this.btnRimuoviCoda = new System.Windows.Forms.Button();
            this.btnRimuoviPila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autore";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(56, 6);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(120, 20);
            this.txtTitolo.TabIndex = 2;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(56, 33);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(120, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // btnAddLibro
            // 
            this.btnAddLibro.Location = new System.Drawing.Point(12, 85);
            this.btnAddLibro.Name = "btnAddLibro";
            this.btnAddLibro.Size = new System.Drawing.Size(164, 34);
            this.btnAddLibro.TabIndex = 4;
            this.btnAddLibro.Text = "Aggiungi libro";
            this.btnAddLibro.UseVisualStyleBackColor = true;
            this.btnAddLibro.Click += new System.EventHandler(this.btnAddLibro_Click);
            // 
            // btnVisualizzaLibri
            // 
            this.btnVisualizzaLibri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizzaLibri.Location = new System.Drawing.Point(198, 6);
            this.btnVisualizzaLibri.Name = "btnVisualizzaLibri";
            this.btnVisualizzaLibri.Size = new System.Drawing.Size(149, 47);
            this.btnVisualizzaLibri.TabIndex = 5;
            this.btnVisualizzaLibri.Text = "Visualizza libri";
            this.btnVisualizzaLibri.UseVisualStyleBackColor = true;
            this.btnVisualizzaLibri.Click += new System.EventHandler(this.btnVisualizzaLibri_Click);
            // 
            // nupLibro
            // 
            this.nupLibro.Location = new System.Drawing.Point(56, 59);
            this.nupLibro.Name = "nupLibro";
            this.nupLibro.Size = new System.Drawing.Size(120, 20);
            this.nupLibro.TabIndex = 6;
            // 
            // btnIndiceLibro
            // 
            this.btnIndiceLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndiceLibro.Location = new System.Drawing.Point(198, 59);
            this.btnIndiceLibro.Name = "btnIndiceLibro";
            this.btnIndiceLibro.Size = new System.Drawing.Size(149, 20);
            this.btnIndiceLibro.TabIndex = 7;
            this.btnIndiceLibro.Text = "Vis libro";
            this.btnIndiceLibro.UseVisualStyleBackColor = true;
            this.btnIndiceLibro.Click += new System.EventHandler(this.btnIndiceLibro_Click);
            // 
            // btnAggiungiCoda
            // 
            this.btnAggiungiCoda.Location = new System.Drawing.Point(12, 125);
            this.btnAggiungiCoda.Name = "btnAggiungiCoda";
            this.btnAggiungiCoda.Size = new System.Drawing.Size(164, 30);
            this.btnAggiungiCoda.TabIndex = 8;
            this.btnAggiungiCoda.Text = "Aggiungi in coda";
            this.btnAggiungiCoda.UseVisualStyleBackColor = true;
            this.btnAggiungiCoda.Click += new System.EventHandler(this.btnAggiungiCoda_Click);
            // 
            // btnAggiungiPila
            // 
            this.btnAggiungiPila.Location = new System.Drawing.Point(12, 161);
            this.btnAggiungiPila.Name = "btnAggiungiPila";
            this.btnAggiungiPila.Size = new System.Drawing.Size(164, 30);
            this.btnAggiungiPila.TabIndex = 9;
            this.btnAggiungiPila.Text = "Aggiungi in pila";
            this.btnAggiungiPila.UseVisualStyleBackColor = true;
            this.btnAggiungiPila.Click += new System.EventHandler(this.btnAggiungiPila_Click);
            // 
            // btnRimuoviCoda
            // 
            this.btnRimuoviCoda.Location = new System.Drawing.Point(182, 125);
            this.btnRimuoviCoda.Name = "btnRimuoviCoda";
            this.btnRimuoviCoda.Size = new System.Drawing.Size(164, 30);
            this.btnRimuoviCoda.TabIndex = 10;
            this.btnRimuoviCoda.Text = "Rimuovi in coda";
            this.btnRimuoviCoda.UseVisualStyleBackColor = true;
            this.btnRimuoviCoda.Click += new System.EventHandler(this.btnRimuoviCoda_Click);
            // 
            // btnRimuoviPila
            // 
            this.btnRimuoviPila.Location = new System.Drawing.Point(182, 161);
            this.btnRimuoviPila.Name = "btnRimuoviPila";
            this.btnRimuoviPila.Size = new System.Drawing.Size(164, 30);
            this.btnRimuoviPila.TabIndex = 11;
            this.btnRimuoviPila.Text = "Rimuovi in pila";
            this.btnRimuoviPila.UseVisualStyleBackColor = true;
            this.btnRimuoviPila.Click += new System.EventHandler(this.btnRimuoviPila_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRimuoviPila);
            this.Controls.Add(this.btnRimuoviCoda);
            this.Controls.Add(this.btnAggiungiPila);
            this.Controls.Add(this.btnAggiungiCoda);
            this.Controls.Add(this.btnIndiceLibro);
            this.Controls.Add(this.nupLibro);
            this.Controls.Add(this.btnVisualizzaLibri);
            this.Controls.Add(this.btnAddLibro);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnAddLibro;
        private System.Windows.Forms.Button btnVisualizzaLibri;
        private System.Windows.Forms.NumericUpDown nupLibro;
        private System.Windows.Forms.Button btnIndiceLibro;
        private System.Windows.Forms.Button btnAggiungiCoda;
        private System.Windows.Forms.Button btnAggiungiPila;
        private System.Windows.Forms.Button btnRimuoviCoda;
        private System.Windows.Forms.Button btnRimuoviPila;
    }
}

