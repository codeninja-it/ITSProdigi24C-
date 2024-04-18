namespace SettimaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // aprire il form di inserimento nuovo contatto
            NuovoContatto nuova = new NuovoContatto("Scheda contatto", lstContatti);
            nuova.Show();
        }
    }
}
