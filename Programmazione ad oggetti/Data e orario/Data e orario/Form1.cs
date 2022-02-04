using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_e_orario
{
    public partial class Form1 : Form
    {
        Data data;
        DataOra ora;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnno.Text, out int anno))
            {
                if (controlloValidita(Convert.ToInt32(nupGiorno.Value), Convert.ToInt32(nupMese.Value), anno))
                {
                    data = new Data(Convert.ToInt32(nupGiorno.Value), Convert.ToInt32(nupMese.Value), anno);
                    MessageBox.Show("Data creata con successo");
                }
                else
                {
                    data = new Data();
                    MessageBox.Show("Parametri non validi. É stata creata una data con valore 1/1/1900");
                }


            }
            else
            {
                data = new Data();
                MessageBox.Show("Valore dell'anno non valido. É stata creata una data con valore 1/1/1900");


            }

            abilitazioneBottoni(true);
            txtAnno.Text = "";
        }

        private bool controlloValidita(int giorno, int mese, int anno)
        {
            if (mese == 2 && (giorno >= 1 && giorno <= 28) && (anno % 4 != 0))
                return true;

            if (mese == 2 && (giorno >= 1 && giorno <= 29) && (anno % 4 == 0)) //bisestile
                return true;

            if ((mese == 1 || mese == 3 || mese == 5 || mese == 7 || mese == 8 || mese == 10 || mese == 12) && (giorno >= 1 && giorno <= 31))
                return true;

            if ((mese == 4 || mese == 6 || mese == 9 || mese == 11) && (giorno >= 1 && giorno <= 30))
                return true;

            return false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abilitazioneBottoni(false);
            abilitazioneBottoniOra(false);

        }

        private void abilitazioneBottoniOra(bool val)
        {
            btnVisualizzaOra.Enabled = val;
            btnLeggiOra.Enabled = val;
            btnScriviOra.Enabled = val;
        }

        private void abilitazioneBottoni(bool val)
        {
            btnAggiungi.Enabled = val;
            btnLeggi.Enabled = val;
            btnScrivi.Enabled = val;
            btnTogli.Enabled = val;
            btnVisualizza.Enabled = val;

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data.ToString());
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            data.domani();
        }

        private void btnTogli_Click(object sender, EventArgs e)
        {
            data.ieri();
        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAnno2.Text, out int anno))
            {
                if (controlloValidita(Convert.ToInt32(nupGiorno2.Value), Convert.ToInt32(nupMese2.Value), anno))
                {
                    ora = new DataOra(Convert.ToInt32(nupGiorno2.Value), Convert.ToInt32(nupMese2.Value), anno);
                    MessageBox.Show("Data aggiornata con successo");
                    txtAnno2.Text = "";
                }
                else
                {
                    ora = new DataOra();
                    MessageBox.Show("Parametri non validi. La data non è stata modificata");
                }
            }
            else
            {
                ora = new DataOra();
                MessageBox.Show("Valore dell'anno non valido. La data non è stata modificata");

            }
        }

        private void btnScrivi_Click(object sender, EventArgs e)
        {

        }

        private void btnCreaOra_Click(object sender, EventArgs e)
        {

            if (controlloOra(txtOra.Text, txtMinuti.Text, txtSecondi.Text))
            {
                if (int.TryParse(txtAnno3.Text, out int anno))
                {
                    if (controlloValidita(Convert.ToInt32(nupGiorno3.Value), Convert.ToInt32(nupMese3.Value), anno))
                    {
                        ora = new DataOra(Convert.ToInt32(txtSecondi.Text), Convert.ToInt32(txtMinuti.Text), Convert.ToInt32(txtOra.Text), Convert.ToInt32(nupGiorno3.Value), Convert.ToInt32(nupMese3.Value), anno);
                        MessageBox.Show("Data e ora aggiunti con successo");
                        txtAnno3.Text = "";
                        txtMinuti.Text = "";
                        txtOra.Text = "";
                        txtSecondi.Text = "";
                    }
                    else
                    {
                        ora = new DataOra(Convert.ToInt32(txtSecondi.Text), Convert.ToInt32(txtMinuti.Text), Convert.ToInt32(txtOra.Text));
                        MessageBox.Show("Valori inseriti della data non validi. É stata creata un'ora senza la data");
                        
                    }
                    
                }
                else
                {
                    data = new Data(Convert.ToInt32(txtSecondi.Text), Convert.ToInt32(txtMinuti.Text), Convert.ToInt32(txtOra.Text));
                    MessageBox.Show("Ora aggiunta con successo");
                    txtMinuti.Text = "";
                    txtOra.Text = "";
                    txtSecondi.Text = "";

                }

            }
            else
            {
                ora = new DataOra();
                MessageBox.Show("Parametri non validi. É stata creata un'ora con valore 00:00:01");
            }

            abilitazioneBottoniOra(true);
        }

        private bool controlloOra(string ora, string minuti, string secondi)
        {
            if (int.TryParse(ora, out int hour))
            {
                if (int.TryParse(minuti, out int min))
                {
                    if (int.TryParse(secondi, out int sec))
                    {
                        if ((hour >= 0 && hour <= 23) && (min >= 0 && min <= 59) && (sec >= 0 && sec <= 59))
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void btnVisualizzaOra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ora.ToString());
        }

        private void btnLeggiOra_Click(object sender, EventArgs e)
        {
            ora.leggi(Convert.ToInt32(nupSecondi.Value), Convert.ToInt32(nupMinuti.Value), Convert.ToInt32(nupOre.Value));

        }
    }
}
