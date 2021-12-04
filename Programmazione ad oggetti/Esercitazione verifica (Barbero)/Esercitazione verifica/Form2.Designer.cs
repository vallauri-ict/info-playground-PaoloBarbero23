namespace Esercitazione_verifica
{
    partial class Form2
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
            this.lblCaratteristiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaratteristiche
            // 
            this.lblCaratteristiche.AutoSize = true;
            this.lblCaratteristiche.Location = new System.Drawing.Point(12, 9);
            this.lblCaratteristiche.Name = "lblCaratteristiche";
            this.lblCaratteristiche.Size = new System.Drawing.Size(35, 13);
            this.lblCaratteristiche.TabIndex = 0;
            this.lblCaratteristiche.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 220);
            this.Controls.Add(this.lblCaratteristiche);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaratteristiche;
    }
}