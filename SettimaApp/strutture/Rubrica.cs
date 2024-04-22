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
            if (File.Exists($"{nome}.json"))
            {
                Apri();
            }
        }

        // "{this.nome}.txt"
        public void Salva()
        {
            string buffer = JsonSerializer.Serialize(this.contatti);
            File.WriteAllText($"{this.nome}.json", buffer);
        }

        public void Apri()
        {
            string buffer = File.ReadAllText($"{this.nome}.json");
            this.contatti = JsonSerializer.Deserialize< List<SchedaContatto> >(buffer);
        }
    }
}
