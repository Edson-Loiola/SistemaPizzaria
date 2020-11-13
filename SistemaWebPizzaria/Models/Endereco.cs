using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }

        public string Cep { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0} Rua ou ' - '")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Rua { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Nº ou ' - '")]
        public string Numero { get; set; }

        [StringLength(45, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Complemento { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Bairro ou ' - '")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Bairro { get; set; }

        [Display(Name = "Informar:")]
        [Required(ErrorMessage = "{0}  Cidade ou ' - '")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Cidade { get; set; }

        public int? ClienteIdCliente { get; set; }

        public string Ativo { get; set; }

        public Cliente ClienteIdClienteNavigation { get; set; }
    }
}
