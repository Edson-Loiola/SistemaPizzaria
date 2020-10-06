using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class HomeController : Controller
    {
        public readonly LoginService _loginService;


        public HomeController(LoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AlterarSenha()
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
        public async Task<IActionResult> Login(string email, string senha)
        {
            var obj = await _loginService.LoginAsync(email, senha);

            if (obj == null)
            {
                if (email.Equals("teste@gmail.com") && senha.Equals("sistema"))
                {

                    HttpContext.Session.SetString("Usuario", email);
                    return RedirectToAction("MenuSistema", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                HttpContext.Session.SetString("Usuario", email);
                HttpContext.Session.SetString("IdUsu", obj.IdLogin.ToString());

                if (obj.SenhaPadrao == "S")
                {
                    return RedirectToAction("AlterarSenha", "Home");
                }
                else
                {
                    return RedirectToAction("MenuSistema", "Home");
                }

          

            }


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Login obj)
        {
                await _loginService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            
        }

        public IActionResult MenuSistema()
        {
            ViewData["Message"] = "Veja aqui os planos.";

            return View();
        }



    }

}
