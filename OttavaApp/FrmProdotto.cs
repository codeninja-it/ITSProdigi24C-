using OttavaApp.strutture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OttavaApp
{
    public partial class FrmProdotto : Form
    {
        public Prodotto prodotto { get; set; }
        public List<Categoria> categorie { get; set; }
        public FrmProdotto()
        {
            InitializeComponent();
            prodotto = new Prodotto();

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {

            this.prodotto = null;
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            this.prodotto.descrizione = txtDescrizione.Text;
            this.prodotto.nome = txtNome.Text;
            this.prodotto.prezzo = (double)numPrezzo.Value;

            if(txtImmagine.Text != "")
            {
                // gestione dell'immagine [collegamento]
                this.prodotto.immagine = txtImmagine.Text;
                // gestione dell'immagine [inclusione]
                byte[] contenuto = File.ReadAllBytes( txtImmagine.Text );
                string immagineBase64 = Convert.ToBase64String(contenuto);
                this.prodotto.immagine = immagineBase64;
            }

            this.prodotto.categorie.Clear();
            foreach (Categoria singola in lstCategorie.SelectedItems)
            {
                this.prodotto.categorie.Add(singola.idCategoria);
            }
            this.Close();
        }

        private void FrmProdotto_Shown(object sender, EventArgs e)
        {
            // imposto gli attributi
            txtNome.Text = this.prodotto.nome;
            numPrezzo.Value = (decimal)this.prodotto.prezzo;
            txtDescrizione.Text = this.prodotto.descrizione;
            // carico la lista delle categorie
            lstCategorie.Items.Clear();
            foreach (Categoria singola in categorie)
            {
                lstCategorie.Items.Add(singola);
                // imposto le categorie selezionate
                if (this.prodotto.categorie.Contains(singola.idCategoria))
                {
                    lstCategorie.SelectedItems.Add(singola);
                }
            }
        }

        private void btnImmagine_Click(object sender, EventArgs e)
        {
            DialogResult risultato = dlgImmagine.ShowDialog();
            if(risultato == DialogResult.OK)
            {
                string pathImmagine = dlgImmagine.FileName;
                // collego il file al prodotto
                txtImmagine.Text = pathImmagine;
            }
        }
    }
}
