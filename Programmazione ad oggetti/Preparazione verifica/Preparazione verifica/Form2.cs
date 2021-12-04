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
    public partial class Form2 : Form
    {
        public string messaggio;
        public Label lbl;
        public Form3 f3;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Label lbl, string messaggio)
        {
            InitializeComponent();
            this.lbl = lbl;
            this.messaggio = messaggio;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f3 = new Form3(lblMessaggio, lbl, messaggio);
            f3.MdiParent = this;
            f3.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
