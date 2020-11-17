using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Web;
using Microsoft.AspNetCore.Http;

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
            if (HttpContext.Session.GetString("Usuario") != null)
            { 
                HttpContext.Session.Remove("Usuario");
                HttpContext.Session.Remove("IdUsu");
                HttpContext.Session.Remove("Perfil");
            }
          

            return View();
        }
        public IActionResult AlterarSenha()
        {
            return View();
        }

        public IActionResult EsqueceuSenha()
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
                    HttpContext.Session.SetString("Perfil", "A");
                    return RedirectToAction("MenuSistema", "Home");
                }
                else
                {
                    TempData["ErroLogin"] = "Login ou senha Inválido";
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                if(obj.Ativo == "S" || obj.Ativo==null)
                {
                    HttpContext.Session.SetString("Usuario", email);
                    HttpContext.Session.SetString("IdUsu", obj.IdLogin.ToString());
                    HttpContext.Session.SetString("Perfil", obj.Perfil.ToString());

                    if (obj.SenhaPadrao == "S")
                    {
                        return RedirectToAction("AlterarSenha", "Home");
                    }
                    else
                    {
                        return RedirectToAction("MenuSistema", "Home");
                    }
                }
                else
                {
                    TempData["ErroLogin"] = "Login ou senha Inválido";
                    return RedirectToAction("Index", "Home");
                }
                

            }


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TrocaSenha(string padrao, string senha)
        {
                var id = HttpContext.Session.GetString("IdUsu");
                var obj = await _loginService.FindByIdAsync(Convert.ToInt32(id));
                
                obj.Senha = senha;
                obj.SenhaPadrao = "N";

                await _loginService.TrocaSenhaAsync(obj);
                return RedirectToAction(nameof(MenuSistema));
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmaEmail(string email)
        {
            var obj = await _loginService.FindByEmailAsync(email);

            if(obj != null)
            {
                
                HttpContext.Session.SetString("Usuario", obj.Email);
                HttpContext.Session.SetString("IdUsu", obj.IdLogin.ToString());
                HttpContext.Session.SetString("Perfil", obj.Perfil.ToString());
                TempData["EsqueceuSenha"] = "S";
                return RedirectToAction(nameof(AlterarSenha));
            }
            else
            {
                TempData["ErroEmail"] = "Email não cadastrado ou inválido";
                return RedirectToAction(nameof(EsqueceuSenha));
            }
                 
           

        }

        public IActionResult MenuSistema()
        {
            ViewData["Message"] = "Veja aqui os planos.";

            return View();
        }

        
        public async Task<bool> VerificaSenhaAtual(string senhaAtual)
        {
            var id = HttpContext.Session.GetString("IdUsu");
            bool obj = await _loginService.ComparePassword(Convert.ToInt32(id),senhaAtual);

            if(obj){
                return false;
            }
            else{
                return true;
            }

             
        }
        public async Task<bool> ComparaSenhaNova(string senhaNova)
        {
            var id = HttpContext.Session.GetString("IdUsu");
            var obj = await _loginService.FindByIdAsync(Convert.ToInt32(id));

            if (obj.Senha == senhaNova)
            {
                return false;
            }
            else
            {
                return true;
            }


        }



    }

}
