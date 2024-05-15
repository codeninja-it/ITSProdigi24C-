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
    public partial class FrmImmagini : Form
    {
        private Catalogo attuale;
        public FrmImmagini(Catalogo aperto)
        {
            InitializeComponent();
            attuale = aperto;
            AggiornaLista();
        }

        private void FrmImmagini_Shown(object sender, EventArgs e)
        {

        }

        private void AggiornaLista()
        {
            lstImmagini.Items.Clear();
            foreach (Immagine singola in attuale.immagini)
            {
                lstImmagini.Items.Add(singola);
            }
        }

        private void mnuAggiungi_Click(object sender, EventArgs e)
        {
            if (dlgImmagini.ShowDialog() == DialogResult.OK)
            {
                Immagine nuova = new Immagine(
                    Path.GetFileNameWithoutExtension(dlgImmagini.FileName),
                    Convert.ToBase64String(
                            File.ReadAllBytes(
                                                dlgImmagini.FileName
                                             )
                    )
                );
                attuale.immagini.Add(nuova);
                AggiornaLista();
            }
        }

        private void mnuCancella_Click(object sender, EventArgs e)
        {
            if (lstImmagini.SelectedItem != null)
            {
                attuale.immagini.Remove((Immagine)lstImmagini.SelectedItem);
                AggiornaLista();
            }
        }

        private void mnuSostituisci_Click(object sender, EventArgs e)
        {
            if(lstImmagini.SelectedItem != null && dlgImmagini.ShowDialog() == DialogResult.OK)
            {
                Immagine daModificare = (Immagine)lstImmagini.SelectedItem;
                daModificare.nome = Path.GetFileNameWithoutExtension(dlgImmagini.FileName);
                daModificare.immagine = Convert.ToBase64String( File.ReadAllBytes(dlgImmagini.FileName) );
                AggiornaLista();
            }
        }
    }
}
