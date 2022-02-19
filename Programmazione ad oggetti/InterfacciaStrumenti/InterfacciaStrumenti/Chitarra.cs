using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacciaStrumenti
{
    class Chitarra : Strumento
    {
        public override void suona()
        {
            System.Windows.Forms.MessageBox.Show("Sono una chitarra che suona");
        }
    }
}
