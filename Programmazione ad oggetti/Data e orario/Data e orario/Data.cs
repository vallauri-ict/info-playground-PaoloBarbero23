using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_e_orario
{
    class Data
    {
        private int giorno, mese, anno;
        int maxGiorno; //per la funzione domani. Sarebbe l'ultimo giorno del mese
        public Data()
        {
            giorno = 1;
            mese = 1;
            anno = 1900;

            maxGiorno = 31;
        }

        public Data(int g, int m, int a)
        {
            giorno = g;
            mese = m;
            anno = a;

            if ((mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12))
                maxGiorno = 31;
            else if ((mese == 4 || mese == 6 || mese == 9 || mese == 11 ))
                maxGiorno = 30;
            else if (mese % 2 == 0 && mese == 2 && (anno % 4 != 0))
                maxGiorno = 28;
            else
                maxGiorno = 29;
        }

        public override string ToString()
        {
            return giorno.ToString() + "/" + mese.ToString() + "/" + anno.ToString();
        }
        public virtual bool bisestile()
        {
            return DateTime.IsLeapYear(anno);
        }

        public virtual void leggi(int g, int m, int a)
        {
            bool ok = true;

            anno = a;
            if (mese > 0 && mese < 13)
                mese = m;
            else
                ok = false;
            if (ok)
            {
                if (controlloGiorno(g))
                    giorno = g;
                else
                    ok = false;
            }
            if (!ok)
                System.Windows.Forms.MessageBox.Show("Formato data non corretto");

        }

        public virtual void scrivi(ref int g, ref int m, ref int a)
        {
            anno = a;
            mese = m;
            giorno = g;
        }

        public virtual void domani()
        {
            DateTime dt = new DateTime(anno, mese, giorno);
            dt.AddDays(1);
            anno = dt.Year;
            mese = dt.Month;
            giorno = dt.Day;
            

        }

        public virtual void ieri()
        {
            DateTime dt = new DateTime(anno, mese, giorno);
            dt.Subtract(TimeSpan.FromDays(1));
            anno = dt.Year;
            mese = dt.Month;
            giorno = dt.Day;
        }

        private bool controlloGiorno(int giorno)
        {
            if (mese == 2 && (giorno >= 1 && giorno <= 28) && (anno % 4 != 0 || anno == 1900))
            {
                maxGiorno = 28;
                return true;

            }
            if (mese == 2 && (giorno >= 1 && giorno <= 29) && (anno % 4 == 0 && anno != 1900)) //bisestile
            {
                maxGiorno = 29;
                return true;

            }
            if ((mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) && (giorno >= 1 && giorno <= 31))
            {
                maxGiorno = 31;
                return true;

            }
            if ((mese == 4|| mese == 6 || mese == 9 || mese == 11) && (giorno >= 1 && giorno <= 30))
            {
                maxGiorno = 30;
                return true;

            }
            return false;

        }

        public virtual string Giorno()
        {
            DateTime dt = new DateTime(anno, mese, giorno);
            string gg = dt.ToString("dddd");
            return gg;
        }
    }

}
