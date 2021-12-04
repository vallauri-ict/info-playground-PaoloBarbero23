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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

