using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es.coda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Paziente
        {
            public string nome;
            public int eta;
            public string colore;
            public int temp;
        }

        Queue<Paziente> codaPazienteR = new Queue<Paziente>();
        Queue<Paziente> codaPazienteG = new Queue<Paziente>();
        Queue<Paziente> codaPazienteV = new Queue<Paziente>();
        Queue<Paziente> codaPazienteB = new Queue<Paziente>();

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            Paziente p = new Paziente();
            p.nome = txtNome.Text;
            p.eta = Convert.ToInt32(nupEta.Value);
            p.colore = cmbCodice.SelectedText;

            switch(p.colore.ToLower())
            {
                case "Rosso":
                    codaPazienteR.Enqueue(p);
                    break;
                case "Giallo":
                    codaPazienteG.Enqueue(p);
                    break;
                case "Verde":
                    codaPazienteV.Enqueue(p);
                    break;
                case "Bianco":
                    codaPazienteB.Enqueue(p);
                    break;
                    
            }
        }

        private void btnVisualizzaPaziente_Click(object sender, EventArgs e)
        {
            Paziente p;
            if(codaPazienteR.Count != 0)
            {
                p = codaPazienteR.Dequeue();
                lblDatiPaziente.Text ="Nome: "+ p.nome + "\tEtà: " + p.eta.ToString() + "\tTemperatura: " + p.temp.ToString();
            }
            else
        }
    }
}
