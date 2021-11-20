using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_06
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void btnGeneraMostro_Click(object sender, EventArgs e)
        {
            Mostro guardiano;
            if (rnd.Next(2) == 0)
                guardiano = new Mannaro();
            else
                guardiano = new Zombie();

            MessageBox.Show("Verso come mostro: " + guardiano.Verso());//guardiano sarà sempre di tipo mostroW
            if (guardiano is Mannaro)
                MessageBox.Show("Verso come mannaro: " + (guardiano as Mannaro).Verso());//as esegue un cast forzato
            else if(guardiano is Zombie)
                MessageBox.Show("Verso come zombie: " + (guardiano as Zombie).Verso());//si può anche fare ((Zombie)guardiano).Verso()



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
                (sender as Button).Text = "Cliccato";
            else if (sender is Label)
                (sender as Label).BackColor = Color.Red;
        }
    }
}
