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
        public readonly ItempedidoService _itempedidoService;
        public readonly ProdutoService _produtoestoqueService;
        public readonly FuncionarioService _funcionarioService;

        public PedidosController(PedidoService pedidoService, ItempedidoService itempedidoService, ProdutoService produtoestoqueService, FuncionarioService funcionarioService)
        {
            _pedidoService = pedidoService;
            _itempedidoService = itempedidoService;
            _produtoestoqueService = produtoestoqueService;
            _funcionarioService = funcionarioService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _pedidoService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Historico(DateTime? minDate, DateTime? maxDate)
        {
            
            if (!minDate.HasValue)
            {
                minDate = DateTime.Now.AddDays(-1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            



            //var relsaidas = await _relatoioService.SaidaDespesas(minDate, maxDate);
            var list = await _pedidoService.FindAllAsync(minDate, maxDate);

            var obj = list.FindAll(x => x.Status == "Finalizado" || x.Status == "Cancelado");

            return View(obj);

            //int paginaTamanho = 10;
            //int paginaNumero = (pagina ?? 1);

            //return View(obj.ToPagedList(paginaNumero, paginaTamanho));

            return View(obj);
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
        public async Task<Cardapiopizza> CardapioById(int id)
        {
            return await _pedidoService.FindByIdCardapio(id);
        }
        public async Task<List<Produtoestoque>> ListaProduto()
        {
            return await _pedidoService.ListaProduto();
        }

        public async Task<Produtoestoque> ProdutoById(int id)
        {
            return await _pedidoService.FindByIdProduto(id);
        }

        public async Task<List<ItemPedido>> ListaItemPedido(int id)
        {
            return await _itempedidoService.FindAllAsyncByIdPedido(id);
        }

        [HttpPost]
        public async Task<ItemPedido> AdicionarItemCardapioAoPedido(int qtd, int cardapioid)
        {
            var cardap = await _pedidoService.FindByIdCardapio(cardapioid);

            var item = new ItemPedido();

            item.Produto = "N";
            item.CardapioPizzaId = cardapioid;
            item.ProdutoEstoqueId = null;
            item.NomeProduto = "" + cardap.Tipo + " de " + cardap.Sabor + "";
            item.PrecoUnidade = cardap.ValorUnitario;
            item.Quantidade = qtd;
            item.Total = (cardap.ValorUnitario * qtd);

            return item;
        }

        [HttpPost]
        public async Task<ItemPedido> AdicionarItemProdutoAoPedido(int qtd, int produtoid)
        {
            try
            {
                var produto = await _pedidoService.FindByIdProduto(produtoid);

                var item = new ItemPedido();

                item.Produto = "S";
                item.CardapioPizzaId = null;
                item.ProdutoEstoqueId = produtoid;
                item.NomeProduto = produto.Nome;
                item.PrecoUnidade = produto.PrecoVenda;
                item.Quantidade = qtd;
                item.Total = (produto.PrecoVenda * qtd);

                return item;
            }
            catch (ArgumentException e)
            {
                throw new System.Exception( "Erro ao gravar o pedido." + e.Message);
            }
            
        }

        public async Task<IActionResult> Detalhe(int id)
        {
            if (TempData["currentPedido"] != null)
            {
                id = (int)TempData["currentPedido"];
            }
            var result = await _pedidoService.FindByIdAsync(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedido pedido, List<ItemPedido> listItemPedido)
        {
            await _pedidoService.InsertAsync(pedido);

            foreach (ItemPedido item in listItemPedido)
            {
                item.PedidoId = pedido.IdPedido;
                await _itempedidoService.InsertAsync(item);

                //remover
                if (item.Produto == "S"){
                    var produto = await _produtoestoqueService.FindByIdAsync(item.ProdutoEstoqueId);
                    produto.Quantidade = produto.Quantidade - item.Quantidade;
                    await _produtoestoqueService.UpdateAsync(produto);
                }
            }

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


        public async Task<IActionResult> AlterarStatus(int id, string status)
        {
            var pedido = await _pedidoService.FindByIdAsync(id);
            pedido.Status = status;
            await _pedidoService.UpdateAsync(pedido);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Update(Pedido pedido)
        {

            try
            {
                pedido.IdFuncioarioNavigation = null;
                pedido.IdClienteNavigation = null;
                await _pedidoService.UpdateAsync(pedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDetalhePedido(Pedido pedido, List<ItemPedido> listItemPedido)
        {
            try
            {
                pedido.IdFuncioarioNavigation = null;
                pedido.IdClienteNavigation = null;
                await _pedidoService.UpdateAsync(pedido);

                var removeList = await ListaItemPedido(pedido.IdPedido);
                foreach (ItemPedido itemRemove in removeList)
                {
                    await _itempedidoService.RemoveAsync(itemRemove);
                }

                foreach (ItemPedido item in listItemPedido)
                {
                    item.PedidoId = pedido.IdPedido;
                    await _itempedidoService.InsertAsync(item);

                    //remover
                    if (item.Produto == "S")
                    {
                        var produto = await _produtoestoqueService.FindByIdAsync(item.ProdutoEstoqueId);
                        produto.Quantidade = produto.Quantidade - item.Quantidade;
                        await _produtoestoqueService.UpdateAsync(produto);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }

    }




}
