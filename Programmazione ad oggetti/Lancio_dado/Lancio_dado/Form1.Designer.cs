﻿namespace Lancio_dado
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
            this.btnDado = new System.Windows.Forms.Button();
            this.btnMoneta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDadoAstratto = new System.Windows.Forms.Button();
            this.btnMonetaAstratta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDado
            // 
            this.btnDado.Location = new System.Drawing.Point(6, 19);
            this.btnDado.Name = "btnDado";
            this.btnDado.Size = new System.Drawing.Size(75, 23);
            this.btnDado.TabIndex = 0;
            this.btnDado.Text = "Lancio dado";
            this.btnDado.UseVisualStyleBackColor = true;
            this.btnDado.Click += new System.EventHandler(this.btnDado_Click);
            // 
            // btnMoneta
            // 
            this.btnMoneta.Location = new System.Drawing.Point(6, 48);
            this.btnMoneta.Name = "btnMoneta";
            this.btnMoneta.Size = new System.Drawing.Size(98, 23);
            this.btnMoneta.TabIndex = 1;
            this.btnMoneta.Text = "Lancio moneta";
            this.btnMoneta.UseVisualStyleBackColor = true;
            this.btnMoneta.Click += new System.EventHandler(this.btnMoneta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDado);
            this.groupBox1.Controls.Add(this.btnMoneta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senza classe astratta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDadoAstratto);
            this.groupBox2.Controls.Add(this.btnMonetaAstratta);
            this.groupBox2.Location = new System.Drawing.Point(18, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Con classe astratta";
            // 
            // btnDadoAstratto
            // 
            this.btnDadoAstratto.Location = new System.Drawing.Point(6, 19);
            this.btnDadoAstratto.Name = "btnDadoAstratto";
            this.btnDadoAstratto.Size = new System.Drawing.Size(75, 23);
            this.btnDadoAstratto.TabIndex = 0;
            this.btnDadoAstratto.Text = "Lancio dado";
            this.btnDadoAstratto.UseVisualStyleBackColor = true;
            this.btnDadoAstratto.Click += new System.EventHandler(this.btnDadoAstratto_Click);
            // 
            // btnMonetaAstratta
            // 
            this.btnMonetaAstratta.Location = new System.Drawing.Point(6, 48);
            this.btnMonetaAstratta.Name = "btnMonetaAstratta";
            this.btnMonetaAstratta.Size = new System.Drawing.Size(98, 23);
            this.btnMonetaAstratta.TabIndex = 1;
            this.btnMonetaAstratta.Text = "Lancio moneta";
            this.btnMonetaAstratta.UseVisualStyleBackColor = true;
            this.btnMonetaAstratta.Click += new System.EventHandler(this.btnMonetaAstratta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDado;
        private System.Windows.Forms.Button btnMoneta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDadoAstratto;
        private System.Windows.Forms.Button btnMonetaAstratta;
    }
}

