namespace DecimaApp
{
    public partial class Form1 : Form
    {
        private bool mouseGiu = false;
        private Bitmap sfondo;

        public Form1()
        {
            InitializeComponent();
            sfondo = new Bitmap(this.Width, this.Height);
        }        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseGiu = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseGiu = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseGiu)
            {
                
                this.Text = $"Coordinate : {e.X} {e.Y}";
                Graphics pennello = Graphics.FromImage(sfondo);

                // sostituire setPixel con DrawLine
                sfondo.SetPixel(e.X, e.Y, Color.Black);
                pennello.DrawLine(Pens.Black, new Point(0, 0), new Point(100, 100));
                
                // e disergnare anche la linea che ottengo tramite un
                // algoritmo ARIMA a 10 elementi

                // refresh di pagina
                this.BackgroundImage = sfondo;
                this.Invalidate();
            }    
        }
    }
}
