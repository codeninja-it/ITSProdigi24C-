using OttavaApp.strutture;

namespace OttavaApp
{
    public partial class Form1 : Form
    {
        private Catalogo catalogoAperto;

        public Form1()
        {
            InitializeComponent();
            catalogoAperto = new Catalogo();
        }

        private void mnuEsci_Click(object sender, EventArgs e)
        {
            DialogResult scelta = MessageBox.Show(
                "Sei sicuro?",
                "Uscita dall'applicazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (scelta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mnuNuovo_Click(object sender, EventArgs e)
        {

        }

        private void mnuApri_Click(object sender, EventArgs e)
        {
            dlgApri.Title = "Apri file di catalogo";
            dlgApri.Filter = "File JSON|*.json|Tutti i files|*.*";
            DialogResult scelta = dlgApri.ShowDialog();
            if (scelta == DialogResult.OK)
            {
                catalogoAperto = Catalogo.Apri(dlgApri.FileName);
                catalogoAperto.MostraProdotti(lstProdotti);
            }
        }

        private void mnuSalva_Click(object sender, EventArgs e)
        {
            dlgSalva.Title = "Salva catalogo";
            dlgSalva.Filter = "File JSON|*.json";
            DialogResult risultato = dlgSalva.ShowDialog();
            if (risultato == DialogResult.OK)
            {
                catalogoAperto.Salva(dlgSalva.FileName);
            }
        }

        private void dlgSalva_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void mnuAggiungiProdotto_Click(object sender, EventArgs e)
        {
            FrmProdotto nuovaFinestra = new FrmProdotto();
            nuovaFinestra.ShowDialog();
            // dopo che ha scelto, continuiamo
            if (nuovaFinestra.prodotto != null)
            {
                catalogoAperto.AddProdotto(nuovaFinestra.prodotto);
            }

            catalogoAperto.MostraProdotti(lstProdotti);
        }

        private void mnuCancellaProdotto_Click(object sender, EventArgs e)
        {
            DialogResult risultato = MessageBox.Show("Sei sicuro?",
                                                        "Cancellazione prodotti",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
            if (risultato == DialogResult.Yes)
            {
                foreach (Prodotto selezionato in lstProdotti.SelectedItems)
                {
                    catalogoAperto.prodotti.Remove(selezionato);
                }
                catalogoAperto.MostraProdotti(lstProdotti);
            }
        }

        private void mnuModificaProdotto_Click(object sender, EventArgs e)
        {
            foreach(Prodotto selezionato in lstProdotti.SelectedItems)
            {
                FrmProdotto nuovaFinestra = new FrmProdotto();
                nuovaFinestra.prodotto = selezionato;
                nuovaFinestra.Show();
            }
        }
    }
}
