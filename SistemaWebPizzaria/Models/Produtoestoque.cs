using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Produtoestoque
    {
        public Produtoestoque()
        {
            Itemproduto = new HashSet<Itemproduto>();
        }

        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double PrecoCompra { get; set; }
        public decimal? PrecoVenda { get; set; }
        public int Quantidade { get; set; }
        public DateTime? DataCompra { get; set; }
        public DateTime? Validade { get; set; }
        public string Marca { get; set; }
        public string NomeFornecedor { get; set; }
        public string Descricao { get; set; }
        public string NotaFiscal { get; set; }
        public string Categoria { get; set; }
        public string Vende { get; set; }

        public ICollection<Itemproduto> Itemproduto { get; set; }
    }
}
