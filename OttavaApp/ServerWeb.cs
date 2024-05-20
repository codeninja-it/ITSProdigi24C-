using OttavaApp.strutture;
using System;
using System.Net;
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
            txtRisultato.Text += $"{DateTime.Now}\t{chiamata.Request.RawUrl}\n";
            chiamata.Response.OutputStream.Close();
        }
    }
}
