using OttavaApp.strutture;
using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace OttavaApp;

public class ServerWeb
{
    private HttpListener linea;
    private bool inAscolto = false;
    private TextBox txtRisultato;
    private Catalogo inUso;

    public ServerWeb(TextBox campoTesto, Catalogo aperto)
    {
        txtRisultato = campoTesto;
        linea = new HttpListener();
        linea.Prefixes.Add("http://127.0.0.1:12345/");
        inUso = aperto;
    }

    public void Stop()
    {
        inAscolto = false;
    }

    public async void Inizia()
    {
        txtRisultato.Text = "";
        linea.Start();
        inAscolto = true;
        while (inAscolto)
        {
            HttpListenerContext chiamata = await linea.GetContextAsync();
            txtRisultato.Text += $"{DateTime.Now}\t{chiamata.Request.RawUrl}\r\n";
            Analizza(chiamata.Request, chiamata.Response);
        }
    }

    public async void Analizza(HttpListenerRequest richiesta, HttpListenerResponse risposta)
    {
        string buffer = "";
        switch (richiesta.RawUrl)
        {
            case "/favicon.ico":
                break;

            case "/stile.css":
                buffer = File.ReadAllText(Path.Combine("templates", "stile.css"));
                break;

            case "/":
                buffer = File.ReadAllText(Path.Combine("templates", "indice.htm"));
                buffer = buffer.Replace("[catalogo]", inUso.nome);
                break;

            default:
                string[] segmenti = richiesta.RawUrl
                                    .Split("/")
                                    .Where(x => x != "")
                                    .ToArray();
                if (segmenti.Length == 1)
                {
                    Categoria trovata = inUso.categorie.FirstOrDefault(x => x.categoria == segmenti[0]);
                    if (trovata != null)
                    {
                        buffer = trovata.ToHTML(inUso.prodotti, true);
                    }
                }
                else if (segmenti.Length == 2) 
                {
                    Categoria trovata = inUso.categorie.FirstOrDefault(x => x.categoria == segmenti[0]);
                    Prodotto trovato = inUso.prodotti.FirstOrDefault(x => x.nome == segmenti[1]);
                    if(trovata != null && trovato != null)
                    {
                        buffer = trovato.ToHTML(trovata, inUso.immagini);
                    }
                }
                break;
        }
        risposta.OutputStream.Write( Encoding.UTF8.GetBytes(buffer) );
        risposta.OutputStream.Close();
    }
}
