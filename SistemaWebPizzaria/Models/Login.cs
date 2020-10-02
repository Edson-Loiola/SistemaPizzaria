using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria.Models
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Perfil { get; set; }
        public int IdFuncionario { get; set; }

        public Funcionario IdFuncionarioNavigation { get; set; }
    }
}
