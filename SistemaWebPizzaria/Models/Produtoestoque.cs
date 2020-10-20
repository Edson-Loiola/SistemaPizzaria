using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria.Models
{
    public partial class Produtoestoque
    {
        public Produtoestoque()
        {
            Itemproduto = new HashSet<Itemproduto>();
        }

        public int IdProduto { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [StringLength(50, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public double PrecoCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public decimal? PrecoVenda { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [Range(0.00, 999999.99, ErrorMessage = "{0} R$ de {1} até {2}")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataCompra { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Validade { get; set; }

        [StringLength(50, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string Marca { get; set; }

        [StringLength(50, ErrorMessage = "{0} Máximo de 50 caracteres")]
        public string NomeFornecedor { get; set; }

        [StringLength(100, ErrorMessage = "{0} Máximo de 100 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "{0} não informado!")]
        public string NotaFiscal { get; set; }

      
        public string Categoria { get; set; }

      
        public string Vende { get; set; }

        public string UnidadeMedida { get; set; }

        public ICollection<Itemproduto> Itemproduto { get; set; }
    }
}
