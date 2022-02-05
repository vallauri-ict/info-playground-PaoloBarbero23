using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstact01
{
    abstract class Figura
    {
        protected int altezza;
        abstract protected double Area();
        public double Volume()
        {
            return Area() * altezza;
        }

        public string stampaArea()
        {
            return "Area: " + Area().ToString();
        }

        public string stampaVolume()
        {
            return "Volume: " + Volume().ToString();
        }
    }
}
