using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Produtoestoque
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public DateTime? DataCompra { get; set; }
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
