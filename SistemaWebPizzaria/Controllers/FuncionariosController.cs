using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class FuncionariosController : Controller
    {
        public readonly FuncionarioService _funcionarioService;
        public FuncionariosController(FuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
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




        //inserir dados no banco (essa função é passada no form da minha view CreatDespesa
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Funcionario funcionario)
        {
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
            if (id == null) //validação se o id é nulo
            {
                return RedirectToAction(nameof(Index));
            }

            var obj = await _funcionarioService.FindByIdAsync(id.Value);

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
                Salario = obj.Salario
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Inativa(int id)
        {
            var obj = await _funcionarioService.FindByIdAsync(id);
            try
            {
               
                obj.Ativo = "N";
              
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

            //essa validação ocorrerá se o JavaScript do usuário estiver desabilitado, pois não fará as validações feitas no html e nas propriedades
            if (!ModelState.IsValid)
            {
                var departments = await _funcionarioService.FindAllAsync(); //carrega os departamentos

                var viewModel = new Funcionario
                {
                    IdFuncionario = obj.IdFuncionario,
                    Nome = obj.Nome,
                    Cpf = obj.Cpf,
                    Email = obj.Email,
                    Celular = obj.Celular,
                    Ativo = obj.Ativo,
                    Salario = obj.Salario
                };


                return View(viewModel);
            }


            if (id != obj.IdFuncionario) //verifica se o Id é diferente
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
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
