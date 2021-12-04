using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryQuadrato
{
    class Quadrato
    {
        private int lato;

        private Quadrato(int val)
        {
            this.lato = val;
        }

        public static Quadrato CreaQuadrato(int val)
        {
            if (val > 0)
                return new Quadrato(val);
            else
                throw new Exception("il lato deve essere maggiore di 0");
        }
    }
}
