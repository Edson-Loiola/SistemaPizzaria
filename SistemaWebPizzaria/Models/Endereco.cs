using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }



        public string Cep { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0} Rua ou ' - '")]
        public string Rua { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Nº ou ' - '")]
        public string Numero { get; set; }
        public string Complemento { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Bairro ou ' - '")]
        public string Bairro { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Cidade ou ' - '")]
        public string Cidade { get; set; }
        public int? ClienteIdCliente { get; set; }

        public Cliente ClienteIdClienteNavigation { get; set; }
    }
}
