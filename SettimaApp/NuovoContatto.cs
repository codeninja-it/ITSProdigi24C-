using SettimaApp.strutture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SettimaApp
{
    public partial class NuovoContatto : Form
    {
        private SchedaContatto contatto;
        public NuovoContatto(string titolo, SchedaContatto contattoRicevuto)
        {
            InitializeComponent();
            this.Text = titolo;
            this.contatto = contattoRicevuto;
            txtNome.Text = contatto.nome;
            txtCognome.Text = contatto.cognome;
            txtEmail.Text = contatto.email;
            txtTelefono.Text = contatto.telefono;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            contatto.nome = txtNome.Text;
            contatto.cognome = txtCognome.Text;
            contatto.email = txtEmail.Text;
            contatto.telefono = txtTelefono.Text;
            contatto.modifica = DateTime.Now;
            this.Close();
        }
    }
}
