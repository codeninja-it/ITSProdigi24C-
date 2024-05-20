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

        public string ToHTML(List<Prodotto> presenti, bool online = false)
        {
            List<string> links = new List<string>();
            foreach(Prodotto singolo in presenti)
            {
                if(online)
                    links.Add(singolo.ToLink());
                else
                    links.Add(singolo.ToLink(categoria));
            }
            string linkAiProdotti = String.Join("", links);

			return File.ReadAllText( Path.Combine("templates", "categoria.htm") )
								   .Replace("[nome]", this.categoria)
								   .Replace("[descrizione]", this.descrizione.Replace("\r\n", "<br>") )
								   .Replace("[motto]", this.motto)
                                   .Replace("[prodotti]", linkAiProdotti)
								   .Replace("[quando]", this.creazione.ToString("dd/MM/yyyy"));
		}

        public override string ToString()
        {
            return this.categoria;
        }
    }
}
