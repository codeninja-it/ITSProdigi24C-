using System.Drawing.Imaging;

namespace NonaApp
{
    public partial class Form1 : Form
    {
        private List<TracciaBordi.XY[]> poligoni;
        private Bitmap fotoSatellitare;

        public Form1()
        {
            InitializeComponent();
            btnCalcola.Enabled = false;
            lblHueStart.Text = $"Da {trkHueStart.Value:N0}�";
            lblHueStop.Text = $"A {trkHueStop.Value:N0}�";
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            DialogResult risultato = dlgImmagine.ShowDialog();
            if (risultato == DialogResult.OK)
            {
                btnApri.Text = dlgImmagine.FileName;
                btnCalcola.Enabled = true;
                fotoSatellitare = (Bitmap)Image.FromFile(dlgImmagine.FileName);
                pctAnteprima.Image = fotoSatellitare;
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

        private bool[,] RecuperaMatrice(Bitmap immagine)
        {
            bool[,] risultato = new bool[immagine.Width, immagine.Height];
            for (int x = 0; x < immagine.Width; x++)
            {
                for (int y = 0; y < immagine.Height; y++)
                {
                    if (immagine.GetPixel(x, y) == Color.Black)
                    {
                        risultato[x, y] = true;
                    }
                    else
                    {
                        risultato[x, y] = false;
                    }
                }
            }
            return risultato;
        }



        private void CalcolaMedia(Bitmap immagine)
        {
            Bitmap sfuocata = new Bitmap(immagine.Width, immagine.Height);
            for (int x = 1; x < immagine.Width - 1; x++)
            {
                for (int y = 1; y < immagine.Height - 1; y++)
                {
                    // recupero il centro
                    Color centro = immagine.GetPixel(x, y);
                    // ed i suoi vicini (destra e sotto)
                    int somma = centro.R +
                                immagine.GetPixel(x - 1, y - 1).R + // top-left
                                immagine.GetPixel(x, y - 1).R + // top
                                immagine.GetPixel(x + 1, y - 1).R + // top-right
                                immagine.GetPixel(x - 1, y).R + // left
                                immagine.GetPixel(x + 1, y).R + // right
                                immagine.GetPixel(x - 1, y + 1).R + // bottom-left
                                immagine.GetPixel(x, y + 1).R + // bottom
                                immagine.GetPixel(x + 1, y + 1).R; // bottom-right
                    int media = somma / 9;
                    Color medio = Color.FromArgb(255, media, media, media);
                    sfuocata.SetPixel(x - 1, y - 1, medio);
                    sfuocata.SetPixel(x - 1, y, medio);
                    sfuocata.SetPixel(x - 1, y + 1, medio);
                    sfuocata.SetPixel(x, y - 1, medio);
                    sfuocata.SetPixel(x, y, medio);
                    sfuocata.SetPixel(x, y + 1, medio);
                    sfuocata.SetPixel(x + 1, y - 1, medio);
                    sfuocata.SetPixel(x + 1, y, medio);
                    sfuocata.SetPixel(x + 1, y + 1, medio);
                }
            }
            sfuocata.Save(btnApri.Text.Replace(".png", ".media.png"), ImageFormat.Png);
        }

        private bool[,] CalcolaMatrice(Bitmap immagine)
        {
            bool[,] bordi = new bool[immagine.Width, immagine.Height];
            for (int x = 0; x < immagine.Width - 1; x++)
            {
                for (int y = 0; y < immagine.Height - 1; y++)
                {
                    // recupero il pixel
                    Color analizzato = immagine.GetPixel(x, y);
                    // ed i suoi vicini (destra e sotto)
                    Color vicinoDX = immagine.GetPixel(x + 1, y);
                    Color vicinoBT = immagine.GetPixel(x, y + 1);
                    // se sono differenti
                    if (analizzato.R != vicinoDX.R || analizzato.R != vicinoBT.R)
                    {
                        bordi[x, y] = true;
                    }
                    else
                    {
                        bordi[x, y] = false;
                    }
                }
            }
            return bordi;
        }

        private Bitmap CalcolaBordi(Bitmap immagine)
        {
            Bitmap bordi = new Bitmap(immagine.Width, immagine.Height);
            for (int x = 0; x < immagine.Width - 1; x++)
            {
                for (int y = 0; y < immagine.Height - 1; y++)
                {
                    // recupero il pixel
                    Color analizzato = immagine.GetPixel(x, y);
                    // ed i suoi vicini (destra e sotto)
                    Color vicinoDX = immagine.GetPixel(x + 1, y);
                    Color vicinoBT = immagine.GetPixel(x, y + 1);
                    // se sono differenti
                    if (analizzato.R != vicinoDX.R || analizzato.R != vicinoBT.R)
                    {
                        bordi.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bordi.SetPixel(x, y, Color.White);
                    }
                }
            }
            //bordi.Save(btnApri.Text.Replace(".png", ".bordi.png"), ImageFormat.Png) ;
            return bordi;
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            Bitmap immagine = new Bitmap(btnApri.Text);
            float bottom = trkHueStart.Value;
            float top = trkHueStop.Value;
            CalcolaTreshold(immagine, bottom, top);
            //CalcolaMedia(immagine);
            Bitmap bordi = CalcolaBordi(immagine);
            pctAnteprima.Image = bordi;
            bool[,] muri = CalcolaMatrice(immagine);

            TracciaBordi tracciatore = new(muri);
            poligoni = tracciatore.Scansiona();

            // pulizia dei segmenti non utili
            poligoni = tracciatore.Pulisci();

            poligoni = tracciatore.SemplificaDP(10, poligoni);
            poligoni = tracciatore.ARIMA(5, poligoni);

            txtRisultato.Text += $"\r\nPoligoni trovati : {poligoni.Count}";
            lstPoligoni.Items.Clear();
            foreach (TracciaBordi.XY[] singolo in poligoni)
            {
                lstPoligoni.Items.Add("poly da " + singolo.Length + " vertici");
            }
        }

        private void trkHueStart_Scroll(object sender, EventArgs e)
        {
            lblHueStart.Text = $"Da {trkHueStart.Value:N0}�";
        }

        private void trkHueStop_Scroll(object sender, EventArgs e)
        {
            lblHueStop.Text = $"A {trkHueStop.Value:N0}�";
        }

        private void lstPoligoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap selezione = new Bitmap(fotoSatellitare);
            Graphics penna = Graphics.FromImage(selezione);
            txtRisultato.Text = "";
            foreach (int indice in lstPoligoni.SelectedIndices)
            {
                TracciaBordi.XY[] selezionato = poligoni[indice];
                txtRisultato.Text += $"poligono {indice}: ";
                List<Point> punti = new();
                foreach (TracciaBordi.XY vertice in selezionato)
                {
                    txtRisultato.Text += $"[{vertice.X} {vertice.Y}] ";
                    punti.Add(new Point(vertice.X, vertice.Y));
                }
                penna.FillPolygon(Brushes.Red, punti.ToArray());
            }
            pctAnteprima.Image = selezione;
        }
    }
}
