using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettimaApp.strutture
{
    public class SchedaContatto
    {
        public string nome = "";
        public string cognome = "";
        public string email = "";
        public string telefono = "";

        public SchedaContatto()
        { 
        
        }

        public SchedaContatto(string nome, string cognome, string email, string telefono)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.telefono = telefono;
        }

        public SchedaContatto(string riga)
        {
            string[] pezzi = riga.Split('\t');
            this.nome = pezzi[0];
            this.cognome = pezzi[1];
            this.email = pezzi[2];
            this.telefono = pezzi[3];
        }

        public override string ToString()
        {
            return $"{nome}\t{cognome}\t{email}\t{telefono}";
        }

    }
}
