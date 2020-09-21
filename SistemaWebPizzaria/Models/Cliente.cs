using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Endereco = new HashSet<Endereco>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
