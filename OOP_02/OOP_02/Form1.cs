using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_02
{
    public partial class Form1 : Form
    {
        Persona abele = new Persona(); //abele punta a una persona appena istanziata
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            abele.eta = 17;
            MessageBox.Show("Età prima del richiamo di Compleanno: " + abele.eta.ToString());
            Compleanno(abele);
            MessageBox.Show("Età dopo il richiamo di Compleanno: " + abele.eta.ToString());


        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            abele.eta = 54;
            MessageBox.Show("Età prima del richiamo Supplenza: " + abele.eta.ToString());
            Supplenza(ref abele);
            MessageBox.Show("Età dopo il richiamo Supplenza: " + abele.eta.ToString());
        }

        private void Compleanno (Persona p)
        {
            p.eta++;
        }
        private void Supplenza (ref Persona p)
        {
            p = new Persona();
            p.eta = 27;
        }

        
    }
}
