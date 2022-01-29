using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_reccipiente
{
    class Bicchiere : Recipiente
    {
        int capacita;

        public Bicchiere()
        {
            capacita = 100;

        }

        public Bicchiere(int k)
        {
            if (k < 0)
                capacita = 0;
            else
            {
                if (k > 1000)
                    capacita = 1000;
                else
                    capacita = k;
            }

        }

        public override string ToString()
        {
            return "capacità: " + capacita.ToString();
        }
        public virtual int Get()
        {
            return capacita;
        }
        public virtual void Set(int value)
        {
            if (value < 0)
                capacita = 0;
            else
            {
                if (value > 1000)
                    capacita = 1000;
                else
                    capacita = value;
            }
        }
    }
}
