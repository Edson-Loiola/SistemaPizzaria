using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Services;

namespace SistemaWebPizzaria.Controllers
{
    public class RelatoriosController : Controller
    {

        public readonly RelatorioService _relatoioService;

        public RelatoriosController (RelatorioService relatoioService)
        {
            _relatoioService = relatoioService;
        }


        public IActionResult  Entrada (DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");


            var entrada = _relatoioService.ValorEntrada(minDate, maxDate);


            return View(entrada);
           
      
        }





        public async Task<IActionResult> Saida(DateTime? minDate, DateTime? maxDate)
        {

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");


            var relsaidas = await _relatoioService.SaidaDespesas(minDate, maxDate);

            return View(relsaidas);
        }





        public async Task<IActionResult> Ganho(DateTime? minDate, DateTime? maxDate)
        {
          
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var listasaida = await _relatoioService.SaidaDespesas(minDate, maxDate);
            var entrada = _relatoioService.ValorEntrada(minDate, maxDate);

            var somasaida = listasaida.Despesas.Sum(x => x.Valor) + listasaida.Produtoestoque.Sum(x => x.PrecoCompra);
         
            var lucro = (entrada - somasaida);

            return View(lucro);
          
           
        }

    }
}
