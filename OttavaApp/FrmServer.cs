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
                switch (client.Request.RawUrl)
                {
                    case "/calzini": //categoria calzini
                        
                        break;

                    default: //404
                        client.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        
                        break;
                }
                
            }

        }
    }
}
