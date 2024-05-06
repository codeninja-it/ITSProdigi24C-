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
    public partial class FrmCategorie : Form
    {
        private Catalogo catalogoAttivo;
        public FrmCategorie(Catalogo catalogo)
        {
            InitializeComponent();
            catalogoAttivo = catalogo;
            AggiornaLista();
        }

        private void AggiornaLista()
        {
            lstCategorie.Items.Clear();
            foreach (Categoria singola in catalogoAttivo.categorie)
            {
                lstCategorie.Items.Add(singola);
            }
        }

        private void mnuCancella_Click(object sender, EventArgs e)
        {
            if (lstCategorie.SelectedItem != null)
            {
                catalogoAttivo.categorie.Remove((Categoria)lstCategorie.SelectedItem);
                AggiornaLista();
            }
        }

        private void mnuModifica_Click(object sender, EventArgs e)
        {
            if(lstCategorie.SelectedItem != null)
            {
                // avendo una categoria a disposizione
                // fare quello che voglio
                (new FrmGestisciCategoria((Categoria)lstCategorie.SelectedItem)).ShowDialog();
                AggiornaLista();
            }
        }

        private void mnuAggiungi_Click(object sender, EventArgs e)
        {
            // avendo una categoria a disposizione
            Categoria nuovo = new();
            if (catalogoAttivo.categorie.Any())
            {
                nuovo.idCategoria = catalogoAttivo
                                .categorie
                                .Max(x => x.idCategoria) + 1;
            }
            
            // fare quello che voglio
            (new FrmGestisciCategoria(nuovo)).ShowDialog();
            if(nuovo != null)
            {
                // salvare il nuovo elemento
                catalogoAttivo.categorie.Add(nuovo);
                AggiornaLista();
            }
            
        }
    }
}
