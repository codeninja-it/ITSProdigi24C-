using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettimaApp.strutture
{
    public class Rubrica
    {
        public string nome;
        public List<SchedaContatto> contatti;

        public Rubrica(string nome)
        {
            this.nome = nome;
            contatti = new List<SchedaContatto>();
        }

        // "{this.nome}.txt"
        public void Salva()
        {
            string buffer = "";
            foreach(SchedaContatto singolo in contatti)
            {
                buffer += $"{singolo}\n";
            }
            File.WriteAllText($"{this.nome}.csv", buffer);
        }

        public void Apri()
        {
            string buffer = File.ReadAllText($"{this.nome}.csv");
            string[] righe = buffer.Split('\n');
            foreach(string riga in righe)
            {
                string[] campi = riga.Split('\t');
                contatti.Add( new SchedaContatto(campi[0], campi[1], campi[2], campi[3]) );
            }
        }
    }
}
