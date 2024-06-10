namespace DecimaApp
{
    public partial class Form1 : Form
    {
        private bool mouseGiu = false;
        private Bitmap sfondo;

        private Point?[] buffer = new Point?[10];
        private Point ultimo;
        private Point ultimoARIMA;
        private int indice = 0;

        public Form1()
        {
            InitializeComponent();
            sfondo = new Bitmap(this.Width, this.Height);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseGiu = true;
            ultimo = e.Location;
            buffer = new Point?[trkBuffer.Value];
            ultimoARIMA = PuntoMedio(ultimo);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseGiu = false;
        }

        private Point PuntoMedio(Point nuovo)
        {
            // calcolo il nuovo Indice
            indice = (indice + 1) % trkBuffer.Value;
            buffer[indice] = nuovo;
            // restituisco il punto medio
            int Xmedia = (int)buffer.Where(p => p != null).Average(p => p.Value.X);
            int Ymedia = (int)buffer.Where(p => p != null).Average(p => p.Value.Y);
            return new Point(Xmedia, Ymedia);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseGiu)
            {

                this.Text = $"Coordinate : {e.X} {e.Y}";
                Graphics pennello = Graphics.FromImage(sfondo);

                // sostituire setPixel con DrawLine
                //sfondo.SetPixel(e.X, e.Y, Color.Black);
                Point attuale = e.Location;
                Point attualeARIMA = PuntoMedio(attuale);
                pennello.DrawLine(new Pen(Color.Black, 5), ultimo, attuale);
                pennello.DrawLine(new Pen(Color.Red, 5), ultimoARIMA, attualeARIMA);
                ultimo = attuale;
                ultimoARIMA = attualeARIMA;

                txtPunti.Text = string.Join(",", buffer.Where(p => p != null).Select(p => $"[{p.Value.X} {p.Value.Y}]"));

                // e disergnare anche la linea che ottengo tramite un
                // algoritmo ARIMA a 10 elementi

                // refresh di pagina
                this.BackgroundImage = sfondo;
                this.Invalidate();
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            sfondo = new Bitmap(this.Width, this.Height);
        }
    }
}
