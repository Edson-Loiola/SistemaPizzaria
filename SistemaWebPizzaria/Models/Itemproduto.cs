namespace SistemaWebPizzaria
{
    public partial class Itemproduto
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public int? QtdeProduto { get; set; }
        public decimal? PrecoUnidade { get; set; }
        public decimal? Total { get; set; }

        public Pedido IdPedidoNavigation { get; set; }
        public Produto IdProdutoNavigation { get; set; }
    }
}
