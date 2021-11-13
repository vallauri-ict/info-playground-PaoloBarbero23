using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Es.dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Articolo
        {
            public string nome_articolo;
        }
        string msg = "Numero inserimenti: ";


        Dictionary<string, Articolo> dicNegozio = new Dictionary<string, Articolo>();

        private void btnInserisciArticolo_Click(object sender, EventArgs e)
        {
            try
            {
                Articolo ar;
                ar.nome_articolo = txtValue.Text;
                dicNegozio.Add(txtKey.Text, ar);
            }
            catch (Exception)
            {
                MessageBox.Show("Chiave già esistente");
            }
            
        }

        private void btnNumeroInserimenti_Click(object sender, EventArgs e)
        {
            int cont = 0;
            foreach (string key in dicNegozio.Keys)
                cont++;
            lblNumeroInserimenti.Text = msg + cont.ToString();
            
        }

        private void btnCercaValue_Click(object sender, EventArgs e)
        {
            string msg = Interaction.InputBox("Inserisci la chive");
            try
            {
                lblAbbigliamento.Text = dicNegozio[msg].nome_articolo;
            }
            catch (Exception)
            {
                MessageBox.Show("Chiave non esistente");
            }
        }
    }
}
