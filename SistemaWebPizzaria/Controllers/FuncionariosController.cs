using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace SistemaWebPizzaria.Controllers
{
    public class FuncionariosController : Controller
    {
        public readonly FuncionarioService _funcionarioService;
        public readonly LoginService _loginService;
        

        public FuncionariosController(FuncionarioService funcionarioService,LoginService loginService)
        {
            _funcionarioService = funcionarioService;
            _loginService = loginService;
        }

        //com essas ações o meu controlador chama as minha telas  CreatDespesa, Index e Edit dentro da minha view Despesas
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var list = await _funcionarioService.FindAllAsync();
            return View(list);
        }

        public async Task<List<Funcionario>> listaFuncionarios()
        {
            var list = await _funcionarioService.FindAllAsync();
            return list;
        }
        

        //inserir dados no banco (essa função é passada no form da minha view CreatDespesa
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Funcionario funcionario)
        {


           

            if (funcionario.Tipo == "Gerente" || funcionario.Tipo == "Atendente")
            {
                Login login = new Login();
                var rand = new Random();

                 login.Email = funcionario.Email;
                 login.DataCriacao = DateTime.Now;

                 if (funcionario.Tipo == "Gerente")
                 {
                     login.Perfil = "A";
                 }
                 else
                 {
                     login.Perfil = "U";
                 }

                 string senha = "";
                 for (int ctr = 0; ctr <= 5; ctr++)
                 {
                     senha += rand.Next(0, 9).ToString();
                 }
                 login.Senha = senha;
                 login.SenhaPadrao = "S";
                 await _loginService.InsertAsync(login);
                 funcionario.IdLogin = login.IdLogin;
            }
            
            funcionario.DataCadastro = DateTime.Now;

            await _funcionarioService.InsertAsync(funcionario);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Despesa, direciona para a propria tela
        }


        public async Task<IActionResult> DeleteDespesa(int id)
        {
            try
            {
                await _funcionarioService.RemoveAsync(id); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        //ao clicar em edit ira abrir a tela com os campos carregados com os dados da despesa
        public async Task<IActionResult> Edit(int? id)
        {
      

            var obj = await _funcionarioService.FindByIdAsync(id.Value);
            var objLog = await _loginService.FindByIdAsync(Convert.ToInt32(obj.IdLogin));

            if (obj == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Index));
            }

            Funcionario viewModel = new Funcionario
            {
                IdFuncionario = obj.IdFuncionario,
                Nome = obj.Nome,
                Cpf = obj.Cpf,
                Email = obj.Email,
                Celular = obj.Celular,
                Ativo = obj.Ativo,
                Salario = obj.Salario,
                DataCadastro = obj.DataCadastro,
                DataInativacao = obj.DataInativacao,
                Tipo = obj.Tipo,
                IdLogin = obj.IdLogin,
                IdLoginNavigation = objLog
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Inativa(int id)
        {
            var obj = await _funcionarioService.FindByIdAsync(id);
            try
            {
               
                obj.Ativo = "N";
                obj.DataInativacao = DateTime.Now;

                await _funcionarioService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        //ação edit -metodo post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Funcionario obj)
        {

   
            if (id != obj.IdFuncionario) //verifica se o Id é diferente
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                if(obj.Tipo == "Gerente" || obj.Tipo == "Atendente")
                {
                    Login login = new Login();
                    login.Email = obj.Email;
                    login.DataCriacao = DateTime.Now;

                    if (obj.Tipo == "Gerente")
                    {
                        login.Perfil = "A";
                    }
                    else
                    {
                        login.Perfil = "U";
                    }

                    if (obj.IdLogin == null)
                    {
                        var rand = new Random();
                        string senha = "";
                        for (int ctr = 0; ctr <= 5; ctr++)
                        {
                            senha += rand.Next(0, 9).ToString();
                        }
                        login.Senha = senha;
                        login.SenhaPadrao = "S";
                        await _loginService.InsertAsync(login);
                        obj.IdLogin = login.IdLogin;
                    }
                    else
                    {
                        login.IdLogin = Convert.ToInt32(obj.IdLogin);
                        login.Senha = obj.IdLoginNavigation.Senha;
                        login.SenhaPadrao = obj.IdLoginNavigation.SenhaPadrao;
                        await _loginService.UpdateAsync(login);
                    }
                   
                  
                }
                else
                {
                    obj.IdLoginNavigation = null;
                }

                await _funcionarioService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }


        }
    }
}
