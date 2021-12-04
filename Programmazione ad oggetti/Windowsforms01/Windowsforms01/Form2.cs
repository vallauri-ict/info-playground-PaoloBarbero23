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
    public partial class Form2 : Form
    {
        private int n;
        private TextBox txt;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int n)//costruttore in cui si passa il parametro n
        {
            InitializeComponent();
            this.n = n;
            
        }

        public Form2(TextBox txt)
        {
            InitializeComponent();
            this.txt = txt;
            //txt.Text = "Ciao da f2";//scrive nella textbox di form1
        }

        private void btnLeggitxt_Click(object sender, EventArgs e)
        {
            if (txt != null)
                MessageBox.Show(txt.Text);
            else
                MessageBox.Show("Non è stato passato l'oggetto textbox");
        }

        
        private void btnAprifiglia_Click_1(object sender, EventArgs e)
        {
            FormFiglia f = new FormFiglia();
            this.AddOwnedForm(f);
            f.Show();
           
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (txt != null)
                txt.Text = txtF2.Text;
            else
                MessageBox.Show("Non è stato passato l'oggetto textbox");
        }
    }
}
