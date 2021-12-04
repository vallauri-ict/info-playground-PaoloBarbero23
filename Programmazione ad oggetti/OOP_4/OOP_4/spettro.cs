using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4
{
    class spettro  : Mostro
    {
        private bool invisibile;

        public spettro():base (30)
        {
            invisibile = true;
        }

        public spettro(int p) : base (p)
        {
            invisibile = true;
            
        }
    }
}
