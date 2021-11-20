using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Es.pila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct container
        {
            public string codice;
            public double peso;
            public double tara;
        }

        Stack<container> pilaContainer = new Stack<container>();

        private void btnInserisciContainer_Click(object sender, EventArgs e)
        {
            container c = new container();
            c.codice = txtCodice.Text;
            c.peso = Convert.ToDouble(nupPeso.Value);
            c.tara = Convert.ToDouble(nupTara.Value);

            pilaContainer.Push(c);
        }

        private void btnVisualizzaDati_Click(object sender, EventArgs e)
        {
            if (pilaContainer.Count != 0)
            {
                container c = pilaContainer.Pop();
                lblDati.Text = "Codice: " + c.codice + " Peso: " + c.peso + " Tara: " + c.tara;
            }
            else
                lblDati.Text = "Pila vuota";

        }
    }
}
