using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Mostro
    {
        protected double punti;
        protected string verso;
        public Mostro() : this(25)//prima viene eseguito il costruttore richiamato col parametro dopo viene eseguito il costruttore che si è richiamato con il new
        {
            //punti = 25;
            verso = "scimmia";
            

        }

        public Mostro(int p)
        {
            this.punti = p;
            verso = "grugnito";

        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
