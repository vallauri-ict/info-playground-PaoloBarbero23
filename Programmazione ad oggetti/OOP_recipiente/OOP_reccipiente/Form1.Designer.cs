namespace OOP_reccipiente
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
            this.btnRecipiente = new System.Windows.Forms.Button();
            this.txtSet = new System.Windows.Forms.TextBox();
            this.btnSetRecipiente = new System.Windows.Forms.Button();
            this.txtValoreRecipiente = new System.Windows.Forms.TextBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.btnMetti = new System.Windows.Forms.Button();
            this.txtMetti = new System.Windows.Forms.TextBox();
            this.btnTogli = new System.Windows.Forms.Button();
            this.txtTogli = new System.Windows.Forms.TextBox();
            this.txtValoreBicchiere = new System.Windows.Forms.TextBox();
            this.btnCreaBicchiere = new System.Windows.Forms.Button();
            this.btnSetBicchiere = new System.Windows.Forms.Button();
            this.txtSetBicchiere = new System.Windows.Forms.TextBox();
            this.btnBicchiere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecipiente
            // 
            this.btnRecipiente.Location = new System.Drawing.Point(264, 12);
            this.btnRecipiente.Name = "btnRecipiente";
            this.btnRecipiente.Size = new System.Drawing.Size(135, 61);
            this.btnRecipiente.TabIndex = 0;
            this.btnRecipiente.Text = "Visualizza informazioni recipiente";
            this.btnRecipiente.UseVisualStyleBackColor = true;
            this.btnRecipiente.Click += new System.EventHandler(this.btnRecipiente_Click);
            // 
            // txtSet
            // 
            this.txtSet.Location = new System.Drawing.Point(126, 62);
            this.txtSet.Name = "txtSet";
            this.txtSet.Size = new System.Drawing.Size(100, 20);
            this.txtSet.TabIndex = 1;
            // 
            // btnSetRecipiente
            // 
            this.btnSetRecipiente.Location = new System.Drawing.Point(12, 62);
            this.btnSetRecipiente.Name = "btnSetRecipiente";
            this.btnSetRecipiente.Size = new System.Drawing.Size(108, 20);
            this.btnSetRecipiente.TabIndex = 3;
            this.btnSetRecipiente.Text = "Set recipiente";
            this.btnSetRecipiente.UseVisualStyleBackColor = true;
            this.btnSetRecipiente.Click += new System.EventHandler(this.btnSetRecipiente_Click);
            // 
            // txtValoreRecipiente
            // 
            this.txtValoreRecipiente.Location = new System.Drawing.Point(126, 12);
            this.txtValoreRecipiente.Name = "txtValoreRecipiente";
            this.txtValoreRecipiente.Size = new System.Drawing.Size(100, 20);
            this.txtValoreRecipiente.TabIndex = 5;
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(12, 12);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(108, 20);
            this.btnCrea.TabIndex = 4;
            this.btnCrea.Text = "Crea recipiente";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // btnMetti
            // 
            this.btnMetti.Location = new System.Drawing.Point(12, 117);
            this.btnMetti.Name = "btnMetti";
            this.btnMetti.Size = new System.Drawing.Size(108, 20);
            this.btnMetti.TabIndex = 7;
            this.btnMetti.Text = "Metti nel recipiente";
            this.btnMetti.UseVisualStyleBackColor = true;
            this.btnMetti.Click += new System.EventHandler(this.btnMetti_Click);
            // 
            // txtMetti
            // 
            this.txtMetti.Location = new System.Drawing.Point(126, 117);
            this.txtMetti.Name = "txtMetti";
            this.txtMetti.Size = new System.Drawing.Size(100, 20);
            this.txtMetti.TabIndex = 6;
            // 
            // btnTogli
            // 
            this.btnTogli.Location = new System.Drawing.Point(12, 172);
            this.btnTogli.Name = "btnTogli";
            this.btnTogli.Size = new System.Drawing.Size(108, 20);
            this.btnTogli.TabIndex = 9;
            this.btnTogli.Text = "Togli dal recipiente";
            this.btnTogli.UseVisualStyleBackColor = true;
            this.btnTogli.Click += new System.EventHandler(this.btnTogli_Click);
            // 
            // txtTogli
            // 
            this.txtTogli.Location = new System.Drawing.Point(126, 172);
            this.txtTogli.Name = "txtTogli";
            this.txtTogli.Size = new System.Drawing.Size(100, 20);
            this.txtTogli.TabIndex = 8;
            // 
            // txtValoreBicchiere
            // 
            this.txtValoreBicchiere.Location = new System.Drawing.Point(583, 16);
            this.txtValoreBicchiere.Name = "txtValoreBicchiere";
            this.txtValoreBicchiere.Size = new System.Drawing.Size(100, 20);
            this.txtValoreBicchiere.TabIndex = 14;
            // 
            // btnCreaBicchiere
            // 
            this.btnCreaBicchiere.Location = new System.Drawing.Point(458, 14);
            this.btnCreaBicchiere.Name = "btnCreaBicchiere";
            this.btnCreaBicchiere.Size = new System.Drawing.Size(119, 22);
            this.btnCreaBicchiere.TabIndex = 13;
            this.btnCreaBicchiere.Text = "Crea bicchiere";
            this.btnCreaBicchiere.UseVisualStyleBackColor = true;
            this.btnCreaBicchiere.Click += new System.EventHandler(this.btnCreaBicchiere_Click);
            // 
            // btnSetBicchiere
            // 
            this.btnSetBicchiere.Location = new System.Drawing.Point(458, 86);
            this.btnSetBicchiere.Name = "btnSetBicchiere";
            this.btnSetBicchiere.Size = new System.Drawing.Size(119, 20);
            this.btnSetBicchiere.TabIndex = 12;
            this.btnSetBicchiere.Text = "Set bicchiere";
            this.btnSetBicchiere.UseVisualStyleBackColor = true;
            this.btnSetBicchiere.Click += new System.EventHandler(this.btnSetBicchiere_Click);
            // 
            // txtSetBicchiere
            // 
            this.txtSetBicchiere.Location = new System.Drawing.Point(583, 86);
            this.txtSetBicchiere.Name = "txtSetBicchiere";
            this.txtSetBicchiere.Size = new System.Drawing.Size(100, 20);
            this.txtSetBicchiere.TabIndex = 11;
            // 
            // btnBicchiere
            // 
            this.btnBicchiere.Location = new System.Drawing.Point(458, 135);
            this.btnBicchiere.Name = "btnBicchiere";
            this.btnBicchiere.Size = new System.Drawing.Size(135, 57);
            this.btnBicchiere.TabIndex = 10;
            this.btnBicchiere.Text = "Visualizza informazioni bicchiere";
            this.btnBicchiere.UseVisualStyleBackColor = true;
            this.btnBicchiere.Click += new System.EventHandler(this.btnBicchiere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 338);
            this.Controls.Add(this.txtValoreBicchiere);
            this.Controls.Add(this.btnCreaBicchiere);
            this.Controls.Add(this.btnSetBicchiere);
            this.Controls.Add(this.txtSetBicchiere);
            this.Controls.Add(this.btnBicchiere);
            this.Controls.Add(this.btnTogli);
            this.Controls.Add(this.txtTogli);
            this.Controls.Add(this.btnMetti);
            this.Controls.Add(this.txtMetti);
            this.Controls.Add(this.txtValoreRecipiente);
            this.Controls.Add(this.btnCrea);
            this.Controls.Add(this.btnSetRecipiente);
            this.Controls.Add(this.txtSet);
            this.Controls.Add(this.btnRecipiente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecipiente;
        private System.Windows.Forms.TextBox txtSet;
        private System.Windows.Forms.Button btnSetRecipiente;
        private System.Windows.Forms.TextBox txtValoreRecipiente;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Button btnMetti;
        private System.Windows.Forms.TextBox txtMetti;
        private System.Windows.Forms.Button btnTogli;
        private System.Windows.Forms.TextBox txtTogli;
        private System.Windows.Forms.TextBox txtValoreBicchiere;
        private System.Windows.Forms.Button btnCreaBicchiere;
        private System.Windows.Forms.Button btnSetBicchiere;
        private System.Windows.Forms.TextBox txtSetBicchiere;
        private System.Windows.Forms.Button btnBicchiere;
    }
}

