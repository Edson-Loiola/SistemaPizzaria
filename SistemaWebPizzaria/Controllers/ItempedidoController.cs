using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Controllers
{
    public class ItempedidoController : Controller
    {
        public readonly ItempedidoService _itempedidoService;

        public ItempedidoController(ItempedidoService itempedidoService)
        {
            _itempedidoService = itempedidoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _itempedidoService.FindAllAsync();
            return View(list);
        }

        [HttpPost]
        public async void Create(ItemPedido itemPedido)
        {
            await _itempedidoService.InsertAsync(itemPedido);
        }

        public async Task<IActionResult> DeleteItemPedido(int id)
        {
            try
            {
                var itempedido = await _itempedidoService.FindByIdAsync(id);
                await _itempedidoService.RemoveAsync(itempedido); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ItemPedido itempedido)
        {
            try
            {
                await _itempedidoService.UpdateAsync(itempedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }




}
