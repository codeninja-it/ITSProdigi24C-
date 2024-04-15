using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintaApp.strutture
{
    internal class Contatto
    {
        public string nome;
        public string cognome;
        public string telefono;

        internal Contatto()
        {
            nome = Domanda("Che nome ha?");
            cognome = Domanda("il suo cognome?");
            telefono = Domanda("che telefono ci metto?");
        }

        private string Domanda(string testo)
        {
            Console.Write(testo);
            return Console.ReadLine();
        }

        internal Contatto(string nome, string cognome, string telefono)
        {
            this.nome = nome;
            this.telefono = telefono;
            this.cognome = cognome;
        }

        // "Jhon    Doe     12342345"
        internal Contatto(string flussoTestuale)
        {
            string[] pezzi = flussoTestuale.Split("\t");
            this.nome = pezzi[0];
            this.cognome = pezzi[1];
            this.telefono = pezzi[2];
        }

        public override string ToString()
        {
            return $"{nome}\t{cognome}\t{telefono}";
        }
    }
}
