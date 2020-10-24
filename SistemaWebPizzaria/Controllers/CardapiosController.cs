using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class CardapiosController : Controller
    {
        public readonly CardapioService _cardapioService;



        public CardapiosController(CardapioService cardapioService)
        {
            _cardapioService = cardapioService;
        }




        //com essas ações o meu controlador chama as minha telas  CreatDespesa, Index e Edit dentro da minha view Despesas
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            var list = await _cardapioService.FindAllAsync();

            return View(list);
        }




        //inserir dados no banco (essa função é passada no form da minha view CreatDespesa
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Cardapiopizza cardapiopizza)
        {
            await _cardapioService.InsertAsync(cardapiopizza);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Despesa, direciona para a propria tela
        }


        public async Task<IActionResult> Delete(int  id)
        {
            try
            {
                await _cardapioService.RemoveAsync(id); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        //ao clicar em edit ira abrir a tela com os campos carregados com os dados da despesa
        public async Task<IActionResult> Detalhe(int? id)
        {
            if (id == null) //validação se o id é nulo
            {
                return RedirectToAction(nameof(Index));
            }

            var obj = await _cardapioService.FindByIdAsync(id.Value);

            if (obj == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Index));
            }

            Cardapiopizza viewModel = new Cardapiopizza
            {
                IdCardapio = obj.IdCardapio,
                Sabor = obj.Sabor,
                ValorUnitario = obj.ValorUnitario,
                Descricao = obj.Descricao,
                Tamanho = obj.Tamanho,
                Tipo = obj.Tipo
            };

            return View(viewModel);
        }



        //ação edit -metodo post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Cardapiopizza obj)
        {

            try
            {
                await _cardapioService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }

            //alterado esses dois cath por apenas 1 passando a super classe ApplicationException

        }


        //metodo de pesquisar produto pelo nome 
        [HttpPost]
        public async Task<IActionResult> BuscarCardapio(string nomeprod)
        {

            var obj = await _cardapioService.FindAllAsync();


            if (nomeprod == null)
            {
                return RedirectToAction(nameof(Index));
            }


            var filtrocardapio = obj.Where(x => x.Sabor == nomeprod);


            /* if (!filtrocardapio.Any(x => x.Sabor.ToLower() == nomeprod.ToLower())) // se o telefone passado não existir no banco, direcionar para create
             {*/
            return View(nameof(Index), filtrocardapio);
            /*}
            else
                return View(nameof(Index), filtrocardapio); */ // se existir retornar a lista
        }





    }




}