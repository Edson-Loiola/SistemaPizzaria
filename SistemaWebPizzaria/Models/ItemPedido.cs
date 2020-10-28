using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Itempedido
    {
        public int Id { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoUnidade { get; set; }
        public decimal? Total { get; set; }
        public string Produto { get; set; }
        public int ProdutoEstoqueIdProduto { get; set; }
        public int CardapioPizzaIdCardapio { get; set; }
        public int PedidoIdPedido { get; set; }

        public Cardapiopizza CardapioPizzaIdCardapioNavigation { get; set; }
        public Pedido PedidoIdPedidoNavigation { get; set; }
        public Produtoestoque ProdutoEstoqueIdProdutoNavigation { get; set; }






    }
}
