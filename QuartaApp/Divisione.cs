using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaApp
{
    internal class Divisione : Tabellina
    {

        /// <summary>
        /// inizializzazione di una nuova tabellina
        /// </summary>
        /// <param name="baseT">base di conteggio</param>
        /// <param name="volte">numero di ripetizioni</param>
        public Divisione(int baseT, int volte) : base(baseT, volte)
        { 
            
        }

        public Divisione(int baseT) : base(baseT, 10)
        {

        }

        public Divisione() : base(2, 10)
        {
        
        }

        /// <summary>
        /// compila la tabellina dentro all'oggetto per le impostazioni date
        /// </summary>
        public void Calcola()
        {
            buffer = "";
            for (int i = 1; i <= ripetizioni; i++)
            {
                double risultato = baseTabellina / i;
                buffer += $"{baseTabellina} / {i} = {risultato}\n";
            }
        }

        public override string ToString()
        {
            return $"Divisione del {baseTabellina}";
        }

    }
}
