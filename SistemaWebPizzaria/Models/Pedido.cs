﻿using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Itempedido = new HashSet<Itempedido>();
        }

        public int IdPedido { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoEntrega { get; set; }
        public string FormaPagamento { get; set; }
        public int IdFuncioario { get; set; }
        public int IdCliente { get; set; }
        public double TotalPedido { get; set; }
        public string Status { get; set; }

        public Cliente IdClienteNavigation { get; set; }
        public Funcionario IdFuncioarioNavigation { get; set; }
        public ICollection<Itempedido> Itempedido { get; set; }
    }
}
