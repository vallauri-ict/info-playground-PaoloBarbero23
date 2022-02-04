using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class DataOra : Data
    {
        private int ore, minuti, secondi;

        public DataOra()
        {
            ore = 0;
            minuti = 0;
            secondi = 1;
        }

        public DataOra(int s, int m, int o)
        {
            ore = o;
            minuti = m;
            secondi = s;
        }

        public DataOra(int s, int m, int h, int g, int mn, int a)
        {
            ore = h;
            minuti = m;
            secondi = s;
            base.leggi(g, mn, a);
        }

        public override string ToString()
        {
            string hour, min, sec;
            if (ore < 10)
                hour = "0" + ore.ToString();
            else
                hour = ore.ToString();
            if(minuti < 10)
                min = "0" + minuti.ToString();
            else
                min = minuti.ToString();
            if (secondi < 10)
                sec = "0" + secondi.ToString();
            else
                sec = secondi.ToString();
            return base.ToString() + " " + hour + ":" + min + ":" + sec;
        }

        public virtual void leggi(int s, int m, int h)
        {
            bool ok = true;

            if (h < 0 && h >= 24)
                ok = false;
            else
                ore = h;
            if (minuti >= 0 && minuti < 60)
                minuti = m;
            else
                ok = false;
            if (ok)
            {
                if (secondi >= 0 && secondi < 60)
                    secondi = s;
                else
                    ok = false;
            }
            if (!ok)
                System.Windows.Forms.MessageBox.Show("Orario non corretto");
            else
                System.Windows.Forms.MessageBox.Show("Orario aggiornato con successo");

        }
    }
}
