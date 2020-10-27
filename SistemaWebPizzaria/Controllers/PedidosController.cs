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

        public IActionResult Pedido()
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

        public async Task<List<Cardapiopizza>> ListaCardapio()
        {
            return await _pedidoService.ListaCardapio();
        }

        public async Task<List<Produtoestoque>> ListaProduto()
        {
            return await _pedidoService.ListaProduto();
        }

        [HttpPost]
        public async Task<Itempedido> AdicionarItemCardapioAoPedido(int qtd, int cardapioid)
        {
            var cardap = await _pedidoService.FindByIdCardapio(cardapioid);

            var item = new Itempedido();

            item.Produto = "N";
            item.CardapioPizzaIdCardapioNavigation = cardap;
            item.PedidoIdPedido = cardapioid;
            item.PrecoUnidade = cardap.ValorUnitario;
            item.Quantidade = qtd;
            item.Total = (cardap.ValorUnitario * qtd);

            return item;
        }

        [HttpPost]
        public async Task<Itempedido> AdicionarItemProdutoAoPedido(int qtd, int produtoid)
        {
            var produto = await _pedidoService.FindByIdProduto(produtoid);

            var item = new Itempedido();

            item.Produto = "S";
            item.ProdutoEstoqueIdProdutoNavigation = produto;
            item.PedidoIdPedido = produtoid;
            item.PrecoUnidade = produto.PrecoVenda;
            item.Quantidade = qtd;
            item.Total = (produto.PrecoVenda * qtd);

            return item;
        }

        public async Task<IActionResult> Detalhe(int id)
        {
            var result = await _pedidoService.FindByIdAsync(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedido pedido, List<Itempedido> listaItemPedido)
        {
            await _pedidoService.InsertAsync(pedido);

            //foreach (Itempedido item in listaItemPedido)
            //{
            //    item.PedidoIdPedido = pedido.IdPedido;
            //    item.PedidoIdPedidoNavigation = pedido;
            //    await _pedidoService.InsertItemPedido(item);
            //}

            return RedirectToAction(nameof(Index));
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

        public async Task<IActionResult> InativaPedido(int id)
        {
            try
            {
                var pedido = await _pedidoService.FindByIdAsync(id);
                pedido.Status = "cancelado";

                await _pedidoService.UpdateAsync(pedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
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
