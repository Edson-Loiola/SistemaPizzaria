using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Pedido
    {
        public int IdPedido { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime DataHora { get; set; }
        public string TipoEntrega { get; set; }
        public string FormaPagamento { get; set; }
        public int IdFuncioario { get; set; }
        public int IdCliente { get; set; }
        public decimal? TotalPedido { get; set; }
        public string Status { get; set; }
        public string Descricao { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public Funcionario IdFuncioarioNavigation { get; set; }
    }
}
