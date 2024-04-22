using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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
            if (File.Exists($"{nome}.csv"))
            {
                Apri();
            }
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
            buffer = buffer.Trim();
            string[] righe = buffer.Split('\n');
            foreach(string riga in righe)
            {
                contatti.Add( new SchedaContatto(riga) );
            }
        }
    }
}
