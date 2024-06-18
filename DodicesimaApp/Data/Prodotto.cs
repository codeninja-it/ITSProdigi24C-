using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodicesimaApp.Data
{
    public class Prodotto
    {
        public string nome { get; set; }
        public string descrizione { get; set; }
        public double prezzo { get; set; }
        public int iva { get; set; } = 22;
        public double prezzoIvato => prezzo * (1 + (iva / 100));
    }
}
