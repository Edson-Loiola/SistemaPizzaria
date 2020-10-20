using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Models.ViewModels
{
    public class ViewModelItemPedido
    {
        public Pedido pedido{ get; set; }
        public Itemcardapio itemCardapio { get; set; }
        public Itemproduto itemProduto { get; set; }
    }
}
