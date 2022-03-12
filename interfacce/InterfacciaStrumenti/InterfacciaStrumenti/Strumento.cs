using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Strumento : ISuonatore
    {
        public virtual void suona()
        {
            System.Windows.Forms.MessageBox.Show("Sono uno strumento che suona");
        }
    }
}
