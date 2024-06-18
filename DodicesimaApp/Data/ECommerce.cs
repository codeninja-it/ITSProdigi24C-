using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodicesimaApp.Data
{
    public class ECommerce
    {
        public Catalogo catalogo { get; set; }
        public Carrello carrello { get; set; }

        public ECommerce() {
            catalogo = new Catalogo();
            carrello = new Carrello();
        }
    }
}
