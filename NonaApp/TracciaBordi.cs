using System;
using System.Collections.Generic;
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
            // se sono fuori perimetro esco
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

        
    }
}
