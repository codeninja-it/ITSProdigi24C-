using System;
using System.Collections.Generic;
using System.Globalization;
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
        public string descrizione_causa { get; set; }
        public string des_compartimento { get; set; }

        public double Distanza(double lat, double lon)
        {
            double y = Convert.ToDouble(this.latitudine, CultureInfo.GetCultureInfo("en-US"));
            double x = Convert.ToDouble(this.longitudine, CultureInfo.GetCultureInfo("en-US"));
            double deltaY = lat - y;
            double deltaX = lon - x;
            return Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
        }
    }
}
