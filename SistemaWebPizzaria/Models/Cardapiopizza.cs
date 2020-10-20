using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Cardapiopizza
    {
        public Cardapiopizza()
        {
            Itemcardapio = new HashSet<Itemcardapio>();
        }

        public int IdCardapio { get; set; }

        [Display(Name = "Sabor")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(30, ErrorMessage = "{0} Máximo de 30 caracteres")]
        public string Sabor { get; set; }

        public string Tipo { get; set; }

        [Display(Name = "ValorUnitario")]
        [Required(ErrorMessage = "Valor não informado!")]
        [Range(1.0, 999.99, ErrorMessage = "Valor precisa ser entre {1} e {2}")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal ValorUnitario { get; set; }

        public string Tamanho { get; set; }

        [Display(Name = "Descricao")]
        [Required(ErrorMessage = "{0} não informada!")]
        [StringLength(100, ErrorMessage = "{0} Máximo de 100 caracteres")]
        public string Descricao { get; set; }

        public ICollection<Itemcardapio> Itemcardapio { get; set; }
    }
}
