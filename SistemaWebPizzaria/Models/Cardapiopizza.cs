using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Cardapiopizza
    {
        public Cardapiopizza()
        {
            Itemcardapio = new HashSet<Itemcardapio>();
        }

        public int IdCardapio { get; set; }
        public string Sabor { get; set; }
        public string Tipo { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Tamanho { get; set; }
        public string Descricao { get; set; }

        public ICollection<Itemcardapio> Itemcardapio { get; set; }
    }
}
