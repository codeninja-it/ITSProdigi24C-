using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttavaApp.strutture
{
    public class Immagine
    {
        public Immagine(string nome, string immagine) { 
            this.nome = nome;
            this.immagine = immagine;
        }
        public string nome { get; set; }
        public string immagine { get; set; }

        public string ToHTML()
        {
            return $"<img src='data:image/jpeg;base64,{immagine}' />";
        }

        public override string ToString()
        {
            int dimkb = (int)((immagine.Length / 1.33) / 1000);
            return $"{nome}\t{dimkb}Kb";
        }
    }
}
