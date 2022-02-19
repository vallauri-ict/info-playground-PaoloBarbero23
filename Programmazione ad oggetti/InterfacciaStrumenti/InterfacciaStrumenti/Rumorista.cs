using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Rumorista : Persona, ISuonatore
    {
        public string NomeArte { get; set; }
        public void suona()
        {
            System.Windows.Forms.MessageBox.Show("Emette suoni con la bocca");
        }
    }
}
