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
        public readonly ItempedidoService _ItempedidoService;

        public ItempedidoController(ItempedidoService ItempedidoService)
        {
            _ItempedidoService = ItempedidoService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _ItempedidoService.FindAllAsync();
            return View(list);
        }

        [HttpPost]
        public async void Create(ItemPedido ItemPedido)
        {
            await _ItempedidoService.InsertAsync(ItemPedido);
        }

        public async Task<IActionResult> DeleteItempedido(int id)
        {
            try
            {
                var ItemPedido = await _ItempedidoService.FindByIdAsync(id);
                await _ItempedidoService.RemoveAsync(ItemPedido); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ItemPedido ItemPedido)
        {
            try
            {
                await _ItempedidoService.UpdateAsync(ItemPedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }




}
