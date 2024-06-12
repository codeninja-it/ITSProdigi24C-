using System.Net;
using System.Text.Json;

namespace UndicesimaApp;

public partial class AnasPage : ContentPage
{
	public AnasPage()
	{
		InitializeComponent();
	}

    private async void btnCerca_Clicked(object sender, EventArgs e)
    {
		Location? posizione = await Geolocation.GetLocationAsync();
        if (posizione != null)
        {
            HttpClient browser = new HttpClient();
            HttpResponseMessage risposta = await browser.GetAsync("https://www.stradeanas.it/it/anas/app/vai/getevents?regione=&strada=&par=0pU8SGhWy&single_data=EVENTI_INIT_3");
            if(risposta.StatusCode == HttpStatusCode.OK)
            {
                string flusso = await risposta.Content.ReadAsStringAsync();
                RispostaAnas tutti = JsonSerializer.Deserialize<RispostaAnas>(flusso);
                int perOggi = tutti.eventi.Count();
                txtRisposta.Text = $"{perOggi} eventi previsti";
            }
        }
    }
}