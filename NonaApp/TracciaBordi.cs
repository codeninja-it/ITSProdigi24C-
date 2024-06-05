using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonaApp
{
    public class TracciaBordi
    {
        public class XY
        {
            public XY(int x, int y) {
                this.X = x; 
                this.Y = y;
            }
            public int X { get; set; }
            public int Y { get; set; }

            public bool UgualeA(XY p2)
            {
                return X == p2.X && Y == p2.Y;
            }

            public double DistanzaDa(XY p2)
            {
                int dX = X - p2.X;
                int dY = Y - p2.Y;
                return Math.Sqrt(dX*dX + dY*dY);
            }

            public override string ToString()
            {
                return $"[{X} {Y}]";
            }
        }

        enum Direzione { 
            TopLeft,        // 0
            Top,            // 1
            TopRight,       // 2
            Right,          // 3
            BottomRight,    // 4
            Bottom,         // 5
            BottomLeft,     // 6
            Left            // 7
        }


        private bool[,] matrice;
        public List<XY[]> poligoni = new();
        public TracciaBordi(bool[,] matrice)
        {
            this.matrice = matrice;
        }

        public List<XY[]> Scansiona()
        {
            // resetto poligoni
            poligoni = new();
            //per ogni cella trovo un punto d'ingresso potenziale
            for (int x = 0; x < matrice.GetLength(0); x++)
            {
                for (int y = 0; y < matrice.GetLength(1); y++)
                {
                    if (matrice[x, y])
                    {
                        // e lo analizzo
                        Analizza(x, y, new XY[0]);
                    }
                }
            }

            // restituisco i poligoni trovati
            return poligoni;
        }

        private bool Analizza(int x, int y, XY[] visitati, Direzione direzione = Direzione.Left)
        {
            // se sono fuori dall'immagine esco
            if(x < 0 || y < 0 || x >= matrice.GetLength(0) || y >= matrice.GetLength(1))
                return false;

            // se sono fuori strada esco
            if (!matrice[x, y])
                return false;

            // se ci sono già passato ho finalmente un poligono chiuso!
            if (visitati.Any(e => e.X == x && e.Y == y))
            {
                // lo aggiungo alle soluzioni
                poligoni.Add(AggiungiVertice(visitati, new XY(x, y)));
                // cancello dalla matrice i visitati
                foreach(XY singolo in visitati)
                {
                    matrice[singolo.X, singolo.Y] = false;
                }
                visitati = new XY[0];
                // ed esco
                return true;
            }
           

            // se sono arrivato qui sono ancora sulla strada...
            // lascio una briciola
            XY[] finoAOra = AggiungiVertice(visitati, new XY(x, y));
            // e per ogni punto clockwise
            for(int i=1; i < 8; i++)
            {
                // calcolo il nuovo punto
                Direzione daControllare = (Direzione)(((int)direzione + i) % 8);
                // e la mia direzione
                Direzione venendoDa = (Direzione)(((int)daControllare + 4) % 8);
                switch (daControllare)
                {
                    case Direzione.TopLeft:
                        if (Analizza(x - 1, y - 1, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.Top:
                        if (Analizza(x, y - 1, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.TopRight:
                        if (Analizza(x + 1, y - 1, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.Right:
                        if(Analizza(x + 1, y, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.BottomRight:
                        if(Analizza(x + 1, y + 1, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.Bottom:
                        if(Analizza(x, y + 1, finoAOra, venendoDa))
                            return true;
                        break;

                    case Direzione.BottomLeft:
                        if(Analizza(x - 1, y + 1, finoAOra, venendoDa))
                            return true;
                        break;

                    default: // Direzione.Left
                        if(Analizza(x - 1, y, finoAOra, venendoDa))
                            return true;
                        break;
                }
            }
            // se arrivo qui senza essere uscito ho finito le caselle...
            return false;
        }

        public Bitmap Disegna()
        {
            Bitmap immagine = new Bitmap(matrice.GetLength(0), matrice.GetLength(1));
            foreach (XY[] singolo in poligoni)
            {
                if(singolo.Length < 1000)
                {
                    foreach (XY vertice in singolo)
                    {
                        immagine.SetPixel(vertice.X, vertice.Y, Color.Red);
                    }
                }
            }
            return immagine;
        }

        private XY[] AggiungiVertice(XY[] vecchioPercorso, XY vertice)
        {
            XY[] nuovo = new XY[vecchioPercorso.Length + 1];
            for(int i=0; i < vecchioPercorso.Length; i++)
            {
                nuovo[i] = vecchioPercorso[i];
            }
            nuovo[vecchioPercorso.Length] = vertice;
            return nuovo;
        }

        // eliminazione del peduncolo
        public List<XY[]> Pulisci()
        {
            List<XY[]> puliti = new List<XY[]>();
            foreach (XY[] poligono in poligoni)
            {
                poligono.Reverse();
                XY primo = poligono[0];
                XY[] nuovoTracciato = AggiungiVertice(new XY[0], primo);
                for (int i = 1; i < poligono.Length; i++)
                {
                    XY vertice = poligono[i];
                    nuovoTracciato = AggiungiVertice(nuovoTracciato, vertice);
                    if (vertice.X == primo.X && vertice.Y == primo.Y)
                        break;
                }
                if (nuovoTracciato[nuovoTracciato.Length - 1].UgualeA(nuovoTracciato[0])){
                    puliti.Add(nuovoTracciato);
                }
            }
            poligoni = puliti;
            return puliti;
        }

        // Semplificazione Douglas Peucker basata sulla distanza
        public List<XY[]> SemplificaDP(double distanza, List<XY[]> collezione)
        {
            List<XY[]> risultato = new List<XY[]>();
            foreach (XY[] poligono in collezione)
            {
                XY[] semplificato = new XY[0];
                XY controllo = poligono[0];
                for (int i = 1; i < poligono.Length; i++)
                {
                    XY daControllare = poligono[i];
                    if (controllo.DistanzaDa(daControllare) > distanza)
                    {
                        semplificato = AggiungiVertice(semplificato, daControllare);
                        controllo = daControllare;
                    }
                }
                if (semplificato.Length > 1)
                {
                    risultato.Add(semplificato);
                }
            }
            return risultato;
        }

        public XY[] AccodaBuffer(XY[] vecchio, XY punto)
        {
            XY[] nuovo = new XY[vecchio.Length];
            for (int i = 1; i < vecchio.Length; i++)
            {
                nuovo[i-1] = vecchio[i];
            }
            nuovo[vecchio.Length - 1] = punto;
            return nuovo;
        }

        public List<XY[]> ARIMA(int grado, List<XY[]> collezione)
        {
            List<XY[]> risultato = new List<XY[]>();
            foreach (XY[] poligono in collezione)
            {
                XY[] smussato = new XY[poligono.Length];
                XY[] buffer = new XY[grado];
                for (int i = 0; i < poligono.Length; i++)
                {
                    buffer = AccodaBuffer(buffer, poligono[i]);
                    smussato[i] = new XY( 
                                            (int)buffer.Where(e => e != null).Average(e => e.X),
                                            (int)buffer.Where(e => e != null).Average(e => e.Y)
                                        );
                }
                
                risultato.Add(smussato);
            }
            return risultato;
        }
    }
}
