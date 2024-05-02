using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttavaApp.strutture
{
    public class Prodotto : CampiCondivisi
    {
        public int idProdotto { get; set; }
        public string nome { get; set; }
        public double prezzo { get; set; }
        public List<int> categorie { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{nome}\t{prezzo:N2}";
        }
    }
}
