using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebPizzaria.Controllers
{
    public class ClienteController : Controller
    {
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
