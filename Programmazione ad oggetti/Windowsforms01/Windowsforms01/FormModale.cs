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
    public partial class FormModale : Form
    {
        public string nome = "";
        public string eta = "";
        public FormModale()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            eta = txtEtà.Text;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            nome = eta = "";
            
        }
    }
}
