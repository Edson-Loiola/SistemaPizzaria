using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebPizzaria
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }

        
        public string Cep { get; set; }
               
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int ClienteIdCliente { get; set; }

        public Cliente ClienteIdClienteNavigation { get; set; }
    }
}
