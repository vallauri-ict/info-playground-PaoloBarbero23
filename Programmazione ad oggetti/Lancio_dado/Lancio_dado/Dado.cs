﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio_dado
{
    class Dado
    {
        private int n;
        public int N { get => n; }
        Random rnd = new Random();

        public Dado()
        {
            this.n = 1;
        }

        public void Lancio()
        {
            n = rnd.Next(6) + 1;
        }
        
    }
}
