
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
            try
            {
                obj.DataHora = DateTime.Now;
                obj.IdClienteNavigation = _context.Cliente.Find(obj.IdCliente);
                obj.IdFuncioarioNavigation = _context.Funcionario.Find(obj.IdFuncioario);
                _context.Add(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new System.Exception(e.Message);
            }

        }


        //fun��o de fazer listagem dos pedidos
        public async Task<List<Pedido>> FindAllAsync()
        {
            return await _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).ToListAsync();
        }

        public async Task<List<Pedido>> FindAllAsync(DateTime? minDate, DateTime? maxDate)
        {

           
            var list = await  _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).ToListAsync();




            if (minDate.HasValue)
            {
                list = list.FindAll(d => d.DataHora >= minDate.Value);
                

            }
            if (maxDate.HasValue)
            {
                list = list.FindAll(d => d.DataHora <= maxDate.Value);
                

            }


           return list;
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

        public async Task<List<Cardapiopizza>> ListaCardapio()
        {
            return await _context.Cardapiopizza.ToListAsync();
        }

        public async Task<Cardapiopizza> FindByIdCardapio(int id)
        {
            return await _context.Cardapiopizza.FindAsync(id);
        }

        public async Task<List<Produtoestoque>> ListaProduto()
        {
            return await _context.Produtoestoque.ToListAsync();
        }

        public async Task<Produtoestoque> FindByIdProduto(int id)
        {
            return await _context.Produtoestoque.FindAsync(id);
        }

        public async Task InsertItemPedido(ItemPedido ItemPedido)
        {
            _context.Add(ItemPedido);
            await _context.SaveChangesAsync();
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
            var pedido = await _context.Pedido.Include(f => f.IdFuncioarioNavigation).Include(c => c.IdClienteNavigation).FirstOrDefaultAsync(obj => obj.IdPedido == id);

            var listaItemPedido = await _context.ItemPedido.ToListAsync();

            return pedido;
        }

        //fun��o de atualizar uma 
        public async Task UpdateAsync(Pedido obj)
        {
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
