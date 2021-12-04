using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparazione_verifica
{
    public partial class Form1 : Form
    {
        Form2 f2;
        private string messaggio;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2(lblMessaggio, messaggio);
            
            //AddOwnedForm(f2);//MDiparent = this e AddOwnedForm() non funzionano insieme

            f2.Show();
        }

        private void apriForm4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form4 f4 = new Form4(f2.f3.messaggio);
           f4.Show();
        }
    }
}
