using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class ProdutosController : Controller
    {
        public readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _produtoService.FindAllAsync();
            return View(list);
        }
        public IActionResult Produto()
        {
            return View();
        }

        //inserir dados no banco (essa função é passada no form da minha view CreatProduto
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Produto produto)
        {
            await _produtoService.InsertAsync(produto);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Produto, direciona para a propria tela
        }


        public async Task<IActionResult> DeleteProduto(int id)
        {
            try
            {
                await _produtoService.RemoveAsync(id); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        //ao clicar em edit ira abrir a tela com os campos carregados com os dados da produto
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) //validação se o id é nulo
            {
                return RedirectToAction(nameof(Produto));
            }

            var obj = await _produtoService.FindByIdAsync(id.Value);

            if (obj == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Produto));
            }

            //Produto viewModel = new Produto { IdProduto = obj.IdProduto, NomeProduto = obj.NomeProduto, Valor = obj.Valor, Descricao = obj.Descricao, DataProduto = obj.DataDespesa  };
            Produto viewModel = new Produto { };
            return View(viewModel);
        }



        //ação edit -metodo post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Produto obj)
        {

            //essa validação ocorrerá se o JavaScript do usuário estiver desabilitado, pois não fará as validações feitas no html e nas propriedades
            if (!ModelState.IsValid)
            {
                var departments = await _produtoService.FindAllAsync(); //carrega os departamentos

                var viewModel = new Produto { };

                return View(viewModel);
            }


            if (id != obj.IdProduto) //verifica se o Id é diferente
            {
                return RedirectToAction(nameof(Produto));
            }

            try
            {
                await _produtoService.UpdateAsync(obj);
                return RedirectToAction(nameof(Produto));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Produto));
            }

            //alterado esses dois cath por apenas 1 passando a super classe ApplicationException

        }
    }




}
