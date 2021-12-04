namespace Esercitazione_verifica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbInterni = new System.Windows.Forms.GroupBox();
            this.chkPelle = new System.Windows.Forms.CheckBox();
            this.chkStoffa = new System.Windows.Forms.CheckBox();
            this.cmbMacchine = new System.Windows.Forms.ComboBox();
            this.gpbInterni.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbInterni
            // 
            this.gpbInterni.Controls.Add(this.chkPelle);
            this.gpbInterni.Controls.Add(this.chkStoffa);
            this.gpbInterni.Location = new System.Drawing.Point(12, 12);
            this.gpbInterni.Name = "gpbInterni";
            this.gpbInterni.Size = new System.Drawing.Size(200, 100);
            this.gpbInterni.TabIndex = 0;
            this.gpbInterni.TabStop = false;
            // 
            // chkPelle
            // 
            this.chkPelle.AutoSize = true;
            this.chkPelle.Location = new System.Drawing.Point(6, 42);
            this.chkPelle.Name = "chkPelle";
            this.chkPelle.Size = new System.Drawing.Size(91, 17);
            this.chkPelle.TabIndex = 1;
            this.chkPelle.Text = "Interni in pelle";
            this.chkPelle.UseVisualStyleBackColor = true;
            this.chkPelle.CheckedChanged += new System.EventHandler(this.chkPelle_CheckedChanged);
            // 
            // chkStoffa
            // 
            this.chkStoffa.AutoSize = true;
            this.chkStoffa.Location = new System.Drawing.Point(6, 19);
            this.chkStoffa.Name = "chkStoffa";
            this.chkStoffa.Size = new System.Drawing.Size(95, 17);
            this.chkStoffa.TabIndex = 1;
            this.chkStoffa.Text = "Interni in stoffa";
            this.chkStoffa.UseVisualStyleBackColor = true;
            this.chkStoffa.CheckedChanged += new System.EventHandler(this.chkStoffa_CheckedChanged);
            // 
            // cmbMacchine
            // 
            this.cmbMacchine.FormattingEnabled = true;
            this.cmbMacchine.Items.AddRange(new object[] {
            "BMW",
            "FIAT",
            "SEAT",
            "OPEL"});
            this.cmbMacchine.Location = new System.Drawing.Point(12, 118);
            this.cmbMacchine.Name = "cmbMacchine";
            this.cmbMacchine.Size = new System.Drawing.Size(121, 21);
            this.cmbMacchine.TabIndex = 2;
            this.cmbMacchine.SelectedIndexChanged += new System.EventHandler(this.cmbMacchine_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 194);
            this.Controls.Add(this.cmbMacchine);
            this.Controls.Add(this.gpbInterni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbInterni.ResumeLayout(false);
            this.gpbInterni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInterni;
        private System.Windows.Forms.CheckBox chkPelle;
        private System.Windows.Forms.CheckBox chkStoffa;
        private System.Windows.Forms.ComboBox cmbMacchine;
    }
}