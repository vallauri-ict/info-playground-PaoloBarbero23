using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    class Mostro
    {
        public double punti;
        public string nome;

        public Mostro(string n)
        {
            nome = n;
            punti = 100;
        }

        public Mostro()
        {
            nome = "Senza nome";
        }

        public double Valore()
        {
            return punti;
        }
    }
}
