using QuintaApp.strutture;

namespace QuintaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // gestione di una rubrica contatti
            // C R U D
            Rubrica rubrica = new Rubrica();

            string comando = "";
            do
            {
                // si parla
                Console.Write("Comando:\t");
                // si ascolta
                comando = Console.ReadLine();
                // si fa
                rubrica.gestisci(comando);
            } while (comando != "exit");

        }
    }
}
