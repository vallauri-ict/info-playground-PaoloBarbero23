namespace OOP_01
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
            this.btnCrea = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltezza = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltezza = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Location = new System.Drawing.Point(12, 12);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Size = new System.Drawing.Size(75, 23);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea";
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.btnCrea_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(62, 51);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(39, 20);
            this.txtBase.TabIndex = 1;
            // 
            // txtAltezza
            // 
            this.txtAltezza.Location = new System.Drawing.Point(62, 77);
            this.txtAltezza.Name = "txtAltezza";
            this.txtAltezza.Size = new System.Drawing.Size(39, 20);
            this.txtAltezza.TabIndex = 2;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 54);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Base:";
            // 
            // lblAltezza
            // 
            this.lblAltezza.AutoSize = true;
            this.lblAltezza.Location = new System.Drawing.Point(12, 80);
            this.lblAltezza.Name = "lblAltezza";
            this.lblAltezza.Size = new System.Drawing.Size(44, 13);
            this.lblAltezza.TabIndex = 4;
            this.lblAltezza.Text = "Altezza:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 183);
            this.Controls.Add(this.lblAltezza);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtAltezza);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnCrea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltezza;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltezza;
    }
}

