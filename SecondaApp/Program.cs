namespace SecondaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parmetri ricevuti:");
            for(int i=0; i < args.Length; i++)
            {
                Console.WriteLine("- " + args[i]);
            }

            /*
             1° argomento, cassetto 0 : nome
             2° argomento, cassetto 1 : cognome
             3° argomento, cassetto 2 : telefono
             */

            if (!Directory.Exists("contatti"))
                Directory.CreateDirectory("contatti");

            if(args.Length > 2)
            {
                string nome = args[0];
                string cognome = args[1];
                string telefono = args[2];

                string nomeFile = Path.Combine("contatti", nome + "_" + cognome + ".vcf");
                string buffer = "BEGIN:VCARD\n";
                buffer += "VERSION:4.0\n";
                buffer += "FN:" + nome + " " + cognome + "\n";
                buffer += "TEL:" + telefono + "\n";
                buffer += "END:VCARD";
                File.WriteAllText(nomeFile, buffer);
            }
        }
    }
}
