using Microsoft.AspNetCore.Mvc;
using PagedList;
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


       
        public async Task<IActionResult> Lista(int? pagina)
        {

            

            var list = await _clienteService.FindAllEndeAsync();

            TempData["TotalClienteA"] = list.Where(x => x.Ativo == "S").Count(); //total de lcientes ativos
            TempData["TotalClienteI"] = list.Where(x => x.Ativo == "N").Count(); //total de lcientes ativos

            int paginaTamanho = 10;
            int paginaNumero = (pagina ?? 1);

            return View(list.ToPagedList(paginaNumero, paginaTamanho));
        }



        //inserir dados no banco (essa função é passada no form da minha view Creatcliente
        [HttpPost] //esse método é um post pois está criando/enviando um novo objeto
        [ValidateAntiForgeryToken] //essa notação evita que a aplicação receba ataques CSRF (envio de dados malicioso na autenticação)
        public async Task<IActionResult> CreateCliente(Cliente cliente, Endereco endereco)

        {

            //salva o cliente
            cliente.Ativo = "S";
            await _clienteService.InsertClienteAsync(cliente);

            if (endereco.Cep != null && endereco.Rua != null && endereco.Numero != null && endereco.Bairro != null)
            {
                //salva o endereço
                 endereco.Ativo = "S";               
;                endereco.ClienteIdCliente = cliente.IdCliente;
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
                endereco.Ativo = "S";

                endereco.ClienteIdCliente = cliente.IdCliente;
                await _clienteService.InsertEnderecoAsync(endereco);

            }
            return RedirectToAction(nameof(Lista));
        }



        //deletar cliente. não utilizado mais
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
        public async Task<IActionResult> Buscar(string telefone, int? pagina)
        {

            var obj = await _clienteService.FindAllEndeAsync();
            TempData["TotalClienteA"] = obj.Where(x => x.Ativo == "S").Count(); //total de lcientes ativos
            TempData["TotalClienteI"] = obj.Where(x => x.Ativo == "N").Count(); //total de lcientes ativos
            //nao estourar erro se a busca for vazia
            if (telefone == null)
            {
                telefone = "";
            }


            var cl = obj.Where(x => x.ClienteIdClienteNavigation.Telefone == telefone || x.ClienteIdClienteNavigation.Nome.ToUpper().Contains(telefone.ToUpper()));
            

            int paginaTamanho = 10;
            int paginaNumero = (pagina ?? 1);

            if (!cl.Any(x => x.ClienteIdClienteNavigation.Telefone == telefone || x.ClienteIdClienteNavigation.Nome.ToUpper().Contains(telefone.ToUpper()))) // se o telefone passado não existir no banco ou o nome
            {
                return RedirectToAction(nameof(Lista));
            }
            else
            {
                return View(nameof(Lista), cl.ToPagedList(paginaNumero, paginaTamanho)); // se existir retornar a lista
            }
        }



   // var listprod = obj.Where(x => x.Nome.ToUpper().Contains(nomeprod.ToUpper()));



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
                ClienteIdClienteNavigation = objEndereco.ClienteIdClienteNavigation, // sem essa referencia não carrega os dados do cliente na tela de edit vindo do banco
                Ativo = objEndereco.Ativo
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
                    ClienteIdClienteNavigation = objEndereco.ClienteIdClienteNavigation,
                    Ativo = objEndereco.Ativo
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



        //inativar o cliente
        public async Task<IActionResult> InativaCliente(int? id)
        {
            var objCliente = await _clienteService.FindByIdAsync(id.Value);
            var objEndereco = await _clienteService.FindByEndIdAsync(id.Value);
            //var objLog = await _loginService.FindByIdAsync(Convert.ToInt32(obj.IdLogin));
            try
            {

                objEndereco.Ativo = "N";
                objCliente.Ativo = "N";
              
                await _clienteService.UpdateAsync(objEndereco, objCliente);

                if (objEndereco != null && objEndereco != null)
                {
                    objEndereco.Ativo = "N";
                    objCliente.Ativo = "N";
                    await _clienteService.UpdateAsync(objEndereco, objCliente);
                }


                return RedirectToAction(nameof(Lista));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Lista));
            }
        }

        //ativar o cliente desativado
        public async Task<IActionResult> AtivaCliente(int? id)
        {
            var objCliente = await _clienteService.FindByIdAsync(id.Value);
            var objEndereco = await _clienteService.FindByEndIdAsync(id.Value);
            //var objLog = await _loginService.FindByIdAsync(Convert.ToInt32(obj.IdLogin));
            try
            {

                objEndereco.Ativo = "S";
                objCliente.Ativo = "S";

                await _clienteService.UpdateAsync(objEndereco, objCliente);

                if (objEndereco != null && objEndereco != null)
                {
                    objEndereco.Ativo = "S";
                    objCliente.Ativo = "S";
                    await _clienteService.UpdateAsync(objEndereco, objCliente);
                }


                return RedirectToAction(nameof(Lista));
            }
            catch (KeyNotFoundException)
            {
                return RedirectToAction(nameof(Lista));
            }
        }






        //verificar se o telefone cadastro já existe
        public async Task<bool> VerificaTelefone(string telefone, string idCliente)
        {

            if (Request.Query.Any( x => x.Key == "Cliente.Telefone"))
            {
                telefone = HttpContext.Request.Query["Cliente.Telefone"];  
                //unica forma de conseguir pegar o tel vindo da tela para comparar com o banco  - pagina create
                
            }
            else
            {
                telefone = HttpContext.Request.Query["ClienteIdClienteNavigation.Telefone"];  //unica forma de conseguir pegar o tel vindo da tela para comparar com o banco  - pagina editar
                idCliente = HttpContext.Request.Query["ClienteIdClienteNavigation.IdCliente"];
            
            }


            var obj = await _clienteService.FindAllAsync();


            if (!obj.Any(x => x.Telefone == telefone))
            {
                return true;
            }
            else
            {
                if (obj.Any(x => x.Telefone == telefone && x.IdCliente == Convert.ToInt32(idCliente)))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


    }

}
