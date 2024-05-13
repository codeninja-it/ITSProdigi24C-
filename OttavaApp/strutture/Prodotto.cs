﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OttavaApp.strutture
{
    public class Prodotto : CampiCondivisi
    {
        public int idProdotto { get; set; }
        public string nome { get; set; } = "";
        public string descrizione { get; set; } = "";
        public double prezzo { get; set; }
        public string immagine { get; set; }
        public List<uint> categorie { get; set; } = new List<uint>();

        public string ToLink(string categoria)
        {
            return $"<a class='prodotto' href='{categoria}/{nome}.htm'>{nome} &euro;{prezzo:N2}</a>";
        }

        public string ToHTML(Categoria categoria)
        {
            return File.ReadAllText(Path.Combine("templates", "prodotto.htm"))
                        .Replace("[nome]", this.nome)
                        .Replace("[categoria]", categoria.categoria)
                        .Replace("[immagine]", immagine)
                        .Replace("[descrizione]", this.descrizione.Replace("\r\n", "<br>"))
                        .Replace("[prezzo]", this.prezzo.ToString("N2"));
        }

        public override string ToString()
        {
            return $"{nome}\t{prezzo:N2}";
        }
    }
}
