using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Complesso : IComparable<Complesso c>
    {
        List<ISuonatore> suonatori = new List<ISuonatore>();

        public void AggiungiStrumento(Strumento str)
        {
            suonatori.Add(str);
        }

        public void AggiungiRumorista(Rumorista rum)
        {
            suonatori.Add(rum);
        }
        public void Play()
        {
            
            foreach (var str in suonatori)
            {
                str.suona();
            }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
