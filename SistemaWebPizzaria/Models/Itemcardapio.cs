namespace SistemaWebPizzaria
{
    public partial class Itemcardapio
    {
        public int Id { get; set; }
        public int IdCardapio { get; set; }
        public int IdPedido { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoUnidade { get; set; }
        public decimal? Total { get; set; }

        public Cardapio IdCardapioNavigation { get; set; }
        public Pedido IdPedidoNavigation { get; set; }
    }
}
