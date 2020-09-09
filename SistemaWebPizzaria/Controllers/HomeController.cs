using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using System.Diagnostics;

namespace SistemaWebPizzaria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult Plano()
        {
            ViewData["Message"] = "Veja aqui os planos.";

            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        [HttpGet]
        public IActionResult Login()
        {


            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string senha)
        {

            if (email.Equals("teste@gmail.com") && senha.Equals("sistema"))
            {

                HttpContext.Session.SetString("Usuario", email);
               return RedirectToAction("MenuSistema","Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
           

        }


        public IActionResult MenuSistema()
        {
            ViewData["Message"] = "Veja aqui os planos.";

            return View();
        }


        public IActionResult Assinatura()
        {
            return View();
        }

    }

}
