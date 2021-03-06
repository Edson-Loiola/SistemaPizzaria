﻿using Microsoft.AspNetCore.Mvc;
using PagedList;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> Detalhe(int id)
        {
            var result = await _produtoService.FindByIdAsync(id);
            return View(result);
        }

        //inserir dados no banco (essa função é passada no form da minha view CreatProduto
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Produtoestoque produto)
        {

            await _produtoService.InsertAsync(produto);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Produto, direciona para a propria tela

        }


        public async Task<IActionResult> DeleteProduto(int id)
        {
            try
            {
                var produto = await _produtoService.FindByIdAsync(id);
                await _produtoService.RemoveAsync(produto); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Produtoestoque produto)
        {
            try
            {

                await _produtoService.UpdateAsync(produto);
                return RedirectToAction(nameof(Index));

            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }




        //metodo de pesquisar produto pelo nome 
        [HttpPost]
        public async Task<IActionResult> BuscarProdPeloNome(string nomeprod)
        {

            var obj = await _produtoService.FindAllAsync();


            if (nomeprod == null)
            {
                return RedirectToAction(nameof(Index));
            }


            var listprod = obj.Where(x => x.Nome.ToUpper().Contains(nomeprod.ToUpper()));




            return View(nameof(Index), listprod);  // se existir retornar a lista
        }


        //listagem dos produtos vencidos
        [HttpPost]
        public async Task<IActionResult> ProdutosVencidos()
        {

            var obj = await _produtoService.FindAllAsync();

            var prodVencidos = obj.Where(x => x.Validade < DateTime.Now).ToList();
          
          

            return View(nameof(Index), prodVencidos); // se existir retornar a lista
        }


        //listagem dos produtos com estoque abaixo de 10
        [HttpPost]
        public async Task<IActionResult> EstoqueBaixo()
        {

            var obj = await _produtoService.FindAllAsync();

            var prodBaixo = obj.Where(x => x.Quantidade < 10).ToList();

            

            return View(nameof(Index), prodBaixo); // se existir retornar a lista
        }




        public async Task<bool> Validade(string Validade) //obs os parametros tem que ter o mesmo nome dos atributos da classe
        {


            if (Convert.ToDateTime(Validade) < Convert.ToDateTime(DateTime.Now))
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
