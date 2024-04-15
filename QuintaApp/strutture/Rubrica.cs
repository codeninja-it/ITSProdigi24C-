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

        public Rubrica() { 
            contatti.Clear();
            Contatto nuovo = new Contatto();
            contatti.Add( nuovo );
            
            for(int i=0; i < contatti.Count; i++)
            {
                Console.WriteLine(contatti[i]);
            }

        }

        internal void gestisci(string comando)
        {
            switch (comando)
            {
                case "add":
                    break;

                case "del":
                    break;

                case "mod":
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
