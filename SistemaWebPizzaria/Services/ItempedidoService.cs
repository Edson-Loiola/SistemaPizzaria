
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaWebPizzaria.Models;
using SistemaWebPizzaria.Services.Exception;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaWebPizzaria.Services { 

    public class ItempedidoService : ControllerBase
{
        private readonly BancoPizzariaContext _context;

        public ItempedidoService(BancoPizzariaContext context)
        {
            _context = context;
        }

        //fun��o de inserir no banco
        public async Task InsertAsync(ItemPedido obj)
        {
            try
            {
                _context.Add(obj);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException e)
            {
                throw new System.Exception(e.Message);
            }

        }

        public async Task<List<ItemPedido>> FindAllAsyncByIdPedido(int idPedido)
        {
            var listaItempedido = new List<ItemPedido>();
            var list = await _context.Itempedido.ToListAsync();

            foreach (ItemPedido Itempedido in list)
            {
                if (Itempedido.PedidoId == idPedido)
                {
                    listaItempedido.Add(Itempedido);
                }
            }

            return listaItempedido;
        }


        //fun��o de fazer listagem dos pedidos
        public async Task<List<ItemPedido>> FindAllAsync()
        {
            return await _context.Itempedido.ToListAsync();
        }

        //fun��o remover  do banco pelo id
        public async Task RemoveAsync(ItemPedido Itempedido)
        {
            try
            {
                _context.Itempedido.Remove(Itempedido);
                await _context.SaveChangesAsync();
            }
            catch (NotFoundException e)
            {
                throw new NotFoundException(e.Message);
            }
        }


        public async Task<ItemPedido> FindByIdAsync(int id)
        {
            var Itempedido = await _context.Itempedido.FirstOrDefaultAsync(obj => obj.Id == id);

            return Itempedido;
        }

        //fun��o de atualizar uma 
        public async Task UpdateAsync(ItemPedido obj)
        {
            //pra atualizar um objeto o id desse objeto j� precisa existir no banco
            bool hasAny = await _context.Itempedido.AnyAsync(x => x.Id == obj.Id);

            if (!hasAny)  // verifica se express�o passada n�o existe no banco
            {
                throw new NotFiniteNumberException("Itempedido n�o existe!");
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
