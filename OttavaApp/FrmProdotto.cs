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
        public List<Immagine> immagini { get; set; }
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

            if(lstImmagini.SelectedItem != null)
            {
                this.prodotto.immagine = ((Immagine)lstImmagini.SelectedItem).nome;
            } else
            {
                this.prodotto.immagine = "";
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
            // carico la lista delle immagini
            lstImmagini.Items.Clear();
            foreach(Immagine singola in immagini)
            {
                lstImmagini.Items.Add(singola);
                if(singola.nome == prodotto.immagine)
                {
                    lstImmagini.SelectedItem = singola;
                }
            }
        }

    }
}
