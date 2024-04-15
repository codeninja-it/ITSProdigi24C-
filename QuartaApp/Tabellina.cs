using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaApp
{
    public class Tabellina
    {
        internal int baseTabellina;
        public int ripetizioni;

        internal string buffer;

        /// <summary>
        /// inizializzazione di una nuova tabellina
        /// </summary>
        /// <param name="baseT">base di conteggio</param>
        /// <param name="volte">numero di ripetizioni</param>
        public Tabellina(int baseT, int volte)
        {
            baseTabellina = baseT;
            ripetizioni = volte;
        }

        /// <summary>
        /// Salva sul disco la nostra tabellina
        /// </summary>
        /// <param name="path">percorso di salvataggio del file</param>
        public void ToDisk(string path)
        {
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
            File.WriteAllText($"{path}/tabellina_{baseTabellina}.txt", buffer);
        }

    }
}
