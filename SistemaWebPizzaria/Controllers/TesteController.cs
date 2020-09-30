using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class TesteController : Controller
    {
        public readonly DespesaService _despesaService;


        public TesteController(DespesaService despesaService)
        {
            _despesaService = despesaService;
        }




        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Funcionario()
        {
            return View();
        }


        public IActionResult StatusPed()
        {
            return View();
        }

        public IActionResult Produto()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }


        public IActionResult Despesa()
        {
            return View();
        }


        //inserir dados no banco
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Despesa despesa)
        {

            await _despesaService.InsertAsync(despesa);
            return RedirectToAction(nameof(Despesa)); //ao clicar em criar um nova Despesa, direciona para a propria tela

        }


    }
}
