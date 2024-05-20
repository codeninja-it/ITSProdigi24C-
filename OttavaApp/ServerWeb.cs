using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OttavaApp
{
    public class ServerWeb
    {
        private HttpListener linea;
        private TextBox txtRisultato;

        public ServerWeb(TextBox campoTesto)
        {
            txtRisultato = campoTesto;
            linea = new HttpListener();
            linea.Prefixes.Add("http://127.0.0.1:12345/");
        }

        public void Stop()
        {
            linea.Stop();
        }

        public async void Inizia()
        {
            linea.Start();
            while (linea.IsListening)
            {
                HttpListenerContext chiamata = linea.GetContext();
                txtRisultato.Text += $"{DateTime.Now}\t{chiamata.Request.RawUrl}\n";
            }
        }



    }
}
