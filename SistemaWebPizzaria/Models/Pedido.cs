using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoEntrega { get; set; }
        public string FormaPagamento { get; set; }
        public int IdFuncioario { get; set; }
        public int IdCliente { get; set; }
        public decimal? TotalPedido { get; set; }
        public string Status { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public Funcionario IdFuncioarioNavigation { get; set; }
    }
}
