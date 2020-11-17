using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Produtoestoque
    {
        public int IdProduto { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(45, ErrorMessage = "{0} Máximo de 45 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public double PrecoCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public decimal PrecoVenda { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [Range(0, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Remote("Validade", "Produtos", AdditionalFields = nameof(Validade), ErrorMessage = "{0} fora do prazo!")]
        public DateTime? Validade { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public double? ValorTotal { get; set; }

        public string Marca { get; set; }
        public string NomeFornecedor { get; set; }
        public string Descricao { get; set; }
        public string NotaFiscal { get; set; }
        public string Categoria { get; set; }
        public string Vende { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
