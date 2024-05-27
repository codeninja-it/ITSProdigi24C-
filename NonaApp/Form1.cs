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

        private void CalcolaTreshold(Bitmap immagine, float da, float a)
        {
            int positivi = 0;
            txtRisultato.Text = $"threshold su hue da {da} a {a}\r\n";
            for (int x = 0; x < immagine.Width; x++)
            {
                for (int y = 0; y < immagine.Height; y++)
                {
                    // calcolo del threshold
                    Color trovato = immagine.GetPixel(x, y);
                    float hue = trovato.GetHue();
                    if (hue >= da && hue < a)
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
            immagine.Save(btnApri.Text.Replace(".png", $".{da:N0}.{a:N0}.png"), ImageFormat.Png);
        }

        private void CalcolaBordi(Bitmap immagine)
        {
            Bitmap bordi = new Bitmap(immagine.Width, immagine.Height);
            for(int x = 0;x < immagine.Width - 1; x++)
            {
                for( int y = 0;y < immagine.Height - 1; y++)
                {
                    // recupero il pixel
                    Color analizzato = immagine.GetPixel(x, y);
                    // ed i suoi vicini (destra e sotto)
                    Color vicinoDX = immagine.GetPixel(x + 1, y);
                    Color vicinoBT = immagine.GetPixel(x ,y + 1);
                    // se sono differenti
                    if(analizzato.R != vicinoDX.R || analizzato.R != vicinoBT.R)
                    {
                        bordi.SetPixel(x, y, Color.Black);
                    } else
                    {
                        bordi.SetPixel(x, y, Color.White);
                    }
                }
            }
            bordi.Save(btnApri.Text.Replace(".png", ".bordi.png"), ImageFormat.Png) ;
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Bitmap immagine = new Bitmap(btnApri.Text);
            float bottom = trkHueStart.Value;
            float top = trkHueStop.Value;
            CalcolaTreshold(immagine, bottom, top);
            CalcolaBordi(immagine);
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
