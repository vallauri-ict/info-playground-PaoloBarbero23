namespace Regex01
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
            this.lblStringa = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.BTNsPLIT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSplit2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStringa
            // 
            this.lblStringa.AutoSize = true;
            this.lblStringa.Location = new System.Drawing.Point(12, 9);
            this.lblStringa.Name = "lblStringa";
            this.lblStringa.Size = new System.Drawing.Size(146, 13);
            this.lblStringa.TabIndex = 0;
            this.lblStringa.Text = "Inserisci stringa da controllare";
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(164, 9);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(100, 20);
            this.txtStr.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(15, 34);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(249, 41);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Verifica";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Uso di match nella stringa: \"One care red car blue car\"";
            // 
            // btnMatch
            // 
            this.btnMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatch.Location = new System.Drawing.Point(313, 34);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(262, 41);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "MATCH";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // BTNsPLIT
            // 
            this.BTNsPLIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsPLIT.Location = new System.Drawing.Point(15, 118);
            this.BTNsPLIT.Name = "BTNsPLIT";
            this.BTNsPLIT.Size = new System.Drawing.Size(332, 41);
            this.BTNsPLIT.TabIndex = 6;
            this.BTNsPLIT.Text = "MATCH";
            this.BTNsPLIT.UseVisualStyleBackColor = true;
            this.BTNsPLIT.Click += new System.EventHandler(this.BTNsPLIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uso di match nella stringa: \"123ABCDE456FGHIJKL789MNOPQ012\"";
            // 
            // btnSplit2
            // 
            this.btnSplit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit2.Location = new System.Drawing.Point(356, 118);
            this.btnSplit2.Name = "btnSplit2";
            this.btnSplit2.Size = new System.Drawing.Size(332, 41);
            this.btnSplit2.TabIndex = 8;
            this.btnSplit2.Text = "MATCH";
            this.btnSplit2.UseVisualStyleBackColor = true;
            this.btnSplit2.Click += new System.EventHandler(this.btnSplit2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uso di match nella stringa: \"\"This is text with far too much \" +\r\n\"whitespace.\";\"" +
    "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSplit2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNsPLIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.lblStringa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStringa;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button BTNsPLIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSplit2;
        private System.Windows.Forms.Label label3;
    }
}

