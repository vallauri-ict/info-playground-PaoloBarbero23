using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryQuadrato
{
    class Singleton
    {
        private Singleton()
        {
            id++;
            n = id;

        }
        private static Singleton _istance = null;
        private static int id = 0;
        public readonly int n;

        public static Singleton GetIstance()
        {
            if (_istance == null)
                _istance = new Singleton();
            return _istance;
        }
    }
}
