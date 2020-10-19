using Microsoft.AspNetCore.Mvc;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            if (endereco.Cep != null && endereco.Rua != null && endereco.Numero != null && endereco.Bairro != null)
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



        //deletar cliente.
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


        //metodo de pesquisar cliente pelo telefone - chama a mesma action Lista de listagem de clientes
        [HttpPost]
        public async Task<IActionResult> Buscar(string telefone)
        {

            var obj = await _clienteService.FindAllEndeAsync();
            var cl = obj.Where(x => x.ClienteIdClienteNavigation.Telefone == telefone);


            if (!cl.Any(x => x.ClienteIdClienteNavigation.Telefone == telefone)) // se o telefone passado não existir no banco, direcionar para create
            {
                return RedirectToAction(nameof(Index));
            }
            else
                return View(nameof(Lista), cl); // se existir retornar a lista
        }





        //ao clicar em edit ira abrir a tela com os campos carregados com os dados de cliente
        public async Task<IActionResult> EditCliente(int? id)
        {
            if (id == null) //validação se o id é nulo
            {
                return RedirectToAction(nameof(Lista));
            }

            var objCliente = await _clienteService.FindByIdAsync(id.Value);
            var objEndereco = await _clienteService.FindByEndIdAsync(id.Value);


            if (objCliente == null) // valida se o obj no banco é nulo
            {
                return RedirectToAction(nameof(Lista));
            }

            Endereco viewModel = new Endereco
            {
                IdEndereco = objEndereco.IdEndereco,
                ClienteIdCliente = objEndereco.ClienteIdCliente,
                Cep = objEndereco.Cep,
                Rua = objEndereco.Rua,
                Numero = objEndereco.Numero,
                Bairro = objEndereco.Bairro,
                Cidade = objEndereco.Cidade,
                Complemento = objEndereco.Complemento,
                ClienteIdClienteNavigation = objEndereco.ClienteIdClienteNavigation // sem essa referencia não carrega os dados do cliente na tela de edit vindo do banco

            };

            return View(viewModel);
        }


        //ação de salvar a edição do cliente (update)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCliente(int id, Endereco objEndereco)
        {
            //----------------------------------------------------------------
            //essa validação ocorrerá se o JavaScript do usuário estiver desabilitado, pois não fará as validações feitas no html e nas propriedades
            if (!ModelState.IsValid)
            {
                var endreco = await _clienteService.FindAllEndeAsync(); //carrega lista


                var viewModel = new Endereco
                {
                    IdEndereco = objEndereco.IdEndereco,
                    Cep = objEndereco.Cep,
                    Rua = objEndereco.Rua,
                    Numero = objEndereco.Numero,
                    Bairro = objEndereco.Bairro,
                    Cidade = objEndereco.Cidade,
                    Complemento = objEndereco.Complemento,
                    ClienteIdCliente = objEndereco.ClienteIdCliente,
                    ClienteIdClienteNavigation = objEndereco.ClienteIdClienteNavigation
                };

                return View(viewModel);
            }
            //----------------------------------------------------------------



            if (id != objEndereco.ClienteIdCliente) //verifica se o Id é diferente
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                await _clienteService.UpdateAsync(objEndereco, objEndereco.ClienteIdClienteNavigation);
                return RedirectToAction(nameof(Lista));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Index));
            }

        }


    }

}
