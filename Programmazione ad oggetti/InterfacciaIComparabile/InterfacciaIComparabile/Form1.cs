using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacciaIComparabile
{
    public partial class Form1 : Form
    {
        List<Persona> list = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Cognome = txtCognome.Text;
            p.Nome = txtNome.Text;
            p.Età = Convert.ToInt32(txtEta.Text);
            list.Add(p);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            list.Sort();
            string s = "";

            foreach (Persona p in list)
            {
                s += "Cognome: " + p.Cognome + " Nome: " + p.Nome + " Età: " + p.Età + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
