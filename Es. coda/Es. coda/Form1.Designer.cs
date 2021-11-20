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
            this.label4 = new System.Windows.Forms.Label();
            this.nupTemp = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemp)).BeginInit();
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
            this.cmbCodice.Location = new System.Drawing.Point(17, 106);
            this.cmbCodice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCodice.Name = "cmbCodice";
            this.cmbCodice.Size = new System.Drawing.Size(160, 24);
            this.cmbCodice.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 43);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 22);
            this.txtNome.TabIndex = 1;
            // 
            // nupEta
            // 
            this.nupEta.Location = new System.Drawing.Point(17, 74);
            this.nupEta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupEta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupEta.Name = "nupEta";
            this.nupEta.Size = new System.Drawing.Size(160, 22);
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
            this.label1.Location = new System.Drawing.Point(185, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Età";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codice";
            // 
            // btnRegistra
            // 
            this.btnRegistra.Location = new System.Drawing.Point(17, 168);
            this.btnRegistra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(221, 33);
            this.btnRegistra.TabIndex = 6;
            this.btnRegistra.Text = "Registra paziente";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnVisualizzaPaziente
            // 
            this.btnVisualizzaPaziente.Location = new System.Drawing.Point(17, 212);
            this.btnVisualizzaPaziente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVisualizzaPaziente.Name = "btnVisualizzaPaziente";
            this.btnVisualizzaPaziente.Size = new System.Drawing.Size(221, 28);
            this.btnVisualizzaPaziente.TabIndex = 7;
            this.btnVisualizzaPaziente.Text = "Visualizza prossimo paziente";
            this.btnVisualizzaPaziente.UseVisualStyleBackColor = true;
            this.btnVisualizzaPaziente.Click += new System.EventHandler(this.btnVisualizzaPaziente_Click);
            // 
            // lblDatiPaziente
            // 
            this.lblDatiPaziente.AutoSize = true;
            this.lblDatiPaziente.Location = new System.Drawing.Point(256, 218);
            this.lblDatiPaziente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatiPaziente.Name = "lblDatiPaziente";
            this.lblDatiPaziente.Size = new System.Drawing.Size(0, 17);
            this.lblDatiPaziente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Temperatura";
            // 
            // nupTemp
            // 
            this.nupTemp.DecimalPlaces = 1;
            this.nupTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupTemp.Location = new System.Drawing.Point(19, 138);
            this.nupTemp.Margin = new System.Windows.Forms.Padding(4);
            this.nupTemp.Maximum = new decimal(new int[] {
            420,
            0,
            0,
            65536});
            this.nupTemp.Minimum = new decimal(new int[] {
            340,
            0,
            0,
            65536});
            this.nupTemp.Name = "nupTemp";
            this.nupTemp.Size = new System.Drawing.Size(158, 22);
            this.nupTemp.TabIndex = 9;
            this.nupTemp.Value = new decimal(new int[] {
            340,
            0,
            0,
            65536});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Visualizza temperatura massima e minima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(256, 248);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(37, 17);
            this.lblMax.TabIndex = 12;
            this.lblMax.Text = "MAX";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(256, 279);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(40, 17);
            this.lblMin.TabIndex = 13;
            this.lblMin.Text = "MIN: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nupTemp);
            this.Controls.Add(this.lblDatiPaziente);
            this.Controls.Add(this.btnVisualizzaPaziente);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupEta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbCodice);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemp)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
    }
}

