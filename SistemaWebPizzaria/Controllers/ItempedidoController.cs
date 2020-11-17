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
        public async void Create(Itempedido itemPedido)
        {
            await _ItempedidoService.InsertAsync(Itempedido);
        }

        public async Task<IActionResult> DeleteItempedido(int id)
        {
            try
            {
                var Itempedido = await _ItempedidoService.FindByIdAsync(id);
                await _ItempedidoService.RemoveAsync(Itempedido); //chamando o metodo remove 
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Itempedido itempedido)
        {
            try
            {
                await _ItempedidoService.UpdateAsync(Itempedido);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }




}
