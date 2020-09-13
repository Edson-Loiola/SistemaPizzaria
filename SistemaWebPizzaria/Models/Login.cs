﻿using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria
{
    public partial class Login
    {
        public Login()
        {
            Funcionario = new HashSet<Funcionario>();
        }

        public int IdLogin { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        public ICollection<Funcionario> Funcionario { get; set; }
    }
}
