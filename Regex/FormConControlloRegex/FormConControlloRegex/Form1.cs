using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace FormConControlloRegex
{
    public partial class Form1 : Form
    {
        Regex rgx_nome;
        Regex rgx_età;
        Regex rgx_CAP;
        Regex rgx_citta;
        Regex rgx_mail;
        Regex rgx_CF;
        Regex rgx_username;
        Regex rgx_password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rgx_nome = new Regex(@"^([a-zA-Z]{3,})$");//cognome è uguale
            rgx_età = new Regex(@"^\d{1,3}$");//non funziona
            rgx_CAP = new Regex(@"^\d{5}$");
            rgx_citta = new Regex(@"^[a-zA-Z]{3,} [a-zA-Z]{2}$");
            rgx_mail = new Regex(@"^(\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)(,\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)*$");
            rgx_CF = new Regex(@"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$");
            rgx_username = new Regex(@"^[a-zA-Z]\w{4,}$");
            rgx_password = new Regex(@"^(\w|[-!+]){8,15}$");//non funziona
        }

        private void btnControllo_Click(object sender, EventArgs e)
        {
            if (rgx_nome.IsMatch(txtNome.Text) && rgx_nome.IsMatch(txtCognome.Text) && rgx_età.IsMatch(txtEta.Text) && rgx_CAP.IsMatch(txtCAP.Text) && rgx_citta.IsMatch(txtCittà.Text) && rgx_mail.IsMatch(txtMail.Text) && rgx_CF.IsMatch(txtCF.Text) && rgx_username.IsMatch(txtUserName.Text) && rgx_password.IsMatch(txtPassword.Text))
            {


                string[] mail = txtMail.Text.Split(',');
                string output = "";
                for (int i = 0; i < mail.Length; i++)
                    output += mail[i] + "\n";
                MessageBox.Show("Mail: \n" + output);
            }
            else
                MessageBox.Show("Errore nella compilazione di alcuni campi");





        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_nome.IsMatch(txtNome.Text) && txtNome.Text != "")
                errorProviderNome.SetError((Control)sender, "Il nome deve avere solo lettere e di almeno 3 caratteri");
            else
                errorProviderNome.Clear();
            
        }

        private void txtCognome_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_nome.IsMatch(txtCognome.Text) && txtCognome.Text != "")
                errorProviderCognome.SetError((Control)sender, "Il cognome deve avere solo lettere e di almeno 3 caratteri");
            else
                errorProviderCognome.Clear();

        }

        private void txtEta_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_età.IsMatch(txtEta.Text) && txtEta.Text != "")
                errorProviderEta.SetError((Control)sender, "l'età dev essere compresa fra 0 e 120");
            else
                errorProviderEta.Clear();

        }

        private void txtCAP_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_CAP.IsMatch(txtCAP.Text) && txtCAP.Text != "")
                errorProviderCAP.SetError((Control)sender, "CAP deve avere 5 cifre");
            else
                errorProviderCAP.Clear();

        }

        private void txtCittà_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_citta.IsMatch(txtCittà.Text) && txtCittà.Text != "")
                errorProviderCitta.SetError((Control)sender, "La città deve avere 3 lettera e seguita da uno spazio e 2 lettere. Es. XXXXX XX");
            else
                errorProviderCitta.Clear();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_mail.IsMatch(txtMail.Text) && txtMail.Text != "")
                errorProviderMail.SetError((Control)sender, "La mail deve essere formata: carattere1@dominio2.dominio1  Il carattere 1 può essere seguito da .carattere2 (infinite volte) e dopo dominio2 ci possono essere infiniti .dominio3. Possono essere aggiunte più mail separate fra loro da una virgola(,) senza spazi");
            else
                errorProviderMail.Clear();
        }

        private void txtCF_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_CF.IsMatch(txtCF.Text) && txtCF.Text != "")
                errorProviderCF.SetError((Control)sender, "Codice fiscale errato");
            else
                errorProviderCF.Clear();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_username.IsMatch(txtUserName.Text) && txtUserName.Text != "")
                errorProviderUsername.SetError((Control)sender, "Lo user name deve avere almeno 5 caratteri di cui il primo alfabetico e gli altri alfanumerici");
            else
                errorProviderUsername.Clear();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!rgx_password.IsMatch(txtPassword.Text) && txtPassword.Text != "")
                errorProviderPassword.SetError((Control)sender, "La password deve avere dagli 8 a 15 caratteri alfanumerici e deve contenere uno di questi caratteri - ! +!");
            else
                errorProviderPassword.Clear();
        }
    }

}
