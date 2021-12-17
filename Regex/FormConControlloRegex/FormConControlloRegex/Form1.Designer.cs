namespace FormConControlloRegex
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
            this.components = new System.ComponentModel.Container();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtCAP = new System.Windows.Forms.TextBox();
            this.lblCAP = new System.Windows.Forms.Label();
            this.txtCittà = new System.Windows.Forms.TextBox();
            this.lblCittà = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.lblCF = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnControllo = new System.Windows.Forms.Button();
            this.errorProviderNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCognome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCAP = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCitta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCF = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCognome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCitta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 12);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(16, 44);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(68, 17);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 9);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(132, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(93, 41);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(132, 22);
            this.txtCognome.TabIndex = 3;
            this.txtCognome.TextChanged += new System.EventHandler(this.txtCognome_TextChanged);
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(93, 73);
            this.txtEta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(132, 22);
            this.txtEta.TabIndex = 5;
            this.txtEta.TextChanged += new System.EventHandler(this.txtEta_TextChanged);
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(16, 76);
            this.lblEta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(29, 17);
            this.lblEta.TabIndex = 4;
            this.lblEta.Text = "Età";
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(93, 105);
            this.txtCAP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(132, 22);
            this.txtCAP.TabIndex = 7;
            this.txtCAP.TextChanged += new System.EventHandler(this.txtCAP_TextChanged);
            // 
            // lblCAP
            // 
            this.lblCAP.AutoSize = true;
            this.lblCAP.Location = new System.Drawing.Point(16, 108);
            this.lblCAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAP.Name = "lblCAP";
            this.lblCAP.Size = new System.Drawing.Size(35, 17);
            this.lblCAP.TabIndex = 6;
            this.lblCAP.Text = "CAP";
            // 
            // txtCittà
            // 
            this.txtCittà.Location = new System.Drawing.Point(93, 137);
            this.txtCittà.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCittà.Name = "txtCittà";
            this.txtCittà.Size = new System.Drawing.Size(132, 22);
            this.txtCittà.TabIndex = 9;
            this.txtCittà.TextChanged += new System.EventHandler(this.txtCittà_TextChanged);
            // 
            // lblCittà
            // 
            this.lblCittà.AutoSize = true;
            this.lblCittà.Location = new System.Drawing.Point(16, 140);
            this.lblCittà.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCittà.Name = "lblCittà";
            this.lblCittà.Size = new System.Drawing.Size(36, 17);
            this.lblCittà.TabIndex = 8;
            this.lblCittà.Text = "Città";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(93, 169);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(132, 22);
            this.txtMail.TabIndex = 11;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(16, 172);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(33, 17);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail";
            // 
            // txtCF
            // 
            this.txtCF.Location = new System.Drawing.Point(93, 201);
            this.txtCF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(132, 22);
            this.txtCF.TabIndex = 13;
            this.txtCF.TextChanged += new System.EventHandler(this.txtCF_TextChanged);
            // 
            // lblCF
            // 
            this.lblCF.AutoSize = true;
            this.lblCF.Location = new System.Drawing.Point(16, 204);
            this.lblCF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCF.Name = "lblCF";
            this.lblCF.Size = new System.Drawing.Size(37, 17);
            this.lblCF.TabIndex = 12;
            this.lblCF.Text = "C. F.";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(93, 233);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 22);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(16, 236);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 17);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 265);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 268);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // btnControllo
            // 
            this.btnControllo.Location = new System.Drawing.Point(19, 310);
            this.btnControllo.Name = "btnControllo";
            this.btnControllo.Size = new System.Drawing.Size(179, 41);
            this.btnControllo.TabIndex = 18;
            this.btnControllo.Text = "Controllo";
            this.btnControllo.UseVisualStyleBackColor = true;
            this.btnControllo.Click += new System.EventHandler(this.btnControllo_Click);
            // 
            // errorProviderNome
            // 
            this.errorProviderNome.ContainerControl = this;
            // 
            // errorProviderCognome
            // 
            this.errorProviderCognome.ContainerControl = this;
            // 
            // errorProviderEta
            // 
            this.errorProviderEta.ContainerControl = this;
            // 
            // errorProviderCAP
            // 
            this.errorProviderCAP.ContainerControl = this;
            // 
            // errorProviderCitta
            // 
            this.errorProviderCitta.ContainerControl = this;
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // errorProviderCF
            // 
            this.errorProviderCF.ContainerControl = this;
            // 
            // errorProviderUsername
            // 
            this.errorProviderUsername.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 363);
            this.Controls.Add(this.btnControllo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtCF);
            this.Controls.Add(this.lblCF);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtCittà);
            this.Controls.Add(this.lblCittà);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.lblCAP);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCognome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCitta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtCAP;
        private System.Windows.Forms.Label lblCAP;
        private System.Windows.Forms.TextBox txtCittà;
        private System.Windows.Forms.Label lblCittà;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtCF;
        private System.Windows.Forms.Label lblCF;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnControllo;
        private System.Windows.Forms.ErrorProvider errorProviderNome;
        private System.Windows.Forms.ErrorProvider errorProviderCognome;
        private System.Windows.Forms.ErrorProvider errorProviderEta;
        private System.Windows.Forms.ErrorProvider errorProviderCAP;
        private System.Windows.Forms.ErrorProvider errorProviderCitta;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.ErrorProvider errorProviderCF;
        private System.Windows.Forms.ErrorProvider errorProviderUsername;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
    }
}

