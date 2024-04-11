namespace TerzaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tabelline : deve salvare nella cartella "tabelline" un file di testo con 
             *              la tabellina scelta
             *  1) base             2
             *  2) ripetizioni      10
             *  3) operazione       +,-,*
             */

            int nBase = 0;
            int nRipetizioni = 0;
            string operazione = "";

            if (args.Length > 2)
            {
                nBase = int.Parse(args[0]);
                nRipetizioni = int.Parse(args[1]);
                operazione = args[2];
            } else
            {
                Console.Write("Base:\t");
                nBase = int.Parse( Console.ReadLine() );
                Console.Write("Ripetizioni:\t");
                nRipetizioni = int.Parse( Console.ReadLine() );
                Console.Write("Operazione:\t");
                operazione = Console.ReadLine();
            }            

            string buffer = "";
            for(int i=1; i < nRipetizioni+1; i++)
            {
                float risultato;
                switch (operazione)
                {
                    case "+":
                        risultato = nBase + i;
                        break;
                    case "-":
                        risultato = nBase - i;
                        break;
                    case "*":
                        risultato = nBase * i;
                        break;
                    default:
                        risultato = (float)nBase / (float)i;
                        break;
                }
                buffer += $"{nBase} {operazione} {i} = {risultato:F2}\n";
            }

            if (!Directory.Exists("tabelline"))
                Directory.CreateDirectory("tabelline");
            File.WriteAllText($"tabelline/tabellina_{nBase}.txt", buffer);
        }
    }
}
