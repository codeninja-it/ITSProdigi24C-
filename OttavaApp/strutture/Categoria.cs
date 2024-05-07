using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttavaApp.strutture
{
    public class Categoria : CampiCondivisi
    {
        public uint idCategoria { get; set; } = 1;
        public string categoria { get; set; } = "";
        public string descrizione { get; set; } = "";
        public override string ToString()
        {
            return this.categoria;
        }
    }
}
