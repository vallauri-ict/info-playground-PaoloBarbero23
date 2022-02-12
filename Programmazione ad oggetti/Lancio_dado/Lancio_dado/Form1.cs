using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lancio_dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDado_Click(object sender, EventArgs e)
        {
            Dado d = new Dado();
            d.Lancio();
            MessageBox.Show("Risultato: " + d.N);
        }

        private void btnMoneta_Click(object sender, EventArgs e)
        {
            Moneta m = new Moneta();
            m.Lancio();
            string msg = m.V == 0 ? "Testa" : "Croce";
            MessageBox.Show("Moneta: " + msg);
        }

        private void btnDadoAstratto_Click(object sender, EventArgs e)
        {
            DadoAbs dabs = new DadoAbs();
            dabs.Lancia();
            MessageBox.Show("Risultato: " + dabs.X);
        }

        private void btnMonetaAstratta_Click(object sender, EventArgs e)
        {
            MonetaAbs mabs = new MonetaAbs();
            mabs.Lancia();
            string msg = mabs.X == 0 ? "Testa" : "Croce";
            MessageBox.Show("Moneta: " + msg);
        }
    }
}
