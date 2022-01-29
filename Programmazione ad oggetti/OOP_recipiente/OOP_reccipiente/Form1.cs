using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_reccipiente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Recipiente rcp;
        Bicchiere bcc;

        private void btnSetRecipiente_Click(object sender, EventArgs e)
        {
            rcp.Set(Convert.ToInt32(txtSet.Text));
            txtSet.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMetti.Enabled = false;
            btnRecipiente.Enabled = false;
            btnSetRecipiente.Enabled = false;
            btnTogli.Enabled = false;
            btnSetBicchiere.Enabled = false;
            btnSetBicchiere.Enabled = false;
           
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            try
            {
                rcp = new Recipiente(Convert.ToInt32(txtValoreRecipiente.Text));
                
            }
            catch (Exception)
            {

                rcp = new Recipiente();
            }
            btnMetti.Enabled = true;
            btnRecipiente.Enabled = true;
            btnSetRecipiente.Enabled = true;
            btnTogli.Enabled = true;
            txtValoreRecipiente.Text = "";
        }

        private void btnRecipiente_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rcp.ToString());
        }

        private void btnMetti_Click(object sender, EventArgs e)
        {
            rcp.Metti(Convert.ToInt32(txtMetti.Text));
            txtMetti.Text = "";
        }

        private void btnTogli_Click(object sender, EventArgs e)
        {
            rcp.Togli(Convert.ToInt32(txtTogli.Text));
            txtTogli.Text = "";
        }

        private void btnCreaBicchiere_Click(object sender, EventArgs e)
        {
            try
            {
                bcc = new Bicchiere(Convert.ToInt32(txtValoreBicchiere.Text));

            }
            catch (Exception)
            {

                bcc = new Bicchiere();
            }
            btnSetBicchiere.Enabled = true;
            btnSetBicchiere.Enabled = true;
            txtValoreBicchiere.Text = "";
        }

        private void btnSetBicchiere_Click(object sender, EventArgs e)
        {
            bcc.Set(Convert.ToInt32(txtSetBicchiere.Text));
            txtSetBicchiere.Text = "";
        }

       

        private void btnBicchiere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bcc.ToString());
        }
    }
}
