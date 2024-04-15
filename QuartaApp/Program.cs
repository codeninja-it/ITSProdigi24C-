namespace QuartaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divisione tab2 = new Divisione(2, 10);
            tab2.Calcola();
            Console.WriteLine(tab2);
            tab2.ToDisk("c:/test/tabelline");
            

            Tabellina tab3 = new Tabellina(3, 10);
        }
    }
}
