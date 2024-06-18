using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodicesimaApp.Data
{
    public class Carrello
    {
        public List<Prodotto> prodotti { get; set; }

        public Carrello() { 
            prodotti = new List<Prodotto>();
        }

        public double Totale()
        {
            return prodotti.Sum(x => x.prezzo);
        }

        public double TotaleIvato()
        {
            return prodotti.Sum(x => x.prezzoIvato);
        }
    }
}
