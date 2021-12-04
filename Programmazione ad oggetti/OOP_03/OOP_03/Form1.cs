using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreaMannaro_Click(object sender, EventArgs e)
        {
            Mannaro m1 = new Mannaro("");
            MessageBox.Show("Valore proprio: " + m1.Valore_Proprio().ToString() +
                "\nValore padre: " + m1.Valore_Padre().ToString() +
                "\nSomma dei valori padre e proprio: " + m1.Valore().ToString());
            
        }

        private void btnCreaMostro_Click(object sender, EventArgs e)
        {
            Mostro mostro1 = new Mostro("Mostro 1");
            MessageBox.Show("Punti del mostro: " + mostro1.Valore().ToString());
            /*mostro1 = new Mostro();
            MessageBox.Show(mostro1.Valore().ToString());*/
        }

        private void btnCreaMannaro2_Click(object sender, EventArgs e)
        {
            Mannaro m2 = new Mannaro();
            m2.punti = 10;
            double x = m2.Valore_Proprio();
            double y = m2.Valore_Padre();
            double z = m2.Valore();
            MessageBox.Show("Valore proprio: " + x + "\n" +
                "Valore padre: " + y + "\n" +
                "Somma dei valori padre e proprio: " + z);
        }
    }
}
