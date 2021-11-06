using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    class Mannaro:Mostro
    {
        public int punti;


        public Mannaro()
        {
            punti = 0;
        }
        public Mannaro(string n)
        {
            nome = n;
            punti = 500;
            
        }
        public double Valore_Proprio()
        { // punti del Mannaro
            return punti;
        }
        public double Valore_Padre()
        { // punti Mostro
            return base.punti;//base prende variabile/metodo/funzione che c'è nel padre. Lo si usa solo se c'è una variabile/metodo/funzione nel figlio che lo stesso nome del padre
        }
        public double Valore()
        { // somma punti
            return punti + base.Valore();//base.Valore() è analogo a base.punti perchè base.valore ritorna i punti del mostro
        }
        
    }
}
