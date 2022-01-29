using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_reccipiente
{
    class Recipiente
    {
        int capacita;
        int contenuto;

        public Recipiente()
        {
            capacita = 1000;
            contenuto = 0;
        }

        public Recipiente(int k)
        {
            capacita = k;
            contenuto = 0;
        }

        public override string ToString()
        {
            return "capacità: " + capacita.ToString() + "\ncontenuto:" + contenuto.ToString();
        }
        public virtual int Get()
        {
            return capacita;
        }
        public virtual void Set(int value)
        {
            capacita = value;
        }

        public virtual void Metti(int k)
        {
            if (k + contenuto >= capacita)
                contenuto = capacita;
            else
                contenuto += k;
        }
        public virtual void Togli(int k)
        {
            if (contenuto - k < 0)
                contenuto = 0;
            else
                contenuto -= k;
        }
    }
}
