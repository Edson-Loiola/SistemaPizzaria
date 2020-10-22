using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class RelatorioService
    {
        private readonly BancoPizzariaContext _context;

        public RelatorioService(BancoPizzariaContext context)
        {
            _context = context;
        }


        public async Task<RelatoriosViewModel> SaidaDespesas(DateTime? minDate, DateTime? maxDate)
        {



            var listdesp = from obj in _context.Despesa select obj;
            var listprod = from obj in _context.Produtoestoque select obj;
            


            if (minDate.HasValue)
            {
                listdesp = listdesp.Where(d => d.DataDespesa >= minDate.Value);
                listprod = listprod.Where(p => p.DataCompra >= minDate.Value);
              
            }
            if (maxDate.HasValue)
            {
                listdesp = listdesp.Where(d => d.DataDespesa <= maxDate.Value);
                listprod = listprod.Where(p => p.DataCompra <= maxDate.Value);
               
            }


            RelatoriosViewModel list = new RelatoriosViewModel(

                    listdesp.ToList(),
                    listprod.ToList()

                );

            return list;

        }


        public async Task<RelatoriosViewModel> ValorEntrada(DateTime? minDate, DateTime? maxDate)
        {

      
            var listpedido = from obj in _context.Pedido select obj;            


            if (minDate.HasValue)
            {
                listpedido = listpedido.Where(p => p.DataHora >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                listpedido = listpedido.Where(p => p.DataHora <= maxDate.Value);
            }

            RelatoriosViewModel list = new RelatoriosViewModel
                (
                    listpedido.ToList()                    
                );

            return list;

        }


        //o de lucro foi feito direto no html

        //    public async Task<double> ValorTotalLucro(DateTime? minDate, DateTime? maxDate)
        //    {

        //        var saida = await SomaTotal(minDate, maxDate);
        //        var entrada = ValorEntrada(minDate, maxDate);
        //        if (minDate.HasValue)
        //        {
        //            desp = desp.Where(x => x.DataDespesa >= minDate.Value);
        //        }
        //        if (maxDate.HasValue)
        //        {
        //            desp = desp.Where(x => x.DataDespesa <= maxDate.Value);
        //        }



        //        var lucro = (entrada - saida);

        //        return lucro;
        //    }
        //}
    }
}
