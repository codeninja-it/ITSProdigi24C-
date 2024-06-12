using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndicesimaApp
{
    public class RispostaAnas
    {
        public List<EventoAnas> eventi { get; set; }
    }

    public class EventoAnas
    {
        public string id { get; set; }
        public string data { get; set; }
        public string latitudine { get; set; }
        public string longitudine { get; set; }
        public string sigla_strada { get; set; }
    }
}
