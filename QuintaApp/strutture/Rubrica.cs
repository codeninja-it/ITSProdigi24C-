using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintaApp.strutture
{
    internal class Rubrica
    {
        private List<Contatto> contatti = new List<Contatto>();

        public Rubrica(string path = "contatti.tab") {
            if (File.Exists(path))
            {
                string buffer = File.ReadAllText(path);
                string[] righe = buffer.Split("\n");
            
                for(int i=0; i < righe.Length; i++)
                {
                    contatti.Add(new Contatto( righe[i] ) );
                }
            }
        }

        internal void gestisci(string comando)
        {
            switch (comando)
            {
                case "add":
                    contatti.Add(new Contatto());
                break;

                case "del":
                    Console.Write("Chi devo cancellare?");
                    string nomeDaCancellare = Console.ReadLine();
                    Contatto daCancellare = null;
                    foreach(Contatto singolo in contatti)
                    {
                        if(singolo.nome == nomeDaCancellare)
                        {
                            daCancellare = singolo;
                        }
                    }
                    if(daCancellare != null)
                    {
                        contatti.Remove(daCancellare);
                    }
                break;

                case "save":
                    string buffer = string.Join("\n", contatti);
                    File.WriteAllText("contatti.tab", buffer);
                break;

                case "mod":
                    Console.Write("Chi devo modificare?");
                    string nomeDaModificare = Console.ReadLine();
                    Contatto daModificare = null;
                    foreach (Contatto singolo in contatti)
                    {
                        if (singolo.nome == nomeDaModificare)
                        {
                            daModificare = singolo;
                        }
                    }
                    if (daModificare != null)
                    {
                        Console.WriteLine($"Attualmente il telefono è :{daModificare.telefono}");
                        Console.Write("Nuovo numero:");
                        daModificare.telefono = Console.ReadLine();
                    }
                    break;

                case "exit":
                    Console.WriteLine("Arrivederci!");
                break;

                default:
                    Console.WriteLine("Non ho capito...");
                break;
            }
        }
    }
}
