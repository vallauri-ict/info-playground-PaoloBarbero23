﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_dado
{
    abstract class OggettoLanciato
    {
        protected int x;

        public int X { get => x; set => x = value; }

        public abstract void Lancia();
        

        

        
    }
}
