using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowsforms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAprif2_Click(object sender, EventArgs e)
        {
            Form2 f2;//Istanzia un oggetto di tipo Form2.
            f2 = new Form2();//Alloco dello spazio in memoria. f2 sarebbe un puntatore che punta all'indirizzo della memoria allocata
            f2.Text = "Form 2 creata da designer";
            f2.Show();//Mostro la finestra


            Form2 f2b = new Form2(10);
            f2b.Text = "Form 2 da Designer con parametro";
            f2b.Show();

        }

        private void btnF2controllo_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtPassare);
            f2.Text = "Form 2 con passaggio di un textbox";
            f2.Show();
        }

        private void btnFormModale_Click(object sender, EventArgs e)
        {
            FormModale frm = new FormModale();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Premuto pulsante OK \nNome: " + frm.nome + " Età: " + frm.eta);
            }
            else
                MessageBox.Show("Premuto pulsante annulla");
        }
    }
}
