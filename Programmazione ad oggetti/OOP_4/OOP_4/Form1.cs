using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostro_Click(object sender, EventArgs e)
        {
            Mostro m = new Mostro();
            MessageBox.Show("Mostro --> Verso: " + m.Verso() + " Punti: " + m.Valore().ToString());
        }

        private void btnMannaro_Click(object sender, EventArgs e)
        {
            Mannaro mn = new Mannaro();
            MessageBox.Show("Mannaro --> Verso: " + mn.Verso() + " Punti: " + mn.Valore().ToString());
            mn.Muta();
            MessageBox.Show("Mannaro --> Verso: " + mn.Verso() + " Punti: " + mn.Valore().ToString());

        }

        private void btnSpettro_Click(object sender, EventArgs e)
        {
            spettro s = new spettro();
            MessageBox.Show("Spettro --> Punti: " + s.Valore().ToString());
            spettro s2 = new spettro(50);
            MessageBox.Show("Spettro --> Punti: " + s2.Valore().ToString());
        }
    }
}
