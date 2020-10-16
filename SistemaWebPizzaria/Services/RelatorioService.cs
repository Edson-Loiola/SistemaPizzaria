using SistemaWebPizzaria.Models;
using System;
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


        public async Task<double> SomaTotal(DateTime? minDate, DateTime? maxDate)
        {

            var listdesp = from obj in _context.Despesa select obj;
            var listprod = from obj in _context.Produtoestoque select obj;
            //   var listfunc = from obj in _context.Funcionario select obj;


            //var listdesp = await _context.Despesa.ToListAsync();
            //var listfunc = await _context.Funcionario.ToListAsync();
            //var listprod = await _context.Produtoestoque.ToListAsync();

            if (minDate.HasValue)
            {
                listdesp = listdesp.Where(d => d.DataDespesa >= minDate.Value);
                listprod = listprod.Where(p => p.DataCompra >= minDate.Value);
                //   listfunc = listfunc.Where(f => f.Ativo == "S");

            }
            if (maxDate.HasValue)
            {
                listdesp = listdesp.Where(d => d.DataDespesa <= maxDate.Value);
                listprod = listprod.Where(p => p.DataCompra <= maxDate.Value);
                //   listfunc = listfunc.Where(f => f.Ativo == "S");

            }


            var somadesp = listdesp.Sum(x => x.Valor);
            // var somafunc = listfunc.Sum(x => x.Salario);
            var somaprod = listprod.Sum(x => x.PrecoCompra);

            var somatotal = (somadesp + Convert.ToDouble(somaprod));

            return somatotal;
        }


        public double ValorEntrada(DateTime? minDate, DateTime? maxDate)
        {

            var entrada = 10000.00;
            //if (minDate.HasValue)
            //{
            //    desp = desp.Where(x => x.DataDespesa >= minDate.Value);
            //}
            //if (maxDate.HasValue)
            //{
            //    desp = desp.Where(x => x.DataDespesa <= maxDate.Value);
            //}


            return entrada;


        }


        public async Task<double> ValorTotalLucro(DateTime? minDate, DateTime? maxDate)
        {

            var saida = await SomaTotal(minDate, maxDate);
            var entrada = ValorEntrada(minDate, maxDate);
            //if (minDate.HasValue)
            //{
            //    desp = desp.Where(x => x.DataDespesa >= minDate.Value);
            //}
            //if (maxDate.HasValue)
            //{
            //    desp = desp.Where(x => x.DataDespesa <= maxDate.Value);
            //}



            var lucro = (entrada - saida);

            return lucro;
        }
    }
}
