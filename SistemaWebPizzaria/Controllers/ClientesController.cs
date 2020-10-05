using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
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

            var list = await _clienteService.FindAllEndeAsync();

            return View(list);
        }



        //inserir dados no banco (essa função é passada no form da minha view Creatcliente
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> CreateCliente(Cliente cliente, Endereco endereco)

        {
            await _clienteService.InsertClienteAsync(cliente);

            if (endereco.Cep != null && endereco.Rua != null)
            {
                endereco.ClienteIdCliente = cliente.IdCliente;
                await _clienteService.InsertEnderecoAsync(endereco);

            }
            else
            {
                //campos em branco salva o mesmo id na tabela de endereço do cliente
                endereco.Cep = "-";
                endereco.Bairro = "-";
                endereco.Cidade = "-";
                endereco.Rua = "-";
                endereco.Numero = "-";
                endereco.Complemento = "-";

                endereco.ClienteIdCliente = cliente.IdCliente;
                await _clienteService.InsertEnderecoAsync(endereco);

            }
            return RedirectToAction(nameof(Lista));
        }



        //deletar cliente. ainda não deleta o endereço
        public async Task<IActionResult> DeleteCliente(int? id)
        {
            try
            {

                var obj = await _clienteService.FindByIdAsync(id.Value);


                await _clienteService.RemoveAsync(obj.IdCliente); //chamando o metodo remove 
                return RedirectToAction(nameof(Lista));

            }
            catch (Exception)
            {
                return NotFound();
            }
        }





        //ao clicar em edit ira abrir a tela com os campos carregados com os dados de cliente
        public async Task<IActionResult> EditCliente(int? id)
        {
            if (id == null) //validação se o id é nulo
            {
                return RedirectToAction(nameof(Lista));
            }

            var obj = await _clienteService.FindByIdAsync(id.Value);
            var objend = await _clienteService.FindByEndIdAsync(id.Value);


            if (obj == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Lista));
            }

            Endereco viewModel = new Endereco { Cep = objend.Cep, ClienteIdClienteNavigation = objend.ClienteIdClienteNavigation };

            return View(viewModel);
        }


        //ação de salvar a edição do cliente (update)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Endereco obj)
        {

            //essa validação ocorrerá se o JavaScript do usuário estiver desabilitado, pois não fará as validações feitas no html e nas propriedades
            if (!ModelState.IsValid)
            {
                var client = await _clienteService.FindAllEndeAsync(); //carrega lista

                var viewModel = new Endereco
                {
                    ClienteIdCliente = obj.ClienteIdClienteNavigation.IdCliente,
                    Cep = obj.Cep,
                    ClienteIdClienteNavigation = obj.ClienteIdClienteNavigation

                };


                return View(viewModel);
            }


            //if (obj.ClienteIdClienteNavigation.IdCliente != obj.ClienteIdCliente) //verifica se o Id é diferente
            //{
            //    return RedirectToAction(nameof(Index));
            //}

            try
            {
                await _clienteService.UpdateAsync(obj);
                return RedirectToAction(nameof(Index));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }

            //alterado esses dois cath por apenas 1 passando a super classe ApplicationException

        }



    }

}
