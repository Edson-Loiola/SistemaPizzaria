using System.Collections.Generic;

namespace SistemaWebPizzaria
{
    public partial class Endereco
    {
        public Endereco()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public ICollection<Cliente> Cliente { get; set; }
    }
}
