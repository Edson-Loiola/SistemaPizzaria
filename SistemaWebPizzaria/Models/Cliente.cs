using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Endereco = new HashSet<Endereco>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }

        [Required(ErrorMessage = "{0} required")] // para campo obrigatório. posso definir uma msg de errou não.
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size shoud be between {1} and {2}")] // define o tamanho máximo e minímo para o nome e adicionar uma mensagem de erro.
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
