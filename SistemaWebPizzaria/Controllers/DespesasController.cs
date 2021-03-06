﻿using Microsoft.AspNetCore.Mvc;
using PagedList;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class DespesasController : Controller
    {
        public readonly DespesaService _despesaService;
        private readonly RelatorioService _relatorioService;

        public DespesasController(DespesaService despesaService, RelatorioService relatorioService)
        {
            _despesaService = despesaService;
            _relatorioService = relatorioService;

        }



        //com essas ações o meu controlador chama as minha telas  CreatDespesa, Index e Edit dentro da minha view Despesas
        public IActionResult CreateDespesa()
        {
            return View();

        }


        public async Task<IActionResult> Index(DateTime? minDate, DateTime? maxDate)
        {

            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }


            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");


            var list = await _despesaService.FindAllAsync(minDate, maxDate);

            return View(list);
        }



        //inserir dados no banco (essa função é passada no form da minha view CreatDespesa
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Despesa despesa)
        {

            await _despesaService.InsertAsync(despesa);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Despesa, direciona para a propria tela
        }


        public async Task<IActionResult> DeleteDespesa(int id)
        {
            try
            {
                await _despesaService.RemoveAsync(id); //chamando o metodo remove 
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

            var obj = await _despesaService.FindByIdAsync(id.Value);

            if (obj == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Index));
            }

            Despesa viewModel = new Despesa
            {
                IdDespesa = obj.IdDespesa,
                NomeDespesa = obj.NomeDespesa,
                Valor = obj.Valor,
                Descricao = obj.Descricao,
                DataDespesa = obj.DataDespesa
            };

            return View(viewModel);
        }



        //ação edit -metodo post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Despesa obj, DateTime? minDate, DateTime? maxDate, int? pagina)
        {

            //essa validação ocorrerá se o JavaScript do usuário estiver desabilitado, pois não fará as validações feitas no html e nas propriedades
            if (!ModelState.IsValid)
            {
                var despesas = await _despesaService.FindAllAsync(minDate, maxDate); //carrega 

                var viewModel = new Despesa
                {
                    IdDespesa = obj.IdDespesa,
                    NomeDespesa = obj.NomeDespesa,
                    Valor = obj.Valor,
                    Descricao = obj.Descricao,
                    DataDespesa = obj.DataDespesa
                };


                return View(viewModel);
            }


            if (id != obj.IdDespesa) //verifica se o Id é diferente
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                await _despesaService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }

            //alterado esses dois cath por apenas 1 passando a super classe ApplicationException

        }


        public async Task<IActionResult> DespesaSalario()
        {
            return View();
        }

      
    }




}
