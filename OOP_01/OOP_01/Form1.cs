using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form1 : Form
    {
        Rectangle r;
        Rectangle s = new Rectangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //r = new Rectangle(3); non puoi farlo perchè quel costruttore è private
            r = new Rectangle(3);
            //r.side1 = Convert.ToInt32(txtBase.Text);
            //r.side2 = Convert.ToInt32(txtAltezza.Text);

            MessageBox.Show("Oggetto r ->Lati: " + r.side1 + "-" + r.side2);

            
            
            MessageBox.Show("Oggetto s -> Lati: " + s.side1 + "-" + s.side2);

            Rectangle t;
            t = r;//Si è passato il puntatore all'oggetto. t, r, s sono puntatori ad una zona di memoria
            MessageBox.Show("Oggetto t -> Lati: " + t.side1 + "-" + t.side2);
        }
    }
}
