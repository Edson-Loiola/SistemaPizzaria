using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Models.ViewModels;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services
{
    public class ClienteService
    {

        private readonly BancoPizzariaContext _context;


        //A clienteservice precisa ser adicionada na classe Startup. Abra a classe Startup para ver o exemplo  na linha 51
        public ClienteService(BancoPizzariaContext context)
        {
            _context = context;
        }

        //função de inserir cliente
        public async Task InsertClienteAsync(Cliente cliente)
        {
               
            _context.Add(cliente);
            await _context.SaveChangesAsync();
        }
        //função de inserir endereço
        public async Task InsertEnderecoAsync(Endereco endereco)
        {
            _context.Add(endereco);
            await _context.SaveChangesAsync();
        }





        //função remove cliente do banco pelo id
        public async Task RemoveAsync(int id)
        {
            try
            {

                var obj = await _context.Cliente.FindAsync(id);
                var ende = await _context.Endereco.FirstOrDefaultAsync(x => x.ClienteIdCliente == id);


                //  _context.Endereco.Remove(ende);

                if (ende == null)
                {
                    //  _context.Endereco.Remove(ende);
                    _context.Cliente.Remove(obj);
                }
                else if (ende.ClienteIdCliente == id)
                {
                    _context.Endereco.Remove(ende);
                    _context.Cliente.Remove(obj);
                }



                await _context.SaveChangesAsync(); //esse metodo confirma a operação no

            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }



        //lista clientes
        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        //lista tudo na tela
        public async Task<List<Endereco>> FindAllEndeAsync()
        {
            return await _context.Endereco.Include(c => c.ClienteIdClienteNavigation).ToListAsync();
        }



        //listar
        public async Task<Endereco> FindByEndIdAsync(int id)
        {
            return await _context.Endereco.FirstOrDefaultAsync(obj => obj.ClienteIdClienteNavigation.IdCliente == id);
            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal
        }



        //usado no edit do cliente (controler)
        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.Cliente.FirstOrDefaultAsync(obj => obj.IdCliente == id);
            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal
        }



        //função de atualizar cliente
        public async Task UpdateAsync(Endereco obj, Cliente cl)
        {
            //pra atualizar um objeto o id desse objeto já precisa existir no banco
            bool hasAny = await _context.Endereco.AnyAsync(x => x.IdEndereco == obj.IdEndereco);

            if (!hasAny)  // verifica se expressão passada não existe no banco
            {
                throw new NotFiniteNumberException("Endereço não existe!");
            }

            try
            {
                _context.Update(obj);
                _context.Update(cl);
                await _context.SaveChangesAsync(); //confirmar alteração
            }
            catch (DllNotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }

        }



    }

}

