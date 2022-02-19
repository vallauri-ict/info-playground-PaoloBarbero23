using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scontro_fra_veicoli
{
    class Veicolo : IConfronta
    {
        Veicolo v1; 
        Veicolo v2;
        
        Random rnd = new Random();
        protected int Peso { get; set; }
        protected int Dimensione { get; set; }
        protected int Velocità { get; set; }
        protected int Integrita { get; set; }
        protected string Type { get; set; }

        public void Scontro()
        {
            System.Windows.Forms.MessageBox.Show("Scontro");
            if(v1.Type == v2.Type)
            {
                if(v1.Type == "camion")
                {
                    //v1.Integrita-=rnd.Next()
                }
            }
            Stampa();
        }

        public void Stampa()
        {
            System.Windows.Forms.MessageBox.Show("Veicolo 1 : "+v1.Type+" Integrita: "+v1.Integrita+ "\nVeicolo 2 : " + v2.Type + " Integrita: " + v2.Integrita);
        }

        public void turno(List<Veicolo> v)
        {
            int n1 = rnd.Next(0, v.Count);
            int n2;
            do
            {
                n2 = rnd.Next(0, v.Count);
            } while (n1 == n2);
            v1 = v.ElementAt(n1);//Il veicolo che prova lo scontro
            v2 = v.ElementAt(n2);//Il veicolo che subisce lo scontro
            if (rnd.Next(0, v2.Velocità) > v2.Velocità / 2)//avvenuto scontro
                Scontro();
            else
                System.Windows.Forms.MessageBox.Show("Lo scontro non è avvenuto");




        }
    }
}
