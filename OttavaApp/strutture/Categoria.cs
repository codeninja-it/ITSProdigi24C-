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
        public string motto { get; set; } = "";
        public string descrizione { get; set; } = "";

        public string ToHTML()
        {
			return File.ReadAllText(Path.Combine("templates", "categoria.htm"))
								   .Replace("[nome]", this.categoria)
								   .Replace("[descrizione]", this.descrizione.Replace("\r\n", "<br>") )
								   .Replace("[motto]", this.motto)
								   .Replace("[quando]", this.creazione.ToString("dd/MM/yyyy"));
		}

        public override string ToString()
        {
            return this.categoria;
        }
    }
}
