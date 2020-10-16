using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class RelatoriosViewModel
    {
        public List<Despesa> Despesas { get; set; }
        public Funcionario Funcionarios { get; set; }        
        public List<Produtoestoque> Produtoestoque { get; set; }

        public RelatoriosViewModel(List<Despesa> despesas, List<Produtoestoque> produtoestoque)
        {
            Despesas = despesas;
            Produtoestoque = produtoestoque;
        }
    }
}
