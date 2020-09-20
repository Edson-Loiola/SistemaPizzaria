using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Login = new HashSet<Login>();
            Pedido = new HashSet<Pedido>();
        }

        public int IdFuncionario { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Ativo { get; set; }
        public decimal Salario { get; set; }

        public ICollection<Login> Login { get; set; }
        public ICollection<Pedido> Pedido { get; set; }
    }
}
