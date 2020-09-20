using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria
{
    public partial class Cliente
    {
        public Cliente()
        {
            Endereco = new HashSet<Endereco>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Informar um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informar um telefone!")]
        public string Telefone { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Pedido> Pedido { get; set; }


    }
}
