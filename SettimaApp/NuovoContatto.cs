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
        private ListBox destinazione;
        public NuovoContatto(string titolo, ListBox dove)
        {
            InitializeComponent();
            this.Text = titolo;
            destinazione = dove;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            destinazione.Items.Add("nuovo contatto");
            this.Close();
        }
    }
}
