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

        private bool[,] RecuperaMatrice(Bitmap immagine)
        {
            bool[,] risultato = new bool[immagine.Width, immagine.Height];
            for(int x = 0; x < immagine.Width; x++)
            {
                for( int y = 0;y < immagine.Height; y++)
                {
                    bool muro = immagine.GetPixel(x, y) == Color.Black;
                    risultato[x, y] = muro;
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
                    sfuocata.SetPixel(x-1, y-1, medio);
                    sfuocata.SetPixel(x-1, y, medio);
                    sfuocata.SetPixel(x-1, y+1, medio);
                    sfuocata.SetPixel(x, y-1, medio);
                    sfuocata.SetPixel(x, y, medio);
                    sfuocata.SetPixel(x, y+1, medio);
                    sfuocata.SetPixel(x+1, y-1, medio);
                    sfuocata.SetPixel(x+1, y, medio);
                    sfuocata.SetPixel(x+1, y+1, medio);
                }
            }
            sfuocata.Save(btnApri.Text.Replace(".png", ".media.png"), ImageFormat.Png);
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
            CalcolaMedia(immagine);
            CalcolaBordi(immagine);
            bool[,] muri = RecuperaMatrice(immagine);
            List< List<Point> > poligoni = new List<List<Point>>();
            List<Point> quadrato = new List<Point>();
            quadrato.Add(new Point(0, 0));
            quadrato.Add(new Point(0, 10));
            quadrato.Add(new Point(10, 10));
            quadrato.Add(new Point(10, 0));
            quadrato.Add(new Point(0, 0));

            poligoni.Add(quadrato);

            poligoni.Clear();

            IntercettaPoligoni(muri, poligoni);

        }

        public void IntercettaPoligoni(bool[,] muri, List<List<Point>> poligoni)
        {
            for(int x = 0; x < muri.GetLength(0); x++)
            {
                for (int y = 0; y < muri.GetLength(1); y++)
                {
                    if (muri[x, y])
                    {

                    }
                }
            }
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
