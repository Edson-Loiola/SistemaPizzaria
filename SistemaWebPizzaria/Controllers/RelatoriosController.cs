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
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
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
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");


            var somaTotal = await _relatoioService.SomaTotal(minDate, maxDate);


            return View(somaTotal);
        }




        public async Task<IActionResult> Ganho(DateTime? minDate, DateTime? maxDate)
        {

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");


            var lucro = await _relatoioService.ValorTotalLucro(minDate, maxDate);


            return View(lucro);
        }





       


  
    }
}
