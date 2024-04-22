using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettimaApp.strutture
{
    public class SchedaContatto
    {
        public SchedaContatto(string nome, string cognome, string email, string telefono)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.telefono = telefono;
        }

        public string nome;
        public string cognome;
        public string email;
        public string telefono;

        public override string ToString()
        {
            return $"contatto: {nome} {cognome}";
        }

    }
}
