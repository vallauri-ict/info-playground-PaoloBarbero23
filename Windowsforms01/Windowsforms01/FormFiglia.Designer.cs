namespace Windowsforms01
{
    partial class FormFiglia
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
            this.btnDichi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDichi
            // 
            this.btnDichi.Location = new System.Drawing.Point(12, 12);
            this.btnDichi.Name = "btnDichi";
            this.btnDichi.Size = new System.Drawing.Size(109, 23);
            this.btnDichi.TabIndex = 0;
            this.btnDichi.Text = "Di chi sono figlia?";
            this.btnDichi.UseVisualStyleBackColor = true;
            this.btnDichi.Click += new System.EventHandler(this.btnDichi_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.btnDichi);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDichi;
    }
}