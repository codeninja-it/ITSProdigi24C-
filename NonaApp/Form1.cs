using System.Drawing.Imaging;

namespace NonaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCalcola.Enabled = false;
            lblHueStart.Text = $"Da {trkHueStart.Value:N0}°";
            lblHueStop.Text = $"A {trkHueStop.Value:N0}°";
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            DialogResult risultato = dlgImmagine.ShowDialog();
            if (risultato == DialogResult.OK)
            {
                btnApri.Text = dlgImmagine.FileName;
                btnCalcola.Enabled = true;
                pctAnteprima.Image = Image.FromFile(dlgImmagine.FileName);
            }
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Bitmap immagine = new Bitmap(btnApri.Text);
            float bottom = trkHueStart.Value;
            float top = trkHueStop.Value;
            int positivi = 0;
            txtRisultato.Text = $"threshold su hue da {bottom} a {top}\r\n";
            for (int x = 0; x < immagine.Width; x++)
            {
                for (int y = 0; y < immagine.Height; y++)
                {
                    Color trovato = immagine.GetPixel(x, y);
                    float hue = trovato.GetHue();
                    if (hue >= bottom && hue < top)
                    {
                        immagine.SetPixel(x, y, Color.White);
                        positivi++;
                    }
                    else
                    {
                        immagine.SetPixel(x, y, Color.Black);
                    }
                }
            }
            double percentuale = ((double)positivi / (immagine.Width * immagine.Height)) * 100;
            txtRisultato.Text += $"Fatto: {percentuale:N2}%";
            pctAnteprima.Image = immagine;
            immagine.Save(btnApri.Text.Replace(".png", $".{bottom:N0}.{top:N0}.png"), ImageFormat.Png);
        }

        private void trkHueStart_Scroll(object sender, EventArgs e)
        {
            lblHueStart.Text = $"Da {trkHueStart.Value:N0}°";
        }

        private void trkHueStop_Scroll(object sender, EventArgs e)
        {
            lblHueStop.Text = $"A {trkHueStop.Value:N0}°";
        }
    }
}
