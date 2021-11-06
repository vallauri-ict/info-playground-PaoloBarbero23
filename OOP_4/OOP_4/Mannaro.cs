using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class Mannaro : Mostro
    {
        protected string verso; //permette che verso e base.verso siano variabili diverse
        protected bool mutato;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }
        public double Valore()
        {
            if (mutato)
                return 2 * base.Valore();
            else
                return base.Valore();
        }
        public string Verso()
        {
            if (mutato)
                return verso;
            else
                return base.verso;//senza la creazione di una variabile stringa verso nella classe Mannaro, verso e base.verso sono la stessa variabile
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
