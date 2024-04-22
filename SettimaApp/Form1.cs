using SettimaApp.strutture;

namespace SettimaApp
{
    public partial class Form1 : Form
    {
        private Rubrica rubrica;

        public Form1()
        {
            InitializeComponent();
            rubrica = new Rubrica("prima");
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // aprire il form di inserimento nuovo contatto
            SchedaContatto contatto = new SchedaContatto();
            rubrica.contatti.Add(contatto);
            NuovoContatto formGestioneContatto = new NuovoContatto("Scheda contatto", contatto);
            formGestioneContatto.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lstContatti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstContatti.SelectedItem != null)
            {
                if (chkCancella.Checked)
                {
                    SchedaContatto daCancellare = (SchedaContatto)lstContatti.SelectedItem;
                    rubrica.contatti.Remove(daCancellare);
                    Form1_Activated(this, EventArgs.Empty);
                }
                else
                {
                    SchedaContatto selezionato = (SchedaContatto)lstContatti.SelectedItem;
                    NuovoContatto finestra = new("Modifica contatto", selezionato);
                    finestra.Show();
                }
            }    
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            rubrica.Salva();
            lstContatti.Items.Clear();
            foreach(SchedaContatto singolo in rubrica.contatti)
            {
                lstContatti.Items.Add(singolo);
            }
        }
    }
}
