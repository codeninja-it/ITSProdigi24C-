namespace SestaApp
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Caricamento(object sender, EventArgs e)
        {

        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Int16 altezza = (Int16)numAltezza.Value;
            Int16 peso = (Int16)numPeso.Value;
            double BMI = peso / (altezza * altezza);
            string descrizione = "";

            switch (BMI)
            {
                case <= 16.5:
                    descrizione = "Sottopeso severo";
                    break;
                case <= 18.4:
                    descrizione = "Sottpeso";
                    break;
                case <= 24.9:
                    descrizione = "Normale";
                    break;
                case <= 30:
                    descrizione = "Sovrappeso";
                    break;
                case <= 34.9:
                    descrizione = "Obesità 1°";
                    break;
                case <= 40:
                    descrizione = "Obesità 2°";
                    break;
                default:
                    descrizione = "Obesità 3°";
                    break;
            }

            //txtRisultato.Text = $"Il BMI è {BMI:N2}, ovvero...";
            txtRisultato.Text = $"Il BMI è {BMI:N2}, ovvero, {descrizione}";
        }
    }
}
