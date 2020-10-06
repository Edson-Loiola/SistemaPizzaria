using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
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


        //função que recebe duas datas e retornar as vendas nesse intervalo (busca agrupada)
        //public async Task<List<IGrouping<Funcionario, Produtoestoque>>> FindByDateGroupingpAsync(DateTime? minDate, DateTime? maxDate)
        //{
        //    //cria um objeto do tipo SalesRecord e guarda na variavel um objeto do tipo IQueryable que permite fazer outras consultas
        //    var result = from obj in _context.Pedido select obj;


        //    if (minDate.HasValue) //se minDate tem valor, fazer a consulta abaixo
        //    {
        //        result = result.Where(x => x.DataHora >= minDate.Value);
        //    }
        //    else
        //    {
        //        result = result.Where(x => x.DataHora <= maxDate.Value);
        //    }

        //    return await result
        //        .Include(x => x.IdFuncioarioNavigation.Salario) //isso faz o join das tabelas  Seller e SalesRecord
        //      //  .Include(x => x.DataHora) // isso faz o join das tabelas  Sales e Departamento
        //     //   .OrderByDescending(x => x.Date) //oredena por data
        //    //    .GroupBy(x => x.Seller.Department) //ao fazer o fazer esse agrupamento tem qie mudar o tipo da lista para IGroup
        //        .ToListAsync();
        //}

    }
}

