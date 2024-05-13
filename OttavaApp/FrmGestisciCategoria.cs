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
    public partial class FrmGestisciCategoria : Form
    {
        private Categoria selezionata;
        public FrmGestisciCategoria(Categoria daModficare)
        {
            InitializeComponent();
            selezionata = daModficare;
            txtCategoria.Text = selezionata.categoria;
            txtDescrizione.Text = selezionata.descrizione;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            selezionata = null;
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            selezionata.categoria = txtCategoria.Text;
            selezionata.descrizione = txtDescrizione.Text;
            this.Close();
        }
    }
}
