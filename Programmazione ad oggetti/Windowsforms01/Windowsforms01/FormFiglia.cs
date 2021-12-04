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
    public partial class FormFiglia : Form
    {
        public FormFiglia()
        {
            InitializeComponent();
        }

        private void btnDichi_Click(object sender, EventArgs e)
        {
            if (Owner != null)
                MessageBox.Show("Form figlia di " + Owner.Text);//owner è un riferimento al genitore
        }
    }
}
