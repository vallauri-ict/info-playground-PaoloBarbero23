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
    public partial class Form2 : Form
    {
        private string marca;
        private string tessuti;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string marca, string tessuti)
        {
            InitializeComponent();
            this.marca = marca;
            this.tessuti = tessuti;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (marca == "" && tessuti == "")
                MessageBox.Show("Bisogna inserire le caratteristiche");
        }
    }
}
