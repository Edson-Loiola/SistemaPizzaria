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



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        //metodo que valida o email e a senha
        //dados ainda nã persistem no banco
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


        
    }

}
