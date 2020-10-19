using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class ObjetosViewModel
    {

        public Endereco Endereco { get; set; }
        public Cliente Cliente { get; set; }


        public Despesa Despesa { get; set; } //usado na tel salario despesas

    }
}
