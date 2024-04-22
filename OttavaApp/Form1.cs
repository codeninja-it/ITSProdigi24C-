namespace OttavaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuEsci_Click(object sender, EventArgs e)
        {
            DialogResult scelta = MessageBox.Show(
                "Sei sicuro?",
                "Uscita dall'applicazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(scelta == DialogResult.Yes)
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
                this.Text = dlgApri.FileName;
                string testo = File.ReadAllText(dlgApri.FileName);
                MessageBox.Show(
                    $"il file è lungo {testo.Length} caratteri",
                    "Aperuta file",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void mnuSalva_Click(object sender, EventArgs e)
        {
            dlgSalva.Title = "Salva catalogo";
            dlgSalva.Filter = "File JSON|*.json";
            DialogResult risultato = dlgSalva.ShowDialog();
            if(risultato == DialogResult.OK)
            {
                File.WriteAllText(dlgSalva.FileName, "qualcosa");
            }
        }

        private void dlgSalva_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
