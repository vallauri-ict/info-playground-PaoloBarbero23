namespace WindowsForms02
{
    partial class ModaleEsci
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
            this.lblEsci = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEsci
            // 
            this.lblEsci.AutoSize = true;
            this.lblEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsci.Location = new System.Drawing.Point(31, 44);
            this.lblEsci.Name = "lblEsci";
            this.lblEsci.Size = new System.Drawing.Size(187, 16);
            this.lblEsci.TabIndex = 0;
            this.lblEsci.Text = "Sei sicuro di voler uscire?";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 124);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnEsci
            // 
            this.btnEsci.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEsci.Location = new System.Drawing.Point(159, 124);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(75, 23);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Annulla";
            this.btnEsci.UseVisualStyleBackColor = true;
            // 
            // ModaleEsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 159);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblEsci);
            this.Name = "ModaleEsci";
            this.Text = "ModaleEsci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEsci;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEsci;
    }
}