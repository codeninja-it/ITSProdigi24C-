using Microsoft;
using Microsoft.CSharp;
using Microsoft.CSharp.RuntimeBinder;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Timers;
using System.Web;
using System.Xml;

namespace PrimaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // saluto
            Console.WriteLine("Benvenuto!");

            // chiedo il nome
            Console.Write("In che file scrivo? ");
            // e lo acquisisco
            string? nomeFile = Console.ReadLine();

            // chiedo il contenuto
            Console.Write("Cosa ci metto dentro?");
            // e lo acquisisco da console
            string? contenuto = Console.ReadLine();

            // se la cartella non esiste
            if (!Directory.Exists("c:\\test"))
                // la creo
                Directory.CreateDirectory("c:\\test");
            nomeFile = Path.Combine("c:\\test", nomeFile);

            // poi vi scrivo dentro
            File.WriteAllText(nomeFile, contenuto);
        }
    }
}
