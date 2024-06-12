using System.Drawing;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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
                List<EventoAnas> ordinati = tutti.eventi
                                                .OrderBy(x => x.Distanza(posizione.Latitude, posizione.Longitude))
                                                .Take(10)
                                                .ToList();
                // tolgo i risultati precedenti
                lstRisultati.Clear();
                foreach (EventoAnas singolo in ordinati)
                {
                    Label nuova = new Label();
                    nuova.Text = $"{singolo.des_compartimento}: {singolo.sigla_strada}\n{singolo.descrizione_causa}";
                    nuova.BackgroundColor = Colors.Wheat;
                    nuova.Padding = 5;
                    lstRisultati.Add(nuova);
                }
            }
        }
    }
}