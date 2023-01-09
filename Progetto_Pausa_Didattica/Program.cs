using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Pausa_Didattica
{
    internal class Program
    {
        

        // Codice dell'intervento (3 caratteri maiuscoli e 3 cifre)
        public string Codice { get; set; }

        // Data di acquisizione del prodotto
        public DateTime DataAcquisto { get; set; }

        // Data di consegna
        public DateTime DataConsegna { get; set; }

        // Descrizione del difetto
        public string Difetto { get; set; }

        // Descrizione dell'intervento effettuato
        public string DescrizioneIntervento { get; set; }

        // Prezzo orario
        public decimal PrezzoOrario { get; set; }

        // Ore di lavoro necessarie alla riparazione
        public int OreLavoro { get; set; }

        // Metodo per il calcolo del prezzo dell'intervento
        public decimal CalcolaPrezzo()
        {
            return PrezzoOrario * OreLavoro;
        }

        // Metodo per l'incremento del costo orario in percentuale
        public void IncrementaPrezzoOrario(decimal percentuale)
        {
            PrezzoOrario += PrezzoOrario * percentuale / 100;
        }

        // Metodo per il confronto tra due interventi
        public int Confronta(Program altroIntervento)
        {
            return CalcolaPrezzo().CompareTo(altroIntervento.CalcolaPrezzo());
        }

    }
}
 
