namespace UndicesimaApp;

public partial class GPSPage : ContentPage
{
	public GPSPage()
	{
        InitializeComponent();
	}

    private async void btnAttiva_Clicked(object sender, EventArgs e)
    {
        Location? posizione = await Geolocation.GetLastKnownLocationAsync();
        if(posizione != null)
        {
            txtLatitudine.Text = $"Lat: {posizione.Latitude:N6}°";
            txtLongintudine.Text = $"Lon: {posizione.Longitude:N6}°";
            txtAltitudine.Text = $"Alt: {posizione.Altitude}slm";
            txtDirezione.Text = $"Dir: {posizione.Course}°";
            txtVelocita.Text = $"Speed: {posizione.Speed}ms";
        }
    }
}