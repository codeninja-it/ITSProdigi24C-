using SettimaApp.strutture;

namespace SettimaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.GotFocus += Form1_GotFocus;
        }

        private void Form1_GotFocus(object? sender, EventArgs e)
        {
            lstContatti.Invalidate();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // aprire il form di inserimento nuovo contatto
            SchedaContatto contatto = new("", "", "", "");
            lstContatti.Items.Add(contatto);
            NuovoContatto nuova = new NuovoContatto("Scheda contatto", contatto);
            nuova.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lstContatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lstContatti.SelectedItem);
        }
    }
}
