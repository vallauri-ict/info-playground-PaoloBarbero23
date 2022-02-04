namespace Data_e_orario
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
            this.gpbdata = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbOra = new System.Windows.Forms.GroupBox();
            this.btnCrea = new System.Windows.Forms.Button();
            this.nupGiorno = new System.Windows.Forms.NumericUpDown();
            this.nupMese = new System.Windows.Forms.NumericUpDown();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnTogli = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnno2 = new System.Windows.Forms.TextBox();
            this.nupMese2 = new System.Windows.Forms.NumericUpDown();
            this.nupGiorno2 = new System.Windows.Forms.NumericUpDown();
            this.btnLeggi = new System.Windows.Forms.Button();
            this.btnScrivi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnno3 = new System.Windows.Forms.TextBox();
            this.nupMese3 = new System.Windows.Forms.NumericUpDown();
            this.nupGiorno3 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreaOra = new System.Windows.Forms.Button();
            this.btnVisualizzaOra = new System.Windows.Forms.Button();
            this.btnScriviOra = new System.Windows.Forms.Button();
            this.btnLeggiOra = new System.Windows.Forms.Button();
            this.nupOre = new System.Windows.Forms.NumericUpDown();
            this.nupMinuti = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nupSecondi = new System.Windows.Forms.NumericUpDown();
            this.txtOra = new System.Windows.Forms.TextBox();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.txtSecondi = new System.Windows.Forms.TextBox();
            this.gpbdata.SuspendLayout();
            this.gpbOra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSecondi)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbdata
            // 
            this.gpbdata.Controls.Add(this.btnScrivi);
            this.gpbdata.Controls.Add(this.btnLeggi);
            this.gpbdata.Controls.Add(this.label4);
            this.gpbdata.Controls.Add(this.label5);
            this.gpbdata.Controls.Add(this.label6);
            this.gpbdata.Controls.Add(this.txtAnno2);
            this.gpbdata.Controls.Add(this.nupMese2);
            this.gpbdata.Controls.Add(this.nupGiorno2);
            this.gpbdata.Controls.Add(this.btnVisualizza);
            this.gpbdata.Controls.Add(this.btnTogli);
            this.gpbdata.Controls.Add(this.btnAggiungi);
            this.gpbdata.Controls.Add(this.label3);
            this.gpbdata.Controls.Add(this.label2);
            this.gpbdata.Controls.Add(this.label1);
            this.gpbdata.Controls.Add(this.txtAnno);
            this.gpbdata.Controls.Add(this.nupMese);
            this.gpbdata.Controls.Add(this.nupGiorno);
            this.gpbdata.Controls.Add(this.btnCrea);
            this.gpbdata.Location = new System.Drawing.Point(12, 12);
            this.gpbdata.Name = "gpbdata";
            this.gpbdata.Size = new System.Drawing.Size(416, 451);
            this.gpbdata.TabIndex = 0;
            this.gpbdata.TabStop = false;
            this.gpbdata.Text = "Data";
            // 
            // gpbOra
            // 
            this.gpbOra.Controls.Add(this.txtSecondi);
            this.gpbOra.Controls.Add(this.txtMinuti);
            this.gpbOra.Controls.Add(this.txtOra);
            this.gpbOra.Controls.Add(this.btnScriviOra);
            this.gpbOra.Controls.Add(this.nupSecondi);
            this.gpbOra.Controls.Add(this.btnLeggiOra);
            this.gpbOra.Controls.Add(this.label13);
            this.gpbOra.Controls.Add(this.label14);
            this.gpbOra.Controls.Add(this.label15);
            this.gpbOra.Controls.Add(this.nupMinuti);
            this.gpbOra.Controls.Add(this.nupOre);
            this.gpbOra.Controls.Add(this.btnVisualizzaOra);
            this.gpbOra.Controls.Add(this.btnCreaOra);
            this.gpbOra.Controls.Add(this.label10);
            this.gpbOra.Controls.Add(this.label11);
            this.gpbOra.Controls.Add(this.label12);
            this.gpbOra.Controls.Add(this.label7);
            this.gpbOra.Controls.Add(this.label8);
            this.gpbOra.Controls.Add(this.nupGiorno3);
            this.gpbOra.Controls.Add(this.label9);
            this.gpbOra.Controls.Add(this.nupMese3);
            this.gpbOra.Controls.Add(this.txtAnno3);
            this.gpbOra.Location = new System.Drawing.Point(443, 12);
            this.gpbOra.Name = "gpbOra";
            this.gpbOra.Size = new System.Drawing.Size(394, 451);
            this.gpbOra.TabIndex = 1;
            this.gpbOra.TabStop = false;
            this.gpbOra.Text = "Ora";
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(9, 105);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(380, 50);
            this.btnCrea.TabIndex = 2;
            this.btnCrea.Text = "Crea data";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // nupGiorno
            // 
            this.nupGiorno.Location = new System.Drawing.Point(9, 59);
            this.nupGiorno.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupGiorno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupGiorno.Name = "nupGiorno";
            this.nupGiorno.Size = new System.Drawing.Size(120, 22);
            this.nupGiorno.TabIndex = 3;
            this.nupGiorno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupMese
            // 
            this.nupMese.Location = new System.Drawing.Point(135, 59);
            this.nupMese.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupMese.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMese.Name = "nupMese";
            this.nupMese.Size = new System.Drawing.Size(120, 22);
            this.nupMese.TabIndex = 4;
            this.nupMese.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(261, 59);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(128, 22);
            this.txtAnno.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giorno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mese";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Anno";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(9, 175);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(158, 47);
            this.btnAggiungi.TabIndex = 9;
            this.btnAggiungi.Text = "Aggiungi un giorno";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnTogli
            // 
            this.btnTogli.Location = new System.Drawing.Point(231, 175);
            this.btnTogli.Name = "btnTogli";
            this.btnTogli.Size = new System.Drawing.Size(158, 47);
            this.btnTogli.TabIndex = 10;
            this.btnTogli.Text = "Togli un giorno";
            this.btnTogli.UseVisualStyleBackColor = true;
            this.btnTogli.Click += new System.EventHandler(this.btnTogli_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(9, 237);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(158, 33);
            this.btnVisualizza.TabIndex = 11;
            this.btnVisualizza.Text = "Visualizza Data";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Anno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mese";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Giorno";
            // 
            // txtAnno2
            // 
            this.txtAnno2.Location = new System.Drawing.Point(231, 368);
            this.txtAnno2.Name = "txtAnno2";
            this.txtAnno2.Size = new System.Drawing.Size(119, 22);
            this.txtAnno2.TabIndex = 14;
            // 
            // nupMese2
            // 
            this.nupMese2.Location = new System.Drawing.Point(231, 340);
            this.nupMese2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupMese2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMese2.Name = "nupMese2";
            this.nupMese2.Size = new System.Drawing.Size(119, 22);
            this.nupMese2.TabIndex = 13;
            this.nupMese2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupGiorno2
            // 
            this.nupGiorno2.Location = new System.Drawing.Point(230, 311);
            this.nupGiorno2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupGiorno2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupGiorno2.Name = "nupGiorno2";
            this.nupGiorno2.Size = new System.Drawing.Size(120, 22);
            this.nupGiorno2.TabIndex = 12;
            this.nupGiorno2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLeggi
            // 
            this.btnLeggi.Location = new System.Drawing.Point(9, 309);
            this.btnLeggi.Name = "btnLeggi";
            this.btnLeggi.Size = new System.Drawing.Size(149, 35);
            this.btnLeggi.TabIndex = 18;
            this.btnLeggi.Text = "Leggi data";
            this.btnLeggi.UseVisualStyleBackColor = true;
            this.btnLeggi.Click += new System.EventHandler(this.btnLeggi_Click);
            // 
            // btnScrivi
            // 
            this.btnScrivi.Location = new System.Drawing.Point(9, 355);
            this.btnScrivi.Name = "btnScrivi";
            this.btnScrivi.Size = new System.Drawing.Size(149, 35);
            this.btnScrivi.TabIndex = 19;
            this.btnScrivi.Text = "Scrivi data";
            this.btnScrivi.UseVisualStyleBackColor = true;
            this.btnScrivi.Click += new System.EventHandler(this.btnScrivi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Anno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mese";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Giorno";
            // 
            // txtAnno3
            // 
            this.txtAnno3.Location = new System.Drawing.Point(263, 59);
            this.txtAnno3.Name = "txtAnno3";
            this.txtAnno3.Size = new System.Drawing.Size(120, 22);
            this.txtAnno3.TabIndex = 22;
            // 
            // nupMese3
            // 
            this.nupMese3.Location = new System.Drawing.Point(137, 59);
            this.nupMese3.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupMese3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMese3.Name = "nupMese3";
            this.nupMese3.Size = new System.Drawing.Size(120, 22);
            this.nupMese3.TabIndex = 21;
            this.nupMese3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupGiorno3
            // 
            this.nupGiorno3.Location = new System.Drawing.Point(11, 59);
            this.nupGiorno3.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nupGiorno3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupGiorno3.Name = "nupGiorno3";
            this.nupGiorno3.Size = new System.Drawing.Size(120, 22);
            this.nupGiorno3.TabIndex = 20;
            this.nupGiorno3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Secondi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Minuti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Ore";
            // 
            // btnCreaOra
            // 
            this.btnCreaOra.Location = new System.Drawing.Point(11, 158);
            this.btnCreaOra.Name = "btnCreaOra";
            this.btnCreaOra.Size = new System.Drawing.Size(372, 50);
            this.btnCreaOra.TabIndex = 20;
            this.btnCreaOra.Text = "Crea data con ora";
            this.btnCreaOra.UseVisualStyleBackColor = true;
            this.btnCreaOra.Click += new System.EventHandler(this.btnCreaOra_Click);
            // 
            // btnVisualizzaOra
            // 
            this.btnVisualizzaOra.Location = new System.Drawing.Point(11, 226);
            this.btnVisualizzaOra.Name = "btnVisualizzaOra";
            this.btnVisualizzaOra.Size = new System.Drawing.Size(158, 33);
            this.btnVisualizzaOra.TabIndex = 20;
            this.btnVisualizzaOra.Text = "Visualizza Data e ora";
            this.btnVisualizzaOra.UseVisualStyleBackColor = true;
            this.btnVisualizzaOra.Click += new System.EventHandler(this.btnVisualizzaOra_Click);
            // 
            // btnScriviOra
            // 
            this.btnScriviOra.Location = new System.Drawing.Point(11, 355);
            this.btnScriviOra.Name = "btnScriviOra";
            this.btnScriviOra.Size = new System.Drawing.Size(149, 35);
            this.btnScriviOra.TabIndex = 21;
            this.btnScriviOra.Text = "Scrivi data";
            this.btnScriviOra.UseVisualStyleBackColor = true;
            // 
            // btnLeggiOra
            // 
            this.btnLeggiOra.Location = new System.Drawing.Point(11, 309);
            this.btnLeggiOra.Name = "btnLeggiOra";
            this.btnLeggiOra.Size = new System.Drawing.Size(149, 35);
            this.btnLeggiOra.TabIndex = 20;
            this.btnLeggiOra.Text = "Leggi data";
            this.btnLeggiOra.UseVisualStyleBackColor = true;
            this.btnLeggiOra.Click += new System.EventHandler(this.btnLeggiOra_Click);
            // 
            // nupOre
            // 
            this.nupOre.Location = new System.Drawing.Point(197, 309);
            this.nupOre.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupOre.Name = "nupOre";
            this.nupOre.Size = new System.Drawing.Size(120, 22);
            this.nupOre.TabIndex = 39;
            this.nupOre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupMinuti
            // 
            this.nupMinuti.Location = new System.Drawing.Point(197, 337);
            this.nupMinuti.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinuti.Name = "nupMinuti";
            this.nupMinuti.Size = new System.Drawing.Size(120, 22);
            this.nupMinuti.TabIndex = 40;
            this.nupMinuti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 41;
            this.label15.Text = "Ore";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "Minuti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(324, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Secondi";
            // 
            // nupSecondi
            // 
            this.nupSecondi.Location = new System.Drawing.Point(197, 366);
            this.nupSecondi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupSecondi.Name = "nupSecondi";
            this.nupSecondi.Size = new System.Drawing.Size(120, 22);
            this.nupSecondi.TabIndex = 44;
            this.nupSecondi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtOra
            // 
            this.txtOra.Location = new System.Drawing.Point(11, 119);
            this.txtOra.Name = "txtOra";
            this.txtOra.Size = new System.Drawing.Size(120, 22);
            this.txtOra.TabIndex = 45;
            // 
            // txtMinuti
            // 
            this.txtMinuti.Location = new System.Drawing.Point(137, 119);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(120, 22);
            this.txtMinuti.TabIndex = 46;
            // 
            // txtSecondi
            // 
            this.txtSecondi.Location = new System.Drawing.Point(263, 119);
            this.txtSecondi.Name = "txtSecondi";
            this.txtSecondi.Size = new System.Drawing.Size(120, 22);
            this.txtSecondi.TabIndex = 47;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 529);
            this.Controls.Add(this.gpbOra);
            this.Controls.Add(this.gpbdata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbdata.ResumeLayout(false);
            this.gpbdata.PerformLayout();
            this.gpbOra.ResumeLayout(false);
            this.gpbOra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMese3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupGiorno3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSecondi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbdata;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gpbOra;
        private System.Windows.Forms.NumericUpDown nupMese;
        private System.Windows.Forms.NumericUpDown nupGiorno;
        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTogli;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnScrivi;
        private System.Windows.Forms.Button btnLeggi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnno2;
        private System.Windows.Forms.NumericUpDown nupMese2;
        private System.Windows.Forms.NumericUpDown nupGiorno2;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nupGiorno3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupMese3;
        private System.Windows.Forms.TextBox txtAnno3;
        private System.Windows.Forms.Button btnCreaOra;
        private System.Windows.Forms.Button btnScriviOra;
        private System.Windows.Forms.NumericUpDown nupSecondi;
        private System.Windows.Forms.Button btnLeggiOra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nupMinuti;
        private System.Windows.Forms.NumericUpDown nupOre;
        private System.Windows.Forms.Button btnVisualizzaOra;
        private System.Windows.Forms.TextBox txtSecondi;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.TextBox txtOra;
    }
}

