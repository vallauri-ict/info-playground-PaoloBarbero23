namespace Windowsforms01
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeggitxt = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.btnAprifiglia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sono la form2";
            // 
            // btnLeggitxt
            // 
            this.btnLeggitxt.Location = new System.Drawing.Point(9, 25);
            this.btnLeggitxt.Name = "btnLeggitxt";
            this.btnLeggitxt.Size = new System.Drawing.Size(100, 46);
            this.btnLeggitxt.TabIndex = 1;
            this.btnLeggitxt.Text = "Leggi valore del txt";
            this.btnLeggitxt.UseVisualStyleBackColor = true;
            this.btnLeggitxt.Click += new System.EventHandler(this.btnLeggitxt_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(9, 77);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(100, 20);
            this.txtF2.TabIndex = 2;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(140, 74);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(94, 23);
            this.btnInvia.TabIndex = 4;
            this.btnInvia.Text = "Invia a form1";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // btnAprifiglia
            // 
            this.btnAprifiglia.Location = new System.Drawing.Point(9, 103);
            this.btnAprifiglia.Name = "btnAprifiglia";
            this.btnAprifiglia.Size = new System.Drawing.Size(164, 30);
            this.btnAprifiglia.TabIndex = 5;
            this.btnAprifiglia.Text = "Apri figlia";
            this.btnAprifiglia.UseVisualStyleBackColor = true;
            this.btnAprifiglia.Click += new System.EventHandler(this.btnAprifiglia_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 171);
            this.Controls.Add(this.btnAprifiglia);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnLeggitxt);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeggitxt;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button btnAprifiglia;
    }
}