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
    public partial class frmEsercitazione : Form
    {
        string chkValue;
        string carType;
        Form1 f;
        public frmEsercitazione()
        {
            InitializeComponent();
        }

        private void frmEsercitazione_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carType = "";
            chkValue = "";
            f= new Form1();
            f.MdiParent = this;
            f.Text = "Scelta del tipo di macchina";
            f.Show();
            





        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chkValue = f.interni;
            carType = f.marca;
            MessageBox.Show(chkValue + "\n" + carType);
            Form2 f2 = new Form2(chkValue, carType); 

            


            
        }
    }
}
