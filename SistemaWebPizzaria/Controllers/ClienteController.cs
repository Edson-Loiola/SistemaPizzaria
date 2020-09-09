using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Services;

namespace SistemaWebPizzaria.Controllers
{
    public class ClienteController : Controller
    {
        //public readonly ClientePzService _clientePzService;


        //public ClienteController(ClientePzService clientePzService)
        //{
        //    _clientePzService = clientePzService;
        //}


        //public async Task<IActionResult> ClientePz()
        //{
        //    var list = await _clientePzService.FindAllAsync(); //retorna uma lista de cliente

        //    return View(list); //passando a lista como argumento no método view para gerar um IActionResult contendo a lista

        //    //...mvc acontecendo aqui: Chamei o controlador, o controlador chamou o model, pegou o dado na lista e encaminha para a view
        //}




        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StatusPed()
        {
            return View();
        }

        public IActionResult Funcionario()
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

    

    }
}
