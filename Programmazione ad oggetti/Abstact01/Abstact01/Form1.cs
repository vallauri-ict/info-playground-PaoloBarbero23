using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstact01
{
    public partial class Form1 : Form
    {
        Cilindro c;
        Parallelepipedo p;
        bool area_p, area_c;
        public Form1()
        {
            InitializeComponent();
            area_c = false;
            area_p = false;
        }

        private void btnAreaCilindro_Click(object sender, EventArgs e)
        {
            controlloCilindro();
            area_c = true;
            MessageBox.Show(c.stampaArea());

        }



        private void btnVolumeCilindro_Click(object sender, EventArgs e)
        {
            if (!area_c)
                controlloCilindro();
            MessageBox.Show(c.stampaVolume());
        }

        private void btnAreaParallelepipedo_Click(object sender, EventArgs e)
        {

            controlloParallelepipedo();
            MessageBox.Show(p.stampaArea());
            area_p = true;
        }

        private void btnVolumeParallelepipedo_Click(object sender, EventArgs e)
        {
            if (!area_p)
                controlloParallelepipedo();
            MessageBox.Show(p.stampaVolume());

        }

        private void controlloCilindro()
        {
            if (int.TryParse(txtRaggio.Text, out int r) && int.TryParse(txtAltezza.Text, out int h))
            {
                c = new Cilindro(r, h);
            }
            else
            {
                c = new Cilindro();
            }
        }

        private void controlloParallelepipedo()
        {
            if (int.TryParse(txtLato1.Text, out int l1) && int.TryParse(txtLato2.Text, out int l2) && int.TryParse(txtAltezza.Text, out int h))
            {
                p = new Parallelepipedo(l1, l2, h);
            }
            else
            {
                p = new Parallelepipedo();
            }
        }
    }
}
