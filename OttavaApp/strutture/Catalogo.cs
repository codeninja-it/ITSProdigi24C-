using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace OttavaApp.strutture
{
    public class Catalogo : CampiCondivisi
    {
        public List<Prodotto> prodotti { get; set; }
        public List<Categoria> categorie { get; set; }

        public Catalogo() { 
            prodotti = new List<Prodotto>();
            categorie = new List<Categoria>();
        }

        public void AddProdotto(Prodotto prodotto)
        {
            prodotti.Add(prodotto);
        }

        public int IdMassimo(Func<Categoria, int> SceltaUtente)
        {
            // metodo classico
            int ultimoId = 0;
            foreach (Categoria singola in categorie)
            {
                if (SceltaUtente(singola) > ultimoId)
                {
                    ultimoId = singola.idCategoria;
                }
            }
            return ultimoId;
        }

        public void AddCategoria(Categoria categoria)
        {
            int nuovoId = IdMassimo(elemento => elemento.idCategoria) + 1;

            // metodo nuovo
            nuovoId = categorie.Max(elemento => elemento.idCategoria) + 1;

            categoria.idCategoria = categorie.Count + 1;
            categorie.Add(categoria);
        }

        public static Catalogo Apri(string percorso)
        {
            string buffer = File.ReadAllText(percorso);
            return JsonSerializer.Deserialize<Catalogo>(buffer);
        }

        public void Salva(string percorso)
        {
            string buffer = JsonSerializer.Serialize(this);
            File.WriteAllText(percorso, buffer);
        }

        public void MostraProdotti(ListBox destinazione)
        {
            destinazione.Items.Clear();
            foreach(Prodotto singolo in prodotti)
            {
                destinazione.Items.Add(singolo);
            }
        }
    }
}
