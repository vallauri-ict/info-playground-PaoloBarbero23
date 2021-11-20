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
            public double temp;
        }

        Queue<Paziente> codaPazienteR = new Queue<Paziente>();
        Queue<Paziente> codaPazienteG = new Queue<Paziente>();
        Queue<Paziente> codaPazienteV = new Queue<Paziente>();
        Queue<Paziente> codaPazienteB = new Queue<Paziente>();

        double maxT = 0, minT = 100;

        private void btnRegistra_Click(object sender, EventArgs e)
        {
            Paziente p = new Paziente();
            p.nome = txtNome.Text;
            p.eta = Convert.ToInt32(nupEta.Value);
            p.colore = cmbCodice.SelectedItem.ToString();
            p.temp = Convert.ToDouble(nupTemp.Value);

            switch (p.colore.ToLower())
            {
                case "rosso":
                    codaPazienteR.Enqueue(p);
                    break;
                case "giallo":
                    codaPazienteG.Enqueue(p);
                    break;
                case "verde":
                    codaPazienteV.Enqueue(p);
                    break;
                case "bianco":
                    codaPazienteB.Enqueue(p);
                    break;

            }

            if (maxT < p.temp)
                maxT = p.temp;
            if (minT > p.temp)
                minT = p.temp;
            
        }

        private void btnVisualizzaPaziente_Click(object sender, EventArgs e)
        {
            Paziente p = new Paziente();
            if (codaPazienteR.Count != 0)
            {
                visualizaPaziente(p, codaPazienteR, lblDatiPaziente);
            }
            else
            {
                if (codaPazienteG.Count != 0)
                    visualizaPaziente(p, codaPazienteG, lblDatiPaziente);
                else
                {
                    if (codaPazienteV.Count != 0)
                        visualizaPaziente(p, codaPazienteV, lblDatiPaziente);
                    else
                    {
                        if (codaPazienteB.Count != 0)
                            visualizaPaziente(p, codaPazienteB, lblDatiPaziente);
                        else
                            lblDatiPaziente.Text = "Non ci sono pazienti";
                    }

                }

            }



        }

        private void visualizaPaziente(Paziente p, Queue<Paziente> codaPaziente, Label lblDatiPaziente)
        {
            p = codaPaziente.Dequeue();
            lblDatiPaziente.Text = "Nome: " + p.nome + "-Età: " + p.eta.ToString() + "-Temperatura: " + p.temp.ToString() + "-Colore: " + p.colore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maxT != 0)
                lblMax.Text = "MAX: " + maxT;
            if (minT != 100)
                lblMin.Text = "MIN: " + minT;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nupTemp.ReadOnly = true;
            nupEta.ReadOnly = true;
            cmbCodice.SelectedIndex = 0;
        }
    }
}
