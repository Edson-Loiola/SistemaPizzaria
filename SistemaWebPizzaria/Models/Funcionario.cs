﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdFuncionario { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Ativo { get; set; }
        public double Salario { get; set; }
        public string Tipo { get; set; }
        public int? IdLogin { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataCadastro { get; set; }
        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataInativacao { get; set; }

        public Login IdLoginNavigation { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
