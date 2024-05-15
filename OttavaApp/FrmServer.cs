using OttavaApp.strutture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace OttavaApp
{
    public partial class FrmServer : Form
    {
        private HttpListener server;
        private Catalogo aperto;
        public FrmServer(Catalogo catalogo)
        {
            InitializeComponent();
            aperto = catalogo;
            server = new HttpListener();
            server.Prefixes.Add("http://127.0.0.1:12345/");
            server.Start();
            while (server.IsListening)
            {
                HttpListenerContext client = server.GetContext();
                client.Response.ContentType = "text/html";
                string risposta = "";
                byte[] pacchetto = null;
                switch (client.Request.RawUrl)
                {
                    case "/calzini": //categoria calzini
                        client.Response.StatusCode = (int)HttpStatusCode.OK;
                        risposta = "<html><body><h1>Calzini</h1></body></html>";
                        pacchetto = Encoding.UTF8.GetBytes(risposta);
                        client.Response.OutputStream.Write(pacchetto);
                        client.Response.Close();
                        break;

                    default: //404
                        client.Response.StatusCode = (int)HttpStatusCode.NotFound;
                        risposta = $"<html><body>Non trovato<br>{client.Request.RawUrl}</body></html>";
                        pacchetto = Encoding.UTF8.GetBytes(risposta);
                        client.Response.OutputStream.Write(pacchetto);
                        client.Response.OutputStream.Close();
                        break;
                }
                
            }

        }
    }
}
