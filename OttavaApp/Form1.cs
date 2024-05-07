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
            catalogoAperto = new Catalogo();
            catalogoAperto.MostraProdotti(lstProdotti);
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
            nuovaFinestra.categorie = catalogoAperto.categorie;
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
            foreach (Prodotto selezionato in lstProdotti.SelectedItems)
            {
                FrmProdotto nuovaFinestra = new FrmProdotto();
				nuovaFinestra.categorie = catalogoAperto.categorie;
				nuovaFinestra.prodotto = selezionato;
				nuovaFinestra.Show(); 
            }
        }

        private void mnuCategorie_Click(object sender, EventArgs e)
        {
            (new FrmCategorie(catalogoAperto)).ShowDialog();

        }

        private void mnuHTML_Click(object sender, EventArgs e)
        {
            // crea un file .htm per ogni prodotto + 1 file htm per ogni categoria
            // creando i link per la navigazione nel sito statico
            string pathCatalogo = catalogoAperto.nome;
            Directory.CreateDirectory(pathCatalogo);
            // catalogo1/
            foreach (Categoria categoria in catalogoAperto.categorie)
            {
                // creo la pagina di categoria -> /catalogo1/vestiti.htm
               
                File.WriteAllText(Path.Combine(pathCatalogo, $"{categoria.categoria}.htm"), categoria.ToHTML() );

                // per ogni prodotto
                string pathCategoria = Path.Combine(pathCatalogo, categoria.categoria);
                Directory.CreateDirectory(pathCategoria);
                // /catalogo1/vestiti/
                List<Prodotto> selezionati = catalogoAperto.prodotti.Where(x => x.categorie.Contains(categoria.idCategoria)).ToList();
                foreach(Prodotto prodotto in selezionati)
                {
                    // creo la pagina di prodotto dentr alla categoria
                    // catalogo1/vestiti/cappello.htm
                    File.WriteAllText(Path.Combine(pathCategoria, $"{prodotto.nome}.htm"), "");
                }
            }
            File.WriteAllText(Path.Combine(pathCatalogo, "index.htm"), "");
            MessageBox.Show("Esportazione terminata con successo!", "Esporta HTML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
