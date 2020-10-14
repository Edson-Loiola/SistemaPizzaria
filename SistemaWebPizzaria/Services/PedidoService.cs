
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services { 

    public class PedidoService : ControllerBase
{
        private readonly BancoPizzariaContext _context;

        public PedidoService(BancoPizzariaContext context)
        {
            _context = context;
        }


        //fun��o de inserir no banco
        public async Task InsertAsync(Pedido obj)
        {
            obj.IdFuncioarioNavigation = _context.Funcionario.Find(obj.IdFuncioarioNavigation.IdFuncionario);
            obj.IdClienteNavigation = _context.Cliente.Find(obj.IdClienteNavigation.IdCliente);
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }


        //fun��o de fazer listagem dos pedidos
        public async Task<List<Pedido>> FindAllAsync()
        {
            return await _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).ToListAsync();
        }

        //fun��o de fazer listagem dos funcionarios
        public async Task<List<Funcionario>> ListaFuncionarios()
        {
            return await _context.Funcionario.ToListAsync();
        }

        //fun��o de fazer listagem dos Clientes
        public async Task<List<Cliente>> ListaClientes()
        {
            return await _context.Cliente.ToListAsync();
        }


        //fun��o remover  do banco pelo id
        public async Task RemoveAsync(Pedido pedido)
        {
            try
            {
                _context.Pedido.Remove(pedido);
                await _context.SaveChangesAsync();
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<Pedido> FindByIdAsync(int id)
        {
            return await _context.Pedido.FirstOrDefaultAsync(obj => obj.IdPedido == id);

            //eager loading (inlcude): inner join para carregar outros objetos associados ao obj principal (no caso o departamento)
        }

        //fun��o de atualizar uma 
        public async Task UpdateAsync(Pedido obj)
        {
            //pra atualizar um objeto o id desse objeto j� precisa existir no banco
            bool hasAny = await _context.Pedido.AnyAsync(x => x.IdPedido == obj.IdPedido);

            if (!hasAny)  // verifica se express�o passada n�o existe no banco
            {
                throw new NotFiniteNumberException("Pedido n�o existe!");
            }

            try
            {
                _context.Update(obj); //atualiza o objeto
                await _context.SaveChangesAsync(); //confirmar altera��o
            }
            catch (DllNotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }

        }


    }
}