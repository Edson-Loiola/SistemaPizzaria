using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Itempedido
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnidade { get; set; }
        public decimal Total { get; set; }
        public string Produto { get; set; }
        public int PedidoId { get; set; }
        public int? ProdutoEstoqueId { get; set; }
        public int? CardapioPizzaId { get; set; }
        public string NomeProduto { get; set; }
    }
}
