using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_dado
{
    class Moneta
    {
        private int v;
        Random rnd = new Random();
        public int V { get => v; set => v = value; }

        public Moneta()
        {
            this.V = 1;
        }

        public void Lancio()
        {
            v = rnd.Next(2);
        }

    }
}
