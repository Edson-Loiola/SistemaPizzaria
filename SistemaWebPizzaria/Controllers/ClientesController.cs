using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Services;

namespace SistemaWebPizzaria.Controllers
{
    public class ClientesController : Controller
    {

        public readonly ClienteService _clienteService;



        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Lista()
        {
            var list = await _clienteService.FindAllAsync();

            return View(list);
        }

        public IActionResult EditCliente()
        {
            return View();
        }


        //inserir dados no banco (essa função é passada no form da minha view CreatDespesa
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> CreateCliente(Cliente cliente, Endereco endereco)
            
        {
            await _clienteService.InsertClienteAsync(cliente);

            if (endereco.Cep != null)
            {
                endereco.ClienteIdCliente = cliente.IdCliente;
            }

            await _clienteService.InsertEnderecoAsync(endereco);



            return RedirectToAction(nameof(Index)); //ao clicar em criar um nova Despesa, direciona para a propria tela
        }




        public async Task<IActionResult> DeleteCliente(int id)
        {
            try
            {
                await _clienteService.RemoveAsync(id); //chamando o metodo remove 
                return RedirectToAction(nameof(Lista));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }




    }
}
