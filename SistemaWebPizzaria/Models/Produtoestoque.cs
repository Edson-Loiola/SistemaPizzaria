using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Produtoestoque
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public double PrecoCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public decimal? PrecoVenda { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [Range(0, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public int Quantidade { get; set; }
        public DateTime? DataCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Remote("Validade", "Produtos", AdditionalFields = nameof(DataCompra), ErrorMessage = "{0} menor que a Data de Compra!")]
        public DateTime? Validade { get; set; }
        public string Marca { get; set; }
        public string NomeFornecedor { get; set; }
        public string Descricao { get; set; }
        public string NotaFiscal { get; set; }
        public string Categoria { get; set; }
        public string Vende { get; set; }
        public string UnidadeMedida { get; set; }
    }
}
