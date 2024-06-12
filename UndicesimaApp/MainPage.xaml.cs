namespace UndicesimaApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGPS_Clicked(object sender, EventArgs e)
        {
            // apriamo una nuova finestra verso il GPS
            Navigation.PushAsync(new GPSPage());
        }

        private void btnBussola_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BussolaPage());
        }
    }

}
