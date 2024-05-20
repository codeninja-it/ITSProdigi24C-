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
        private ServerWeb server;
        private Catalogo aperto;
        public FrmServer(Catalogo catalogo)
        {
            InitializeComponent();
            aperto = catalogo;

            server = new ServerWeb(txtBuffer, catalogo);

            //server = new HttpListener();
            //server.Prefixes.Add("http://127.0.0.1:12345/");
            //server.Start();
            //while (server.IsListening)
            //{
            //    HttpListenerContext client = server.GetContext();
            //    client.Response.ContentType = "text/html";
            //    string buffer = $"<html><body><h1>{aperto.nome}</h1></body></html>";
            //    byte[] pacchetto = null;
            //    // /[categoria]/[prodotto]/
            //    string[] segmenti = client.Request.RawUrl.Split('/');

            //    if(segmenti.Length == 2)
            //    {
            //        string categoria = segmenti[1];
            //        Categoria selezionata = aperto.categorie
            //            .FirstOrDefault(x => x.categoria == categoria);
            //        if(selezionata != null)
            //        {
            //            buffer = selezionata.ToHTML(aperto.prodotti);
            //        }
            //    } else if (segmenti.Length == 3)
            //    {
            //        string categoria = segmenti[1];
            //        string prodotto = segmenti[2];
            //        Prodotto selezionato = aperto.prodotti.FirstOrDefault(x => x.nome == prodotto);
            //        Categoria selezionata = aperto.categorie.FirstOrDefault(x => x.categoria == categoria);
            //        buffer = selezionato.ToHTML(selezionata, aperto.immagini);
            //    }
            //    pacchetto = Encoding.UTF8.GetBytes(buffer);
            //    client.Response.OutputStream.Write(pacchetto);
            //    client.Response.OutputStream.Close();
            //}

        }

        private void mnuAvvia_Click(object sender, EventArgs e)
        {
            server.Inizia();
        }

        private void mnuFerma_Click(object sender, EventArgs e)
        {
            server.Stop();
        }
    }
}
