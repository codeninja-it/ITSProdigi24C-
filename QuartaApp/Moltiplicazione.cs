using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartaApp
{
    internal class Moltiplicazione : Tabellina
    {
        public Moltiplicazione(int baseOperazione, int quanteVolte) : 
        base(baseOperazione, quanteVolte)
        {

        }

        public void Calcola()
        {
            buffer = "";
            for(int i=0; i < ripetizioni; i++)
            {
                buffer += $"{baseTabellina} * {i} = {baseTabellina*i}\n";
            }
        }

        public override string ToString()
        {
            return $"Moltiplicazione del {baseTabellina}";
        }
    }
}
