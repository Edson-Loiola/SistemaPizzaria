using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class RelatoriosViewModel
    {
        public List<Despesa> Despesas { get; set; }
          
        public List<Produtoestoque> Produtoestoque { get; set; }

        public List<Pedido> Pedidos { get; set; }





        public RelatoriosViewModel(List<Despesa> despesas, List<Produtoestoque> produtoestoque) //construtor com 2 argumentos usado no relatorio saida (relatorios service)
        {
            Despesas = despesas;
            Produtoestoque = produtoestoque;           

        }

        public RelatoriosViewModel(List<Pedido> pedidos) //construtor com 1 argumento usado no relatorio entrada (relatorios service)
        {
            Pedidos = pedidos;

        }


    }
}
