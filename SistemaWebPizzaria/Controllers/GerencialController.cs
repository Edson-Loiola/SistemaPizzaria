using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebPizzaria.Controllers
{
    public class GerencialController : Controller
    {
        public IActionResult Inicial()
        {
            ViewData["Message"] = "inicial.";

            return View();
        }
    }
}
