using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria
{
    public partial class Pedido
    {
        public Pedido()
        {
            Itemcardapio = new HashSet<Itemcardapio>();
            Itemproduto = new HashSet<Itemproduto>();
        }

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
        public ICollection<Itemcardapio> Itemcardapio { get; set; }
        public ICollection<Itemproduto> Itemproduto { get; set; }
    }
}
