using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_dado
{
    class MonetaAbs : OggettoLanciato
    {
        Random rnd = new Random();
        public override void Lancia()
        {
            x = rnd.Next(2);
        }
        public MonetaAbs()
        {
            x = 0;
        }

        
    }
}
