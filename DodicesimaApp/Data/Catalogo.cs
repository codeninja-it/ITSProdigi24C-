using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodicesimaApp.Data
{
    public class Catalogo
    {
        public List<Prodotto> prodotti { get; set; }

        public Catalogo()
        {
            prodotti = new List<Prodotto>() { 
                new Prodotto() {nome = "mouse", descrizione="mouse logitech", prezzo=5 },
                new Prodotto() {nome = "ThinkStation Lenovo", descrizione="mini pc", prezzo=400 },
                new Prodotto() {nome = "webcam jepssen", descrizione="webcam da 1080p auto-focus", prezzo=15 }
            };
        }
    }
}
