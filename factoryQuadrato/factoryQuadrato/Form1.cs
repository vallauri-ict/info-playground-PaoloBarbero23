using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factoryQuadrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Prova con lato = 5");
                Quadrato q = Quadrato.CreaQuadrato(5);
                MessageBox.Show("Prova con lato = 0");
                Quadrato q1 = Quadrato.CreaQuadrato(0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRORE!!");
            }
        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creazione primo oggetto singleton");
            Singleton s1 = Singleton.GetIstance();
            MessageBox.Show("Progressivo: " + s1.n);

            MessageBox.Show("Prova creazione secondo oggetto singleton");
            Singleton s2 = Singleton.GetIstance();
            MessageBox.Show("Progressivo: " + s2.n);

            


        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            Stringhe_indexate s = new Stringhe_indexate(10);
            for (int i = 0; i < 10; i++)
            {
                s[i] = i.ToString();
            }
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("stringa " + i + " = " + s[i]);
            }
        }
    }
}
