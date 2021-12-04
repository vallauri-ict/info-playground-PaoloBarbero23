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
    public partial class Form3 : Form
    {
        public string messaggio;
        public Label lblPadre;
        public Label lblNonno;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Label lblPadre, Label lblNonno, string messaggio)
        {
            InitializeComponent();
            this.lblPadre = lblPadre;
            this.lblNonno = lblNonno;
            this.messaggio = messaggio;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPadre_Click(object sender, EventArgs e)
        {
            lblPadre.Text = textBox1.Text;


        }

        private void btnNonno_Click(object sender, EventArgs e)
        {
            lblNonno.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZio_Click(object sender, EventArgs e)
        {
            messaggio = textBox1.Text;
        }
    }
}
