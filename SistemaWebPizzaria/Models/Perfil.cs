using System;
using System.Collections.Generic;

namespace SistemaWebPizzaria
{
    public partial class Perfil
    {
        public Perfil()
        {
            Funcionario = new HashSet<Funcionario>();
        }

        public int IdPerfil { get; set; }
        public string TipoPerfil { get; set; }

        public ICollection<Funcionario> Funcionario { get; set; }
    }
}
