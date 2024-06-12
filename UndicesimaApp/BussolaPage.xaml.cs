namespace UndicesimaApp;

public partial class BussolaPage : ContentPage
{
	public BussolaPage()
	{
		InitializeComponent();

        if (Compass.IsSupported)
        {
            Compass.ReadingChanged += Compass_ReadingChanged;
        } else
        {
            txtDirezione.Text = "non supportato";
        }

       

	}

    private void Compass_ReadingChanged(object sender, CompassChangedEventArgs e)
    {
        txtDirezione.Text = $"{e.Reading.HeadingMagneticNorth:N2}°";
    }

    private void btnAttiva_Clicked(object sender, EventArgs e)
    {
        if (Compass.IsMonitoring)
        {
            Compass.Stop();
            btnAttiva.Text = "attiva";
        } else
        {
            Compass.Start(SensorSpeed.UI);
            btnAttiva.Text = "spegni";
        }
    }
}