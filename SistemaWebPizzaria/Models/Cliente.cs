using Microsoft.AspNetCore.Mvc;
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

        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 45 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "{0} inválido")]    
        public string Telefone { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
