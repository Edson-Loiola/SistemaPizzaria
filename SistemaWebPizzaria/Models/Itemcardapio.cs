using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Itemcardapio
    {
        public int Id { get; set; }
        public int IdCardapio { get; set; }
        public int IdPedido { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoUnidade { get; set; }
        public decimal? Total { get; set; }

        public Cardapiopizza IdCardapioNavigation { get; set; }
        public Pedido IdPedidoNavigation { get; set; }
    }
}
