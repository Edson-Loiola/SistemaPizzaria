using Microsoft.AspNetCore.Mvc;
using System;
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

        [Display(Name = "IdFuncionario")]
        public int IdFuncionario { get; set; }

        [Display(Name = "Cpf")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(11, ErrorMessage = "{0} Máximo de 11 dígitos")]
        public string Cpf { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 45 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Celular")]
        [StringLength(11, ErrorMessage = "{0} Máximo de 11 caracteres")]
        public string Celular { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "{0} não informado!")]
        [EmailAddress(ErrorMessage = "Entre com um email válido")]
        [StringLength(30, ErrorMessage = "{0} Máximo de 30 caracteres")]
        [Remote("VerificaEmail", "Funcionarios", AdditionalFields = nameof(IdFuncionario), ErrorMessage = "Email já cadastrado, utilize outro")]
        public string Email { get; set; }

        public string Ativo { get; set; }

        [Display(Name = "Salario")]
        [Required(ErrorMessage = "{0} não informado!")]
        [Range(1.0, 999999.99, ErrorMessage = "{0} precisa ser entre {1} e {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
