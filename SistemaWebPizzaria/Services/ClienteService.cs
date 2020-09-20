using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
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
                _context.Cliente.Remove(obj);
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



    }

}

