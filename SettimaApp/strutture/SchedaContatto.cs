using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettimaApp.strutture
{
    public class SchedaContatto
    {
        public string nome { get; set; } = "";
        public string cognome { get; set; } = "";
        public string email { get; set; } = "";
        public string telefono { get; set; } = "";
        public DateTime creazione { get; set; } = DateTime.Now;
        public DateTime modifica { get; set; } = DateTime.Now;

        public string nomeCompleto => $"{nome} {cognome}";

        public SchedaContatto()
        { 
        
        }

        public override string ToString()
        {
            return $"{nome} {cognome}";
        }
    }
}
