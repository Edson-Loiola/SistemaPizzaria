using System.Collections.Generic;

namespace SistemaWebPizzaria
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedido = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public int TbEnderecoIdEndereco { get; set; }

        public Endereco TbEnderecoIdEnderecoNavigation { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
