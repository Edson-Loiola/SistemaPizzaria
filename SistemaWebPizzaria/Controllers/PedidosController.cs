using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class PedidosController : Controller
    {
        public readonly PedidoService _pedidoService;

        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _pedidoService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Pedido()
        {
            return View();
        }

        public async Task<List<Funcionario>> ListaFuncionarios()
        {
            return await _pedidoService.ListaFuncionarios();
        }

        //ListaClientes
        public async Task<List<Cliente>> ListaClientes()
        {
            return await _pedidoService.ListaClientes();
        }

        public async Task<IActionResult> Detalhe(int id)
        {
            var result = await _pedidoService.FindByIdAsync(id);
            return View(result);
        }


        //inserir dados no banco (essa função é passada no form da minha view CreatProduto
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> Create(Pedido pedido)
        {
            
            await _pedidoService.InsertAsync(pedido);
            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Produto, direciona para a propria tela
        }


        public async Task<IActionResult> DeletePedido(int id)
        {
            try
            {
                var pedido = await _pedidoService.FindByIdAsync(id);
                await _pedidoService.RemoveAsync(pedido); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Pedido pedido)
        {
            try
            {
                await _pedidoService.UpdateAsync(pedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }




}
