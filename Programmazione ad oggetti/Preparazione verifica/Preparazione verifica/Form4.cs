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
    public partial class Form4 : Form
    {
        string lbl;
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string lbl)
        {
            InitializeComponent();
            this.lbl = lbl;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (lbl != null)
            {
                lblMessaggio.Text = lbl;
            }
        }
    }
}
