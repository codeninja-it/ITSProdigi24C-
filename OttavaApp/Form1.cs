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
            Close();
        }

        private void mnuNuovo_Click(object sender, EventArgs e)
        {

        }

        private void mnuApri_Click(object sender, EventArgs e)
        {
            dlgApri.Title = "Apri file di catalogo";
            DialogResult scelta = dlgApri.ShowDialog();
            if(scelta == DialogResult.OK)
            {
                MessageBox.Show(
                    $"Apro il file {dlgApri.FileName}", 
                    "Aperuta file", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
            }
        }

        private void mnuSalva_Click(object sender, EventArgs e)
        {

        }
    }
}
