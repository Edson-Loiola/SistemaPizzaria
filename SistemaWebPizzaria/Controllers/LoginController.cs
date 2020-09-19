
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Services;

namespace SistemaWebPizzaria.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }


       

       
    }
}
