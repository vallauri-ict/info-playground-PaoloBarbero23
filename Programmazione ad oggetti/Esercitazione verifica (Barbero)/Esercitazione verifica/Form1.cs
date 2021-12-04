using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_verifica
{
    public partial class Form1 : Form
    {
        public string interni;
        public string marca;

        public Form1()
        {
            InitializeComponent();
        }

   

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMacchine.SelectedIndex = -1;
        }

        private void chkStoffa_CheckedChanged(object sender, EventArgs e)
        {
            interni = "";
            if (chkPelle.Checked == true)
                interni += chkPelle.Text + " ";
            if (chkStoffa.Checked == true)
                interni += chkStoffa.Text;
            
        }

        private void cmbMacchine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMacchine.SelectedIndex != -1)
                marca = cmbMacchine.Text;
        }

        private void chkPelle_CheckedChanged(object sender, EventArgs e)
        {
            interni = "";
            if (chkPelle.Checked == true)
                interni += chkPelle.Text + " ";
            if (chkStoffa.Checked == true)
                interni += chkStoffa.Text;
        }
    }
}
